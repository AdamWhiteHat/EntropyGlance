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
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnByteDetails = new System.Windows.Forms.Button();
            this.btnFileDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAbsolute = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAbsoluteNormalized = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(556, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shannon Specific Entropy:";
            // 
            // tbShannonSpecific
            // 
            this.tbShannonSpecific.Enabled = false;
            this.tbShannonSpecific.Location = new System.Drawing.Point(204, 6);
            this.tbShannonSpecific.Name = "tbShannonSpecific";
            this.tbShannonSpecific.Size = new System.Drawing.Size(100, 20);
            this.tbShannonSpecific.TabIndex = 2;
            // 
            // tbShannonNormalized
            // 
            this.tbShannonNormalized.Enabled = false;
            this.tbShannonNormalized.Location = new System.Drawing.Point(204, 28);
            this.tbShannonNormalized.Name = "tbShannonNormalized";
            this.tbShannonNormalized.Size = new System.Drawing.Size(100, 20);
            this.tbShannonNormalized.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shannon Specific Entropy (Normalized):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCompression
            // 
            this.tbCompression.Enabled = false;
            this.tbCompression.Location = new System.Drawing.Point(204, 50);
            this.tbCompression.Name = "tbCompression";
            this.tbCompression.Size = new System.Drawing.Size(100, 20);
            this.tbCompression.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Compression Ratio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "bits/symbol (Range: 0 to 8)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "entropy/symbol (Range: 0 to 1)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "% (does not work well on small files)";
            // 
            // progressBarEntropy
            // 
            this.progressBarEntropy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEntropy.Location = new System.Drawing.Point(5, 165);
            this.progressBarEntropy.Maximum = 800;
            this.progressBarEntropy.Name = "progressBarEntropy";
            this.progressBarEntropy.Size = new System.Drawing.Size(629, 20);
            this.progressBarEntropy.TabIndex = 16;
            // 
            // progressBarCompression
            // 
            this.progressBarCompression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarCompression.Location = new System.Drawing.Point(5, 128);
            this.progressBarCompression.Name = "progressBarCompression";
            this.progressBarCompression.Size = new System.Drawing.Size(629, 20);
            this.progressBarCompression.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Shannon entropy:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Compression ratio:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbAbsolute);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbAbsoluteNormalized);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbShannonSpecific);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbShannonNormalized);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCompression);
            this.panel1.Location = new System.Drawing.Point(5, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 74);
            this.panel1.TabIndex = 20;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(5, 7);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(551, 20);
            this.tbFilePath.TabIndex = 21;
            // 
            // btnByteDetails
            // 
            this.btnByteDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnByteDetails.Location = new System.Drawing.Point(497, 58);
            this.btnByteDetails.Name = "btnByteDetails";
            this.btnByteDetails.Size = new System.Drawing.Size(137, 23);
            this.btnByteDetails.TabIndex = 22;
            this.btnByteDetails.Text = "View per-byte details...";
            this.btnByteDetails.UseVisualStyleBackColor = true;
            this.btnByteDetails.Visible = false;
            this.btnByteDetails.Click += new System.EventHandler(this.btnByteDetails_Click);
            // 
            // btnFileDetails
            // 
            this.btnFileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileDetails.Location = new System.Drawing.Point(497, 32);
            this.btnFileDetails.Name = "btnFileDetails";
            this.btnFileDetails.Size = new System.Drawing.Size(137, 23);
            this.btnFileDetails.TabIndex = 23;
            this.btnFileDetails.Text = "View file entropy details...";
            this.btnFileDetails.UseVisualStyleBackColor = true;
            this.btnFileDetails.Click += new System.EventHandler(this.btnFileDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Absolute Entropy:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Visible = false;
            // 
            // tbAbsolute
            // 
            this.tbAbsolute.Enabled = false;
            this.tbAbsolute.Location = new System.Drawing.Point(204, 72);
            this.tbAbsolute.Name = "tbAbsolute";
            this.tbAbsolute.Size = new System.Drawing.Size(100, 20);
            this.tbAbsolute.TabIndex = 17;
            this.tbAbsolute.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "entropy";
            this.label9.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Absolute Entropy (Normalized):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "bits";
            this.label8.Visible = false;
            // 
            // tbAbsoluteNormalized
            // 
            this.tbAbsoluteNormalized.Enabled = false;
            this.tbAbsoluteNormalized.Location = new System.Drawing.Point(204, 94);
            this.tbAbsoluteNormalized.Name = "tbAbsoluteNormalized";
            this.tbAbsoluteNormalized.Size = new System.Drawing.Size(100, 20);
            this.tbAbsoluteNormalized.TabIndex = 19;
            this.tbAbsoluteNormalized.Visible = false;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAbsolute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAbsoluteNormalized;
    }
}

