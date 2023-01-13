using Qc_Lab.Services;
using Qc_Lab.Services.Interfaces;
using Qc_Lab.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Qc_Lab.Forms.Users
{
    public partial class frm_AddOrEditUser : Form
    {
        IUserServices _userServices;
        public int customerId = 0;
        public frm_AddOrEditUser()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void frm_AddOrEditUser_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
                var customer = _userServices.FindUserById(customerId);
                customer.Read();
                txtEmail.Text = customer["Email"].ToString();
                txtAddress.Text = customer["Address"].ToString();
                txtMobile.Text = customer["Mobile"].ToString();
                txtName.Text = customer["Name"].ToString();
                txtFamily.Text = customer["Family"].ToString();
                txtUserName.Text= customer["UserName"].ToString();
                chkActivity.Checked=(bool) customer["IsActive"];
                txtUserName.Enabled = false;
                pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer["ImageAddress"].ToString();
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imagName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);   //نام و پسوند عکس
                string path = Application.StartupPath + "/Images/";
                
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
               
                if (customerId != 0)
                {
                   
                    bool isEdit= _userServices.EditUser(customerId, txtName.Text, txtFamily.Text, txtUserName.Text, txtMobile.Text, txtEmail.Text, txtAddress.Text, chkActivity.Checked, imagName);
                    if (isEdit)
                    {
                        pcCustomer.Image.Save(path + imagName);
                        lblMessage.Text = "کاربر مورد نظر با موفقیت اصلاح گردید. ";
                        System.Threading.Thread.Sleep(1000);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        lblMessage.Text = "متاسفانه مشگلی رخ داده با پشتیبانی تماس بگیرید. ";
                    }
                       
                }
                else
                {
                    var customer = _userServices.GetUserByUserName(txtUserName.Text);
                    customer.Read();
                 
                    if (customer.Read() && customer.GetValue(0) != DBNull.Value)
                    {
                        lblMessage.Text = "نام کاربری تکراری می باشد. ";
                    }
                    else
                    {
                        string hassPass = PasswordHelper.EncodePasswordMd5("1234");

                        bool isAdd = _userServices.AddUser(txtName.Text, txtFamily.Text, txtUserName.Text, hassPass, txtMobile.Text, txtEmail.Text, txtAddress.Text, chkActivity.Checked, imagName);

                        if (isAdd)
                        {
                            pcCustomer.Image.Save(path + imagName);
                            lblMessage.Text = "کاربر مورد نظر با موفقیت درج گردید. ";
                            System.Threading.Thread.Sleep(1000);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            lblMessage.Text = "متاسفانه مشگلی رخ داده با پشتیبانی تماس بگیرید. ";
                        }
                    }
                  

                }
                    //_userServices.UserSave();
                 
                //Accounting.DataLayer.Customers customers = new Accounting.DataLayer.Customers()
                //{
                //    Address = txtAddress.Text,
                //    Email = txtEmail.Text,
                //    FullName = txtName.Text,
                //    Mobile = txtMobile.Text,
                //    CustomerImage = imagName
                //};

                //db.CustomerRepository.InsertCustomer(customers);
                //db.save();
                //DialogResult = DialogResult.OK;




            }
        }
    }

}
