﻿namespace nLauncher
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
            this.txt_image1 = new System.Windows.Forms.TextBox();
            this.btn_searchImage = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_image2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(101, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(105, 20);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(101, 78);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(317, 20);
            this.txt_name.TabIndex = 5;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(101, 119);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(317, 20);
            this.txt_path.TabIndex = 6;
            // 
            // txt_image1
            // 
            this.txt_image1.Location = new System.Drawing.Point(101, 159);
            this.txt_image1.Name = "txt_image1";
            this.txt_image1.Size = new System.Drawing.Size(317, 20);
            this.txt_image1.TabIndex = 7;
            // 
            // btn_searchImage
            // 
            this.btn_searchImage.Location = new System.Drawing.Point(424, 157);
            this.btn_searchImage.Name = "btn_searchImage";
            this.btn_searchImage.Size = new System.Drawing.Size(75, 23);
            this.btn_searchImage.TabIndex = 8;
            this.btn_searchImage.Text = "button1";
            this.btn_searchImage.UseVisualStyleBackColor = true;
            this.btn_searchImage.Click += new System.EventHandler(this.btn_searchImage_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(424, 235);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "button1";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_image2
            // 
            this.txt_image2.Location = new System.Drawing.Point(101, 194);
            this.txt_image2.Name = "txt_image2";
            this.txt_image2.Size = new System.Drawing.Size(317, 20);
            this.txt_image2.TabIndex = 10;
            // 
            // AppEntryDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 270);
            this.Controls.Add(this.txt_image2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_searchImage);
            this.Controls.Add(this.txt_image1);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppEntryDetailsForm";
            this.Text = "AppEntryDetailsForm";
            this.Load += new System.EventHandler(this.AppEntryDetailsForm_Load);
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
        private System.Windows.Forms.TextBox txt_image1;
        private System.Windows.Forms.Button btn_searchImage;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_image2;
    }
}