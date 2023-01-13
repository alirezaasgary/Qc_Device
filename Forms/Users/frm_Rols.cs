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

namespace Qc_Lab.Forms.Users
{
    public partial class frm_Rols : Form
    {
        IUserServices _userServices;

        public frm_Rols()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void frm_Rols_Load(object sender, EventArgs e)
        {

            BindGrid();
        }
        void BindGrid()
        {

            raddgRols.AutoGenerateColumns = false;
            raddgRols.DataSource = _userServices.GetAllRolse();
            //////
            raddgPermission.AutoGenerateColumns = false;
            raddgPermission.DataSource = _userServices.GetAllPermission();
            /////
            raddgRolePermission.AutoGenerateColumns = false;
            raddgRolePermission.DataSource = _userServices.GetAllRolePermission(int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString()));
            fn_chekedPermission();

        }


        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_AddOrEditRole"))
            {
                if (raddgRols.CurrentRow != null)
                {
                    int RoleId = int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString());
                    frm_AddOrEditRole frmAddOrEdit = new frm_AddOrEditRole();
                    frmAddOrEdit.RoleId = RoleId;
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

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_AddOrEditRole"))
            {
                frm_AddOrEditRole frmAddOrEdit = new frm_AddOrEditRole();
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

        private void btnRefreshCustomer_Click(object sender, EventArgs e)
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
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "DeleteRole"))
            {

                if (raddgRols.CurrentRow != null)
                {
                    if (MessageBox.Show("با حذف نقش مورد نظر تمامی دسترسی های این نقش حذف خواهد شد آیا ادامه می دهید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _userServices.DeleteRole(int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString()));
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }


        }



        private void raddgRols_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            raddgRolePermission.AutoGenerateColumns = false;
            raddgRolePermission.DataSource = _userServices.GetAllRolePermission(int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString()));

            fn_chekedPermission();
        }

        void fn_chekedPermission()
        {
            for (int j = 0; raddgPermission.RowCount > j; j++)
            {
                raddgPermission.Rows[j].Cells[1].Value = false;

            }


            for (int i = 0; raddgRolePermission.RowCount > i; i++)
            {
                for (int j = 0; raddgPermission.RowCount > j; j++)
                {

                    if (int.Parse(raddgPermission.Rows[j].Cells[0].Value.ToString()) == int.Parse(raddgRolePermission.Rows[i].Cells[0].Value.ToString()))
                    {
                        raddgPermission.Rows[j].Cells[1].Value = true;
                    }

                }
            }
        }
        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "AddPermissionToRole"))
            {

                if (raddgRols.CurrentRow != null)
                {
                    if (MessageBox.Show("آیا از افزودن این دسترسی مطمعن هستید ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        for (int i = 0; i < raddgPermission.RowCount; i++)
                        {
                            if (Convert.ToBoolean(raddgPermission.Rows[i].Cells[1].Value))
                            {
                                _userServices.DeleteRole_Permission(int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString()), int.Parse(raddgPermission.Rows[i].Cells[0].Value.ToString()));

                                _userServices.AddRole_permission(int.Parse(raddgRols.CurrentRow.Cells[0].Value.ToString()), int.Parse(raddgPermission.Rows[i].Cells[0].Value.ToString()));
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
            if (CheckAccess(StaticParametr.UserId, "DeletePermissionToRole"))
            {
                if (raddgRolePermission.CurrentRow != null)
                {
                    if (MessageBox.Show("آیا از حذف این دسترسی مطمعن هستید ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _userServices.DeleteRolePermissionByRolePermissionId(int.Parse(raddgRolePermission.CurrentRow.Cells[1].Value.ToString()));
                        BindGrid();
                    }
                }

            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void raddgRols_Click(object sender, EventArgs e)
        {

        }
    }
}
