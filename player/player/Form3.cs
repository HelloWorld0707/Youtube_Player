using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace player
{
    public partial class Form3 : Form
    {
        Form2 form2 = null;
        string name;
        int index;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 form2, int index, string name)
        {
            InitializeComponent();

            // 컨트롤을 맨 위에 //
            this.TopMost = true;

            this.form2 = form2;
            this.name = name;
            this.index = index;
            textBox1.Text = name;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form2.set_Songs_name(index, textBox1.Text);
            this.Close();
        }
    }
}
