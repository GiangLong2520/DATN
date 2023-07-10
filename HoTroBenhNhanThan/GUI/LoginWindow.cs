using HoTroBenhNhanThan.Authentication;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTroBenhNhanThan
{
    public partial class LoginWindow : Sample
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (LibMainClass.checkControls(left_panel).Count > 0)
            {
                LibMainClass.showMessage("Fields with RED are madatory", "error");
            }
            else
            {
                Hashtable ht= new Hashtable();
                ht.Add(@"username", txt_user.Text);
                ht.Add(@"Password", txt_password.Text);
                if (/*Login.getLoginDetails("[st_getAuthentication]", ht)*/ true)
                {
                    HomeWindow hw = new HomeWindow();
                    LibMainClass.showWindow(hw, this, MDI.ActiveForm);
                }
                else
                {

                }
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            if(txt_user.Text == "")
            {
                txt_user.BackColor= Color.Firebrick;
            }
            else
            {
                txt_user.BackColor= Color.White;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.BackColor = Color.Firebrick;
            }
            else
            {
                txt_password.BackColor = Color.White;
            }
        }
    }
}
