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
    public partial class 로그인화면 : Form
    {
        public I서버인터페이스 서비스 { get; set; }

        public 로그인화면()
        {
            
            InitializeComponent();
            InitializeEvent();

        }

        private void InitializeEvent()
        {
            this.KeyDown += (object sender, KeyEventArgs e)=> { if (e.KeyCode == Keys.Enter) 로그인_Click(this.로그인버튼, EventArgs.Empty); };
            this.로그인버튼.Click += 로그인_Click;
            this.회원가입버튼.Click += 회원가입버튼_Click;
        }

   

        private void 로그인_Click(object sender, EventArgs e)
        {
            string 명령어 = @"SELECT [아이디],
                                     [비밀번호],
                                     [이름]
                                FROM [사용자정보]
                               WHERE [아이디] = '"+this.textBox1.Text +"'";

            DataTable 결과= 서비스.GetDataTable(명령어);
            

            if (결과.Rows.Count != 0)
                로그인(결과);//로그인시도
            else
                MessageBox.Show("아이디가 존재하지 않습니다.");
        }
        private void 회원가입버튼_Click(object sender, EventArgs e)
        {
            회원가입화면 화면 = new 회원가입화면();
            화면.서비스 = this.서비스;
            화면.ShowDialog();
        }

        private void 로그인(DataTable 결과)
        {
            if (this.textBox2.Text == 결과.Rows[0][1].ToString())
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("비밀번호가 틀립니다.");
        }
    }
}
