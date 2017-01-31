using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Message_Generator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBox1.ShortcutsEnabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word text = new Word(textBox2.Text);
            if (checkBox1.Checked)
                textBox1.Text = text.Write();
            else
                textBox1.Text = text.ConvertToString(text.Combine());
        }

    }
}
