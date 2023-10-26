using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacary
{
    public partial class Form4 : Form
    {
        public Form4()
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
        public void SetListBox1(ListBox listBox)
        {
            foreach (var item in listBox.Items)
            {
                listBox2.Items.Add(item);
            }
            listBox2 = listBox;
        }
    }
}
