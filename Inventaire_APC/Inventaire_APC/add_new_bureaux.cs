using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Globalization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace Inventaire_APC
{
    public partial class add_new_bureaux : DevExpress.XtraEditors.XtraForm
    {
        inventaire_apcEntities dbcontex;
        services_antennesSet serv_antenn;
        bureauxSet bureau;
        public add_new_bureaux()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new inventaire_apcEntities();
            serv_antenn = new services_antennesSet();
            bureau = new bureauxSet();
            bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.ToList();
            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();

            simpleButton2.Enabled = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bureauxSetBindingSource.DataSource = bureau;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bureauxSetBindingSource.EndEdit();
            bureau.etat_bureau = 0;
            dbcontex.bureauxSet.Add((bureauxSet)bureauxSetBindingSource.Current);
            dbcontex.SaveChanges();
            bureau = new bureauxSet();
            bureauxSetBindingSource.DataSource = bureau;

            bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.ToList();

            simpleButton1.Enabled = true;
            simpleButton2.Enabled = false;
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void textEdit2_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();
            bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.ToList();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                bureauxSetBindingSource.EndEdit();
                bureauxSet delt_bureau = (bureauxSet)bureauxSetBindingSource.Current;
                dbcontex.bureauxSet.Remove(delt_bureau);

                dbcontex.SaveChanges();
                bureauxSetBindingSource.DataSource = dbcontex.bureauxSet.ToList();
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                regroupe_parts();
            }
            else
            {

                GridView gridView1 = gridControl1.FocusedView as GridView;
               
                gridView1.ClearGrouping();
 
            }
        }

        public void regroupe_parts()
        {
            GridView gridView1 = gridControl1.FocusedView as GridView;
        


            GridColumnSortInfo[] sortinfo1 = { new GridColumnSortInfo(gridView1.Columns["services_antennesSet.nom_service"], DevExpress.Data.ColumnSortOrder.Ascending) };
            gridView1.SortInfo.ClearAndAddRange(sortinfo1, 2);
 

         
        }
    }
}