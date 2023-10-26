using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacary
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void SetListBoxResult(ListBox listBox)
        {
            foreach (var item in listBox.Items)
            {
                listBox1.Items.Add(item);
            }
            listBox1 = listBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox2.Items.Add($"Адрес доставки: {textBox1.Text}");
            listBox2.Items.Add($"Номер телефона: {textBox2.Text}");
            listBox2.Items.Add($"ФИО: {textBox3.Text}");

            
            
                Form4 form4 = new Form4();


                form4.SetListBoxResult(listBox1);
                form4.SetListBox1(listBox2);

                form4.Show();
                this.Hide();
            

        }

    }
}
