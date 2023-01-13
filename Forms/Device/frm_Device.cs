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
    public partial class frm_Device : Form
    {
        ITestServices _testServices;
        public frm_Device()
        {
            InitializeComponent();
            _testServices = new TestServices();
        }
        

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frm_AddOrEditDevice frmAddOrEdit = new frm_AddOrEditDevice();
            //frmAddOrEdit.ShowDialog();
            if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (radDgDevices.CurrentRow != null)
            {
                int deviceId = int.Parse(radDgDevices.CurrentRow.Cells[0].Value.ToString());
                frm_AddOrEditDevice frmAddOrEdit = new frm_AddOrEditDevice();
                frmAddOrEdit.deviceId = deviceId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                   BindGrid();
                }
            }
        }

        private void frm_Device_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        void  BindGrid()
        {
          radDgDevices.DataSource=  _testServices.GetAllDevais();
        }
    }
}
