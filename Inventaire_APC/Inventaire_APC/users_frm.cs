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

namespace Inventaire_APC
{
    public partial class users_frm : DevExpress.XtraEditors.XtraForm
    {
        public users_frm()
        {
            InitializeComponent();
            dbcontex = new inventaire_apcEntities();
            loginn = new login_tab();
            logintabBindingSource.DataSource = dbcontex.login_tabSet.ToList();
            
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            simpleButton1.Enabled = false;
        }

        inventaire_apcEntities dbcontex;
        login_tab loginn;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            logintabBindingSource.DataSource = loginn;
            loginn = new login_tab();
            simpleButton2.Enabled = false;
            simpleButton1.Enabled = true;



        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            logintabBindingSource.EndEdit();
            dbcontex.login_tabSet.Add((login_tab)logintabBindingSource.Current);
            dbcontex.SaveChanges();

            logintabBindingSource.DataSource = dbcontex.login_tabSet.ToList();

            AlertInfo info = new AlertInfo("", "لقد تم العملية بنجاح ");
            alertControl1.Show(this, info);
            simpleButton2.Enabled = true;
            simpleButton1.Enabled = false;
             
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            dbcontex.SaveChanges();

            AlertInfo info = new AlertInfo("", "لقد تم التعديـــــل بنجاح ");
            alertControl1.Show(this, info);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show(" هل تريد حذف ملـــــــف من قاعدة البيانات ؟؟ ", " Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult.OK == reponse)
            {
                logintabBindingSource.EndEdit();
                login_tab delt_user = (login_tab)logintabBindingSource.Current;
                dbcontex.login_tabSet.Remove(delt_user);
                dbcontex.SaveChanges();
                logintabBindingSource.DataSource = dbcontex.login_tabSet.ToList();
                MessageBox.Show(" لقد تم حذف ملـــــــف من قاعدة البيانات ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}