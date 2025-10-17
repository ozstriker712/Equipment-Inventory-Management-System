using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity.Infrastructure;

namespace Inventaire_APC
{
    public partial class show_invt_bereau : DevExpress.XtraEditors.XtraForm
    {
        public show_invt_bereau(bureauxSet selct_bureau, inventaire_apcEntities dbcontex)//
        {
            InitializeComponent();
            this.dbcontex = dbcontex;
            this.selct_burreau = selct_bureau;
            invt_bureau = new inventaires_bureauSet();

            inventairesbureauSetBindingSource.ResetBindings(true);
            bureauxSetBindingSource.DataSource = selct_burreau;
            inventairesbureauSetBindingSource.DataSource = invt_bureau;
            //dbcontex = new inventaire_apcEntities();
            //invt_bureau = new inventaires_bureauSet();

            inventairesbureauSetBindingSource.DataSource = selct_burreau.inventaires_bureauSet.ToList();


            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

        }
        inventaire_apcEntities dbcontex;
        inventaires_bureauSet invt_bureau;
        bureauxSet selct_burreau;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int check_type;

        public void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.StartsWith("مصلحة") || textEdit1.Text.StartsWith("المصلحة"))

            {
                check_type=1;
            }
            else
                if (textEdit1.Text.StartsWith ("فرع") || textEdit1.Text.StartsWith ("الفرع") )
                {
                    check_type = 2;
                }
                else
                {
                    check_type = 3;
                }


            var dt = selct_burreau;

            XtraReport1 frm_print_inv_bur = new XtraReport1(check_type,dt);

            //frm_print_inv_bur.DataSource = selct_burreau.inventaires_bureauSet.ToList();

            ReportPrintTool printTool = new ReportPrintTool(frm_print_inv_bur);
            printTool.ShowPreviewDialog();
        }

       
        
         
    }
}