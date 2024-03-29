﻿namespace Filedublicates.NET
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
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelNumberOfFilesToBeHashed = new System.Windows.Forms.Label();
            this.labelNumberOfHashedFiles = new System.Windows.Forms.Label();
            this.labelCurrentFileBeingHeshed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarByteByByteComparsion
            // 
            this.progressBarByteByByteComparsion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarByteByByteComparsion.Location = new System.Drawing.Point(16, 38);
            this.progressBarByteByByteComparsion.Name = "progressBarByteByByteComparsion";
            this.progressBarByteByByteComparsion.Size = new System.Drawing.Size(609, 23);
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
            this.label2.Location = new System.Drawing.Point(13, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hashing";
            // 
            // progressBarHashing
            // 
            this.progressBarHashing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarHashing.Location = new System.Drawing.Point(13, 253);
            this.progressBarHashing.Name = "progressBarHashing";
            this.progressBarHashing.Size = new System.Drawing.Size(609, 23);
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
            this.label6.Location = new System.Drawing.Point(12, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time passed";
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.Location = new System.Drawing.Point(86, 392);
            this.labelTimePassed.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(100, 13);
            this.labelTimePassed.TabIndex = 11;
            this.labelTimePassed.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total number of hashin groups";
            // 
            // labelTotalHashingOp
            // 
            this.labelTotalHashingOp.AutoSize = true;
            this.labelTotalHashingOp.Location = new System.Drawing.Point(204, 152);
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
            this.label8.Location = new System.Drawing.Point(13, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of processed hash groups";
            // 
            // labelPassedHashingOp
            // 
            this.labelPassedHashingOp.AutoSize = true;
            this.labelPassedHashingOp.Location = new System.Drawing.Point(204, 179);
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
            this.progressBarOverallProcess.Location = new System.Drawing.Point(12, 355);
            this.progressBarOverallProcess.Name = "progressBarOverallProcess";
            this.progressBarOverallProcess.Size = new System.Drawing.Size(609, 23);
            this.progressBarOverallProcess.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Overall process";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(415, 392);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 17;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Number of files to be hashed";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Number of hashed files";
            // 
            // labelNumberOfFilesToBeHashed
            // 
            this.labelNumberOfFilesToBeHashed.AutoSize = true;
            this.labelNumberOfFilesToBeHashed.Location = new System.Drawing.Point(201, 288);
            this.labelNumberOfFilesToBeHashed.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelNumberOfFilesToBeHashed.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelNumberOfFilesToBeHashed.Name = "labelNumberOfFilesToBeHashed";
            this.labelNumberOfFilesToBeHashed.Size = new System.Drawing.Size(100, 13);
            this.labelNumberOfFilesToBeHashed.TabIndex = 20;
            this.labelNumberOfFilesToBeHashed.Text = "0";
            // 
            // labelNumberOfHashedFiles
            // 
            this.labelNumberOfHashedFiles.AutoSize = true;
            this.labelNumberOfHashedFiles.Location = new System.Drawing.Point(201, 312);
            this.labelNumberOfHashedFiles.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelNumberOfHashedFiles.MinimumSize = new System.Drawing.Size(100, 0);
            this.labelNumberOfHashedFiles.Name = "labelNumberOfHashedFiles";
            this.labelNumberOfHashedFiles.Size = new System.Drawing.Size(100, 13);
            this.labelNumberOfHashedFiles.TabIndex = 21;
            this.labelNumberOfHashedFiles.Text = "0";
            // 
            // labelCurrentFileBeingHeshed
            // 
            this.labelCurrentFileBeingHeshed.AutoSize = true;
            this.labelCurrentFileBeingHeshed.Location = new System.Drawing.Point(65, 237);
            this.labelCurrentFileBeingHeshed.Name = "labelCurrentFileBeingHeshed";
            this.labelCurrentFileBeingHeshed.Size = new System.Drawing.Size(46, 13);
            this.labelCurrentFileBeingHeshed.TabIndex = 22;
            this.labelCurrentFileBeingHeshed.Text = "Hashing";
            // 
            // SearchingDuplicates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 420);
            this.Controls.Add(this.labelCurrentFileBeingHeshed);
            this.Controls.Add(this.labelNumberOfHashedFiles);
            this.Controls.Add(this.labelNumberOfFilesToBeHashed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelNumberOfFilesToBeHashed;
        private System.Windows.Forms.Label labelNumberOfHashedFiles;
        private System.Windows.Forms.Label labelCurrentFileBeingHeshed;
    }
}