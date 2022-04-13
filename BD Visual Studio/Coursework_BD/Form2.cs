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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            //подключение
            string connectionString = $"Server=DESKTOP-UI4VHJA;Database=Cartoteka1;Trusted_Connection=True;";

            //запрос
            string sqlExpression = $"INSERT INTO Authors (Surname, Name, Patronymic, Initials) VALUES ('{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}')";
            
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
    }
}
