using DexCommonUtil.UI도구;
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

namespace DexHive.컨텐츠화면.업무관리.계약관리
{
    public partial class 두번째예제 : 스크린,I스크린
    {
        public 수강생관리표 수강생관리 { get; set; }
        public 두번째예제()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvnet();


        }

        private void InitializeEvnet()
        {
            수강생관리.시간검색.Click += 시간검색_Click;
            수강생관리.학년검색.Click += 학년검색_Click;
        }

        private void 학년검색_Click(object sender, EventArgs e)
        {
            Hashtable 조건 = new Hashtable();
            this.dexGridView1.AutoGenerateColumns = true;
            this.dexGridView1.DataSource = 서비스.조회수행("수강생관리표", 조건);
        }

        private void 시간검색_Click(object sender, EventArgs e)
        {
            Hashtable 조건 = new Hashtable();
            조건["기린반"] = comboBox1.Text; 
            this.dexGridView1.AutoGenerateColumns = true;
            this.dexGridView1.DataSource = 서비스.조회수행("수강생관리표", 조건);
        }

        private void InitializeProperty()
        {
            수강생관리 = new 수강생관리표();
            수강생관리.시간검색 = comboBox1;
            수강생관리.학년검색 = comboBox2;
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
