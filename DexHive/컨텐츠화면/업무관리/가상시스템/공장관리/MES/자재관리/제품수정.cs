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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public partial class 제품수정 : Form
    {
        public DataGridViewRow SelectedRow { get; set; }
        public I서버인터페이스 서비스 { get; internal set; }

        public 제품수정()
        {
            InitializeComponent();
            InitializeEvent();
        }

        private void InitializeEvent()
        {
            this.Shown += 제품수정_Shown;
        }

        private void 제품수정_Shown(object sender, EventArgs e)
        {
            textBox1.Text = SelectedRow.Cells["PRODUCTDEFINITIONID"].Value.ToString();
        }
    }
}
