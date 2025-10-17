using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventaire_APC
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport3(object datasource )
        {
            InitializeComponent();
            bindingSource1.DataSource = datasource;

            PrintingSystem.ShowMarginsWarning = false;
            
        }

        

        private void XtraReport3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        { 
           
        }

    }
}
