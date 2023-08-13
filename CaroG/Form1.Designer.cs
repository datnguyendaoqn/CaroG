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
            panel1 = new Panel();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnBoardchess
            // 
            pnBoardchess.Location = new Point(12, 27);
            pnBoardchess.Name = "pnBoardchess";
            pnBoardchess.Size = new Size(761, 524);
            pnBoardchess.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(791, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 306);
            panel1.TabIndex = 1;
            // 
            // tbName
            // 
            tbName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(791, 345);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.ReadOnly = true;
            tbName.Size = new Size(132, 29);
            tbName.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbIcon);
            panel2.Location = new Point(929, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 184);
            panel2.TabIndex = 3;
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbIcon.Location = new Point(3, 3);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(194, 167);
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            // 
            // CD
            // 
            CD.Tick += CD_Tick;
            // 
            // pgbtime
            // 
            pgbtime.Location = new Point(791, 380);
            pgbtime.Name = "pgbtime";
            pgbtime.Size = new Size(132, 23);
            pgbtime.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1393, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(174, 22);
            newGameToolStripMenuItem.Text = "New game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(174, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            quitToolStripMenuItem.Size = new Size(174, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // tbIPAddress
            // 
            tbIPAddress.Location = new Point(791, 409);
            tbIPAddress.Name = "tbIPAddress";
            tbIPAddress.Size = new Size(132, 23);
            tbIPAddress.TabIndex = 6;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(791, 438);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(132, 23);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 613);
            Controls.Add(btnConnect);
            Controls.Add(tbIPAddress);
            Controls.Add(pgbtime);
            Controls.Add(panel2);
            Controls.Add(tbName);
            Controls.Add(panel1);
            Controls.Add(pnBoardchess);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlLightLight;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(2000, 2000);
            MinimumSize = new Size(938, 575);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Shown += Form1_Shown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBoardchess;
        private Panel panel1;
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
    }
}