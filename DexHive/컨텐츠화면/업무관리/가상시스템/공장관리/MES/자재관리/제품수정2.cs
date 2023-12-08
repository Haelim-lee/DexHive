using DexServer;
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

namespace DexHive.컨텐츠화면.업무관리.가상시스템.공장관리.MES.자재관리
{
    public partial class 제품수정2 : Form
    {
        public DataGridViewRow SelectedRow { get; set; }
        public I서버인터페이스 서비스 { get;  set; }

        
        public 제품수정2()
        {
            InitializeComponent();
            InitializeEvent();

        }

        private void InitializeEvent()
        {
            this.Shown += 제품수정2_Shown;
        }

        private void 제품수정2_Shown(object sender, EventArgs e)
        {
            textBox1.Text = SelectedRow.Cells["PRODUCTDEFINITIONID"].Value.ToString();
            textBox2.Text = SelectedRow.Cells["PRODUCTDEFINITIONNAME"].Value.ToString();
            textBox3.Text = SelectedRow.Cells["SITEID"].Value.ToString();
            textBox4.Text = SelectedRow.Cells["QTY"].Value.ToString();
            textBox5.Text = SelectedRow.Cells["UNITID"].Value.ToString();
            textBox6.Text = SelectedRow.Cells["PRODUCTDEFINITIONTYPE"].Value.ToString();
            textBox7.Text = SelectedRow.Cells["CUSTOMERID"].Value.ToString();
            textBox8.Text = SelectedRow.Cells["LOCATION"].Value.ToString();
            textBox9.Text = SelectedRow.Cells["MATERIALTYPE"].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string 쿼리 = @"SELECT * FROM CIM_PRODUCTDEFINITION
                            WHERE PRODUCTDEFINITIONID = '{0}'
                            AND PRODUCTDEFINITIONNAME = '{1}'";
            DataTable 결과 = 서비스.GetDataTable(string.Format(쿼리,this.textBox1.Text,this.textBox2.Text));
            if (결과.Rows.Count == 0)
            {
                Hashtable Param = new Hashtable();
                Param["PRODUCTDEFINITIONID"] = textBox1.Text.ToString();
                Param["PRODUCTDEFINITIONNAME"] = textBox2.Text.ToString();
                Param["SITEID"] = textBox3.Text.ToString();
                Param["QTY"] = textBox4.Text.ToString();
                Param["UNITID"] = textBox5.Text.ToString();
                Param["PRODUCTDEFINITIONTYPE"] = textBox6.Text.ToString();
                Param["CUSTOMERID"] = textBox7.Text.ToString();
                Param["LOCATION"] = textBox8.Text.ToString();
                Param["MATERIALTYPE"] = textBox9.Text.ToString();
                Param["MODIFYTIME"] = DateTime.Now;

                서비스.명령수행("제품수정2", Param);
            }
            else
            {
                Hashtable Param = new Hashtable();
                Param["PRODUCTDEFINITIONID"] = textBox1.Text.ToString();
                Param["PRODUCTDEFINITIONNAME"] = textBox2.Text.ToString();
                Param["SITEID"] = textBox3.Text.ToString();
                Param["QTY"] = textBox4.Text.ToString();
                Param["UNITID"] = textBox5.Text.ToString();
                Param["PRODUCTDEFINITIONTYPE"] = textBox6.Text.ToString();
                Param["CUSTOMERID"] = textBox7.Text.ToString();
                Param["LOCATION"] = textBox8.Text.ToString();
                Param["MATERIALTYPE"] = textBox9.Text.ToString();
                Param["MODIFYTIME"] = DateTime.Now;

                서비스.명령수행("제품수정3", Param);
            }
            

            조회();

        }

        private void 조회()
        {
            Hashtable Param = new Hashtable();
            Param["PRODUCTDEFINITIONID"] = textBox1.Text.ToString();
            Param["PRODUCTDEFINITIONNAME"] = textBox2.Text.ToString(); ;
            Param["SITEID"] = textBox3.Text.ToString();
            Param["QTY"] = textBox4.Text.ToString();
            Param["UNITID"] = textBox5.Text.ToString(); ;
            Param["PRODUCTDEFINITIONTYPE"] = textBox6.Text.ToString();
            Param["CUSTOMERID"] = textBox7.Text.ToString();
            Param["LOCATION"] = textBox8.Text.ToString();
            Param["MATERIALTYPE"] = textBox9.Text.ToString();
            Param["MODIFYTIME"] = DateTime.Now;
        }
    }
}
