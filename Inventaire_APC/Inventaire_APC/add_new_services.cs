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

namespace Inventaire_APC
{
    public partial class add_new_services : DevExpress.XtraEditors.XtraForm
    {
        inventaire_apcEntities dbcontex;
        services_antennesSet serv_antenn;

        public add_new_services()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new inventaire_apcEntities();
            serv_antenn = new services_antennesSet();
            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();

            simpleButton2.Enabled = false;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                servicesantennesSetBindingSource.EndEdit();
                services_antennesSet delt_serv = (services_antennesSet)servicesantennesSetBindingSource.Current;
                dbcontex.services_antennesSet.Remove(delt_serv);

                dbcontex.SaveChanges();
                servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();
            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            servicesantennesSetBindingSource.DataSource = serv_antenn;

            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            servicesantennesSetBindingSource.EndEdit();
            dbcontex.services_antennesSet.Add((services_antennesSet)servicesantennesSetBindingSource.Current);
            dbcontex.SaveChanges();
            serv_antenn = new services_antennesSet();
            servicesantennesSetBindingSource.DataSource = serv_antenn;
            servicesantennesSetBindingSource.DataSource = dbcontex.services_antennesSet.ToList();

            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;
        }

        private void textEdit1_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        private void textEdit2_Enter(object sender, EventArgs e)
        {
            Application.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ar-DZ"));
        }

        
    }
}