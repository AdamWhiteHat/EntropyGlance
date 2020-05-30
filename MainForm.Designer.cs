namespace EntropyGlance
{
    partial class MainForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbShannonSpecific = new System.Windows.Forms.TextBox();
            this.tbShannonNormalized = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCompression = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBarEntropy = new System.Windows.Forms.ProgressBar();
            this.progressBarCompression = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnByteDetails = new System.Windows.Forms.Button();
            this.btnFileDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(555, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(81, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shannon Specific Entropy:";
            // 
            // tbShannonSpecific
            // 
            this.tbShannonSpecific.Enabled = false;
            this.tbShannonSpecific.Location = new System.Drawing.Point(204, 3);
            this.tbShannonSpecific.Name = "tbShannonSpecific";
            this.tbShannonSpecific.Size = new System.Drawing.Size(72, 20);
            this.tbShannonSpecific.TabIndex = 1;
            this.tbShannonSpecific.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbShannonNormalized
            // 
            this.tbShannonNormalized.Enabled = false;
            this.tbShannonNormalized.Location = new System.Drawing.Point(204, 24);
            this.tbShannonNormalized.Name = "tbShannonNormalized";
            this.tbShannonNormalized.Size = new System.Drawing.Size(72, 20);
            this.tbShannonNormalized.TabIndex = 5;
            this.tbShannonNormalized.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shannon Specific Entropy (Normalized):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCompression
            // 
            this.tbCompression.Enabled = false;
            this.tbCompression.Location = new System.Drawing.Point(204, 45);
            this.tbCompression.Name = "tbCompression";
            this.tbCompression.Size = new System.Drawing.Size(72, 20);
            this.tbCompression.TabIndex = 9;
            this.tbCompression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compression Rate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "bits/symbol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "entropy/symbol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "%";
            // 
            // progressBarEntropy
            // 
            this.progressBarEntropy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEntropy.Location = new System.Drawing.Point(3, 162);
            this.progressBarEntropy.MarqueeAnimationSpeed = 1;
            this.progressBarEntropy.Maximum = 80;
            this.progressBarEntropy.Name = "progressBarEntropy";
            this.progressBarEntropy.Size = new System.Drawing.Size(633, 24);
            this.progressBarEntropy.Step = 1;
            this.progressBarEntropy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEntropy.TabIndex = 7;
            // 
            // progressBarCompression
            // 
            this.progressBarCompression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCompression.Location = new System.Drawing.Point(3, 120);
            this.progressBarCompression.MarqueeAnimationSpeed = 1;
            this.progressBarCompression.Name = "progressBarCompression";
            this.progressBarCompression.Size = new System.Drawing.Size(633, 24);
            this.progressBarCompression.Step = 1;
            this.progressBarCompression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCompression.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 147);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Shannon entropy:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Compression rate:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbShannonSpecific);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbShannonNormalized);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCompression);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 69);
            this.panel1.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(303, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = " (does not work well on small files)";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "(Range: 0 to 1)";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(393, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "(Range: 0 to 8)";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(3, 6);
            this.tbFilePath.MinimumSize = new System.Drawing.Size(100, 20);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(549, 20);
            this.tbFilePath.TabIndex = 0;
            this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
            // 
            // btnByteDetails
            // 
            this.btnByteDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnByteDetails.Location = new System.Drawing.Point(483, 33);
            this.btnByteDetails.Name = "btnByteDetails";
            this.btnByteDetails.Size = new System.Drawing.Size(152, 27);
            this.btnByteDetails.TabIndex = 8;
            this.btnByteDetails.Text = "View per-byte frequencies...";
            this.btnByteDetails.UseVisualStyleBackColor = true;
            this.btnByteDetails.Click += new System.EventHandler(this.btnByteDetails_Click);
            // 
            // btnFileDetails
            // 
            this.btnFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileDetails.Location = new System.Drawing.Point(483, 60);
            this.btnFileDetails.Name = "btnFileDetails";
            this.btnFileDetails.Size = new System.Drawing.Size(152, 42);
            this.btnFileDetails.TabIndex = 0;
            this.btnFileDetails.Text = "View graph of entropy changes across entire file...";
            this.btnFileDetails.UseVisualStyleBackColor = true;
            this.btnFileDetails.Click += new System.EventHandler(this.btnFileDetails_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 191);
            this.Controls.Add(this.btnFileDetails);
            this.Controls.Add(this.btnByteDetails);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBarCompression);
            this.Controls.Add(this.progressBarEntropy);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Entropy at a glance";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbShannonSpecific;
        private System.Windows.Forms.TextBox tbShannonNormalized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCompression;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBarEntropy;
        private System.Windows.Forms.ProgressBar progressBarCompression;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnByteDetails;
        private System.Windows.Forms.Button btnFileDetails;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
	}
}

