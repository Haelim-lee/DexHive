using DexCommonUtil.UI도구.MES도구;
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

namespace DexCommonUtil.UI도구
{
    public partial class MES스크린 : Form
    {
        public I서버인터페이스 서비스 { get; set; }
        public TabControl 컨텐츠뷰어 { get; set; }
        public MES공통기능 MES기본기능 { get; set; }//기본기능
        public MES스크린()
        {
            InitializeComponent();
            InitializeProperty();
            InitializeEvent();
            InitializeScreen();

        }

        private void InitializeScreen()
        {
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Show();
        }

        private void InitializeEvent()
        {
            this.btnClose.Click += (object sender, EventArgs e) => 컨텐츠뷰어.TabPages.Remove(컨텐츠뷰어.SelectedTab);
        }

        private void InitializeProperty()
        {
            MES기본기능 = new MES공통기능();
            MES기본기능.조회버튼 = this.btnSearch;
           
        }
    }
}
