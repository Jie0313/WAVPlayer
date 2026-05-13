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

        // ── 讓無邊框視窗可以拖移 ───────────────────────────────────────
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // ── 漸層繪製 ───────────────────────────────────────────────────
        private void pnlTitleBar_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            using (var brush = new LinearGradientBrush(
                p.ClientRectangle,
                ColorTranslator.FromHtml("#A855F7"),   // 左：紫
                ColorTranslator.FromHtml("#EC4899"),   // 右：粉
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, p.ClientRectangle);
            }
        }

        private void pnlStatus_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            using (var brush = new LinearGradientBrush(
                p.ClientRectangle,
                ColorTranslator.FromHtml("#A855F7"),
                ColorTranslator.FromHtml("#EC4899"),
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, p.ClientRectangle);
            }
        }

        // ── 初始化 ─────────────────────────────────────────────────────
        public frmWAVPlayer()
        {
            InitializeComponent();
        }

        private void frmWAVPlayer_Load(object sender, EventArgs e)
        {
            SetStatus("就緒");
        }

        // ── 瀏覽按鈕 ───────────────────────────────────────────────────
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

        // ── 播放一次 ───────────────────────────────────────────────────
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

        // ── 重複播放 ───────────────────────────────────────────────────
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

        // ── 停止播放 ───────────────────────────────────────────────────
        private void btnStop_Click(object sender, EventArgs e)
        {
            StopLoop();
            try { new SoundPlayer(txtPath.Text).Stop(); } catch { }
            SetStatus("■ 已停止");
        }

        // ── 結束程式 ───────────────────────────────────────────────────
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ── 關閉確認 ───────────────────────────────────────────────────
        private void frmWAVPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                StopLoop();
        }

        // ── 工具方法 ───────────────────────────────────────────────────
        private void StopLoop()
        {
            _loopPlayer?.Stop();
            _loopPlayer?.Dispose();
            _loopPlayer = null;
        }

        private void SetStatus(string msg)
        {
            lblStatus.Text = $"  {msg}";
        }
    }
}
