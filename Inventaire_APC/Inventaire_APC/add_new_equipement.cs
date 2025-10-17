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
    public partial class add_new_equipement : DevExpress.XtraEditors.XtraForm
    {
        inventaire_apcEntities dbcontex;
        liste_equipementSet list_equip;
        public add_new_equipement()
        {
            InitializeComponent();
            dbcontex = new inventaire_apcEntities();
            list_equip = new liste_equipementSet();
            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            simpleButton2.Enabled = false;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listeequipementSetBindingSource.DataSource = list_equip;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listeequipementSetBindingSource.EndEdit();
            dbcontex.liste_equipementSet.Add((liste_equipementSet)listeequipementSetBindingSource.Current);
            dbcontex.SaveChanges();

            list_equip = new liste_equipementSet();
            listeequipementSetBindingSource.DataSource = list_equip;

            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();

            simpleButton1.Enabled = true;
            simpleButton2.Enabled = false;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();
            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف  من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                listeequipementSetBindingSource.EndEdit();
                liste_equipementSet delt_lits = (liste_equipementSet)listeequipementSetBindingSource.Current;
                dbcontex.liste_equipementSet.Remove(delt_lits);
         
                dbcontex.SaveChanges();
                listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.ToList();
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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