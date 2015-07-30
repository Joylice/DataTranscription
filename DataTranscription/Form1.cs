using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace DataTranscription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataBase(combDataBaseNew, 0, "");
            BindDataBase(combDataBaseOld, 0, "");
            
        }
        //获取新数据库 0 是数据库 1是 表
        private void BindDataBase(ComboBox combDataBase, int style, string database)
        {
            switch (style)
            {
                case 0:
                    {
                        string strSql = "select name from sysdatabases order by name";
                        combDataBase.DataSource = this.GetDataBases(strSql).Tables[0];
                        combDataBase.DisplayMember = "name";
                        combDataBase.ValueMember = "name";
                        break;
                    }
                case 1:
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendFormat("use {0}", database);
                        sb.AppendFormat(" SELECT Name from sysobjects Where Type='U' ORDER BY Name");
                        combDataBase.DataSource = this.GetDataBases(sb.ToString()).Tables[0];
                        combDataBase.ValueMember = "name";
                        combDataBase.DisplayMember = "name";
                        break;
                    }
            }
        }
        //获取数据库连接
        private SqlConnection GetConnections()
        {
            SqlConnectionStringBuilder sqlsb = new SqlConnectionStringBuilder();
            sqlsb.DataSource = "localhost";
            sqlsb.IntegratedSecurity = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = sqlsb.ConnectionString;
            return conn;
        }
        //根据查询语句，获取对应的数据集
        private DataSet GetDataBases(string strSql)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            using (SqlConnection conn = this.GetConnections())
            {
                conn.Open();
                cmd.CommandText = strSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                sda.SelectCommand = cmd;
                sda.Fill(ds, "databases");
                conn.Close()        ;
               
            }
            return ds;
        }
        private int GetDoIt(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            object b = null;
            using (SqlConnection conn = this.GetConnections())
            {
                conn.Open();
                cmd.CommandText = strSql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                b= cmd.ExecuteNonQuery();
                conn.Close();
            }
           return Convert.ToInt32(b);
        }
        private void btn_biaoOld_Click(object sender, EventArgs e)
        {
            BindDataBase(comOldtable, 1, combDataBaseOld.SelectedValue.ToString());

        }

        private void btn_biaoNew_Click(object sender, EventArgs e)
        {
            BindDataBase(comNewtable, 1, combDataBaseNew.SelectedValue.ToString());
        }
        //绑定grid控件
        public void GetTableZiDuan()
        {
            string strSql = string.Format("use {0}  Select Name FROM SysColumns Where id=Object_Id('{1}')", combDataBaseOld.SelectedValue, comOldtable.SelectedValue);
            this.dataGridView1.DataSource = GetDataBases(strSql).Tables[0];

        }
        //绑定combobox控件
        public void GetNewTableZiDuan()
        {
            string strSql = string.Format("use {0}  Select Name FROM SysColumns Where id=Object_Id('{1}')", combDataBaseNew.SelectedValue, comNewtable.SelectedValue);
            this.NewZiDuan.DataSource = GetDataBases(strSql).Tables[0];
            this.NewZiDuan.ValueMember = "name";
            this.NewZiDuan.DisplayMember = "name";
        }
        private void btn_OldZiDuan_Click(object sender, EventArgs e)
        {
            GetTableZiDuan();
        }

        private void btn_NewZiDuan_Click(object sender, EventArgs e)
        {
            GetNewTableZiDuan();
        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dataGridView1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataGridView1.Rows.Count; )
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Pink;
                    i += 2;
                }
            }
        }

        private void btn_StartZhuanLu_Click(object sender, EventArgs e)
        {
            List<string> oldList = new List<string>();
            List<string> newList = new List<string>();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                if ((bool)(((DataGridViewCheckBoxCell)this.dataGridView1.Rows[i].Cells["isTrue"]).EditedFormattedValue) == true)
                {
                    oldList.Add(dataGridView1.Rows[i].Cells["OldZiDuan"].Value.ToString());
                    newList.Add(((DataGridViewComboBoxCell)dataGridView1.Rows[i].Cells["NewZiDuan"]).Value.ToString());
                }
            }
           OldToNew(oldList,newList,"");
        }
        private void OldToNew(List<string> oldList, List<string> newList, string where)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("use {0}",combDataBaseOld.SelectedValue);
            sb.AppendFormat(" select ");
            for (int i = 0; i < oldList.Count; i++)
            {
                sb.AppendFormat(oldList[i] + ",");
            }
            sb.Remove(sb.ToString().LastIndexOf(','), 1);
            sb.AppendFormat(" from {0}", comOldtable.SelectedValue);
            if (!string.IsNullOrEmpty(where))
            {
                sb.AppendFormat(" where {0}", where);
            }
            MessageBox.Show(sb.ToString());
           DataTable dt= GetDataBases(sb.ToString()).Tables[0];
           if (dt.Rows.Count > 0)
           {
               int sum = 0;
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                 sum+=InsertNewDataBase(dt,i,newList,oldList);
               }
               if (sum == dt.Rows.Count)
               {
                   MessageBox.Show("数据转录成功");
               }
               else
               {
                   if (sum != 0)
                   {
                       MessageBox.Show("理论转录信息条数：" + dt.Rows.Count + "；实践转录信息条数：" + sum + ";实际转录条数与理论条数不符");
                   }
                   
               }
           }
           else 
           {
               MessageBox.Show("要转录的旧数据库，没有数据信息");
           }
        }
        private int  InsertNewDataBase(DataTable dt,int a,List<string> newList,List<string> oldList)
        {
            int sum = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("use {0}", combDataBaseNew.SelectedValue);
                sb.AppendFormat(" insert into {0} (", comNewtable.SelectedValue);
                for (int i = 0; i < newList.Count; i++)
                {
                    sb.AppendFormat(newList[i] + ",");
                }
                sb.Remove(sb.ToString().LastIndexOf(','), 1);
                sb.AppendFormat(")values(");
                for (int i = 0; i < oldList.Count; i++)
                {
                    sb.AppendFormat("'" + dt.Rows[a][oldList[i]] + "'" + ",");
                }
                sb.Remove(sb.ToString().LastIndexOf(','), 1);
                sb.AppendFormat(")");
                MessageBox.Show(sb.ToString());
                sum = GetDoIt(sb.ToString());
                return sum;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return sum;
            }
           
        }
    }
}