using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bacary
{
    public partial class Form5 : Form
    {
        private SQLiteConnection connection;
        public Form5()
        {
            InitializeComponent();
            // Инициализация подключения к базе данных MenuPrice.db
            string menuDbPath = "Userlogin.db";
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
                    cmd.CommandText = "CREATE TABLE Users (ID INTEGER PRIMARY KEY AUTOINCREMENT, Lodin TEXT, Password TEXT);";
                    cmd.ExecuteNonQuery();

                    // Вставляем начальные данные в таблицу Menu
                    InsertInitialMenuData(cmd);
                }
            }

            // Загрузка данных из Menu в DataGridView
            LoadMenuDataToDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox2.Text != null)
            {
                // Получите значения из текстовых полей
                string name = textBox1.Text;
                string price = textBox2.Text;
                // SQL-запрос для вставки данных
                string query = "INSERT INTO Users (Login, Password) VALUES (@name, @price)";

                    // Создайте команду с параметрами
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@price", price);

                        // Выполните запрос
                        command.ExecuteNonQuery();

                        // Очистите текстовые поля после вставки
                        textBox1.Clear();
                        textBox2.Clear();

                        // Обновите DataGridView, чтобы отобразить новые данные
                        RefreshDataGridView();
                    }
                
            }
            else
            {
                MessageBox.Show("Измените значениz.");
            }

        }
        private void RefreshDataGridView()
        {
            // Предполагая, что dataGridView1 у вас уже связан с источником данных (например, DataTable)
            // Очистите существующие данные
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.Clear();

            // Загрузите данные из базы данных в DataTable
            string query = "SELECT * FROM Users";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            // Обновите DataGridView
            dataGridView1.Refresh();
        }
        private void InsertInitialMenuData(SQLiteCommand cmd)
        {

        }

        private void LoadMenuDataToDataGridView()
        {
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Users", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Устанавливаем источник данных для DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }

            // Установите ширину каждого столбца в DataGridView
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем выбранную строку
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Убеждаемся, что строка не является новой строкой для добавления
                if (!selectedRow.IsNewRow)
                {
                    // Удаляем выбранную строку
                    dataGridView1.Rows.Remove(selectedRow);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку в DataGridView перед удалением.", "Предупреждение");
            }
        }
    }
}


