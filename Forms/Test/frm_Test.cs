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
    public partial class frm_Test : Form
    {
        ITestServices _testServices;
     
        public frm_Test()
        {
            InitializeComponent();
            _testServices= new TestServices();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            TextBox[] textBox = new TextBox[] { txtEnterValue1, txtEnterValue2, txtEnterValue3, txtEnterValue4, txtEnterValue5, txtEnterValue6, txtEnterValue7, txtEnterValue8 ,txtEnterValue9, txtEnterValue10, txtEnterValue11, txtEnterValue12 };
            Label[] labels = new Label[] { lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10, lbl11, lbl12 };
            Button[] buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12 };

            for (int i = 0; i < 12; i++)
            {
                textBox[i].Visible = false;
                labels[i].Visible = false;
                buttons[i].Visible = false;

                if (textBox[i].Text == "")
                {
                    buttons[i].Text = "...";
                }
                else
                {
                    buttons[i].Text = textBox[i].Text;
                }
                

            }


            for (int i=0; i<nuEnterCount.Value; i++)
            {
                textBox[i].Visible = true;
                labels[i].Visible = true;
                buttons[i].Visible = true;
            }
            
        }

        private void frm_Test_Load(object sender, EventArgs e)
        {
         
            this.raddgvTest.AutoGenerateColumns = false;
            cbDevice.DisplayMember = "Name";
            cbDevice.ValueMember = "DeviceId";
            cbDevice.DataSource = _testServices.FillDevice().Tables[0];
            raddgvTest.DataSource = _testServices.GetAllTest();
            this.raddgvTest.TableElement.BeginUpdate();
  
            this.raddgvTest.EnableFiltering = true;
            this.raddgvTest.AllowAddNewRow = false;
            this.raddgvTest.ReadOnly = true;
            this.raddgvTest.MasterTemplate.ShowHeaderCellButtons = true;
            this.raddgvTest.MasterTemplate.ShowFilteringRow = false;
            this.raddgvTest.TableElement.EndUpdate();




            cbDevice.Enabled = true;
        }

        private void txtEnterValue1_TextChanged(object sender, EventArgs e)
        {
            btn1.Text = txtEnterValue1.Text;
        }

        private void txtEnterValue2_TextChanged(object sender, EventArgs e)
        {
            btn2.Text = txtEnterValue2.Text;
        }

        private void txtEnterValue3_TextChanged(object sender, EventArgs e)
        {
            btn3.Text = txtEnterValue3.Text;
        }

        private void txtEnterValue4_TextChanged(object sender, EventArgs e)
        {
            btn4.Text = txtEnterValue4.Text;
        }

        private void txtEnterValue5_TextChanged(object sender, EventArgs e)
        {
            btn5.Text = txtEnterValue5.Text;
        }

        private void txtEnterValue6_TextChanged(object sender, EventArgs e)
        {
            btn6.Text = txtEnterValue6.Text;
        }

        private void txtEnterValue7_TextChanged(object sender, EventArgs e)
        {
            btn7.Text = txtEnterValue7.Text;
        }

        private void txtEnterValue8_TextChanged(object sender, EventArgs e)
        {
            btn8.Text = txtEnterValue8.Text;
        }

        private void txtEnterValue9_TextChanged(object sender, EventArgs e)
        {
            btn9.Text = txtEnterValue9.Text;
        }

        private void txtEnterValue10_TextChanged(object sender, EventArgs e)
        {
            btn10.Text = txtEnterValue10.Text;
        }

        private void txtEnterValue11_TextChanged(object sender, EventArgs e)
        {
            btn11.Text = txtEnterValue11.Text;
        }

        private void txtEnterValue12_TextChanged(object sender, EventArgs e)
        {
            btn12.Text = txtEnterValue12.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn1.Text +"}";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if(btn2.Text!="...")
            richTextBox1.Text = richTextBox1.Text + "{" + btn2.Text + "}";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn3.Text + "}";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn4.Text + "}";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn5.Text + "}";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn6.Text + "}";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn7.Text + "}";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn8.Text + "}";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn9.Text + "}";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn10.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn10.Text + "}";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn11.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn11.Text + "}";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn12.Text != "...")
                richTextBox1.Text = richTextBox1.Text + "{" + btn12.Text + "}";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _testServices.AddTest(txtTestName.Text, int.Parse(cbDevice.SelectedValue.ToString()), int.Parse(nuEnterCount.Value.ToString()), float.Parse(minEnterval.Text), float.Parse(maxEnterVal.Text)
                , txtEnterValue1.Text, txtEnterValue2.Text, txtEnterValue3.Text, txtEnterValue4.Text, txtEnterValue5.Text, txtEnterValue6.Text
                 , txtEnterValue7.Text, txtEnterValue8.Text, txtEnterValue9.Text, txtEnterValue10.Text, txtEnterValue11.Text, txtEnterValue12.Text,
                 richTextBox1.Text);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            _testServices.TestDelete(int.Parse(raddgvTest.CurrentRow.Cells[0].Value.ToString()));
            raddgvTest.DataSource = _testServices.GetAllTest();
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            raddgvTest.DataSource = _testServices.GetAllTest();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button14.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button9.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button20.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button18.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button17.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + button16.Text;
        }
    }
}
