namespace Filedublicates.NET
{
    partial class SearchingDuplicates
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
            this.progressBarByteByByteComparsion = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarHashing = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalCmpOpNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCmpOpPassed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEstimatedTimeForCmp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTimePassed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarByteByByteComparsion
            // 
            this.progressBarByteByByteComparsion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarByteByByteComparsion.Location = new System.Drawing.Point(16, 38);
            this.progressBarByteByByteComparsion.Name = "progressBarByteByByteComparsion";
            this.progressBarByteByByteComparsion.Size = new System.Drawing.Size(378, 23);
            this.progressBarByteByByteComparsion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Byte by byte comparsion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hashing";
            // 
            // progressBarHashing
            // 
            this.progressBarHashing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarHashing.Location = new System.Drawing.Point(12, 204);
            this.progressBarHashing.Name = "progressBarHashing";
            this.progressBarHashing.Size = new System.Drawing.Size(378, 23);
            this.progressBarHashing.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total number of comparsion operations";
            // 
            // labelTotalCmpOpNumber
            // 
            this.labelTotalCmpOpNumber.AutoSize = true;
            this.labelTotalCmpOpNumber.Location = new System.Drawing.Point(209, 79);
            this.labelTotalCmpOpNumber.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelTotalCmpOpNumber.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTotalCmpOpNumber.Name = "labelTotalCmpOpNumber";
            this.labelTotalCmpOpNumber.Size = new System.Drawing.Size(100, 13);
            this.labelTotalCmpOpNumber.TabIndex = 5;
            this.labelTotalCmpOpNumber.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of passed comparsion operations";
            // 
            // labelCmpOpPassed
            // 
            this.labelCmpOpPassed.AutoSize = true;
            this.labelCmpOpPassed.Location = new System.Drawing.Point(221, 105);
            this.labelCmpOpPassed.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelCmpOpPassed.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelCmpOpPassed.Name = "labelCmpOpPassed";
            this.labelCmpOpPassed.Size = new System.Drawing.Size(100, 13);
            this.labelCmpOpPassed.TabIndex = 7;
            this.labelCmpOpPassed.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estimated time for comparsion";
            // 
            // labelEstimatedTimeForCmp
            // 
            this.labelEstimatedTimeForCmp.AutoSize = true;
            this.labelEstimatedTimeForCmp.Location = new System.Drawing.Point(166, 128);
            this.labelEstimatedTimeForCmp.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelEstimatedTimeForCmp.Name = "labelEstimatedTimeForCmp";
            this.labelEstimatedTimeForCmp.Size = new System.Drawing.Size(100, 13);
            this.labelEstimatedTimeForCmp.TabIndex = 9;
            this.labelEstimatedTimeForCmp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time passed";
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.Location = new System.Drawing.Point(86, 153);
            this.labelTimePassed.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(100, 13);
            this.labelTimePassed.TabIndex = 11;
            this.labelTimePassed.Text = "0";
            // 
            // SearchingDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 244);
            this.Controls.Add(this.labelTimePassed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEstimatedTimeForCmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCmpOpPassed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotalCmpOpNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarHashing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarByteByByteComparsion);
            this.Name = "SearchingDuplicates";
            this.Text = "SearchingDuplicates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarByteByByteComparsion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarHashing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalCmpOpNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCmpOpPassed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEstimatedTimeForCmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTimePassed;
    }
}