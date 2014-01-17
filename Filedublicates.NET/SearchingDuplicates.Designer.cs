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
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalHashingOp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelPassedHashingOp = new System.Windows.Forms.Label();
            this.progressBarOverallProcess = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarByteByByteComparsion
            // 
            this.progressBarByteByByteComparsion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarByteByByteComparsion.Location = new System.Drawing.Point(16, 38);
            this.progressBarByteByByteComparsion.Name = "progressBarByteByByteComparsion";
            this.progressBarByteByByteComparsion.Size = new System.Drawing.Size(479, 23);
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
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hashing";
            // 
            // progressBarHashing
            // 
            this.progressBarHashing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarHashing.Location = new System.Drawing.Point(16, 166);
            this.progressBarHashing.Name = "progressBarHashing";
            this.progressBarHashing.Size = new System.Drawing.Size(479, 23);
            this.progressBarHashing.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total number of comparsion operations";
            // 
            // labelTotalCmpOpNumber
            // 
            this.labelTotalCmpOpNumber.AutoSize = true;
            this.labelTotalCmpOpNumber.Location = new System.Drawing.Point(221, 75);
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
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of passed comparsion operations";
            // 
            // labelCmpOpPassed
            // 
            this.labelCmpOpPassed.AutoSize = true;
            this.labelCmpOpPassed.Location = new System.Drawing.Point(221, 101);
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
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estimated time for comparsion";
            // 
            // labelEstimatedTimeForCmp
            // 
            this.labelEstimatedTimeForCmp.AutoSize = true;
            this.labelEstimatedTimeForCmp.Location = new System.Drawing.Point(166, 124);
            this.labelEstimatedTimeForCmp.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelEstimatedTimeForCmp.Name = "labelEstimatedTimeForCmp";
            this.labelEstimatedTimeForCmp.Size = new System.Drawing.Size(100, 13);
            this.labelEstimatedTimeForCmp.TabIndex = 9;
            this.labelEstimatedTimeForCmp.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time passed";
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.Location = new System.Drawing.Point(90, 307);
            this.labelTimePassed.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(100, 13);
            this.labelTimePassed.TabIndex = 11;
            this.labelTimePassed.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total number of hashing operations";
            // 
            // labelTotalHashingOp
            // 
            this.labelTotalHashingOp.AutoSize = true;
            this.labelTotalHashingOp.Location = new System.Drawing.Point(196, 204);
            this.labelTotalHashingOp.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelTotalHashingOp.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTotalHashingOp.Name = "labelTotalHashingOp";
            this.labelTotalHashingOp.Size = new System.Drawing.Size(100, 13);
            this.labelTotalHashingOp.TabIndex = 13;
            this.labelTotalHashingOp.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of passed hashing operations";
            // 
            // labelPassedHashingOp
            // 
            this.labelPassedHashingOp.AutoSize = true;
            this.labelPassedHashingOp.Location = new System.Drawing.Point(208, 232);
            this.labelPassedHashingOp.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelPassedHashingOp.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelPassedHashingOp.Name = "labelPassedHashingOp";
            this.labelPassedHashingOp.Size = new System.Drawing.Size(100, 13);
            this.labelPassedHashingOp.TabIndex = 13;
            this.labelPassedHashingOp.Text = "0";
            // 
            // progressBarOverallProcess
            // 
            this.progressBarOverallProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarOverallProcess.Location = new System.Drawing.Point(16, 270);
            this.progressBarOverallProcess.Name = "progressBarOverallProcess";
            this.progressBarOverallProcess.Size = new System.Drawing.Size(479, 23);
            this.progressBarOverallProcess.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Overall process";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(419, 307);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // SearchingDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 336);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBarOverallProcess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPassedHashingOp);
            this.Controls.Add(this.labelTotalHashingOp);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalHashingOp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelPassedHashingOp;
        private System.Windows.Forms.ProgressBar progressBarOverallProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonStop;
    }
}