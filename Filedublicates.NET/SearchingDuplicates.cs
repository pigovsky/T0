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

        long totalCmpOps;

        public SearchingDuplicates()
        {
            InitializeComponent();

            totalCmpOps = ByteByByteFileComparer.totalNumberOfCmpOps();

            labelTotalCmpOpNumber.Text = totalCmpOps.ToString();
            tmr.Tick += tmr_Tick;
            tmr.Interval = 1000;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            labelCmpOpPassed.Text = ByteByByteFileComparer.numberOfCmpOpPassed.
                ToString();
            progressBarByteByByteComparsion.Value =(int)
                (ByteByByteFileComparer.numberOfCmpOpPassed * 100 / totalCmpOps);

            if (progressBarByteByByteComparsion.Value >= 100)
                Hide();
        }
    }
}
