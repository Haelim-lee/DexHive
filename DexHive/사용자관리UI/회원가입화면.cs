using DexHive;
using DexServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexHive.사용자관리UI
{
    public partial class 회원가입화면 : Form
    {
        public I서버인터페이스 서비스 { get; set; }
        public 회원가입화면()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string 명령어 = string.Format(@"INSERT INTO [dbo].[사용자정보]
                                               ([아이디]
                                               ,[비밀번호]
                                               ,[이름])
                                         VALUES
                                               ('{0}'
                                               ,'{1}'
                                               ,'{2}')",this.textBox1.Text,this.textBox2.Text,this.textBox4.Text);
            서비스.ExcuteQuery(명령어);
            this.Close();
        }
    }
}
