using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filedublicates.NET
{
    public partial class SearchingDuplicates : Form
    {
        Timer tmr = new Timer();

        private Form1 mainForm;

        long totalCmpOps;

        public SearchingDuplicates(Form1 mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            totalCmpOps = mainForm.byteByByteFileComparer.totalNumberOfCmpOps;

            labelTotalCmpOpNumber.Text = totalCmpOps.ToString();
            if (mainForm.hashingAndByteByByteComparer!=null)
                labelTotalHashingOp.Text = mainForm.hashingAndByteByByteComparer.groupFilesByHash.totalNumberOfBytesToBeHashed.ToString();
            tmr.Tick += tmr_Tick;
            tmr.Interval = 1000;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            if (mainForm.byteByByteFileComparer != null)
            {
                labelCmpOpPassed.Text = mainForm.byteByByteFileComparer.numberOfCmpOpPassed.
                    ToString();
                progressBarByteByByteComparsion.Value = (int)
                    (mainForm.byteByByteFileComparer.numberOfCmpOpPassed * 100 / totalCmpOps);

                if (progressBarByteByByteComparsion.Value >= 100 && mainForm.hashingAndByteByByteComparer == null)
                    Hide();
            }

            if (mainForm.hashingAndByteByByteComparer != null)
            {
                var habbc = mainForm.hashingAndByteByByteComparer;
                var gfbh = habbc.groupFilesByHash;
                progressBarHashing.Value = (int)
                    (gfbh.bytesHashed * 100 /
                    gfbh.totalNumberOfBytesToBeHashed);
                labelPassedHashingOp.Text = habbc.hashGroupIndex.ToString();
            }
        }
    }
}
