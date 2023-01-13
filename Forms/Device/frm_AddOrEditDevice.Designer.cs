namespace Qc_Lab.Forms.Device
{
    partial class frm_AddOrEditDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddOrEditDevice));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDActivity = new System.Windows.Forms.CheckBox();
            this.txtDModel = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDcreateYear = new System.Windows.Forms.ComboBox();
            this.nuDYearUse = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDYearUse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDActivity);
            this.groupBox3.Location = new System.Drawing.Point(258, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 75);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "وضعیت دستگاه";
            // 
            // chkDActivity
            // 
            this.chkDActivity.AutoSize = true;
            this.chkDActivity.Location = new System.Drawing.Point(170, 31);
            this.chkDActivity.Name = "chkDActivity";
            this.chkDActivity.Size = new System.Drawing.Size(47, 17);
            this.chkDActivity.TabIndex = 0;
            this.chkDActivity.Text = "فعال";
            this.chkDActivity.UseVisualStyleBackColor = true;
            // 
            // txtDModel
            // 
            this.txtDModel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDModel.Location = new System.Drawing.Point(258, 88);
            this.txtDModel.Name = "txtDModel";
            this.txtDModel.Size = new System.Drawing.Size(234, 22);
            this.txtDModel.TabIndex = 9;
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDName.Location = new System.Drawing.Point(258, 40);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(234, 22);
            this.txtDName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "نام دستگاه :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "سال ساخت :";
            // 
            // txtDDescription
            // 
            this.txtDDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDDescription.Location = new System.Drawing.Point(9, 138);
            this.txtDDescription.Multiline = true;
            this.txtDDescription.Name = "txtDDescription";
            this.txtDDescription.Size = new System.Drawing.Size(229, 53);
            this.txtDDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "توضیحات :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد سال استفاده :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "مدل :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDcreateYear);
            this.groupBox2.Controls.Add(this.nuDYearUse);
            this.groupBox2.Controls.Add(this.txtDName);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDModel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 240);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات دستگاه";
            // 
            // cmbDcreateYear
            // 
            this.cmbDcreateYear.FormattingEnabled = true;
            this.cmbDcreateYear.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbDcreateYear.Location = new System.Drawing.Point(9, 41);
            this.cmbDcreateYear.Name = "cmbDcreateYear";
            this.cmbDcreateYear.Size = new System.Drawing.Size(229, 21);
            this.cmbDcreateYear.TabIndex = 13;
            // 
            // nuDYearUse
            // 
            this.nuDYearUse.Location = new System.Drawing.Point(9, 88);
            this.nuDYearUse.Name = "nuDYearUse";
            this.nuDYearUse.Size = new System.Drawing.Size(229, 21);
            this.nuDYearUse.TabIndex = 12;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtDName;
            this.requiredFieldValidator3.ErrorMessage = "نام دستگاه نمی تواند خالی باشد.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // frm_AddOrEditDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 249);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddOrEditDevice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddOrEditDevice";
            this.Load += new System.EventHandler(this.frm_AddOrEditDevice_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDYearUse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDActivity;
        private System.Windows.Forms.TextBox txtDModel;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbDcreateYear;
        private System.Windows.Forms.NumericUpDown nuDYearUse;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}