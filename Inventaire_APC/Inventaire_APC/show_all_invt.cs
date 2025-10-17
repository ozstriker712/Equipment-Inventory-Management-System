using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;

namespace Inventaire_APC
{
    public partial class show_all_invt : DevExpress.XtraEditors.XtraForm
    {
        public show_all_invt()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            dbcontex = new inventaire_apcEntities();
            list_equip = new liste_equipementSet();

            listeequipementSetBindingSource.DataSource = dbcontex.liste_equipementSet.Where(r => r.quantite != 0).Where(r => r.quantite != null).ToList();

 
             
        }

        inventaire_apcEntities dbcontex;
        liste_equipementSet list_equip;

     

        
        
    }
}