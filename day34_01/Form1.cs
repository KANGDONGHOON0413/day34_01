using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day34_01
{
    public partial class Form1 : Form
    {
        DataSet dataSet1;
        DataRelation dataRelation1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1 = new DataSet("info");
            dataSet1.Tables.Add(new DataTable("Table1"));
            dataSet1.Tables.Add(new DataTable("Table2"));

            //table1

            //Column생성
            DataColumn Col1;
            Col1 = new DataColumn("id", typeof(int));
            Col1.Unique = true;
            dataSet1.Tables[0].Columns.Add(Col1); //  dataSet1.Tables["Table1"].~~~~ 랑 같다
            dataSet1.Tables[0].PrimaryKey = new DataColumn[] { Col1 };

            Col1 = new DataColumn("pwd", typeof(string));
            Col1.MaxLength = 16;
            dataSet1.Tables[0].Columns.Add(Col1);

            Col1 = new DataColumn("name", typeof(string));
            Col1.MaxLength = 5;
            dataSet1.Tables[0].Columns.Add(Col1);

            //Row생성
            DataRow row1;
            row1 = dataSet1.Tables[0].NewRow();
            row1[0] = 201984001;
            row1[1] = "password";
            row1[2] = "강동훈";
            dataSet1.Tables[0].Rows.Add(row1);

            row1 = dataSet1.Tables[0].NewRow();
            row1[0] = 22220329;
            row1[1] = "alenee";
            row1[2] = "이준상";
            dataSet1.Tables[0].Rows.Add(row1);

            row1 = dataSet1.Tables[0].NewRow();
            row1[0] = 20220011;
            row1[1] = "irisas";
            row1[2] = "김훈";
            dataSet1.Tables[0].Rows.Add(row1);


            //table2

            //Column생성
            DataColumn Col2;
            Col2 = new DataColumn("주문번호", typeof(int));
            Col2.Unique = true;
            dataSet1.Tables[1].Columns.Add(Col2); 
            dataSet1.Tables[1].PrimaryKey = new DataColumn[] { Col2 };

            Col2 = new DataColumn("상품명", typeof(string));
            Col2.MaxLength = 16;
            dataSet1.Tables[1].Columns.Add(Col2);

            Col2 = new DataColumn("상품수량", typeof(int));
            dataSet1.Tables[1].Columns.Add(Col2);

            Col2 = new DataColumn("고객번호", typeof(int));
            dataSet1.Tables[1].Columns.Add(Col2);
            ForeignKeyConstraint FK = new ForeignKeyConstraint("FK", dataSet1.Tables[0].Columns["id"], Col2);

            //Row생성
            row1 = dataSet1.Tables[1].NewRow();
            row1[0] = 2022072501;
            row1[1] = "사과";
            row1[2] = 6;
            row1[3] = 201984001;
            dataSet1.Tables[1].Rows.Add(row1);

            row1 = dataSet1.Tables[1].NewRow();
            row1[0] = 2022072502;
            row1[1] = "바나나";
            row1[2] = 2;
            row1[3] = 201984001;
            dataSet1.Tables[1].Rows.Add(row1);

            row1 = dataSet1.Tables[1].NewRow();
            row1[0] = 2022072503;
            row1[1] = "사과";
            row1[2] = 1;
            row1[3] = 22220329;
            dataSet1.Tables[1].Rows.Add(row1);

            row1 = dataSet1.Tables[1].NewRow();
            row1[0] = 2022072504;
            row1[1] = "설탕";
            row1[2] = 2;
            row1[3] = 20220011;
            dataSet1.Tables[1].Rows.Add(row1);

            row1 = dataSet1.Tables[1].NewRow();
            row1[0] = 2022072505;
            row1[1] = "사과";
            row1[2] = 8;
            row1["고객번호"] = 20220011;
            dataSet1.Tables[1].Rows.Add(row1);

            //객체를 통한 관계 설정
            dataRelation1 = new DataRelation("ORDER", dataSet1.Tables[0].Columns["id"], dataSet1.Tables[1].Columns["고객번호"]);
            dataSet1.Relations.Add(dataRelation1);
            dataGridView1.DataSource = dataSet1.Tables[0];
            dataGridView2.DataSource = dataSet1.Tables[1];
        }

        private void BTN_CHECKORDER1_Click(object sender, EventArgs e)
        {
            int chkId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            DataRow[] people = dataSet1.Tables[0].Select("id ="+ chkId);
            DataRow[] Items = people[0].GetChildRows("ORDER");
            string Fruit = "";
            if(Items.Length > 0)
            {
                foreach(DataRow row in Items)
                {
                    Fruit += "주문번호: " + row["주문번호"].ToString();
                    Fruit += "  상품명: " + row["상품명"].ToString();
                    Fruit += "  상품수량: " + row["상품수량"].ToString();
                    Fruit += "\n";
                }
                MessageBox.Show(Fruit,"상품주문");
            }
        }

        private void BTN_CHECKORDER2_Click(object sender, EventArgs e)
        {
            int chkId = (int)dataGridView2.CurrentRow.Cells["고객번호"].Value;
            DataRow[] people = dataSet1.Tables[1].Select("고객번호 =" + chkId);
            DataRow Items = people[0].GetParentRow("ORDER");
            string odr = "이름: " + Items["name"].ToString();
                MessageBox.Show(odr, "상품주문");           
        }
    }
}
