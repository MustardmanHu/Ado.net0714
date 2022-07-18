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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
        static public string ExecuteReader(string CommandText, string ReturnString, int Index)
        {
            SqlConnection SC = new SqlConnection();
            SC.ConnectionString = @"Data Source=.;Initial Catalog=ClassUse;Integrated Security=True";
            SC.Open();
            SqlCommand SCommand = new SqlCommand();
            SCommand.Connection = SC;
            SCommand.CommandText = CommandText;
            // 執行指令的程式碼:ExecuteReader()(有傳回值的指令)
            SqlDataReader R = SCommand.ExecuteReader();
            if (R.Read())//R.Read回傳是否有資料,true/false
            {
                ReturnString = R[Index].ToString();
            }
            return ReturnString;
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            string PassWord = "";
            string ActivateN_A ="";
            string Email = txt_Email.Text;
            string CT =
                $"Select[fPassword],[ActivatedN_A] from tCustomer Where fEmail='{Email}'";
            PassWord = ExecuteReader(CT,PassWord,0);
            ActivateN_A = ExecuteReader(CT, ActivateN_A, 1);
            // 執行指令的程式碼:ExecuteReader()(有傳回值的指令)
            string PassWords = txt_PassWord.Text ;
            PassWord=Regex.Replace(PassWord, @"\s", "");//刪除字串後面自動產生的空白
            if (PassWords == PassWord&&ActivateN_A=="1")
            {(new UI_frm()).Show();}
            else
            {MessageBox.Show("電子郵件不存在或密碼錯誤");}
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string CommandText =
              "INsert tCustomer" +
               $" ( [fEmail]," +
               $"[ActivatedN_A ]," +
               $"[fPassword] ) " +
               $"Values" +
               $"('{txt_Email.Text}'," +
               "1," +
               $"'{txt_PassWord.Text}')";
            ExecuteNonQuery(CommandText);
            MessageBox.Show("新增會員成功,請登入並填寫會員資料");
        }
    }
}
