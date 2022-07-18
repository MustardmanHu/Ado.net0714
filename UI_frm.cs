using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.net0714
{

    public partial class UI_frm : Form
    {
        static public void ExecuteNonQuery(string CommandText)
        {
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = @"Data Source=.;Initial Catalog=ClassUse;Integrated Security=True";
            SC.Open();
            SqlCommand SCommand = new SqlCommand();
            SCommand.Connection = SC;
            SCommand.CommandText = CommandText;
            SCommand.ExecuteNonQuery();
            SC.Close();
        }
        public string ExecuteReader(string CMText, string ReturnString, string Index)
        {
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = @"Data Source=.;Initial Catalog=ClassUse;Integrated Security=True";
            SC.Open();
            SqlCommand SCommand = new SqlCommand();
            SCommand.Connection = SC;
            SCommand.CommandText = CMText;
            // 執行指令的程式碼:ExecuteReader()(有傳回值的指令)
            SqlDataReader R = SCommand.ExecuteReader();
            while (R.Read())//R.Read回傳是否有資料,true/false
            {
                ReturnString = R[Index].ToString();
            }
            return ReturnString;
        }
        //public void ExecuteReader(string CMText)
        //{
        //    SqlConnection SC = new SqlConnection();
        //    SC.ConnectionString = @"Data Source=.;Initial Catalog=ClassUse;Integrated Security=True";
        //    SC.Open();
        //    SqlCommand SCommand = new SqlCommand();
        //    SCommand.Connection = SC;
        //    SCommand.CommandText = CMText;
        //    // 執行指令的程式碼:ExecuteReader()(有傳回值的指令)
        //    SqlDataReader R = SCommand.ExecuteReader();
        //    while (R.Read())//R.Read回傳是否有資料,true/false
        //    {
        //        txt_Name.Text = R["fname"].ToString();
        //        txt_Adr.Text = R["fAddress"].ToString();
        //        txt_Phone.Text = R["fPhone"].ToString();
        //        txt_PassWord.Text = R["fPassword"].ToString();
        //    }
        //}
        public UI_frm()
        {
            InitializeComponent();

        }
        new string Name;
        string Phone;
        string Email;
        string Address;
        Form1 Form1 = new Form1();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Names = listBox1.SelectedItem.ToString();
            string CMText = $"select * From tCustomer where fName='{Names}'";
            ExecuteReader(CMText,Name,"fName");

            ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string CMText = $"select fName From tCustomer";
            string NameItem = "";
            //ExecuteReader(CMText, NameItem, "fName");
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = @"Data Source=.;Initial Catalog=ClassUse;Integrated Security=True";
            SC.Open();
            SqlCommand SCommand = new SqlCommand();
            SCommand.Connection = SC;
            SCommand.CommandText = CMText;
            // 執行指令的程式碼:ExecuteReader()(有傳回值的指令)
            SqlDataReader R = SCommand.ExecuteReader();
            while (R.Read())//R.Read回傳是否有資料,true/false
            {
                NameItem = R["fName"].ToString();
                NameItems.Add(NameItem);
                listBox1.Items.Add(NameItem);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Name = txt_Name.Text;
            Phone = txt_Phone.Text;
            Address = txt_Adr.Text;
            string CommandText = $"Update tCustomer " + $"Set fName='{Name}'," +
           $"fPhone='{Phone}'," +
           $"fAddress='{Address}'," +
           $"fPassword='{txt_PassWord.Text}'" +
           $" where fEmail='{Email}'";
            ExecuteNonQuery(CommandText);
            MessageBox.Show("修改成功");
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("請先確認密碼正確");
            Name = txt_Name.Text;
            Phone = txt_Phone.Text;
            Address = txt_Adr.Text;
            string InsertPassWord = txt_PassWord.Text;
            string PassWord="";//從SQL找到的密碼
            string CT = "";
            PassWord = Regex.Replace(PassWord, @"\s", "");//刪除字串後面自動產生的空白
            if (InsertPassWord == PassWord)
            {
              string Text =
              $"use[ClassUse]Update tCustomer Set " +
              $"fName = '{Name}'," +
              $"fPhone = '{Phone}'," +
              $"fAddress = '{Address}'," +
              $"fPassword = '{InsertPassWord}'," +
              $"ActivatedN_A = 0 " +
              $"where fEmail = '{Form1.txt_Email.Text}'";
              ExecuteNonQuery(Text);
                MessageBox.Show("刪除成功");
            }
            else
            { MessageBox.Show("密碼錯誤");
              return;}
        }
        
        
        List<string> NameItems = new List<string>();

        

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKey frmkey = new FrmKey();
            frmkey.ShowDialog();
            if (frmkey.isOKButtonClicked)
            {
                string keyword = frmkey.keyword;
                string CMText =
                    $"select*from tCustomer " +
                    $" where " +
                    $"fName like '%{keyword}%' or " +
                    $"fAddress like '%{keyword}%' or " +
                    $"fPhone like '%{keyword}%' or " +
                    $" fEmail like '%{keyword}%'";
            }
        }

        
    }
}
