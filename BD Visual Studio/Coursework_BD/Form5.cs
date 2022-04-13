using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_BD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            //подключение
            string connectionString = $"Server=DESKTOP-UI4VHJA;Database=Cartoteka1;Trusted_Connection=True;";

            //запрос
            string sqlExpression = $"INSERT INTO Issued_books (ID_book, ID_reader, Date_of_issue, Date_of_return, Returned) VALUES ('{Convert.ToInt32(textBox2.Text)}', '{Convert.ToInt32(textBox3.Text)}', '{Convert.ToDateTime(textBox4.Text)}', '{Convert.ToDateTime(textBox5.Text)}', '{comboBox1.Text}')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    //выводим названия столбцов
                    string columnName1 = reader.GetName(0);

                    while (reader.Read()) //построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                    }
                }

                reader.Close();
            }
            MessageBox.Show("Данные были внесены");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "Да", "Нет" });
        }
    }
}
