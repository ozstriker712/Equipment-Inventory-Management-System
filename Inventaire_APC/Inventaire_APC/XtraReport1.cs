using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Inventaire_APC
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(int value, object datasource)
        {
            InitializeComponent();

            bindingSource1.DataSource = datasource;
            //: المصلحة 
            //: الفرع 
            this.val=value;
            //PrintingSystem.ShowMarginsWarning = false;

        }

        int val;

        private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            if (val==1)
            {
                xrLabel5.Text = ": المصلحة";
                xrLabel22.Text = "رئيس ";

            }
            else
            {
                if (val==2)
                {
                    xrLabel5.Text = ": الفرع";
                    xrLabel22.Text = "رئيس";

                }
                else
                {
                    xrLabel5.Text = "";
                    xrLabel22.Text = "";

                }
            }
           

            
        }

    }
}
