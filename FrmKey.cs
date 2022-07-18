using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.net0714
{
    
    public partial class FrmKey : Form
    {
        
        public string keyword
        {
            get { return txt_KeyWord.Text; }
            set { keyword = value; }
        }

        public bool _isOKClicked = false;

        public FrmKey()
        {
            InitializeComponent();
        }
        public bool isOKButtonClicked 
        { 
            get { return _isOKClicked; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _isOKClicked = true;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
