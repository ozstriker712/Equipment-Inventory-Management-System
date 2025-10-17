namespace Inventaire_APC
{
    partial class show_all_invt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_all_invt));
            this.inventairesbureauSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listeequipementSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_equipement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_equipement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantite = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventairesbureauSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeequipementSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventairesbureauSetBindingSource
            // 
            this.inventairesbureauSetBindingSource.DataSource = typeof(Inventaire_APC.inventaires_bureauSet);
            // 
            // listeequipementSetBindingSource
            // 
            this.listeequipementSetBindingSource.DataSource = typeof(Inventaire_APC.liste_equipementSet);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(505, 99);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(148, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(345, 18);
            this.labelControl1.TabIndex = 96;
            this.labelControl1.Text = "  الجـــــــــرد العـــــــــــام لممتلكات البلدية المجرودة";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(29, 11);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(75, 82);
            this.pictureEdit1.TabIndex = 95;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.listeequipementSetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 486);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_equipement,
            this.colnom_equipement,
            this.colquantite});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colid_equipement
            // 
            this.colid_equipement.Caption = "كود العتاد";
            this.colid_equipement.FieldName = "id_equipement";
            this.colid_equipement.Name = "colid_equipement";
            this.colid_equipement.Visible = true;
            this.colid_equipement.VisibleIndex = 2;
            this.colid_equipement.Width = 69;
            // 
            // colnom_equipement
            // 
            this.colnom_equipement.Caption = "التعييـــــــــــــــن";
            this.colnom_equipement.FieldName = "nom_equipement";
            this.colnom_equipement.Name = "colnom_equipement";
            this.colnom_equipement.Visible = true;
            this.colnom_equipement.VisibleIndex = 1;
            this.colnom_equipement.Width = 298;
            // 
            // colquantite
            // 
            this.colquantite.Caption = "المحموع الكلي";
            this.colquantite.FieldName = "quantite";
            this.colquantite.Name = "colquantite";
            this.colquantite.Visible = true;
            this.colquantite.VisibleIndex = 0;
            this.colquantite.Width = 120;
            // 
            // show_all_invt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 585);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "show_all_invt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " الجـــــــــرد العـــــــــــام للممتلكات";
            ((System.ComponentModel.ISupportInitialize)(this.inventairesbureauSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listeequipementSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource inventairesbureauSetBindingSource;
        private System.Windows.Forms.BindingSource listeequipementSetBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid_equipement;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_equipement;
        private DevExpress.XtraGrid.Columns.GridColumn colquantite;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}