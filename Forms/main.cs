using Qc_Lab.Forms.Device;
using Qc_Lab.Forms.Test;
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
    public partial class main : Form
    {
        IUserServices _userServices;

        public main()
        {

            InitializeComponent();
            _userServices = new UserServices();
        }


        private void main_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                }
            }

            tsDown_Date.Text = tsDown_Date.Text + " " + DateTime.Now.ToShamsi();
            //tsDown_UserName.Text = _userServices.GetUserName();
        }
        public bool CheckIfFormIsOpen(string formname)
        {

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == formname)
                {
                    return true;
                }
            }
            return false;

            //bool formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == formname);

            //return formOpen;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_User"))
            {
                if (CheckIfFormIsOpen("frm_User"))
                {
                    // It means it exists, so close the form
                    frm_User frm = new frm_User();
                    frm.BringToFront();
                }
                else
                {
                    frm_User f = new frm_User();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_Rols"))
            {
                if (CheckIfFormIsOpen("frm_Rols"))
                {
                    // It means it exists, so close the form
                    frm_Rols frm = new frm_Rols();
                    frm.BringToFront();
                }


                else
                {
                    frm_Rols f = new frm_Rols();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void btnSandogh_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_Test"))
            {
                if (CheckIfFormIsOpen("frm_Test"))
                {
                    // It means it exists, so close the form
                    frm_Test frm = new frm_Test();
                    frm.BringToFront();
                }


                else
                {
                    frm_Test f = new frm_Test();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_Device"))
            {
                if (CheckIfFormIsOpen("frm_Device"))
                {
                    // It means it exists, so close the form
                    frm_Device frm = new frm_Device();
                    frm.BringToFront();
                }


                else
                {
                    frm_Device f = new frm_Device();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (CheckAccess(StaticParametr.UserId, "frm_DeviceTest"))
            {
                if (CheckIfFormIsOpen("frm_DeviceTest"))
                {
                    // It means it exists, so close the form
                    frm_DeviceTest frm = new frm_DeviceTest();
                    frm.BringToFront();
                }


                else
                {
                    frm_DeviceTest f = new frm_DeviceTest();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("شما دسترسی به این فرم ندارید .", "مشکل دسترسی");
            }
        }
    }
}
