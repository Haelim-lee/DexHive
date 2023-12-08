using DexCommonUtil.UI도구;
using DexHive.컨텐츠화면.업무관리.계약관리;
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

namespace DexHive.컨텐츠화면.업무관리.계약관리그룹
{
    public partial class 계약관리 :스크린 ,I스크린
    {
        public 거래처 거래처관리 { get; set; }
        
        public 계약관리()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            거래처관리.버튼1.Click += 버튼1_Click;
        }

        private void 버튼1_Click(object sender, EventArgs e)
        {
            거래처관리.거래처관리표.AutoGenerateColumns = true;
            거래처관리.거래처관리표.DataSource = 서비스.조회수행("계약관리조회", new Hashtable());
            
        }

        private void InitializeProperty()
        {
            거래처관리 = new 거래처();
            거래처관리.텍스트1 = textBox1;
            거래처관리.텍스트2 = textBox2;
            거래처관리.텍스트3 = textBox3;
            거래처관리.텍스트4 = textBox4;

            거래처관리.콤보박스1 = comboBox1;
            거래처관리.거래처관리표 = dexGridView1;
            거래처관리.버튼1 = button1;

        }

        public void 저장()
        {
            throw new NotImplementedException();
        }

        public void 조회()
        {
            throw new NotImplementedException();
        }

        public void 초기화()
        {
            throw new NotImplementedException();
        }

        public void 행제거()
        {
            throw new NotImplementedException();
        }

        public void 행추가()
        {
            throw new NotImplementedException();
        }
    }
}
