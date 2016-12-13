namespace Minesweeper_DataStructAndAlgorithms
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.M_Head = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Easy = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Normal = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Advanced = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.P_Head = new System.Windows.Forms.Panel();
            this.PIC_Flag = new System.Windows.Forms.PictureBox();
            this.PIC_Boom = new System.Windows.Forms.PictureBox();
            this.LB_Flag = new System.Windows.Forms.Label();
            this.BTN_Status = new System.Windows.Forms.Button();
            this.LB_Boom = new System.Windows.Forms.Label();
            this.LB_Time = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minefields = new Minesweeper_DataStructAndAlgorithms.Minefields();
            this.M_Head.SuspendLayout();
            this.P_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Boom)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // M_Head
            // 
            this.M_Head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.M_Head.Location = new System.Drawing.Point(0, 0);
            this.M_Head.Name = "M_Head";
            this.M_Head.Size = new System.Drawing.Size(184, 24);
            this.M_Head.TabIndex = 0;
            this.M_Head.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.TS_Exit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Easy,
            this.TS_Normal,
            this.TS_Advanced});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // TS_Easy
            // 
            this.TS_Easy.Name = "TS_Easy";
            this.TS_Easy.Size = new System.Drawing.Size(127, 22);
            this.TS_Easy.Text = "Easy";
            this.TS_Easy.Click += new System.EventHandler(this.TS_Easy_Click);
            // 
            // TS_Normal
            // 
            this.TS_Normal.Name = "TS_Normal";
            this.TS_Normal.Size = new System.Drawing.Size(127, 22);
            this.TS_Normal.Text = "Normal";
            this.TS_Normal.Click += new System.EventHandler(this.TS_Normal_Click);
            // 
            // TS_Advanced
            // 
            this.TS_Advanced.Name = "TS_Advanced";
            this.TS_Advanced.Size = new System.Drawing.Size(127, 22);
            this.TS_Advanced.Text = "&Advanced";
            this.TS_Advanced.Click += new System.EventHandler(this.TS_Advanced_Click);
            // 
            // TS_Exit
            // 
            this.TS_Exit.Name = "TS_Exit";
            this.TS_Exit.Size = new System.Drawing.Size(98, 22);
            this.TS_Exit.Text = "&Exit";
            this.TS_Exit.Click += new System.EventHandler(this.TS_Exit_Click);
            // 
            // P_Head
            // 
            this.P_Head.BackColor = System.Drawing.Color.Transparent;
            this.P_Head.Controls.Add(this.PIC_Flag);
            this.P_Head.Controls.Add(this.PIC_Boom);
            this.P_Head.Controls.Add(this.LB_Flag);
            this.P_Head.Controls.Add(this.BTN_Status);
            this.P_Head.Controls.Add(this.LB_Boom);
            this.P_Head.Controls.Add(this.LB_Time);
            this.P_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Head.Location = new System.Drawing.Point(0, 24);
            this.P_Head.Name = "P_Head";
            this.P_Head.Size = new System.Drawing.Size(184, 82);
            this.P_Head.TabIndex = 1;
            // 
            // PIC_Flag
            // 
            this.PIC_Flag.BackgroundImage = Properties.Resources.flag;
            this.PIC_Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_Flag.Location = new System.Drawing.Point(74, 28);
            this.PIC_Flag.Name = "PIC_Flag";
            this.PIC_Flag.Size = new System.Drawing.Size(19, 18);
            this.PIC_Flag.TabIndex = 6;
            this.PIC_Flag.TabStop = false;
            // 
            // PIC_Boom
            // 
            this.PIC_Boom.BackgroundImage = global::Minesweeper_DataStructAndAlgorithms.Properties.Resources.bomb;
            this.PIC_Boom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_Boom.Location = new System.Drawing.Point(129, 28);
            this.PIC_Boom.Name = "PIC_Boom";
            this.PIC_Boom.Size = new System.Drawing.Size(19, 18);
            this.PIC_Boom.TabIndex = 5;
            this.PIC_Boom.TabStop = false;
            // 
            // LB_Flag
            // 
            this.LB_Flag.AutoSize = true;
            this.LB_Flag.Location = new System.Drawing.Point(71, 49);
            this.LB_Flag.Name = "LB_Flag";
            this.LB_Flag.Size = new System.Drawing.Size(27, 13);
            this.LB_Flag.TabIndex = 4;
            this.LB_Flag.Text = "Flag";
            // 
            // BTN_Status
            // 
            this.BTN_Status.BackgroundImage = global::Minesweeper_DataStructAndAlgorithms.Properties.Resources.play;
            this.BTN_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Status.Location = new System.Drawing.Point(12, 11);
            this.BTN_Status.Name = "BTN_Status";
            this.BTN_Status.Size = new System.Drawing.Size(48, 35);
            this.BTN_Status.TabIndex = 2;
            this.BTN_Status.UseVisualStyleBackColor = true;
            this.BTN_Status.Click += new System.EventHandler(this.BTN_Status_Click);
            // 
            // LB_Boom
            // 
            this.LB_Boom.AutoSize = true;
            this.LB_Boom.Location = new System.Drawing.Point(125, 49);
            this.LB_Boom.Name = "LB_Boom";
            this.LB_Boom.Size = new System.Drawing.Size(34, 13);
            this.LB_Boom.TabIndex = 1;
            this.LB_Boom.Text = "Bomb";
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Location = new System.Drawing.Point(16, 49);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(28, 13);
            this.LB_Time.TabIndex = 0;
            this.LB_Time.Text = "0:00";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(184, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 185);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.minefields);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 185);
            this.panel2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minefields
            // 
            this.minefields.BackColor = System.Drawing.Color.White;
            this.minefields.ForeColor = System.Drawing.Color.White;
            this.minefields.Location = new System.Drawing.Point(5, 5);
            this.minefields.Name = "minefields";
            this.minefields.Size = new System.Drawing.Size(179, 181);
            this.minefields.TabIndex = 0;
            this.minefields.CellClick += new System.EventHandler(this.minefields_CellClick);
            this.minefields.firebombEvent += new System.EventHandler(this.minesfields_firebombEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 291);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_Head);
            this.Controls.Add(this.M_Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.M_Head;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper - Data struct & Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.M_Head.ResumeLayout(false);
            this.M_Head.PerformLayout();
            this.P_Head.ResumeLayout(false);
            this.P_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Boom)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip M_Head;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_Easy;
        private System.Windows.Forms.ToolStripMenuItem TS_Exit;
        private System.Windows.Forms.ToolStripMenuItem TS_Normal;
        private System.Windows.Forms.ToolStripMenuItem TS_Advanced;
        private System.Windows.Forms.Panel P_Head;
        private System.Windows.Forms.PictureBox PIC_Flag;
        private System.Windows.Forms.PictureBox PIC_Boom;
        private System.Windows.Forms.Label LB_Flag;
        private System.Windows.Forms.Button BTN_Status;
        private System.Windows.Forms.Label LB_Boom;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Minefields minefields;
        private System.Windows.Forms.Timer timer1;
    }
}

