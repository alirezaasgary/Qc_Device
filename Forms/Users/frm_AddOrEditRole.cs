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

namespace Qc_Lab.Forms.Users
{
    public partial class frm_AddOrEditRole : Form
    {
        IUserServices _userServices;
        public int RoleId = 0;
     
        public frm_AddOrEditRole()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void frm_AddOrEditRole_Load(object sender, EventArgs e)
        {
            if (RoleId != 0)
            {
                this.Text = "ویرایش نقش";
                btnOk.Text = "ویرایش";
                var customer = _userServices.FindRoleById(RoleId);
                customer.Read();
                txtRoleName.Text = customer["RoleName"].ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (RoleId != 0)
            {
                bool editRole = _userServices.EditRole(RoleId, txtRoleName.Text);
                if (editRole)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {

                    lblMessage.Text = "متاسفانه مشگلی رخ داده با پشتیبانی تماس بگیرید. ";
                }
            }

            else
            {
                bool addRole = _userServices.AddRole(txtRoleName.Text);
                if (addRole)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {

                    lblMessage.Text = "متاسفانه مشگلی رخ داده با پشتیبانی تماس بگیرید. ";
                }
            }
               
        }
    }
}
