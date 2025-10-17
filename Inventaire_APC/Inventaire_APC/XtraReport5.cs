using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Threading;
using System.Globalization;

namespace Inventaire_APC
{
    public partial class XtraReport5 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport5()
        {
            InitializeComponent();
 
            xrLabel8.Text = DateTime.Now.Year.ToString();

            PrintingSystem.ShowMarginsWarning = false;
        }

    }
}
