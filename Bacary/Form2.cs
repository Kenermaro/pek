using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bacary
{
    public partial class Form2 : Form
    {
        private SQLiteConnection connection;
        public Form2()
        {
            InitializeComponent();
            // Инициализация подключения к базе данных MenuPrice.db
            string menuDbPath = "MenuPrice.db";
            bool createMenuTable = false;

            if (!System.IO.File.Exists(menuDbPath))
            {
                createMenuTable = true;
                SQLiteConnection.CreateFile(menuDbPath);
            }

            connection = new SQLiteConnection($"Data Source={menuDbPath};");

            connection.Open();

            if (createMenuTable)
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Menu (Id INTEGER PRIMARY KEY, Name TEXT, Price REAL, Image BLOB);";
                    cmd.ExecuteNonQuery();

                    // Вставляем начальные данные в таблицу Menu
                    InsertInitialMenuData(cmd);
                }
            }
            LoadMenuDataToDataGridView();
        }
        private void InsertInitialMenuData(SQLiteCommand cmd)
        {

        }
        private void LoadMenuDataToDataGridView()
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }
        private void UpdateCheckedListBoxCount()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обработка изменений в CheckedListBox1
            UpdateCheckedListBoxCount();

            Form3 form3 = new Form3();

            form3.SetListBoxResult(listBox1);
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label2.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label12.Text} Цена: {label2.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label4.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label13.Text} Цена: {label4.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label6.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label14.Text} Цена: {label6.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label8.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label15.Text} Цена: {label18.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label10.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label16.Text} Цена: {label10.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel7.Hide();
            panel13.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel1.Hide();
            panel13.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel13.Show();
            panel7.Hide();
            panel1.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label33.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label32.Text} Цена: {label33.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label39.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label38.Text} Цена: {label39.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label45.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label34.Text} Цена: {label45.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label42.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label41.Text} Цена: {label42.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label36.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label35.Text} Цена: {label36.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label18.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label17.Text} Цена: {label18.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label24.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label23.Text} Цена: {label24.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label30.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label29.Text} Цена: {label30.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label27.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label26.Text} Цена: {label27.Text}");

            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label21.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
                listBox1.Items.Add($"{label20.Text} Цена: {label21.Text}");
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }


    }
}
