using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


using System.Windows.Forms;

namespace Filedublicates.NET
{
    

    public partial class SearchingDuplicates : Form
    {
        private Timer tmr = new Timer();

        private DateTime startTime;

        public bool stop { get; set; }

        public long totalNumberOfIterationsInOverallProcess { get; set; }
        public long numberOfIterationsInOverallProcessPassed { get; set; }
        public long bytesHashed { get; set; }
        public long totalNumberOfBytesToBeHashed { get; set; }

        public int numberOfFilesToBeHashed { get; set; }
        public int numberOfHashedFiles { get; set; }

        public long hashGroupIndex { get; set; }
        public long numberOfHashGroupIndexes { get; set; }

        public string currentFileBeingHeshed { get; set; }

        private MainForm mainForm;
        public System.Threading.Thread th { get; set; }

        

        public SearchingDuplicates(MainForm mainForm)
        {
            InitializeComponent();

            stop = false;
            startTime = DateTime.Now;

            this.mainForm = mainForm;
                        
                
            tmr.Tick += tmr_Tick;
            tmr.Interval = 1000;
            tmr.Start();
        }

        public SearchingDuplicates(MainForm mainForm, System.Threading.Thread th) : 
            this(mainForm)
        {            
            this.th = th;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (!th.IsAlive)
            {
                tmr.Stop();
                Hide();
                mainForm.updateUIafterSearching();
                return;
            }

            var timeSpan = DateTime.Now - startTime;
            labelTimePassed.Text = "" + Math.Floor(timeSpan.TotalHours) + ":" +
                timeSpan.Minutes + ":" + timeSpan.Seconds;

            if (totalNumberOfIterationsInOverallProcess > 0)
            {
                int progressValue = (int) (numberOfIterationsInOverallProcessPassed *100 /
                    totalNumberOfIterationsInOverallProcess);
                if (0 <= progressValue && progressValue <= 100)
                    progressBarOverallProcess.Value = progressValue;
            }

            if (mainForm.byteByByteFileComparer != null)
            {
                labelCmpOpPassed.Text = mainForm.byteByByteFileComparer.numberOfCmpOpPassed.
                    ToString();
                
                long totalCmpOps = mainForm.byteByByteFileComparer.totalNumberOfCmpOps;

                labelTotalCmpOpNumber.Text = totalCmpOps.ToString();
                if (totalCmpOps > 0)
                {
                    int progressValue = (int)
                    (mainForm.byteByByteFileComparer.numberOfCmpOpPassed * 100 / totalCmpOps);

                    if (0 <= progressValue && progressValue <= 100)
                        progressBarByteByByteComparsion.Value = progressValue;
                }
                
            }

            if (mainForm.hashingAndByteByByteComparer != null)
            {
                var habbc = mainForm.hashingAndByteByByteComparer;
                

                if (totalNumberOfBytesToBeHashed > 0)
                {
                    labelTotalHashingOp.Text = totalNumberOfBytesToBeHashed.ToString();
                    int progressValue = (int)
                        (bytesHashed * 100 /
                        totalNumberOfBytesToBeHashed);
                    if (0<=progressValue && progressValue<=100)
                        progressBarHashing.Value = progressValue;
                    labelNumberOfFilesToBeHashed.Text = numberOfFilesToBeHashed.ToString();
                    labelNumberOfHashedFiles.Text = numberOfHashedFiles.ToString();
                    labelCurrentFileBeingHeshed.Text = currentFileBeingHeshed;
                }
                labelTotalHashingOp.Text = numberOfHashGroupIndexes.ToString();
                labelPassedHashingOp.Text = hashGroupIndex.ToString();

                
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }
    }
}
