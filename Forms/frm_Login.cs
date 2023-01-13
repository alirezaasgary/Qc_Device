using Qc_Lab.Services;
using Qc_Lab.Services.Interfaces;
using Qc_Lab.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qc_Lab.Forms
{
    public partial class frm_Login : Form
    {
         IUserServices _userServices;

        public frm_Login()
        {
           
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void frm_Login2_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(txtPass.Text);
            //string pass = EncodePasswordMd5(txtUser.Text);  TODO
           bool exeist= _userServices.LoginCheck(txtUser.Text, txtPass.Text);
           var customer = _userServices.GetUserId(txtUser.Text, txtPass.Text);
           
            if (customer.Read() && customer.GetValue(0) != DBNull.Value)
            {
                StaticParametr.UserId = int.Parse(customer["UserId"].ToString());
            }
            

            if (exeist)
            {
                Utilities.StaticParametr.UserName = txtUser.Text;
                //main frm = new main();
                //frm.Show();
                this.Close();

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
