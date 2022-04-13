using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_BD
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cartoteka1DataSet8.Issues_books". При необходимости она может быть перемещена или удалена.
            this.issues_booksTableAdapter.Fill(this.cartoteka1DataSet8.Issues_books);

            //переименовать
            IssuedBooksDGV.Columns[0].HeaderCell.Value = "ID";
            IssuedBooksDGV.Columns[1].HeaderCell.Value = "ID книги";
            IssuedBooksDGV.Columns[2].HeaderCell.Value = "ID читателя";
            IssuedBooksDGV.Columns[3].HeaderCell.Value = "Дата выдачи";
            IssuedBooksDGV.Columns[4].HeaderCell.Value = "Дата возврата";
            IssuedBooksDGV.Columns[5].HeaderCell.Value = "Вернули";
        }

        private void PainBT_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;

            //Красный - подходит к дате возврата
            for (int i = 0; i < IssuedBooksDGV.RowCount; i++)
            {
                IssuedBooksDGV.Rows[i].Selected = false;
                if (IssuedBooksDGV.Rows[i].Cells[4].Value != null)
                {
                    for (int t = 0; t < 7; t++)
                    {
                        var d = DateTime.Today.AddDays(t);
                        if (IssuedBooksDGV.Rows[i].Cells[4].Value.ToString().Contains(d.ToString()))
                        {
                            string zn = IssuedBooksDGV.Rows[i].Cells[5].Value.ToString();
                            if (zn == "Нет")
                                IssuedBooksDGV.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            break;
                        }
                    }

                }
            }

            DateTime dt1 = DateTime.Now.Date;

            //Cерый - просрочен
            for (int i = 0; i < IssuedBooksDGV.RowCount; i++)
            {
                IssuedBooksDGV.Rows[i].Selected = false;
                if (IssuedBooksDGV.Rows[i].Cells[4].Value != null)
                {
                    for (int t = 0; t < 30; t++)
                    {
                        var dt = DateTime.Today.Subtract(new TimeSpan(t, 0, 0, 0));
                        if (IssuedBooksDGV.Rows[i].Cells[4].Value.ToString().Contains(dt.ToString()))
                        {
                            string zn = IssuedBooksDGV.Rows[i].Cells[5].Value.ToString();
                            if (zn == "Нет")
                                IssuedBooksDGV.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                            break;
                        }
                    }
                        
                }
            }
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < IssuedBooksDGV.RowCount; i++)
            {
                IssuedBooksDGV.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
