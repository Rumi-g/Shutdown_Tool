using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
　　　　　
            DialogResult dr = MessageBox.Show("本当によろしいですか？", "確認", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.ProcessStartInfo psi
                = new System.Diagnostics.ProcessStartInfo();
                psi.FileName = "shutdown.exe";

                // shutdown
                psi.Arguments = "-r -t 0";

                psi.CreateNoWindow = true;
                System.Diagnostics.Process p
                = System.Diagnostics.Process.Start(psi); ;
                Application.Exit();
             }
            else if (dr == System.Windows.Forms.DialogResult.No)
            {
                MessageBox.Show("キャンセルしました。");
                this.Close();
            }
            else
            {
                MessageBox.Show("Yes,No以外の動作");
                this.Close();
            };
            
       　 
        }
    }
}
