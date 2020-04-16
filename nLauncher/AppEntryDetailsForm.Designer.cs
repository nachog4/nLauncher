namespace nLauncher
{
    partial class AppEntryDetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmd_delete = new System.Windows.Forms.Button();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.pic_screenshot1 = new System.Windows.Forms.PictureBox();
            this.pic_screenshot3 = new System.Windows.Forms.PictureBox();
            this.pic_screenshot2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Image";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(79, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 20);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(79, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(372, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(79, 58);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(372, 20);
            this.txt_path.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(376, 269);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmd_delete
            // 
            this.cmd_delete.Location = new System.Drawing.Point(295, 269);
            this.cmd_delete.Name = "cmd_delete";
            this.cmd_delete.Size = new System.Drawing.Size(75, 23);
            this.cmd_delete.TabIndex = 11;
            this.cmd_delete.Text = "Delete";
            this.cmd_delete.UseVisualStyleBackColor = true;
            this.cmd_delete.Click += new System.EventHandler(this.cmd_delete_Click);
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(79, 84);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(120, 20);
            this.txt_category.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Screenshot";
            // 
            // pic_image
            // 
            this.pic_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_image.Location = new System.Drawing.Point(79, 110);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(120, 68);
            this.pic_image.TabIndex = 19;
            this.pic_image.TabStop = false;
            this.pic_image.Click += new System.EventHandler(this.pic_image_Click);
            // 
            // pic_screenshot1
            // 
            this.pic_screenshot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_screenshot1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_screenshot1.Location = new System.Drawing.Point(79, 184);
            this.pic_screenshot1.Name = "pic_screenshot1";
            this.pic_screenshot1.Size = new System.Drawing.Size(120, 68);
            this.pic_screenshot1.TabIndex = 20;
            this.pic_screenshot1.TabStop = false;
            this.pic_screenshot1.Click += new System.EventHandler(this.pic_screenshot1_Click);
            // 
            // pic_screenshot3
            // 
            this.pic_screenshot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_screenshot3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_screenshot3.Location = new System.Drawing.Point(331, 184);
            this.pic_screenshot3.Name = "pic_screenshot3";
            this.pic_screenshot3.Size = new System.Drawing.Size(120, 68);
            this.pic_screenshot3.TabIndex = 21;
            this.pic_screenshot3.TabStop = false;
            this.pic_screenshot3.Click += new System.EventHandler(this.pic_screenshot3_Click);
            // 
            // pic_screenshot2
            // 
            this.pic_screenshot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_screenshot2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_screenshot2.Location = new System.Drawing.Point(205, 184);
            this.pic_screenshot2.Name = "pic_screenshot2";
            this.pic_screenshot2.Size = new System.Drawing.Size(120, 68);
            this.pic_screenshot2.TabIndex = 22;
            this.pic_screenshot2.TabStop = false;
            this.pic_screenshot2.Click += new System.EventHandler(this.pic_screenshot2_Click);
            // 
            // AppEntryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 302);
            this.Controls.Add(this.pic_screenshot2);
            this.Controls.Add(this.pic_screenshot3);
            this.Controls.Add(this.pic_screenshot1);
            this.Controls.Add(this.pic_image);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.cmd_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppEntryDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppEntryDetailsForm";
            this.Load += new System.EventHandler(this.AppEntryDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_screenshot2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button cmd_delete;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pic_image;
        private System.Windows.Forms.PictureBox pic_screenshot1;
        private System.Windows.Forms.PictureBox pic_screenshot3;
        private System.Windows.Forms.PictureBox pic_screenshot2;
    }
}