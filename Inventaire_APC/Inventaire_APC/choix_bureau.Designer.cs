namespace Inventaire_APC
{
    partial class choix_bureau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(choix_bureau));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.servicesantennesSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_service = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.bureauxSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_bureau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_bureau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesantennesSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bureauxSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.gridLookUpEdit1);
            this.groupControl1.Controls.Add(this.gridLookUpEdit2);
            this.groupControl1.Location = new System.Drawing.Point(3, 17);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(581, 100);
            this.groupControl1.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(414, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "المكتـــــب  ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(93, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "المصلحة او الفرع ";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.EditValue = "Services / Antennes";
            this.gridLookUpEdit1.Location = new System.Drawing.Point(19, 60);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.DataSource = this.servicesantennesSetBindingSource;
            this.gridLookUpEdit1.Properties.DisplayMember = "nom_service";
            this.gridLookUpEdit1.Properties.ValueMember = "id_service";
            this.gridLookUpEdit1.Properties.View = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(253, 22);
            this.gridLookUpEdit1.TabIndex = 5;
            this.gridLookUpEdit1.EditValueChanged += new System.EventHandler(this.gridLookUpEdit1_EditValueChanged);
            this.gridLookUpEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.gridLookUpEdit1_EditValueChanging);
            this.gridLookUpEdit1.EnabledChanged += new System.EventHandler(this.gridLookUpEdit1_EnabledChanged);
            this.gridLookUpEdit1.Click += new System.EventHandler(this.gridLookUpEdit1_Click);
            this.gridLookUpEdit1.Validated += new System.EventHandler(this.gridLookUpEdit1_Validated);
            // 
            // servicesantennesSetBindingSource
            // 
            this.servicesantennesSetBindingSource.DataSource = typeof(Inventaire_APC.services_antennesSet);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_service,
            this.colnom_service});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_service
            // 
            this.colid_service.Caption = "الرقم";
            this.colid_service.FieldName = "id_service";
            this.colid_service.Name = "colid_service";
            this.colid_service.Visible = true;
            this.colid_service.VisibleIndex = 0;
            this.colid_service.Width = 128;
            // 
            // colnom_service
            // 
            this.colnom_service.Caption = "اسم المصلحة او الفرع";
            this.colnom_service.FieldName = "nom_service";
            this.colnom_service.Name = "colnom_service";
            this.colnom_service.Visible = true;
            this.colnom_service.VisibleIndex = 1;
            this.colnom_service.Width = 914;
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.EditValue = "[aaaaaaaaaaaaaaaaa]";
            this.gridLookUpEdit2.Location = new System.Drawing.Point(312, 60);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.bureauxSetBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "nom_bureau";
            this.gridLookUpEdit2.Properties.ValueMember = "id_bureau";
            this.gridLookUpEdit2.Properties.View = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Size = new System.Drawing.Size(248, 22);
            this.gridLookUpEdit2.TabIndex = 6;
            this.gridLookUpEdit2.EditValueChanged += new System.EventHandler(this.gridLookUpEdit2_EditValueChanged);
            // 
            // bureauxSetBindingSource
            // 
            this.bureauxSetBindingSource.DataSource = typeof(Inventaire_APC.bureauxSet);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_bureau,
            this.colnom_bureau});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colid_bureau
            // 
            this.colid_bureau.Caption = "الرفم";
            this.colid_bureau.FieldName = "id_bureau";
            this.colid_bureau.Name = "colid_bureau";
            this.colid_bureau.Visible = true;
            this.colid_bureau.VisibleIndex = 0;
            this.colid_bureau.Width = 261;
            // 
            // colnom_bureau
            // 
            this.colnom_bureau.Caption = "اسم المكتب";
            this.colnom_bureau.FieldName = "nom_bureau";
            this.colnom_bureau.Name = "colnom_bureau";
            this.colnom_bureau.Visible = true;
            this.colnom_bureau.VisibleIndex = 1;
            this.colnom_bureau.Width = 783;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(195, 134);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(185, 44);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "تـأكـــــــــــيد المكتب";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 181);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(71, 26);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // choix_bureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 216);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "choix_bureau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيــــــــــار المكتب المراد جرد عتاده";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesantennesSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bureauxSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_service;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_service;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colid_bureau;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_bureau;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource servicesantennesSetBindingSource;
        private System.Windows.Forms.BindingSource bureauxSetBindingSource;
        public DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}