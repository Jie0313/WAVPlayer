namespace WAVPlayer
{
    partial class frmWAVPlayer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleIcon= new System.Windows.Forms.Label();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.grpPath     = new System.Windows.Forms.GroupBox();
            this.txtPath     = new System.Windows.Forms.TextBox();
            this.btnBrowse   = new System.Windows.Forms.Button();
            this.grpButtons  = new System.Windows.Forms.GroupBox();
            this.btnPlay     = new System.Windows.Forms.Button();
            this.btnLoop     = new System.Windows.Forms.Button();
            this.btnStop     = new System.Windows.Forms.Button();
            this.btnEnd      = new System.Windows.Forms.Button();
            this.pnlStatus   = new System.Windows.Forms.Panel();
            this.lblStatus   = new System.Windows.Forms.Label();
            this.ofdWAVFile  = new System.Windows.Forms.OpenFileDialog();

            this.pnlTitleBar.SuspendLayout();
            this.grpPath.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();

            // ── 色彩定義 ────────────────────────────────────────────
            var clrBg      = System.Drawing.ColorTranslator.FromHtml("#FAF0FF");
            var clrWhite   = System.Drawing.Color.White;
            var clrBorder  = System.Drawing.ColorTranslator.FromHtml("#D8B4FE");
            var clrPurple  = System.Drawing.ColorTranslator.FromHtml("#7C3AED");
            var clrPurpleL = System.Drawing.ColorTranslator.FromHtml("#A855F7");
            var clrPink    = System.Drawing.ColorTranslator.FromHtml("#EC4899");
            var clrRed     = System.Drawing.ColorTranslator.FromHtml("#F43F5E");
            var clrEndBg   = System.Drawing.ColorTranslator.FromHtml("#F3E8FF");
            var clrInputBg = System.Drawing.ColorTranslator.FromHtml("#FAF5FF");

            var fntUI   = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            var fntBold = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);

            // ── Form ─────────────────────────────────────────────────
            this.Text            = "WAV 音效檔播放器";
            this.BackColor       = clrBg;
            this.ForeColor       = clrPurple;
            this.Font            = fntUI;
            this.ClientSize      = new System.Drawing.Size(516, 278);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load           += new System.EventHandler(this.frmWAVPlayer_Load);
            this.FormClosing    += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);

            // ── 自訂標題列 ────────────────────────────────────────────
            this.pnlTitleBar.Location   = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Size       = new System.Drawing.Size(516, 38);
            this.pnlTitleBar.BackColor  = clrPurpleL;
            this.pnlTitleBar.Paint     += new System.Windows.Forms.PaintEventHandler(this.pnlTitleBar_Paint);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            this.lblTitleIcon.Text       = "♪";
            this.lblTitleIcon.ForeColor  = clrWhite;
            this.lblTitleIcon.Font       = new System.Drawing.Font("Microsoft JhengHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitleIcon.Location   = new System.Drawing.Point(10, 8);
            this.lblTitleIcon.AutoSize   = true;
            this.lblTitleIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            this.lblTitle.Text       = "WAV 音效檔播放器";
            this.lblTitle.ForeColor  = clrWhite;
            this.lblTitle.Font       = fntBold;
            this.lblTitle.Location   = new System.Drawing.Point(34, 11);
            this.lblTitle.AutoSize   = true;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            this.pnlTitleBar.Controls.Add(this.lblTitleIcon);
            this.pnlTitleBar.Controls.Add(this.lblTitle);

            // ── grpPath ──────────────────────────────────────────────
            this.grpPath.Text      = "音效位置";
            this.grpPath.ForeColor = clrPurple;
            this.grpPath.BackColor = clrWhite;
            this.grpPath.Location  = new System.Drawing.Point(14, 50);
            this.grpPath.Size      = new System.Drawing.Size(488, 68);
            this.grpPath.Font      = fntBold;

            this.txtPath.BackColor       = clrInputBg;
            this.txtPath.ForeColor       = clrPurple;
            this.txtPath.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location        = new System.Drawing.Point(12, 28);
            this.txtPath.Size            = new System.Drawing.Size(376, 24);
            this.txtPath.ReadOnly        = true;
            this.txtPath.Font            = new System.Drawing.Font("Consolas", 9F);

            this.btnBrowse.Text      = "瀏覽";
            this.btnBrowse.BackColor = clrPurpleL;
            this.btnBrowse.ForeColor = clrWhite;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.Location  = new System.Drawing.Point(400, 26);
            this.btnBrowse.Size      = new System.Drawing.Size(76, 28);
            this.btnBrowse.Font      = fntBold;
            this.btnBrowse.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Click    += new System.EventHandler(this.btnBrowse_Click);

            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Controls.Add(this.btnBrowse);

            // ── grpButtons ───────────────────────────────────────────
            this.grpButtons.Text      = "播放按鈕";
            this.grpButtons.ForeColor = clrPurple;
            this.grpButtons.BackColor = clrWhite;
            this.grpButtons.Location  = new System.Drawing.Point(14, 130);
            this.grpButtons.Size      = new System.Drawing.Size(488, 106);
            this.grpButtons.Font      = fntBold;

            int bY = 32, bH = 46, bW = 106, gap = 10, bX = 12;

            this.btnPlay.Text      = "▶  播放一次";
            this.btnPlay.BackColor = clrPurple;
            this.btnPlay.ForeColor = clrWhite;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Location  = new System.Drawing.Point(bX, bY);
            this.btnPlay.Size      = new System.Drawing.Size(bW, bH);
            this.btnPlay.Enabled   = false;
            this.btnPlay.Font      = fntBold;
            this.btnPlay.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Click    += new System.EventHandler(this.btnPlay_Click);

            this.btnLoop.Text      = "↺  重複播放";
            this.btnLoop.BackColor = clrPink;
            this.btnLoop.ForeColor = clrWhite;
            this.btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoop.FlatAppearance.BorderSize = 0;
            this.btnLoop.Location  = new System.Drawing.Point(bX + (bW + gap), bY);
            this.btnLoop.Size      = new System.Drawing.Size(bW, bH);
            this.btnLoop.Enabled   = false;
            this.btnLoop.Font      = fntBold;
            this.btnLoop.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.Click    += new System.EventHandler(this.btnLoop_Click);

            this.btnStop.Text      = "■  停止播放";
            this.btnStop.BackColor = clrRed;
            this.btnStop.ForeColor = clrWhite;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Location  = new System.Drawing.Point(bX + (bW + gap) * 2, bY);
            this.btnStop.Size      = new System.Drawing.Size(bW, bH);
            this.btnStop.Enabled   = false;
            this.btnStop.Font      = fntBold;
            this.btnStop.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Click    += new System.EventHandler(this.btnStop_Click);

            this.btnEnd.Text      = "✕  結束程式";
            this.btnEnd.BackColor = clrEndBg;
            this.btnEnd.ForeColor = clrPurple;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.FlatAppearance.BorderSize  = 1;
            this.btnEnd.FlatAppearance.BorderColor = clrBorder;
            this.btnEnd.Location  = new System.Drawing.Point(bX + (bW + gap) * 3, bY);
            this.btnEnd.Size      = new System.Drawing.Size(bW, bH);
            this.btnEnd.Font      = fntUI;
            this.btnEnd.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Click    += new System.EventHandler(this.btnEnd_Click);

            this.grpButtons.Controls.Add(this.btnPlay);
            this.grpButtons.Controls.Add(this.btnLoop);
            this.grpButtons.Controls.Add(this.btnStop);
            this.grpButtons.Controls.Add(this.btnEnd);

            // ── Status bar ───────────────────────────────────────────
            this.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Size      = new System.Drawing.Size(516, 28);
            this.pnlStatus.BackColor = clrPurpleL;
            this.pnlStatus.Paint    += new System.Windows.Forms.PaintEventHandler(this.pnlStatus_Paint);

            this.lblStatus.Text      = "● 就緒";
            this.lblStatus.ForeColor = clrWhite;
            this.lblStatus.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location  = new System.Drawing.Point(12, 6);
            this.lblStatus.AutoSize  = true;
            this.pnlStatus.Controls.Add(this.lblStatus);

            // ── OpenFileDialog ───────────────────────────────────────
            this.ofdWAVFile.Title  = "選擇 WAV 音效檔案";
            this.ofdWAVFile.Filter = "WAV Files (*.wav)|*.wav";

            // ── 加入 Form ─────────────────────────────────────────────
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.grpPath);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.pnlStatus);

            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel      pnlTitleBar;
        private System.Windows.Forms.Label      lblTitleIcon;
        private System.Windows.Forms.Label      lblTitle;
        private System.Windows.Forms.GroupBox   grpPath;
        private System.Windows.Forms.TextBox    txtPath;
        private System.Windows.Forms.Button     btnBrowse;
        private System.Windows.Forms.GroupBox   grpButtons;
        private System.Windows.Forms.Button     btnPlay;
        private System.Windows.Forms.Button     btnLoop;
        private System.Windows.Forms.Button     btnStop;
        private System.Windows.Forms.Button     btnEnd;
        private System.Windows.Forms.Panel      pnlStatus;
        private System.Windows.Forms.Label      lblStatus;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}
