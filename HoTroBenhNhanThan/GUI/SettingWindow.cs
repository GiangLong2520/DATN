using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoTroBenhNhanThan.API;

namespace HoTroBenhNhanThan
{
    public partial class SettingWindow : Sample
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if(isCB.Checked)
            {
                txt_userid.Enabled = false;
                txt_pass.Enabled = false;
                txt_userid.Text = "";
                txt_pass.Text = "";
            }
            else
            {
                txt_userid.Enabled = false;
                txt_pass.Enabled = false;
            }
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                txt_userid.AllowDrop = true;
                txt_pass.AllowDrop = true;
                if (LibMainClass.checkControls(left_panel_common).Count > 0)
                {
                    LibMainClass.showMessage("Fields With Red Coler Are Mandatory", "error");
                }
                else
                {
                    LibSetting.createFile("\\cms_connect", 1, txt_source.Text, txt_Db.Text);
                }
            }
            else
            {
                txt_userid.AllowDrop = false;
                txt_pass.AllowDrop = false;
                if (LibMainClass.checkControls(LEFTPANEL).Count > 0)
                {
                    LibMainClass.showMessage("Fields With Red Coler Are Mandatory", "error");
                }
                else
                {
                    LibSetting.createFile("\\cms_connect", 0, txt_source.Text, txt_Db.Text, txt_userid.Text, txt_pass.Text);
                }

            }
            LoginWindow lw = new LoginWindow();
            LibMainClass.showWindow(lw, this, MDI.ActiveForm);
        }
    }
}
