using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Inventaire_APC
{
    public partial class choix_bureau : DevExpress.XtraEditors.XtraForm
    {
        public choix_bureau(int flag)
        {
            InitializeComponent();
            dbcontex = new inventaire_apcEntities();
            serv_antenn = new services_antennesSet();
            bureau = new bureauxSet();

            this.flag_button = flag;
            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();

            
        }


        inventaire_apcEntities dbcontex;
        services_antennesSet serv_antenn, selctd_service;
        bureauxSet bureau, selctd_bureau;

        int id_bureau_selctd, id_service_selctd;

        int flag_button;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                id_service_selctd = (int)gridLookUpEdit1.Properties.View.GetFocusedRowCellValue("id_service");

                id_bureau_selctd = (int)gridLookUpEdit2.Properties.View.GetFocusedRowCellValue("id_bureau");


                if (flag_button ==1)
                {
                    new_invt_bureau frm_new_invt_bur = new new_invt_bureau(selctd_service, selctd_bureau, dbcontex);
                    frm_new_invt_bur.xtraTabPage2.PageEnabled = false;
                    frm_new_invt_bur.gridView2.OptionsBehavior.ReadOnly = true;

                    frm_new_invt_bur.Show();
                    this.Close();
                }
                else
                {
                    if (flag_button==2)
                    {
                        new_invt_bureau frm_new_invt_bur = new new_invt_bureau(selctd_service, selctd_bureau, dbcontex);
                        frm_new_invt_bur.xtraTabPage1.PageEnabled = false;
                        frm_new_invt_bur.gridView2.OptionsBehavior.ReadOnly = false;

                        frm_new_invt_bur.Show();
                        this.Close();
                    }
                }
                


                

            }
            catch  
            {
             MessageBox.Show(" قم بتحديد المصلحة أو الفرع و المكتب المراد جرده", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

              
            }
           
         
             
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (flag_button==1)
            {
                bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.Where(r => r.services_antennes_id_service == (int)gridLookUpEdit1.EditValue).Where(r => r.etat_bureau == 0).ToList();

            }
            else
            {
                if (flag_button==2)
                {
                   bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.Where(r => r.services_antennes_id_service == (int)gridLookUpEdit1.EditValue).Where(r => r.etat_bureau == 1).ToList();

                }
            }


            GridLookUpEdit lookup = sender as GridLookUpEdit;
            BindingManagerBase bm = BindingContext[lookup.Properties.DataSource];
            bm.Position = lookup.Properties.View.GetDataSourceRowIndex(lookup.Properties.GetIndexByKeyValue(lookup.EditValue));
            
            selctd_service = (services_antennesSet)servicesantennesSetBindingSource.Current;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lookup = sender as GridLookUpEdit;
            BindingManagerBase bm = BindingContext[lookup.Properties.DataSource];
            bm.Position = lookup.Properties.View.GetDataSourceRowIndex(lookup.Properties.GetIndexByKeyValue(lookup.EditValue));
            selctd_bureau = (bureauxSet)bureauxSetBindingSource.Current;
        }

        private void gridLookUpEdit1_Click(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        }

        private void gridLookUpEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void gridLookUpEdit1_Validated(object sender, EventArgs e)
        {

        }
 
        
    }
}