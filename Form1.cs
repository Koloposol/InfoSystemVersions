using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InfoSystemVersions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadDb()
        {
            //Создаем соединение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\testDb.mdb";// строка соединения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);// создаем соединение

            //Запрос к бд
            dbConnection.Open();// открываем соединение
            string query = "SELECT * FROM [table]";// запрос
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда
            OleDbDataReader dbReader = dbCommand.ExecuteReader();// считываем данные

            //Проверяем данные
            if (dbReader.HasRows == false)
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            else
            {
                //Записываем данные в таблицу
                while (dbReader.Read())
                {
                    //Ввывод данных
                    dataGridView1.Rows.Add(dbReader["Id"], dbReader["Column1"], dbReader["Column2"], dbReader["Column3"]);
                }
            }

            //Закрываем соединение с бд
            dbReader.Close();
            dbConnection.Close();
        }

        private void AddData()
        {
            try
            {
                //Запоминаем выбранную строку
                int index = dataGridView1.SelectedRows[0].Index;

                //Проверка данных в таблице
                if (dataGridView1.Rows[index].Cells[1].Value == null ||
                    dataGridView1.Rows[index].Cells[2].Value == null ||
                    dataGridView1.Rows[index].Cells[3].Value == null)
                {
                    MessageBox.Show("Необходимо заполнить все ячейки!", "Внимание!");
                    return;
                }

                //Считываем данные
                string column1 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string column2 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string column3 = dataGridView1.Rows[index].Cells[3].Value.ToString();

                //Создаем соединение
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\testDb.mdb";// строка соединения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);// создаем соединение

                //Запрос к бд
                dbConnection.Open();// открываем соединение
                string query = $"INSERT INTO [table] ([column1], [column2], [column3]) VALUES ('{column1}', '{column2}', '{column3}')";// запрос
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                //Выполнение запроса
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка запрооса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Информмационная система");

                //Закрываем соединение с бд
                dbConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        private void UpdateData()
        {
            try
            {
                //Запоминаем выбранную строку
                int index = dataGridView1.SelectedRows[0].Index;

                //Проверка данных в таблице
                if (dataGridView1.Rows[index].Cells[1].Value == null ||
                    dataGridView1.Rows[index].Cells[2].Value == null ||
                    dataGridView1.Rows[index].Cells[3].Value == null)
                {
                    MessageBox.Show("Необходимо заполнить все ячейки!", "Внимание!");
                    return;
                }

                //Считываем данные
                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string column1 = dataGridView1.Rows[index].Cells[1].Value.ToString();
                string column2 = dataGridView1.Rows[index].Cells[2].Value.ToString();
                string column3 = dataGridView1.Rows[index].Cells[3].Value.ToString();

                //Создаем соединение
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\testDb.mdb";// строка соединения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);// создаем соединение

                //Запрос к бд
                dbConnection.Open();// открываем соединение
                string query = $"UPDATE [table] SET [column1]='{column1}', [column2]='{column2}', [column3]='{column3}' WHERE [id]={id}";// запрос
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                //Выполнение запроса
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка запрооса!", "Ошибка!");
                else
                    MessageBox.Show("Данные изменены!", "Информмационная система");

                //Закрываем соединение с бд
                dbConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        private void DeleteData()
        {
            try
            {
                //Запоминаем выбранную строку
                int index = dataGridView1.SelectedRows[0].Index;

                //Считываем данные
                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();


                //Создаем соединение
                string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=db\\testDb.mdb";// строка соединения
                OleDbConnection dbConnection = new OleDbConnection(connectionString);// создаем соединение

                //Запрос к бд
                dbConnection.Open();// открываем соединение
                string query = $"DELETE FROM [table] WHERE [id]={id}";// запрос
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);// команда

                //Выполнение запроса
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка запрооса!", "Ошибка!");
                else
                {
                    MessageBox.Show("Данные удалены!", "Информмационная система");
                    dataGridView1.Rows.RemoveAt(index);
                }

                //Закрываем соединение с бд
                dbConnection.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button_dowload_Click(object sender, EventArgs e)
        {
            //Отчищаем таблицу
            dataGridView1.Rows.Clear();

            //Загружаем бд
            LoadDb();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Добавляем данные в бд
            AddData();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            //Изменяем данные в бд
            UpdateData();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            //Удаляем данные из бд
            DeleteData();
        }
    }
}
