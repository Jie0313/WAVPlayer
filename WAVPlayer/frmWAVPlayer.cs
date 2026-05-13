using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WAVPlayer
{
    public partial class frmWAVPlayer : Form
    {
        private SoundPlayer _loopPlayer = null;

        // ── 無邊框視窗拖移 ─────────────────────────────────────────
        [DllImport("user32.dll")] static extern bool ReleaseCapture();
        [DllImport("user32.dll")] static extern IntPtr SendMessage(IntPtr h, int msg, int w, int l);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        // ── 漸層 Paint 事件（在 Load 裡掛上，不放 Designer）─────────
        private void frmWAVPlayer_Load(object sender, EventArgs e)
        {
            // 標題列漸層
            pnlTitle.Paint += (s, pe) =>
            {
                using (var b = new LinearGradientBrush(pnlTitle.ClientRectangle,
                    ColorTranslator.FromHtml("#A855F7"),
                    ColorTranslator.FromHtml("#EC4899"),
                    LinearGradientMode.Horizontal))
                    pe.Graphics.FillRectangle(b, pnlTitle.ClientRectangle);
            };

            // 狀態列漸層
            pnlStatus.Paint += (s, pe) =>
            {
                using (var b = new LinearGradientBrush(pnlStatus.ClientRectangle,
                    ColorTranslator.FromHtml("#A855F7"),
                    ColorTranslator.FromHtml("#EC4899"),
                    LinearGradientMode.Horizontal))
                    pe.Graphics.FillRectangle(b, pnlStatus.ClientRectangle);
            };

            // Form 背景漸層
            this.Paint += (s, pe) =>
            {
                using (var b = new LinearGradientBrush(this.ClientRectangle,
                    ColorTranslator.FromHtml("#F0E6FF"),
                    ColorTranslator.FromHtml("#FCE4F0"),
                    LinearGradientMode.Vertical))
                    pe.Graphics.FillRectangle(b, this.ClientRectangle);
            };

            pnlTitle.Invalidate();
            pnlStatus.Invalidate();
            this.Invalidate();
            SetStatus("就緒");
        }

        // ── 建構子 ─────────────────────────────────────────────────
        public frmWAVPlayer()
        {
            InitializeComponent();
        }

        // ── 事件處理 ───────────────────────────────────────────────
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdWAVFile.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text      = ofdWAVFile.FileName;
                txtPath.ForeColor = ColorTranslator.FromHtml("#6B21A8");
                btnPlay.Enabled   = true;
                btnLoop.Enabled   = true;
                btnStop.Enabled   = true;
                SetStatus($"已載入：{Path.GetFileName(ofdWAVFile.FileName)}");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            StopLoop();
            try
            {
                var player = new SoundPlayer(txtPath.Text);
                player.Load();
                player.Play();
                SetStatus("▶ 播放中...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"播放失敗：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            StopLoop();
            try
            {
                _loopPlayer = new SoundPlayer(txtPath.Text);
                _loopPlayer.PlayLooping();
                SetStatus("↺ 重複播放中...");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"播放失敗：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopLoop();
            try { new SoundPlayer(txtPath.Text).Stop(); } catch { }
            SetStatus("■ 已停止");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                StopLoop();
        }

        private void StopLoop()
        {
            _loopPlayer?.Stop();
            _loopPlayer?.Dispose();
            _loopPlayer = null;
        }

        private void SetStatus(string msg) => lblStatus.Text = $"● {msg}";
    }
}
