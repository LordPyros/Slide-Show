namespace Slide_Show
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartSlideShowBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.ImageSizeCb = new System.Windows.Forms.ComboBox();
            this.SelectFolderBtn = new System.Windows.Forms.Button();
            this.PathLb = new System.Windows.Forms.Label();
            this.trackBarValueLb = new System.Windows.Forms.Label();
            this.RestoreDefaultsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slide Show Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Image Rotation Speed";
            // 
            // StartSlideShowBtn
            // 
            this.StartSlideShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSlideShowBtn.Location = new System.Drawing.Point(616, 401);
            this.StartSlideShowBtn.Name = "StartSlideShowBtn";
            this.StartSlideShowBtn.Size = new System.Drawing.Size(151, 30);
            this.StartSlideShowBtn.TabIndex = 2;
            this.StartSlideShowBtn.Text = "Start Slide Show";
            this.StartSlideShowBtn.UseVisualStyleBackColor = true;
            this.StartSlideShowBtn.Click += new System.EventHandler(this.StartSlideShowBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(91, 304);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(596, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Image Size";
            // 
            // ImageSizeCb
            // 
            this.ImageSizeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSizeCb.FormattingEnabled = true;
            this.ImageSizeCb.Location = new System.Drawing.Point(102, 157);
            this.ImageSizeCb.Name = "ImageSizeCb";
            this.ImageSizeCb.Size = new System.Drawing.Size(121, 28);
            this.ImageSizeCb.TabIndex = 6;
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderBtn.Location = new System.Drawing.Point(524, 155);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(221, 30);
            this.SelectFolderBtn.TabIndex = 7;
            this.SelectFolderBtn.Text = "Select Image Folder";
            this.SelectFolderBtn.UseVisualStyleBackColor = true;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // PathLb
            // 
            this.PathLb.AutoSize = true;
            this.PathLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLb.Location = new System.Drawing.Point(520, 188);
            this.PathLb.Name = "PathLb";
            this.PathLb.Size = new System.Drawing.Size(118, 20);
            this.PathLb.TabIndex = 8;
            this.PathLb.Text = "C:\\ImageFolder";
            // 
            // trackBarValueLb
            // 
            this.trackBarValueLb.AutoSize = true;
            this.trackBarValueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBarValueLb.Location = new System.Drawing.Point(353, 352);
            this.trackBarValueLb.Name = "trackBarValueLb";
            this.trackBarValueLb.Size = new System.Drawing.Size(85, 20);
            this.trackBarValueLb.TabIndex = 9;
            this.trackBarValueLb.Text = "3 Seconds";
            // 
            // RestoreDefaultsBtn
            // 
            this.RestoreDefaultsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDefaultsBtn.Location = new System.Drawing.Point(34, 401);
            this.RestoreDefaultsBtn.Name = "RestoreDefaultsBtn";
            this.RestoreDefaultsBtn.Size = new System.Drawing.Size(161, 30);
            this.RestoreDefaultsBtn.TabIndex = 10;
            this.RestoreDefaultsBtn.Text = "Restore Default Settings";
            this.RestoreDefaultsBtn.UseVisualStyleBackColor = true;
            this.RestoreDefaultsBtn.Click += new System.EventHandler(this.RestoreDefaultsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestoreDefaultsBtn);
            this.Controls.Add(this.trackBarValueLb);
            this.Controls.Add(this.PathLb);
            this.Controls.Add(this.SelectFolderBtn);
            this.Controls.Add(this.ImageSizeCb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.StartSlideShowBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide Show";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartSlideShowBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ImageSizeCb;
        private System.Windows.Forms.Button SelectFolderBtn;
        private System.Windows.Forms.Label PathLb;
        private System.Windows.Forms.Label trackBarValueLb;
        private System.Windows.Forms.Button RestoreDefaultsBtn;
    }
}

