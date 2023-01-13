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
    public partial class frm_DeviceTest : Form
    {

        ITestServices _testServices;

        public frm_DeviceTest()
        {
            InitializeComponent();
            _testServices = new TestServices();
        }

        private void frm_DeviceTest_Load(object sender, EventArgs e)
        {
            raddgDevice.DataSource = _testServices.GetAllDevais();
        }

        private void raddgDevice_Click(object sender, EventArgs e)
        {
            raddgTest.DataSource = _testServices.GetTestByDeviceId(int.Parse(raddgDevice.CurrentRow.Cells[0].Value.ToString()));
        }

        private void raddgTest_Click(object sender, EventArgs e)
        {
            lblAftetChek.Visible = false;
            TextBox[] textBox = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12 };
            Label[] labels = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12 };
            for (int i = 0; i < 12; i++)
            {
                textBox[i].Visible = false;
                labels[i].Visible = false;
            }
            for (int i = 0; i < int.Parse(raddgTest.CurrentRow.Cells[2].Value.ToString()); i++)
            {
                textBox[i].Visible = true;
                labels[i].Visible = true;

            }

            label1.Text = "{" + raddgTest.CurrentRow.Cells[5].Value.ToString() + "}";
            label2.Text = "{" + raddgTest.CurrentRow.Cells[6].Value.ToString() + "}";
            label3.Text = "{" + raddgTest.CurrentRow.Cells[7].Value.ToString() + "}";
            label4.Text = "{" + raddgTest.CurrentRow.Cells[8].Value.ToString() + "}";
            label5.Text = "{" + raddgTest.CurrentRow.Cells[9].Value.ToString() + "}";
            label6.Text = "{" + raddgTest.CurrentRow.Cells[10].Value.ToString() + "}";
            label7.Text = "{" + raddgTest.CurrentRow.Cells[11].Value.ToString() + "}";
            label8.Text = "{" + raddgTest.CurrentRow.Cells[12].Value.ToString() + "}";
            label9.Text = "{" + raddgTest.CurrentRow.Cells[13].Value.ToString() + "}";
            label10.Text = "{" + raddgTest.CurrentRow.Cells[14].Value.ToString() + "}";
            label11.Text = "{" + raddgTest.CurrentRow.Cells[15].Value.ToString() + "}";
            label12.Text = "{" + raddgTest.CurrentRow.Cells[16].Value.ToString() + "}";
            lblFormula.Text = raddgTest.CurrentRow.Cells[17].Value.ToString();
        }

        private void lblFormula_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            string formul = lblFormula.Text;
            formul = formul.Replace(label1.Text, txt1.Text);
            formul = formul.Replace(label2.Text, txt2.Text);
            formul = formul.Replace(label3.Text, txt3.Text);
            formul = formul.Replace(label4.Text, txt4.Text);
            formul = formul.Replace(label5.Text, txt5.Text);
            formul = formul.Replace(label6.Text, txt6.Text);
            formul = formul.Replace(label7.Text, txt7.Text);
            formul = formul.Replace(label8.Text, txt8.Text);
            formul = formul.Replace(label9.Text, txt9.Text);
            formul = formul.Replace(label10.Text, txt10.Text);
            formul = formul.Replace(label11.Text, txt11.Text);
            formul = formul.Replace(label12.Text, txt12.Text);
            lblAftetChek.Visible = true;
            lblAftetChek.Text = formul;




        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            lblLastNumber.Visible = true;
            DataTable dt = new DataTable();
            var v = dt.Compute(lblAftetChek.Text, "");
            lblLastNumber.Text = Math.Round(decimal.Parse(v.ToString()), 3).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_SaveTest frm_SaveTest = new frm_SaveTest();
            frm_SaveTest.DeviceId = int.Parse(raddgDevice.CurrentRow.Cells[0].Value.ToString());
            frm_SaveTest.TestId = int.Parse(raddgTest.CurrentRow.Cells[0].Value.ToString());
            frm_SaveTest.UserId = 1;
            frm_SaveTest.formula = lblFormula.Text;
            frm_SaveTest.lastNumber = lblLastNumber.Text;
            frm_SaveTest.formulaAfterCheck = lblAftetChek.Text;


            if (frm_SaveTest.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("کنترل کیفیت با موفقیت ذخیره گردید .", "پیام");
            }
        }

    }
}
