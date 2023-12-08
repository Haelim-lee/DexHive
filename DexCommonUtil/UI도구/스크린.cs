using DexHive;
using DexServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexCommonUtil.UI도구
{
    public partial class 스크린 : Form 
    {
        public I서버인터페이스 서비스 { get; set; }
        public TabControl 컨텐츠뷰어 { get; set; }
        public 공통기능 기본기능 { get; set; }//기본기능
        

        public 스크린()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            InitializeScreen();
        }

        private void InitializeProperty()
        {
            기본기능 = new 공통기능();
            기본기능.저장버튼 = this.저장버튼;
            기본기능.조회버튼 = this.조회버튼;
            기본기능.행추가버튼 = this.행추가버튼;
            기본기능.행제거버튼 = this.행제거버튼;
        }

        private void InitializeScreen()
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Show();
        }

        private void InitializeEvent()
        {
            this.닫기버튼.Click += (object sender, EventArgs e) => 컨텐츠뷰어.TabPages.Remove(컨텐츠뷰어.SelectedTab);
        }
        public void ComboBoxBinding(ComboBox 콤보박스, string 쿼리아이디, Hashtable param, bool 전체여부)
        {
            DataTable 결과표 =서비스.조회수행(쿼리아이디, param);
            if(전체여부 == true)
            {
                DataRow 전체행= 결과표.NewRow();
                전체행["명칭"] = "전체";
                전체행["코드"] = " ";
                결과표.Rows.InsertAt(전체행,0);
            }
            콤보박스.DataSource = 결과표;
            콤보박스.DisplayMember = "명칭";
            콤보박스.ValueMember = "코드";
        }
    }
}
