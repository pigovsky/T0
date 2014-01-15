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
        Timer tmr = new Timer();

        private MainForm mainForm;
        private System.Threading.Thread th;

        

        public SearchingDuplicates(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
                        
            if (mainForm.hashingAndByteByByteComparer!=null)
                labelTotalHashingOp.Text = mainForm.hashingAndByteByByteComparer.groupFilesByHash.totalNumberOfBytesToBeHashed.ToString();
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
                var gfbh = habbc.groupFilesByHash;

                if (gfbh.totalNumberOfBytesToBeHashed > 0)
                {
                    int progressValue = (int)
                        (gfbh.bytesHashed * 100 /
                        gfbh.totalNumberOfBytesToBeHashed);
                    if (0<=progressValue && progressValue<=100)
                        progressBarHashing.Value = progressValue;
                }
                labelPassedHashingOp.Text = habbc.hashGroupIndex.ToString();
            }
        }
    }
}
