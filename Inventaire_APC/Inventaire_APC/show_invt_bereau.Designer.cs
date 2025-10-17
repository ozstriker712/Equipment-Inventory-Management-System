namespace Inventaire_APC
{
    partial class show_invt_bereau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(show_invt_bereau));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.inventairesbureauSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnom_inventaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre_inventaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrefrence_inventaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colremarque_inventaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bureauxSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventairesbureauSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bureauxSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.inventairesbureauSetBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(701, 327);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // inventairesbureauSetBindingSource
            // 
            this.inventairesbureauSetBindingSource.DataSource = typeof(Inventaire_APC.inventaires_bureauSet);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnom_inventaire,
            this.colnombre_inventaire,
            this.colrefrence_inventaire,
            this.colremarque_inventaire});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colnom_inventaire
            // 
            this.colnom_inventaire.Caption = "التعيين";
            this.colnom_inventaire.FieldName = "nom_inventaire";
            this.colnom_inventaire.Name = "colnom_inventaire";
            this.colnom_inventaire.Visible = true;
            this.colnom_inventaire.VisibleIndex = 0;
            this.colnom_inventaire.Width = 209;
            // 
            // colnombre_inventaire
            // 
            this.colnombre_inventaire.Caption = "العدد";
            this.colnombre_inventaire.FieldName = "nombre_inventaire";
            this.colnombre_inventaire.Name = "colnombre_inventaire";
            this.colnombre_inventaire.Visible = true;
            this.colnombre_inventaire.VisibleIndex = 1;
            this.colnombre_inventaire.Width = 50;
            // 
            // colrefrence_inventaire
            // 
            this.colrefrence_inventaire.Caption = "رقم الجرد";
            this.colrefrence_inventaire.FieldName = "refrence_inventaire";
            this.colrefrence_inventaire.Name = "colrefrence_inventaire";
            this.colrefrence_inventaire.Visible = true;
            this.colrefrence_inventaire.VisibleIndex = 2;
            this.colrefrence_inventaire.Width = 266;
            // 
            // colremarque_inventaire
            // 
            this.colremarque_inventaire.Caption = "الملاحظة";
            this.colremarque_inventaire.FieldName = "remarque_inventaire";
            this.colremarque_inventaire.Name = "colremarque_inventaire";
            this.colremarque_inventaire.Visible = true;
            this.colremarque_inventaire.VisibleIndex = 3;
            this.colremarque_inventaire.Width = 158;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(281, 429);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 43);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "طبـــــــــــاعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.textEdit1);
            this.groupBox1.Controls.Add(this.textEdit2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(92, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "اسم المكتـــــب  :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(66, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "اسم المصلحة او الفرع :";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bureauxSetBindingSource, "services_antennesSet.nom_service", true));
            this.textEdit1.Location = new System.Drawing.Point(204, 17);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(336, 22);
            this.textEdit1.TabIndex = 14;
            this.textEdit1.TabStop = false;
            // 
            // bureauxSetBindingSource
            // 
            this.bureauxSetBindingSource.DataSource = typeof(Inventaire_APC.bureauxSet);
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bureauxSetBindingSource, "nom_bureau", true));
            this.textEdit2.Location = new System.Drawing.Point(204, 48);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(336, 22);
            this.textEdit2.TabIndex = 15;
            this.textEdit2.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(638, 440);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 28);
            this.simpleButton2.TabIndex = 20;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(638, 10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(61, 70);
            this.pictureEdit1.TabIndex = 95;
            // 
            // show_invt_bereau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 484);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "show_invt_bereau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عـــــــــــــــــرض عتـــــاد مكتــــــب";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventairesbureauSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bureauxSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource inventairesbureauSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_inventaire;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre_inventaire;
        private DevExpress.XtraGrid.Columns.GridColumn colrefrence_inventaire;
        private DevExpress.XtraGrid.Columns.GridColumn colremarque_inventaire;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        public DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource bureauxSetBindingSource;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}