
namespace Ado.net0714
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(444, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 72);
            this.button5.TabIndex = 4;
            this.button5.Text = "登入";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(148, 83);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(213, 22);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(148, 175);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(213, 22);
            this.txt_PassWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(444, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(228, 72);
            this.button6.TabIndex = 9;
            this.button6.Text = "新增會員";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Login_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.button5);
            this.Name = "Login_Frm";
            this.Text = "Login_Frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
    }
}

