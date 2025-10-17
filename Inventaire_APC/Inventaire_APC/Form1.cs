using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventaire_APC
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1(string user_name)
        {
            InitializeComponent();
            dbcontex = new inventaire_apcEntities();
            serv_antenn = new services_antennesSet();
            bureau = new bureauxSet();
            invt_bureau = new inventaires_bureauSet();
            lits_equip = new liste_equipementSet();
            textEdit1.Text = user_name.ToString();


            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();
            bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.ToList();
            bureauxSetBindingSource1.DataSource = dbcontex.bureauxSet.ToList();

            inventairesbureauSetBindingSource.DataSource = dbcontex.inventaires_bureauSet.ToList();

            compteur();
            refrech_db();
        }

        inventaire_apcEntities dbcontex;
        services_antennesSet serv_antenn, selctd_service;
        bureauxSet bureau, selctd_bureau;
        inventaires_bureauSet invt_bureau;
        liste_equipementSet lits_equip;

        services_antennesSet service_selcted;


        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_equipement frm_add_new_equip = new add_new_equipement();
            frm_add_new_equip.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_services frm_add_new_ser = new add_new_services();
            frm_add_new_ser.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            add_new_bureaux frm_add_new_bureau = new add_new_bureaux();
            frm_add_new_bureau.Show();
        }

        int flag_button;
         
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag_button = 1;
            choix_bureau frm_choix_burea = new choix_bureau(flag_button);
            frm_choix_burea.Show();
            
           
        }


        public void RefreshAll()
        {
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshAll();
            refrech_db();
            compteur();
            //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns["etat_bureau"], 1);
              
        }


         

        void compteur()
        {

            var count_bureau_invt = dbcontex.bureauxSet.Where(a => a.etat_bureau == 1).Count() ;
             
            textEdit2.Text = count_bureau_invt.ToString();
             
        }

        void refrech_db()
        {
          
            bureauxSetBindingSource.ResetBindings(true);
            bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.Where(r => r.etat_bureau == 1).ToList();
            bureauxSetBindingSource1.DataSource = dbcontex.bureauxSet.Where(r => r.etat_bureau == 0).ToList();
            inventairesbureauSetBindingSource.ResetBindings(true);
            inventairesbureauSetBindingSource.DataSource = dbcontex.inventaires_bureauSet.ToList();

             
             
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                bureauxSetBindingSource.EndEdit();
                bureauxSet delt_bureau = (bureauxSet)bureauxSetBindingSource.Current;
                dbcontex.bureauxSet.Remove(delt_bureau);
 
                dbcontex.SaveChanges();
               
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            refrech_db();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            flag_button = 2;
            choix_bureau frm_choix_burea = new choix_bureau(flag_button);
            frm_choix_burea.Show();
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            GridView view = (GridView)sender;


            selctd_bureau = (bureauxSet)bureauxSetBindingSource.Current;

            
        }

      
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            about frm_about = new about();
            frm_about.Show();
        }
        
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dashboard frm_dashboard = new dashboard();
            
            frm_dashboard.Show();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            users_frm frm_users = new users_frm();
            frm_users.xtraTabPage2.PageEnabled = false;
            frm_users.gridView1.OptionsBehavior.ReadOnly = true;

            frm_users.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            users_frm frm_users = new users_frm();
            frm_users.xtraTabPage1.PageEnabled = false;
            frm_users.gridView1.OptionsBehavior.ReadOnly = false;

            frm_users.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            RefreshAll();


            if (selctd_bureau!=null)
            {
                show_invt_bereau frm_show_invt = new show_invt_bereau(selctd_bureau, dbcontex);  //
                frm_show_invt.Show();

                RefreshAll();
            }
            else
            {
                MessageBox.Show(" يرجــــــــى اختيـــــــــــار المكتب أولا من القائمة ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (barCheckItem1.Checked == true)
            {
                regroupe_parts();
            }
            else
            {

                GridView gridView1 = gridControl1.FocusedView as GridView;
                GridView gridView2 = gridControl2.FocusedView as GridView;

                gridView1.ClearGrouping();

                gridView2.ClearGrouping();
            }
        }

        public void regroupe_parts()
        {
            GridView gridView1 = gridControl1.FocusedView as GridView;
            GridView gridView2 = gridControl2.FocusedView as GridView;


            GridColumnSortInfo[] sortinfo1 = { new GridColumnSortInfo(gridView1.Columns["services_antennesSet.nom_service"], DevExpress.Data.ColumnSortOrder.Ascending) };
            gridView1.SortInfo.ClearAndAddRange(sortinfo1, 2);

            GridColumnSortInfo[] sortinfo2 = { new GridColumnSortInfo(gridView2.Columns["services_antennesSet.nom_service"], DevExpress.Data.ColumnSortOrder.Ascending) };
            gridView2.SortInfo.ClearAndAddRange(sortinfo2, 2);

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport5 frm_print_inv_bur = new XtraReport5();
            //print_invt_bureau frm_print_inv_bur = new print_invt_bureau();

            frm_print_inv_bur.DataSource = dbcontex.liste_equipementSet.Where(r => r.quantite != 0).Where(r => r.quantite != null).ToList();


            ReportPrintTool printTool = new ReportPrintTool(frm_print_inv_bur);
            printTool.ShowPreviewDialog();
        }

        private void barCheckItem2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsSelection.MultiSelect = barCheckItem2.Checked;

        }

             

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            //GridView view = (GridView)sender;
             

            List<int> id_bureau = new List<int>(); ;
            foreach (int selectedRow in gridView1.GetSelectedRows().ToList())
            {
                id_bureau.Add((int)gridView1.GetRowCellValue(selectedRow, colid_bureau));
            }

            var dt = (from GetBureaus in dbcontex.bureauxSet where id_bureau.Contains(GetBureaus.id_bureau) select GetBureaus).ToList();
            XtraReport3 frm_print_inv_bur = new XtraReport3(dt);


            ReportPrintTool printTool = new ReportPrintTool(frm_print_inv_bur);
            printTool.ShowPreviewDialog();

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            show_all_invt frm = new show_all_invt();
            frm.Show();
        }
       
    }
}
