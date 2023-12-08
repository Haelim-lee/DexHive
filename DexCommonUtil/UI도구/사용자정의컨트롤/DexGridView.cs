using DexServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DexCommonUtil.UI도구.사용자정의컨트롤
{
    public enum 컬럼타입
    {
        텍스트박스,
        콤보박스,
        체크박스,
        버튼
        
    }
    public class DexGridView : DataGridView
    {
        public string 기본테이블명 { get; set; }
        public DataTable 원본표 {get;set;}

        public DexGridView()
        {
            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            원본표 = new DataTable();
        }

        public void 열생성(DexGridColumn[] 컬럼들)
        {
            this.Columns.Clear(); 
            foreach (DexGridColumn 컬럼 in 컬럼들)
            {
                switch (컬럼.컬럼타입)
                {
                    case 컬럼타입.콤보박스:
                        this.Columns.Add(new DataGridViewComboBoxColumn()
                        { 
                            Name = 컬럼.컬럼명, HeaderText = 컬럼.헤더명,
                            DataSource = 컬럼.콤보박스데이터소스 ,
                            DisplayMember = 컬럼.콤보박스디스플레이멤버,
                            ValueMember = 컬럼.콤보박스벨류멤버,
                            DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                });
                        
                        break;
                    case 컬럼타입.체크박스:
                        this.Columns.Add(new DataGridViewCheckBoxColumn() { Name = 컬럼.컬럼명, HeaderText = 컬럼.헤더명 });
                        break;
                    case 컬럼타입.텍스트박스:
                        this.Columns.Add(new DataGridViewTextBoxColumn() { Name = 컬럼.컬럼명, HeaderText = 컬럼.헤더명 });
                        break;
                    case 컬럼타입.버튼:
                        this.Columns.Add(new DataGridViewButtonColumn() { Name = 컬럼.컬럼명, HeaderText = 컬럼.헤더명, UseColumnTextForButtonValue = true, Text = 컬럼.헤더명 }) ;
                        break;
                    default:
                        this.Columns.Add(컬럼.컬럼명, 컬럼.헤더명);
                        break;
                }
                this.Columns[컬럼.컬럼명].Width = 컬럼.너비;
                this.Columns[컬럼.컬럼명].DataPropertyName = 컬럼.컬럼명;
                
            }
        }

        public void 반영(DataTable 반영표,I서버인터페이스 서비스)
        {
            for (int RowCount = 0; RowCount < 반영표.Rows.Count; RowCount++)
                행처리(RowCount, 반영표,this.원본표, 기본테이블명, 서비스);
        }

        public void 바인딩(DataTable Source)
        {
            this.DataSource = Source;
            this.원본표 = Source.Copy();
        }



        private void 행처리(int Index, DataTable 반영표, DataTable 원본표, string 테이블명, I서버인터페이스 서비스)
        {
            Hashtable OldValue = new Hashtable();
            Hashtable NewValue = new Hashtable();
            OldValue.Clear();
            NewValue.Clear();


            if (반영표.Rows[Index].RowState != DataRowState.Deleted)
            {
                for (int i = 0; i < 반영표.Columns.Count; i++)
                    NewValue.Add(반영표.Columns[i].ColumnName, (반영표.Rows[Index][i] == DBNull.Value) ? "#NULL#" : (반영표.Rows[Index][i]));
            }
            if (반영표.Rows[Index].RowState != DataRowState.Added)
                for (int i = 0; i < 원본표.Columns.Count; i++)
                    OldValue.Add(원본표.Columns[i].ColumnName, (원본표.Rows[Index][i] == DBNull.Value) ? "#NULL#" : (원본표.Rows[Index][i]));

            서비스.Flag처리(테이블명, NewValue, OldValue, 반영표.Rows[Index].RowState);
        }
    }
}
