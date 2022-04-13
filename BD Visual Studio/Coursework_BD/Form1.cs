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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet7.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.cartoteka1DataSet7.Genres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet6.Issues_books". При необходимости она может быть перемещена или удалена.
            this.issues_booksTableAdapter.Fill(this.cartoteka1DataSet6.Issues_books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet5.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.cartoteka1DataSet5.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet4.Readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.cartoteka1DataSet4.Readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet3.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this.cartoteka1DataSet3.Authors);


            //Изменение название столбцов
            AuthorsDGV.Columns[0].HeaderCell.Value = "ID автора";
            AuthorsDGV.Columns[1].HeaderCell.Value = "Фамилия";
            AuthorsDGV.Columns[2].HeaderCell.Value = "Имя";
            AuthorsDGV.Columns[3].HeaderCell.Value = "Отчество";
            AuthorsDGV.Columns[4].HeaderCell.Value = "Инициалы";

            ReaderDGV.Columns[0].HeaderCell.Value = "ID читателя";
            ReaderDGV.Columns[1].HeaderCell.Value = "Фамиилия";
            ReaderDGV.Columns[2].HeaderCell.Value = "Имя";
            ReaderDGV.Columns[3].HeaderCell.Value = "Отчество";
            ReaderDGV.Columns[4].HeaderCell.Value = "Группа";
            ReaderDGV.Columns[5].HeaderCell.Value = "Номер телефона";

            BooksDGV.Columns[0].HeaderCell.Value = "ID книги";
            BooksDGV.Columns[1].HeaderCell.Value = "Название";
            BooksDGV.Columns[2].HeaderCell.Value = "Инициалы автора";
            BooksDGV.Columns[3].HeaderCell.Value = "Жанр";
            BooksDGV.Columns[4].HeaderCell.Value = "Количество";
            BooksDGV.Columns[5].HeaderCell.Value = "Стоимость";

            IssuedBooksDGV.Columns[0].HeaderCell.Value = "ID";
            IssuedBooksDGV.Columns[1].HeaderCell.Value = "ID книги";
            IssuedBooksDGV.Columns[2].HeaderCell.Value = "ID читателя";
            IssuedBooksDGV.Columns[3].HeaderCell.Value = "Дата выдачи";
            IssuedBooksDGV.Columns[4].HeaderCell.Value = "Дата возврата";
            IssuedBooksDGV.Columns[5].HeaderCell.Value = "Вернули";

            GenreDGV.Columns[0].HeaderCell.Value = "ID жанра";
            GenreDGV.Columns[1].HeaderCell.Value = "Жанр";

            //combox
            table1CB.Items.AddRange(new object[] { "Authors", "Readers", "Books", "Issued_books", "Genres" });
            table2CB.Items.AddRange(new object[] { "Authors", "Readers", "Books", "Issued_books", "Genres" });
            idStrokCB.Items.AddRange(new object[] { "ID_authors", "ID_reader", "ID_book", "ID", "ID_genres" });
            tipCB.Items.AddRange(new object[] { "int", "nvarchar(30)", "money" });
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            this.genresTableAdapter.Fill(this.cartoteka1DataSet7.Genres);
            this.issues_booksTableAdapter.Fill(this.cartoteka1DataSet6.Issues_books);
            this.booksTableAdapter.Fill(this.cartoteka1DataSet5.Books);
            this.readersTableAdapter.Fill(this.cartoteka1DataSet4.Readers);
            this.authorsTableAdapter.Fill(this.cartoteka1DataSet3.Authors);
        }


        private void AuthorsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 my_Form2 = new Form2();
            my_Form2.Show();
        }

        private void ReaderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 my_Form3 = new Form3();
            my_Form3.Show();
        }

        private void BooksLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 my_Form4 = new Form4();
            my_Form4.Show();
        }

        private void IssuedBooksLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 my_Form5 = new Form5();
            my_Form5.Show();
        }

        private void GenreLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 my_Form6 = new Form6();
            my_Form6.Show();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            //подключение
            string connectionString = $"Server=DESKTOP-UI4VHJA;Database=Cartoteka1;Trusted_Connection=True;";

            //запрос
            string sqlExpression = $"ALTER TABLE {table1CB.Text} ADD '{nameStolbTB.Text} {tipCB.Text}";

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
            MessageBox.Show("Данные были добавлены");

        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
           
            //подключение
            string connectionString = $"Server=DESKTOP-UI4VHJA;Database=Cartoteka1;Trusted_Connection=True;";

            //запрос
            string sqlExpression = $"delete from {table2CB.Text} Where {idStrokCB.Text} = {numberTB.Text}";


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

            MessageBox.Show("Данные были удалены");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 my_Form8 = new Form8();
            my_Form8.Show();
        }

        //поиск
        private void SearchBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AuthorsDGV.RowCount; i++)
            {
                AuthorsDGV.Rows[i].Selected = false;
                for (int j = 0; j < AuthorsDGV.ColumnCount; j++)
                    if (AuthorsDGV.Rows[i].Cells[j].Value != null)
                        if (AuthorsDGV.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            AuthorsDGV.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < ReaderDGV.RowCount; i++)
            {
                ReaderDGV.Rows[i].Selected = false;
                for (int j = 0; j < ReaderDGV.ColumnCount; j++)
                    if (ReaderDGV.Rows[i].Cells[j].Value != null)
                        if (ReaderDGV.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            ReaderDGV.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < BooksDGV.RowCount; i++)
            {
                BooksDGV.Rows[i].Selected = false;
                for (int j = 0; j < BooksDGV.ColumnCount; j++)
                    if (BooksDGV.Rows[i].Cells[j].Value != null)
                        if (BooksDGV.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            BooksDGV.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < IssuedBooksDGV.RowCount; i++)
            {
                IssuedBooksDGV.Rows[i].Selected = false;
                for (int j = 0; j < IssuedBooksDGV.ColumnCount; j++)
                    if (IssuedBooksDGV.Rows[i].Cells[j].Value != null)
                        if (IssuedBooksDGV.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            IssuedBooksDGV.Rows[i].Selected = true;
                            break;
                        }
            }

            for (int i = 0; i < GenreDGV.RowCount; i++)
            {
                GenreDGV.Rows[i].Selected = false;
                for (int j = 0; j < GenreDGV.ColumnCount; j++)
                    if (GenreDGV.Rows[i].Cells[j].Value != null)
                        if (GenreDGV.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            GenreDGV.Rows[i].Selected = true;
                            break;
                        }
            }

        }
    }
}
