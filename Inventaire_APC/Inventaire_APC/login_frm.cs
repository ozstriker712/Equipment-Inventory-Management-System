using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using System.Data;
using System.Collections.Generic;
using System.Linq;


namespace Inventaire_APC
{
    public partial class login_frm : SplashScreen
    {
        public login_frm()
        {
            InitializeComponent();
            loginn = new login_tab();
            dbcontex = new inventaire_apcEntities();
            logintabBindingSource.DataSource=dbcontex.login_tabSet.ToList();

        }
        inventaire_apcEntities dbcontex;
        login_tab loginn;
        

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        
        }

        private void logintabBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        
        }

        private void login_frm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var loginn in dbcontex.login_tabSet)
            {
                if (loginn.user_names == comboBox1.Text && loginn.passwords == textBox1.Text)
                {
                    Form1 open_frm_main = new Form1(loginn.user_names);   //loginn.id_user, loginn.user_name
                    if (loginn.permissions == 1)
                    {
                        open_frm_main.Show();
                        this.Hide();
                        found = true;
                        break;
                    }
                    else
                    {
                        if (loginn.permissions == 2)
                        {

                            open_frm_main.Show();
                            //open_frm_main.barButtonItem1.Enabled = false; open_frm_main.barButtonItem2.Enabled = false;
                            open_frm_main.barButtonItem7.Enabled = false; open_frm_main.barButtonItem11.Enabled = false; open_frm_main.barButtonItem12.Enabled = false;
                            open_frm_main.barButtonItem1.Enabled = false; open_frm_main.barButtonItem2.Enabled = false; open_frm_main.barButtonItem3.Enabled = false;


                            this.Hide();
                            found = true;
                            break;
                        }
                        else
                        {
                            if (loginn.permissions == 3)
                            {
                                open_frm_main.Show();
                                open_frm_main.barButtonItem7.Enabled = false; open_frm_main.barButtonItem11.Enabled = false; open_frm_main.barButtonItem12.Enabled = false;
                                open_frm_main.barButtonItem4.Enabled = false; open_frm_main.barButtonItem5.Enabled = false; open_frm_main.barButtonItem10.Enabled = false;
                                open_frm_main.barButtonItem1.Enabled = false; open_frm_main.barButtonItem2.Enabled = false; open_frm_main.barButtonItem3.Enabled = false;


                                this.Hide();
                                found = true;
                                break;
                            }





                        }

                    }

                }


            }

            if (found == false)
            {
                MessageBox.Show("كلمة المــــــــرور خاطئــــة أو لا تتطابق مع اسم المستخدم", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }
    }
}