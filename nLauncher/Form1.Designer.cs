namespace nLauncher
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmd_play = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pic_rightpanel_3 = new System.Windows.Forms.PictureBox();
            this.pic_rightpanel_2 = new System.Windows.Forms.PictureBox();
            this.pic_rightpanel_1 = new System.Windows.Forms.PictureBox();
            this.lbl_rightpanel_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_group_drives = new System.Windows.Forms.RadioButton();
            this.rd_group_categories = new System.Windows.Forms.RadioButton();
            this.rd_group_none = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_1)).BeginInit();
            this.panel3.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 1301);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 77);
            this.panel1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(300, 27);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(209, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 45F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "nLauncher";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmd_play);
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Controls.Add(this.pic_rightpanel_3);
            this.panel2.Controls.Add(this.pic_rightpanel_2);
            this.panel2.Controls.Add(this.pic_rightpanel_1);
            this.panel2.Controls.Add(this.lbl_rightpanel_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1049, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 1301);
            this.panel2.TabIndex = 2;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // cmd_play
            // 
            this.cmd_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_play.Image = global::nLauncher.Properties.Resources.play_button;
            this.cmd_play.Location = new System.Drawing.Point(370, 1168);
            this.cmd_play.Name = "cmd_play";
            this.cmd_play.Size = new System.Drawing.Size(117, 99);
            this.cmd_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmd_play.TabIndex = 5;
            this.cmd_play.TabStop = false;
            this.cmd_play.Visible = false;
            this.cmd_play.Click += new System.EventHandler(this.cmd_play_Click);
            this.cmd_play.MouseEnter += new System.EventHandler(this.cmd_play_MouseEnter);
            this.cmd_play.MouseLeave += new System.EventHandler(this.cmd_play_MouseLeave);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(11, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(477, 268);
            this.webBrowser1.TabIndex = 4;
            // 
            // pic_rightpanel_3
            // 
            this.pic_rightpanel_3.Location = new System.Drawing.Point(10, 894);
            this.pic_rightpanel_3.Name = "pic_rightpanel_3";
            this.pic_rightpanel_3.Size = new System.Drawing.Size(477, 268);
            this.pic_rightpanel_3.TabIndex = 3;
            this.pic_rightpanel_3.TabStop = false;
            this.pic_rightpanel_3.Click += new System.EventHandler(this.pic_rightpanel_1_Click);
            // 
            // pic_rightpanel_2
            // 
            this.pic_rightpanel_2.Location = new System.Drawing.Point(11, 620);
            this.pic_rightpanel_2.Name = "pic_rightpanel_2";
            this.pic_rightpanel_2.Size = new System.Drawing.Size(477, 268);
            this.pic_rightpanel_2.TabIndex = 2;
            this.pic_rightpanel_2.TabStop = false;
            this.pic_rightpanel_2.Click += new System.EventHandler(this.pic_rightpanel_1_Click);
            // 
            // pic_rightpanel_1
            // 
            this.pic_rightpanel_1.Location = new System.Drawing.Point(11, 346);
            this.pic_rightpanel_1.Name = "pic_rightpanel_1";
            this.pic_rightpanel_1.Size = new System.Drawing.Size(477, 268);
            this.pic_rightpanel_1.TabIndex = 1;
            this.pic_rightpanel_1.TabStop = false;
            this.pic_rightpanel_1.Click += new System.EventHandler(this.pic_rightpanel_1_Click);
            // 
            // lbl_rightpanel_title
            // 
            this.lbl_rightpanel_title.AutoSize = true;
            this.lbl_rightpanel_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rightpanel_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rightpanel_title.ForeColor = System.Drawing.Color.White;
            this.lbl_rightpanel_title.Location = new System.Drawing.Point(4, 4);
            this.lbl_rightpanel_title.Name = "lbl_rightpanel_title";
            this.lbl_rightpanel_title.Size = new System.Drawing.Size(37, 39);
            this.lbl_rightpanel_title.TabIndex = 0;
            this.lbl_rightpanel_title.Text = "_";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 1378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1549, 21);
            this.panel3.TabIndex = 4;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(3, 2);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(13, 13);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "_";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Black;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.groupBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 77);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 1301);
            this.leftPanel.TabIndex = 5;
            this.leftPanel.Click += new System.EventHandler(this.leftPanel_Click);
            this.leftPanel.DoubleClick += new System.EventHandler(this.leftPanel_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_group_drives);
            this.groupBox1.Controls.Add(this.rd_group_categories);
            this.groupBox1.Controls.Add(this.rd_group_none);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rd_group_drives
            // 
            this.rd_group_drives.AutoSize = true;
            this.rd_group_drives.Location = new System.Drawing.Point(14, 68);
            this.rd_group_drives.Name = "rd_group_drives";
            this.rd_group_drives.Size = new System.Drawing.Size(55, 17);
            this.rd_group_drives.TabIndex = 2;
            this.rd_group_drives.TabStop = true;
            this.rd_group_drives.Text = "Drives";
            this.rd_group_drives.UseVisualStyleBackColor = true;
            this.rd_group_drives.CheckedChanged += new System.EventHandler(this.rd_group_drives_CheckedChanged);
            // 
            // rd_group_categories
            // 
            this.rd_group_categories.AutoSize = true;
            this.rd_group_categories.Location = new System.Drawing.Point(14, 45);
            this.rd_group_categories.Name = "rd_group_categories";
            this.rd_group_categories.Size = new System.Drawing.Size(75, 17);
            this.rd_group_categories.TabIndex = 1;
            this.rd_group_categories.TabStop = true;
            this.rd_group_categories.Text = "Categories";
            this.rd_group_categories.UseVisualStyleBackColor = true;
            this.rd_group_categories.CheckedChanged += new System.EventHandler(this.rd_group_categories_CheckedChanged);
            // 
            // rd_group_none
            // 
            this.rd_group_none.AutoSize = true;
            this.rd_group_none.Location = new System.Drawing.Point(14, 22);
            this.rd_group_none.Name = "rd_group_none";
            this.rd_group_none.Size = new System.Drawing.Size(51, 17);
            this.rd_group_none.TabIndex = 0;
            this.rd_group_none.TabStop = true;
            this.rd_group_none.Text = "None";
            this.rd_group_none.UseVisualStyleBackColor = true;
            this.rd_group_none.CheckedChanged += new System.EventHandler(this.rd_group_none_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(150, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 1301);
            this.panel5.TabIndex = 6;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 1399);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rightpanel_1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pic_rightpanel_3;
        private System.Windows.Forms.PictureBox pic_rightpanel_2;
        private System.Windows.Forms.PictureBox pic_rightpanel_1;
        private System.Windows.Forms.Label lbl_rightpanel_title;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_group_drives;
        private System.Windows.Forms.RadioButton rd_group_categories;
        private System.Windows.Forms.RadioButton rd_group_none;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox cmd_play;
    }
}

