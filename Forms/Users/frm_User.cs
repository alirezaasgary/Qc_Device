using Qc_Lab.Forms.Users;
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
    public partial class frm_User : Form
    {
        IUserServices _userServices;
        public frm_User()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void frm_User_Load(object sender, EventArgs e)
        {

            BindGrid();
        }
        bool CheckAccess(int userId, string permissionLatinName)
        {
            var access = _userServices.GetAccess(StaticParametr.UserId, permissionLatinName);
            if (access.Read() && access.GetValue(0) != DBNull.Value)
            {
                return (true);
            }
            else
            {
                return (false);
            }

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_AddOrEditUser"))
            {
                frm_AddOrEditUser frmAddOrEdit = new frm_AddOrEditUser();
                //frmAddOrEdit.ShowDialog();
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }
        void BindGrid()
        {
            raddgvCustomers.AutoGenerateColumns = false;
            raddgvCustomers.DataSource = _userServices.GetAllUser();
            ///
            raddgRole.AutoGenerateColumns = false;
            raddgRole.DataSource = _userServices.GetAllRolse();

        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_AddOrEditUser"))
            {
                if (raddgvCustomers.CurrentRow != null)
                {
                    int customerId = int.Parse(raddgvCustomers.CurrentRow.Cells[0].Value.ToString());
                    frm_AddOrEditUser frmAddOrEdit = new frm_AddOrEditUser();
                    frmAddOrEdit.customerId = customerId;
                    if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                    {
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "AddUserRole"))
            {
                if (raddgvCustomers.CurrentRow != null)
                {
                    if (MessageBox.Show("با ویرایش نقش تمامی نقش های قبل حذف شده و نقش های جدید جایگزین خواهد شد؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _userServices.DeleteUserRole(int.Parse(raddgvCustomers.CurrentRow.Cells[0].Value.ToString()));
                        for (int i = 0; i < raddgRole.RowCount; i++)
                        {
                            if (Convert.ToBoolean(raddgRole.Rows[i].Cells[2].Value))
                            {
                                _userServices.AddUserRole(int.Parse(raddgvCustomers.CurrentRow.Cells[0].Value.ToString()), int.Parse(raddgRole.Rows[i].Cells[0].Value.ToString()));
                            }
                        }
                        BindGrid();
                    }
                }
                else
                {
                    MessageBox.Show("یک نقش انتخاب کنید.", "پیام");
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "DeleteUserRole"))
            {
                if (raddvUserRole.CurrentRow != null)
                {
                    _userServices.DeleteUserRoleByRoleId(int.Parse(raddvUserRole.CurrentRow.Cells[0].Value.ToString()));
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void raddgvCustomers_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            raddvUserRole.DataSource = _userServices.GetAllUserRoles(int.Parse(raddgvCustomers.CurrentRow.Cells[0].Value.ToString()));

        }
    }
}
