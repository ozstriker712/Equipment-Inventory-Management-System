using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter;
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace Inventaire_APC
{
    public partial class new_invt_bureau : DevExpress.XtraEditors.XtraForm
    {
        public new_invt_bureau(services_antennesSet servicé, bureauxSet burééau, inventaire_apcEntities dbcontex)
        {
            InitializeComponent();
           
            this.dbcontex = dbcontex;
            this.serv_antenn = servicé;
            this.bureau = burééau;
            invt_bureau = new inventaires_bureauSet();
            lits_equip = new liste_equipementSet();

             numero_inv_val = 0;

            servicesantennesSetBindingSource.DataSource = serv_antenn;
            bureauxSetBindingSource.DataSource = bureau;
            inventairesbureauSetBindingSource.DataSource = invt_bureau;

            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();
            inventairesbureauSetBindingSource1.DataSource = bureau.inventaires_bureauSet.ToList() ;   // 2eme table  affichage
             

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

        }

        inventaire_apcEntities dbcontex;
        services_antennesSet serv_antenn;
        bureauxSet bureau;
        inventaires_bureauSet invt_bureau;
        liste_equipementSet lits_equip;

        int numero_inv_val;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
 
        }

        
        private void simpleButton2_Click(object sender, EventArgs e)
        {

                try
                {
                    inventairesbureauSetBindingSource.EndEdit();
                    listeequipementSetBindingSource.EndEdit();
                    invt_bureau.bureaux_id_bureau = bureau.id_bureau;
                     invt_bureau.numero_inventaire = bureau.inventaires_bureauSet.Count()+1;
                    
 
                    if (invt_bureau.nombre_inventaire !=0)
                    {
                        bureau.inventaires_bureauSet.Add(invt_bureau);
                        invt_bureau.code_equippent_insert = code_equip;
                        //lits_equip.quantite = lits_equip.quantite + invt_bureau.nombre_inventaire;

                        //((liste_equipementSet)listeequipementSetBindingSource.Current).quantite = lits_equip.quantite + invt_bureau.nombre_inventaire;
                        
                        
                         //dbcontex.liste_equipementSet.Add(new liste_equipementSet { quantite = lits_equip.quantite + invt_bureau.nombre_inventaire });
                         

                         dbcontex.SaveChanges();
                        invt_bureau = new inventaires_bureauSet();
                        inventairesbureauSetBindingSource.DataSource = invt_bureau;

                        inventairesbureauSetBindingSource1.DataSource = bureau.inventaires_bureauSet.ToList();   // 2eme table  affichage

                        AlertInfo info = new AlertInfo("", "لقد تم اضافة الجرد الى قاعدة البيانات");
                        alertControl1.Show(this, info);

                    }
                    else
                    {
                        MessageBox.Show(" يرجى التــــــــأكد من عـدد العتــــاد = 0  !!", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                   

                }
                catch
                {
                    MessageBox.Show("يوجد حقـــــــل فـــــــــارغ يرجى التــــــــأكد !!", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

 

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            

        }

         

        public void LoadDataSource(inventaires_bureauSet invt_bureau)
        {
            inventairesbureauSetBindingSource.DataSource = invt_bureau;

            invt_bureau = new inventaires_bureauSet();

            inventairesbureauSetBindingSource.DataSource = invt_bureau;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           
           

        }

        private void textEdit4_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit4_Leave(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit6_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit6_Leave(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit7_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit7_Leave(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (aa!= 0)
            {
                textBox1.Clear();
                textBox1.Text = aa.ToString();
            }
            

             inventairesbureauSetBindingSource.EndEdit();
             inventairesbureauSetBindingSource1.EndEdit();

           
                 
                dbcontex.SaveChanges();

            AlertInfo info;
            info = new AlertInfo("", "لقد تم تعـــديل معلومات الجرد");
            alertControl1.Show(this, info);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                inventairesbureauSetBindingSource1.EndEdit();
                inventaires_bureauSet delt_invt_bureau = (inventaires_bureauSet)inventairesbureauSetBindingSource1.Current;
                dbcontex.inventaires_bureauSet.Remove(delt_invt_bureau);
                dbcontex.SaveChanges();
                inventairesbureauSetBindingSource1.DataSource = bureau.inventaires_bureauSet.ToList();   // 2eme table  affichage
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }


        }

        private void gridView2_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.Caption == "numero_inventaire")
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                xtraTabPage1.PageEnabled = true;
            }
            else
            {
                xtraTabPage1.PageEnabled = false;
            }
        }

        int code_equip, code_equip2;
        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

            inventairesbureauSetBindingSource1.EndEdit();
            inventairesbureauSetBindingSource.EndEdit();
            if (textEdit4.Properties.View.GetFocusedRowCellValue("id_equipement") != null)
                {
                    code_equip = (int)textEdit4.Properties.View.GetFocusedRowCellValue("id_equipement");

                }
          
        }


        int aa ;
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            inventairesbureauSetBindingSource1.EndEdit();
            SearchLookUpEdit searchLookUpEdit = sender as SearchLookUpEdit;

           
            if (searchLookUpEdit.Properties.View.GetFocusedRowCellValue("id_equipement") != null)
            {
                 aa = (int)searchLookUpEdit.Properties.View.GetFocusedRowCellValue ( "id_equipement") ;

                  
            }
        }

        private void searchLookUpEdit1_QueryCloseUp(object sender, CancelEventArgs e)
        {
            
        }

        int check_type;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            
       
        }

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            if (textEdit1.Text.StartsWith("مصلحة") || textEdit1.Text.StartsWith("المصلحة"))
            {
                check_type = 1;
            }
            else
                if (textEdit1.Text.StartsWith("فرع") || textEdit1.Text.StartsWith("الفرع"))
                {
                    check_type = 2;
                }
                else
                {
                    check_type = 3;
                }

            //print_invt_bureau frm_print_inv_bur = new print_invt_bureau();
            var dt = bureau;

            XtraReport1 frm_print_inv_bur = new XtraReport1(check_type, dt);

            //frm_print_inv_bur.DataSource = bureau.inventaires_bureauSet.ToList();


            ReportPrintTool printTool = new ReportPrintTool(frm_print_inv_bur);
            printTool.ShowPreviewDialog();
          
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد انهـــــــــاء  عملية جرد عتاد هذا المكتب ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                bureau.etat_bureau = 1;
                dbcontex.SaveChanges();

                AlertInfo info;
                info = new AlertInfo("", "لقد تم انهـــــاء  عملية جرد عتاد هذا المكتب");
                this.Close();
            } 

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            listeequipementSetBindingSource.Clear();


            RefreshAll();

            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();

        }

        public void RefreshAll()
        {
            foreach (var entity in dbcontex.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }
      
       
    }
}