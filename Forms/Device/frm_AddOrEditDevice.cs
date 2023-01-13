using Qc_Lab.Services;
using Qc_Lab.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qc_Lab.Forms.Device
{
    public partial class frm_AddOrEditDevice : Form
    {
        public int deviceId = 0;
        ITestServices _testServices;
        public frm_AddOrEditDevice()
        {
            InitializeComponent();
            _testServices = new TestServices();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (deviceId == 0)
            {
                _testServices.AddDevaice(txtDName.Text, txtDModel.Text, 
                    int.Parse(cmbDcreateYear.SelectedItem.ToString()),
                    int.Parse(nuDYearUse.Value.ToString()), 
                    chkDActivity.Checked, txtDDescription.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {

                _testServices.EditDevaice(txtDName.Text, txtDModel.Text,
                   int.Parse(cmbDcreateYear.SelectedItem.ToString()),
                   int.Parse(nuDYearUse.Value.ToString()),
                   chkDActivity.Checked, txtDDescription.Text, deviceId);
                DialogResult = DialogResult.OK;
            }
        }

        private void frm_AddOrEditDevice_Load(object sender, EventArgs e)
        {
            if (deviceId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = _testServices.FindDeviceById(deviceId);
                customer.Read();
                txtDName.Text =               customer["Name"].ToString();
                txtDModel.Text =              customer["Model"].ToString();
                nuDYearUse.Value =            int.Parse(customer["YearUse"].ToString());
                cmbDcreateYear.SelectedItem = customer["CreateYear"].ToString();
                txtDDescription.Text =        customer["Description"].ToString();           
                chkDActivity.Checked =        (bool)customer["IsActive"];
             
            }
        }
    }
}
