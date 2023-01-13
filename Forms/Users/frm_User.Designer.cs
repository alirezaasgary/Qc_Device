namespace Qc_Lab.Forms
{
    partial class frm_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_User));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEditCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.raddgvCustomers = new Telerik.WinControls.UI.RadGridView();
            this.raddvUserRole = new Telerik.WinControls.UI.RadGridView();
            this.raddgRole = new Telerik.WinControls.UI.RadGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvCustomers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddvUserRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddvUserRole.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRole.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewCustomer,
            this.btnEditCustomer,
            this.btnRefreshCustomer,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 65);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.Image")));
            this.btnAddNewCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(51, 62);
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
            this.btnEditCustomer.Size = new System.Drawing.Size(55, 62);
            this.btnEditCustomer.Text = "ویرایش";
            this.btnEditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnRefreshCustomer
            // 
            this.btnRefreshCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRefreshCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCustomer.Image")));
            this.btnRefreshCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCustomer.Name = "btnRefreshCustomer";
            this.btnRefreshCustomer.Size = new System.Drawing.Size(76, 62);
            this.btnRefreshCustomer.Text = "بروزرسانی";
            this.btnRefreshCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshCustomer.Click += new System.EventHandler(this.btnRefreshCustomer_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(71, 62);
            this.toolStripLabel1.Text = "جستجو : ";
            // 
            // txtFilter
            // 
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(300, 65);
            // 
            // button1
            // 
            this.button1.Image = global::Qc_Lab.Properties.Resources.remove__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = ">>";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Image = global::Qc_Lab.Properties.Resources.add__2_;
            this.btnAddRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddRole.Location = new System.Drawing.Point(382, 485);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(73, 34);
            this.btnAddRole.TabIndex = 6;
            this.btnAddRole.Text = "<<";
            this.btnAddRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.button2_Click);
            // 
            // raddgvCustomers
            // 
            this.raddgvCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.raddgvCustomers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddgvCustomers.Location = new System.Drawing.Point(0, 65);
            // 
            // 
            // 
            this.raddgvCustomers.MasterTemplate.AllowAddNewRow = false;
            this.raddgvCustomers.MasterTemplate.AllowColumnChooser = false;
            this.raddgvCustomers.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddgvCustomers.MasterTemplate.AllowDeleteRow = false;
            this.raddgvCustomers.MasterTemplate.AllowDragToGroup = false;
            this.raddgvCustomers.MasterTemplate.AllowRowResize = false;
            this.raddgvCustomers.MasterTemplate.AutoGenerateColumns = false;
            this.raddgvCustomers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "UserId";
            gridViewTextBoxColumn1.HeaderText = "دسترسی ها";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 294;
            gridViewTextBoxColumn2.FieldName = "UserName";
            gridViewTextBoxColumn2.HeaderText = "نام کاربری";
            gridViewTextBoxColumn2.Name = "UserName";
            gridViewTextBoxColumn2.Width = 232;
            gridViewTextBoxColumn3.FieldName = "Name";
            gridViewTextBoxColumn3.HeaderText = "نام";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 232;
            gridViewTextBoxColumn4.FieldName = "Family";
            gridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 232;
            gridViewCheckBoxColumn1.FieldName = "IsActive";
            gridViewCheckBoxColumn1.HeaderText = "انتخاب";
            gridViewCheckBoxColumn1.Name = "IsActive";
            gridViewCheckBoxColumn1.Width = 123;
            this.raddgvCustomers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCheckBoxColumn1});
            this.raddgvCustomers.MasterTemplate.EnableGrouping = false;
            this.raddgvCustomers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.raddgvCustomers.Name = "raddgvCustomers";
            this.raddgvCustomers.ShowGroupPanel = false;
            this.raddgvCustomers.ShowGroupPanelScrollbars = false;
            this.raddgvCustomers.Size = new System.Drawing.Size(837, 386);
            this.raddgvCustomers.TabIndex = 9;
            this.raddgvCustomers.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.raddgvCustomers_CellClick);
            // 
            // raddvUserRole
            // 
            this.raddvUserRole.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddvUserRole.Location = new System.Drawing.Point(461, 457);
            // 
            // 
            // 
            this.raddvUserRole.MasterTemplate.AllowAddNewRow = false;
            this.raddvUserRole.MasterTemplate.AllowColumnChooser = false;
            this.raddvUserRole.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddvUserRole.MasterTemplate.AllowDeleteRow = false;
            this.raddvUserRole.MasterTemplate.AllowDragToGroup = false;
            this.raddvUserRole.MasterTemplate.AllowEditRow = false;
            this.raddvUserRole.MasterTemplate.AllowRowResize = false;
            this.raddvUserRole.MasterTemplate.AutoGenerateColumns = false;
            this.raddvUserRole.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "UR_Id";
            gridViewTextBoxColumn5.HeaderText = "column2";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "column2";
            gridViewTextBoxColumn5.Width = 39;
            gridViewTextBoxColumn6.FieldName = "RoleName";
            gridViewTextBoxColumn6.HeaderText = "نام نقش";
            gridViewTextBoxColumn6.Name = "column1";
            gridViewTextBoxColumn6.Width = 356;
            this.raddvUserRole.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.raddvUserRole.MasterTemplate.EnableGrouping = false;
            this.raddvUserRole.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.raddvUserRole.Name = "raddvUserRole";
            this.raddvUserRole.ShowGroupPanel = false;
            this.raddvUserRole.ShowGroupPanelScrollbars = false;
            this.raddvUserRole.Size = new System.Drawing.Size(377, 173);
            this.raddvUserRole.TabIndex = 10;
            // 
            // raddgRole
            // 
            this.raddgRole.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raddgRole.Location = new System.Drawing.Point(0, 457);
            // 
            // 
            // 
            this.raddgRole.MasterTemplate.AllowAddNewRow = false;
            this.raddgRole.MasterTemplate.AllowColumnChooser = false;
            this.raddgRole.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.raddgRole.MasterTemplate.AllowDeleteRow = false;
            this.raddgRole.MasterTemplate.AllowDragToGroup = false;
            this.raddgRole.MasterTemplate.AllowRowResize = false;
            this.raddgRole.MasterTemplate.AutoGenerateColumns = false;
            this.raddgRole.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.FieldName = "RoleId";
            gridViewTextBoxColumn7.HeaderText = "دسترسی ها";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "column1";
            gridViewTextBoxColumn7.Width = 294;
            gridViewTextBoxColumn8.FieldName = "RoleName";
            gridViewTextBoxColumn8.HeaderText = "نام فرم";
            gridViewTextBoxColumn8.Name = "column2";
            gridViewTextBoxColumn8.Width = 304;
            gridViewCheckBoxColumn2.HeaderText = "انتخاب";
            gridViewCheckBoxColumn2.Name = "column3";
            gridViewCheckBoxColumn2.Width = 52;
            this.raddgRole.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewCheckBoxColumn2});
            this.raddgRole.MasterTemplate.EnableGrouping = false;
            this.raddgRole.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.raddgRole.Name = "raddgRole";
            this.raddgRole.ShowGroupPanel = false;
            this.raddgRole.ShowGroupPanelScrollbars = false;
            this.raddgRole.Size = new System.Drawing.Size(376, 173);
            this.raddgRole.TabIndex = 11;
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 630);
            this.Controls.Add(this.raddgRole);
            this.Controls.Add(this.raddvUserRole);
            this.Controls.Add(this.raddgvCustomers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_User";
            this.Load += new System.EventHandler(this.frm_User_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvCustomers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddvUserRole.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddvUserRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRole.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raddgRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddNewCustomer;
        private System.Windows.Forms.ToolStripButton btnEditCustomer;
        private System.Windows.Forms.ToolStripButton btnRefreshCustomer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadGridView raddgvCustomers;
        private Telerik.WinControls.UI.RadGridView raddvUserRole;
        private Telerik.WinControls.UI.RadGridView raddgRole;
    }
}