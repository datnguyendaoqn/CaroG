namespace CaroG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnBoardchess = new Panel();
            pnStatus = new Panel();
            lbstatus = new Label();
            LBname = new Label();
            tbName = new TextBox();
            panel2 = new Panel();
            pbIcon = new PictureBox();
            CD = new System.Windows.Forms.Timer(components);
            pgbtime = new ProgressBar();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            tbIPAddress = new TextBox();
            btnConnect = new Button();
            lbPort = new Label();
            tbPort = new TextBox();
            pnStatus.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnBoardchess
            // 
            pnBoardchess.Location = new Point(14, 36);
            pnBoardchess.Margin = new Padding(3, 4, 3, 4);
            pnBoardchess.Name = "pnBoardchess";
            pnBoardchess.Size = new Size(954, 1093);
            pnBoardchess.TabIndex = 0;
            // 
            // pnStatus
            // 
            pnStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pnStatus.Controls.Add(lbstatus);
            pnStatus.Controls.Add(LBname);
            pnStatus.Location = new Point(975, 36);
            pnStatus.Margin = new Padding(3, 4, 3, 4);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(417, 408);
            pnStatus.TabIndex = 1;
            // 
            // lbstatus
            // 
            lbstatus.AutoSize = true;
            lbstatus.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbstatus.ForeColor = SystemColors.ActiveCaptionText;
            lbstatus.Location = new Point(23, 80);
            lbstatus.Name = "lbstatus";
            lbstatus.Size = new Size(74, 26);
            lbstatus.TabIndex = 1;
            lbstatus.Text = "label1";
            // 
            // LBname
            // 
            LBname.AutoSize = true;
            LBname.BackColor = SystemColors.Menu;
            LBname.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBname.ForeColor = SystemColors.ActiveCaptionText;
            LBname.Location = new Point(23, 27);
            LBname.Name = "LBname";
            LBname.Size = new Size(123, 27);
            LBname.TabIndex = 0;
            LBname.Text = "Your name:";
            LBname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            tbName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(975, 452);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(150, 37);
            tbName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbIcon);
            panel2.Location = new Point(1166, 452);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 227);
            panel2.TabIndex = 3;
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbIcon.Location = new Point(0, 0);
            pbIcon.Margin = new Padding(3, 4, 3, 4);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(222, 223);
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // CD
            // 
            CD.Tick += CD_Tick;
            // 
            // pgbtime
            // 
            pgbtime.Location = new Point(975, 499);
            pgbtime.Margin = new Padding(3, 4, 3, 4);
            pgbtime.Name = "pgbtime";
            pgbtime.Size = new Size(151, 31);
            pgbtime.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1399, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(217, 26);
            newGameToolStripMenuItem.Text = "New game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(217, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            quitToolStripMenuItem.Size = new Size(217, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(975, 537);
            tbIPAddress.Margin = new Padding(3, 4, 3, 4);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(150, 27);
            tbIPAddress.TabIndex = 6;
            // 
            // btnConnect
            // 
            btnConnect.ForeColor = SystemColors.WindowText;
            btnConnect.Location = new Point(975, 576);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(151, 31);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPort.ForeColor = SystemColors.ButtonFace;
            lbPort.Location = new Point(975, 626);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(55, 31);
            lbPort.TabIndex = 8;
            lbPort.Text = "Port";
            // 
            // tbPort
            // 
            tbPort.Location = new Point(1031, 632);
            tbPort.Name = "tbPort";
            tbPort.Size = new Size(95, 27);
            tbPort.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1399, 754);
            Controls.Add(tbPort);
            Controls.Add(lbPort);
            Controls.Add(btnConnect);
            Controls.Add(tbIPAddress);
            Controls.Add(pgbtime);
            Controls.Add(panel2);
            Controls.Add(tbName);
            Controls.Add(pnStatus);
            Controls.Add(pnBoardchess);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(2283, 2651);
            MinimumSize = new Size(1069, 741);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
            pnStatus.ResumeLayout(false);
            pnStatus.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBoardchess;
        private Panel pnStatus;
        private TextBox tbName;
        private Panel panel2;
        private PictureBox pbIcon;
        private System.Windows.Forms.Timer CD;
        private ProgressBar pgbtime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private TextBox tbIPAddress;
        private Button btnConnect;
        private Label LBname;
        public Label lbstatus;
        private Label lbPort;
        private TextBox tbPort;
    }
}