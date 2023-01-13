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

namespace Qc_Lab.Forms.Test
{
    public partial class frm_SaveTest : Form
    {
        public int DeviceId = 0;
        public int TestId = 0;
        public int UserId = 0;
        public string formula;
        public string formulaAfterCheck;
        public string lastNumber;
        ITestServices _testServices;

        public frm_SaveTest()
        {
            InitializeComponent();
            _testServices = new TestServices();
        }

        private void frm_SaveTest_Load(object sender, EventArgs e)
        {
            lblFormula.Text = formula;
            lblLastNumber.Text = lastNumber;
            var test= _testServices.FindTestById(TestId);
           var device= _testServices.FindDeviceById(DeviceId);
            test.Read();
            device.Read();
            lblDeviceName.Text= device["Name"].ToString();
           lblmodel.Text= device["Model"].ToString();
           lblYearUse.Text= device["YearUse"].ToString();
            lblTestName.Text = test["TestName"].ToString();
            lblMin.Text = test["MinOkValue"].ToString();
            lblMax.Text = test["MaxOkValue"].ToString();
      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = DateTime.Now.ToString();
            _testServices.AddTesting(UserId, DeviceId, TestId, formula, formulaAfterCheck, lastNumber, d);
            DialogResult = DialogResult.OK;
        }
    }
}
