using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_server_master
{
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLog_Click(object sender, EventArgs e)
        {
            if(tbName.Text=="")
            {
                MessageBox.Show("用户名不得为空!");
            }
            else if(tbPasswd.Text == "")
            {
                MessageBox.Show("密码不得为空!");
            }
            else if(tbName.Text !=""&&tbPasswd.Text != "")
            {
                MessageBox.Show("开始登录！");
            }
        }
    }
}
