namespace Qc_Lab.Forms.Users
{
    partial class frm_Rols
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn3 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition7 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition8 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition9 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rols));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raddgPermission = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raddgRols = new Telerik.WinControls.UI.RadGridView();
            this.raddgRolePermission = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raddgPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgPermission.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRols.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRolePermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRolePermission.MasterTemplate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raddgPermission);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 630);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت فرم ها";
            // 
            // raddgPermission
            // 
            this.raddgPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raddgPermission.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddgPermission.Location = new System.Drawing.Point(3, 18);
            // 
            // 
            // 
            this.raddgPermission.MasterTemplate.AllowAddNewRow = false;
            this.raddgPermission.MasterTemplate.AllowColumnChooser = false;
            this.raddgPermission.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddgPermission.MasterTemplate.AllowDeleteRow = false;
            this.raddgPermission.MasterTemplate.AllowDragToGroup = false;
            this.raddgPermission.MasterTemplate.AllowRowResize = false;
            this.raddgPermission.MasterTemplate.AutoGenerateColumns = false;
            this.raddgPermission.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn15.FieldName = "PermissionId";
            gridViewTextBoxColumn15.HeaderText = "دسترسی ها";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "column1";
            gridViewTextBoxColumn15.Width = 294;
            gridViewCheckBoxColumn3.HeaderText = "انتخاب";
            gridViewCheckBoxColumn3.Name = "column3";
            gridViewCheckBoxColumn3.Width = 64;
            gridViewTextBoxColumn16.FieldName = "PermissionName";
            gridViewTextBoxColumn16.HeaderText = "نام فرم";
            gridViewTextBoxColumn16.Name = "column2";
            gridViewTextBoxColumn16.Width = 376;
            this.raddgPermission.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn15,
            gridViewCheckBoxColumn3,
            gridViewTextBoxColumn16});
            this.raddgPermission.MasterTemplate.EnableGrouping = false;
            this.raddgPermission.MasterTemplate.ViewDefinition = tableViewDefinition7;
            this.raddgPermission.Name = "raddgPermission";
            this.raddgPermission.ShowGroupPanel = false;
            this.raddgPermission.ShowGroupPanelScrollbars = false;
            this.raddgPermission.Size = new System.Drawing.Size(460, 609);
            this.raddgPermission.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddRole);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.raddgRols);
            this.groupBox2.Controls.Add(this.raddgRolePermission);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(472, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 630);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مدیریت نقش ها";
            // 
            // raddgRols
            // 
            this.raddgRols.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddgRols.Location = new System.Drawing.Point(6, 90);
            // 
            // 
            // 
            this.raddgRols.MasterTemplate.AllowAddNewRow = false;
            this.raddgRols.MasterTemplate.AllowColumnChooser = false;
            this.raddgRols.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddgRols.MasterTemplate.AllowDeleteRow = false;
            this.raddgRols.MasterTemplate.AllowDragToGroup = false;
            this.raddgRols.MasterTemplate.AllowEditRow = false;
            this.raddgRols.MasterTemplate.AllowRowResize = false;
            this.raddgRols.MasterTemplate.AutoGenerateColumns = false;
            this.raddgRols.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn17.FieldName = "RoleId";
            gridViewTextBoxColumn17.HeaderText = "دسترسی ها";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "column1";
            gridViewTextBoxColumn17.Width = 294;
            gridViewTextBoxColumn18.FieldName = "RoleName";
            gridViewTextBoxColumn18.HeaderText = "عنوان نقش";
            gridViewTextBoxColumn18.Name = "column2";
            gridViewTextBoxColumn18.Width = 333;
            this.raddgRols.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.raddgRols.MasterTemplate.EnableGrouping = false;
            this.raddgRols.MasterTemplate.ViewDefinition = tableViewDefinition8;
            this.raddgRols.Name = "raddgRols";
            this.raddgRols.ShowGroupPanel = false;
            this.raddgRols.ShowGroupPanelScrollbars = false;
            this.raddgRols.Size = new System.Drawing.Size(354, 348);
            this.raddgRols.TabIndex = 7;
            this.raddgRols.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.raddgRols_CellClick);
            this.raddgRols.Click += new System.EventHandler(this.raddgRols_Click);
            // 
            // raddgRolePermission
            // 
            this.raddgRolePermission.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddgRolePermission.Location = new System.Drawing.Point(88, 444);
            // 
            // 
            // 
            this.raddgRolePermission.MasterTemplate.AllowAddNewRow = false;
            this.raddgRolePermission.MasterTemplate.AllowColumnChooser = false;
            this.raddgRolePermission.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddgRolePermission.MasterTemplate.AllowDeleteRow = false;
            this.raddgRolePermission.MasterTemplate.AllowDragToGroup = false;
            this.raddgRolePermission.MasterTemplate.AllowEditRow = false;
            this.raddgRolePermission.MasterTemplate.AllowRowResize = false;
            this.raddgRolePermission.MasterTemplate.AutoGenerateColumns = false;
            this.raddgRolePermission.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn19.FieldName = "PermissionId";
            gridViewTextBoxColumn19.HeaderText = "column2";
            gridViewTextBoxColumn19.IsVisible = false;
            gridViewTextBoxColumn19.Name = "column2";
            gridViewTextBoxColumn19.Width = 44;
            gridViewTextBoxColumn20.FieldName = "RP_Id";
            gridViewTextBoxColumn20.HeaderText = "column3";
            gridViewTextBoxColumn20.IsVisible = false;
            gridViewTextBoxColumn20.Name = "column3";
            gridViewTextBoxColumn20.Width = 42;
            gridViewTextBoxColumn21.FieldName = "PermissionName";
            gridViewTextBoxColumn21.HeaderText = "دسترسی ها";
            gridViewTextBoxColumn21.Name = "column1";
            gridViewTextBoxColumn21.Width = 251;
            this.raddgRolePermission.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21});
            this.raddgRolePermission.MasterTemplate.EnableGrouping = false;
            this.raddgRolePermission.MasterTemplate.ViewDefinition = tableViewDefinition9;
            this.raddgRolePermission.Name = "raddgRolePermission";
            this.raddgRolePermission.ShowGroupPanel = false;
            this.raddgRolePermission.ShowGroupPanelScrollbars = false;
            this.raddgRolePermission.Size = new System.Drawing.Size(272, 192);
            this.raddgRolePermission.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewCustomer,
            this.toolStripSeparator1,
            this.btnEditCustomer,
            this.toolStripSeparator2,
            this.btnDeleteCustomer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(357, 61);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.Image")));
            this.btnAddNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(44, 58);
            this.btnAddNewCustomer.Text = "افزودن";
            this.btnAddNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.Image")));
            this.btnEditCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(46, 58);
            this.btnEditCustomer.Text = "ویرایش";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(44, 58);
            this.btnDeleteCustomer.Text = "حذف";
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Qc_Lab.Properties.Resources.remove__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = ">>";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Image = global::Qc_Lab.Properties.Resources.add__2_;
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.Location = new System.Drawing.Point(6, 534);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(76, 43);
            this.btnAddRole.TabIndex = 10;
            this.btnAddRole.Text = "<<";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // frm_Rols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "frm_Rols";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم مدیریت دسترسی نقش ها";
            this.Load += new System.EventHandler(this.frm_Rols_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raddgPermission.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgPermission)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRols.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRolePermission.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRolePermission)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnDeleteCustomer;
        private Telerik.WinControls.UI.RadGridView raddgRolePermission;
        private Telerik.WinControls.UI.RadGridView raddgRols;
        private Telerik.WinControls.UI.RadGridView raddgPermission;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}