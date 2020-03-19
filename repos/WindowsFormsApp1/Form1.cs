using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("这是我的第一个C#窗体程序!");
            string res = RestClient.GetX("http://www.kuaidi100.com/query?type=ems&postid=1146732559175");
            textBox2.Text = res;
            textBox2.SelectionStart = textBox2.TextLength;
            textBox2.Focus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] musicList = { "爱你一万年", "风起时想你", "泪痕", "哭泣的小羊", "野狼DISCO", "下山" };
            for (int i = 0; i < musicList.Length; i++)
            {
                listView1.Items.Add(musicList[i]);
            }
            // listView1.ItemMouseHover += ListView1_ItemMouseHover;
            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
            insertDataBtn.Click += btnInsert_Click;
            queryDataBtn.Click += btnQuery_Click;
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                MessageBox.Show("你选择的歌曲是：" + e.Item.Text);
            }
            
        }

        private void ListView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            MessageBox.Show("你选择的歌曲是：" + e.Item.Text);
        }




        //查询按钮
        private void btnQuery_Click(object sender, EventArgs e)
        {

            /*  MySqlDataReader data= MysqlUtil.ExecuteReader(MysqlUtil.Conn, CommandType.Text, "select * from person", null);
              while (data.Read())
              {
                  string name = data.GetString("name");
                  int age = data.GetInt32("age");
                  char sex = data.GetChar("sex");


                  listView1.Items.Add(new ListViewItem(string.Format("{0}-{1}-{2}",name,age,sex)));
              }*/
            DataTable data = MysqlUtil.GetDataTable(MysqlUtil.Conn, CommandType.Text, "select * from person", null);
            List<Person> persons = MysqlUtil.DataTableToList<Person>(data);
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                string str = string.Format("{0}-{1}-{2}", p.Name, p.Age, p.Sex);
                listView1.Items.Add(str);
            }
        }


        //添加按钮
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string User = textBox1.Text;
            string PWD = textBox2.Text;
            MySqlConnection conn = new MySqlConnection(MysqlUtil.Conn);
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO person(name,age,sex) VALUES(@name,@age,@sex)";
                cmd.Parameters.AddWithValue("@name",nameInput.Text);
                cmd.Parameters.AddWithValue("@age", int.Parse(ageInput.Text));
                cmd.Parameters.AddWithValue("@sex", sexInput.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    //DataSet dataSet = MysqlUtil.GetDataSet(MysqlUtil.Conn, CommandType.Text, "select * from person", null);
                }
            }
        }
    }
}
