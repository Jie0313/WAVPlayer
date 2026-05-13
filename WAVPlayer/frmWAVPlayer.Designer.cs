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

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.pnlTitle  = new System.Windows.Forms.Panel();
            this.lblIcon   = new System.Windows.Forms.Label();
            this.lblTitle  = new System.Windows.Forms.Label();
            this.grpPath   = new System.Windows.Forms.GroupBox();
            this.txtPath   = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.btnPlay   = new System.Windows.Forms.Button();
            this.btnLoop   = new System.Windows.Forms.Button();
            this.btnStop   = new System.Windows.Forms.Button();
            this.btnEnd    = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ofdWAVFile = new System.Windows.Forms.OpenFileDialog();

            this.pnlTitle.SuspendLayout();
            this.grpPath.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();

            // ── pnlTitle ──────────────────────────────────────────
            this.pnlTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#A855F7");
            this.pnlTitle.Location  = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name      = "pnlTitle";
            this.pnlTitle.Size      = new System.Drawing.Size(766, 44);
            this.pnlTitle.TabIndex  = 10;
            this.pnlTitle.Controls.Add(this.lblIcon);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            // ── lblIcon ───────────────────────────────────────────
            this.lblIcon.AutoSize  = true;
            this.lblIcon.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIcon.ForeColor = System.Drawing.Color.White;
            this.lblIcon.Location  = new System.Drawing.Point(12, 10);
            this.lblIcon.Name      = "lblIcon";
            this.lblIcon.Text      = "♪";
            this.lblIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            // ── lblTitle ──────────────────────────────────────────
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location  = new System.Drawing.Point(38, 12);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Text      = "WAV 音效檔播放器";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);

            // ── grpPath ───────────────────────────────────────────
            this.grpPath.BackColor = System.Drawing.Color.Transparent;
            this.grpPath.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPath.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7C3AED");
            this.grpPath.Location  = new System.Drawing.Point(12, 56);
            this.grpPath.Name      = "grpPath";
            this.grpPath.Size      = new System.Drawing.Size(742, 110);
            this.grpPath.TabIndex  = 0;
            this.grpPath.TabStop   = false;
            this.grpPath.Text      = "音效位置";
            this.grpPath.Controls.Add(this.txtPath);
            this.grpPath.Controls.Add(this.btnBrowse);

            // ── txtPath ───────────────────────────────────────────
            this.txtPath.BackColor   = System.Drawing.ColorTranslator.FromHtml("#FAF5FF");
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font        = new System.Drawing.Font("Consolas", 10F);
            this.txtPath.ForeColor   = System.Drawing.ColorTranslator.FromHtml("#C4A8E0");
            this.txtPath.Location    = new System.Drawing.Point(16, 40);
            this.txtPath.Name        = "txtPath";
            this.txtPath.ReadOnly    = true;
            this.txtPath.Size        = new System.Drawing.Size(610, 34);
            this.txtPath.TabIndex    = 0;

            // ── btnBrowse ─────────────────────────────────────────
            this.btnBrowse.BackColor = System.Drawing.ColorTranslator.FromHtml("#A855F7");
            this.btnBrowse.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location  = new System.Drawing.Point(638, 36);
            this.btnBrowse.Name      = "btnBrowse";
            this.btnBrowse.Size      = new System.Drawing.Size(88, 40);
            this.btnBrowse.TabIndex  = 1;
            this.btnBrowse.Text      = "瀏覽";
            this.btnBrowse.Click    += new System.EventHandler(this.btnBrowse_Click);

            // ── grpButton ─────────────────────────────────────────
            this.grpButton.BackColor = System.Drawing.Color.Transparent;
            this.grpButton.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpButton.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7C3AED");
            this.grpButton.Location  = new System.Drawing.Point(12, 178);
            this.grpButton.Name      = "grpButton";
            this.grpButton.Size      = new System.Drawing.Size(742, 110);
            this.grpButton.TabIndex  = 1;
            this.grpButton.TabStop   = false;
            this.grpButton.Text      = "播放按鈕";
            this.grpButton.Controls.Add(this.btnPlay);
            this.grpButton.Controls.Add(this.btnLoop);
            this.grpButton.Controls.Add(this.btnStop);
            this.grpButton.Controls.Add(this.btnEnd);

            // ── btnPlay  (x=16) ───────────────────────────────────
            this.btnPlay.BackColor = System.Drawing.ColorTranslator.FromHtml("#7C3AED");
            this.btnPlay.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Enabled   = false;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location  = new System.Drawing.Point(16, 36);
            this.btnPlay.Name      = "btnPlay";
            this.btnPlay.Size      = new System.Drawing.Size(165, 48);
            this.btnPlay.TabIndex  = 2;
            this.btnPlay.Text      = "▶  播放一次";
            this.btnPlay.Click    += new System.EventHandler(this.btnPlay_Click);

            // ── btnLoop  (x=193) ──────────────────────────────────
            this.btnLoop.BackColor = System.Drawing.ColorTranslator.FromHtml("#EC4899");
            this.btnLoop.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.Enabled   = false;
            this.btnLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoop.FlatAppearance.BorderSize = 0;
            this.btnLoop.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoop.ForeColor = System.Drawing.Color.White;
            this.btnLoop.Location  = new System.Drawing.Point(193, 36);
            this.btnLoop.Name      = "btnLoop";
            this.btnLoop.Size      = new System.Drawing.Size(165, 48);
            this.btnLoop.TabIndex  = 3;
            this.btnLoop.Text      = "↺  重複播放";
            this.btnLoop.Click    += new System.EventHandler(this.btnLoop_Click);

            // ── btnStop  (x=370) ──────────────────────────────────
            this.btnStop.BackColor = System.Drawing.ColorTranslator.FromHtml("#F43F5E");
            this.btnStop.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Enabled   = false;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location  = new System.Drawing.Point(370, 36);
            this.btnStop.Name      = "btnStop";
            this.btnStop.Size      = new System.Drawing.Size(165, 48);
            this.btnStop.TabIndex  = 4;
            this.btnStop.Text      = "■  停止播放";
            this.btnStop.Click    += new System.EventHandler(this.btnStop_Click);

            // ── btnEnd   (x=547) ──────────────────────────────────
            this.btnEnd.BackColor = System.Drawing.ColorTranslator.FromHtml("#F3E8FF");
            this.btnEnd.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.FlatAppearance.BorderSize  = 1;
            this.btnEnd.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D8B4FE");
            this.btnEnd.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.btnEnd.ForeColor = System.Drawing.ColorTranslator.FromHtml("#7C3AED");
            this.btnEnd.Location  = new System.Drawing.Point(547, 36);
            this.btnEnd.Name      = "btnEnd";
            this.btnEnd.Size      = new System.Drawing.Size(165, 48);
            this.btnEnd.TabIndex  = 5;
            this.btnEnd.Text      = "✕  結束程式";
            this.btnEnd.Click    += new System.EventHandler(this.btnEnd_Click);

            // ── pnlStatus ─────────────────────────────────────────
            this.pnlStatus.BackColor = System.Drawing.ColorTranslator.FromHtml("#A855F7");
            this.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Name      = "pnlStatus";
            this.pnlStatus.Size      = new System.Drawing.Size(766, 32);
            this.pnlStatus.TabIndex  = 11;
            this.pnlStatus.Controls.Add(this.lblStatus);

            // ── lblStatus ─────────────────────────────────────────
            this.lblStatus.AutoSize  = true;
            this.lblStatus.Font      = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location  = new System.Drawing.Point(14, 8);
            this.lblStatus.Name      = "lblStatus";
            this.lblStatus.Text      = "● 就緒";

            // ── ofdWAVFile ────────────────────────────────────────
            this.ofdWAVFile.DefaultExt = "wav";
            this.ofdWAVFile.Filter     = "WAV Files (*.wav)|*.wav";

            // ── frmWAVPlayer ──────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(766, 340);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.None;
            this.Name                = "frmWAVPlayer";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "WAV 音效檔播放器";
            this.FormClosing        += new System.Windows.Forms.FormClosingEventHandler(this.frmWAVPlayer_FormClosing);
            this.Load               += new System.EventHandler(this.frmWAVPlayer_Load);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.grpPath);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.pnlStatus);

            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel      pnlTitle;
        private System.Windows.Forms.Label      lblIcon;
        private System.Windows.Forms.Label      lblTitle;
        private System.Windows.Forms.GroupBox   grpPath;
        private System.Windows.Forms.TextBox    txtPath;
        private System.Windows.Forms.Button     btnBrowse;
        private System.Windows.Forms.GroupBox   grpButton;
        private System.Windows.Forms.Button     btnPlay;
        private System.Windows.Forms.Button     btnLoop;
        private System.Windows.Forms.Button     btnStop;
        private System.Windows.Forms.Button     btnEnd;
        private System.Windows.Forms.Panel      pnlStatus;
        private System.Windows.Forms.Label      lblStatus;
        private System.Windows.Forms.OpenFileDialog ofdWAVFile;
    }
}
