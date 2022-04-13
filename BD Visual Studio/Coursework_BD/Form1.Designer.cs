
namespace Coursework_BD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AuthorsDGV = new System.Windows.Forms.DataGridView();
            this.ReaderDGV = new System.Windows.Forms.DataGridView();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.GenreDGV = new System.Windows.Forms.DataGridView();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IssuedBooksDGV = new System.Windows.Forms.DataGridView();
            this.AuthorsLink = new System.Windows.Forms.LinkLabel();
            this.ReaderLink = new System.Windows.Forms.LinkLabel();
            this.BooksLink = new System.Windows.Forms.LinkLabel();
            this.IssuedBooksLink = new System.Windows.Forms.LinkLabel();
            this.GenreLink = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tipCB = new System.Windows.Forms.ComboBox();
            this.AddBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameStolbTB = new System.Windows.Forms.TextBox();
            this.table1CB = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.idStrokCB = new System.Windows.Forms.ComboBox();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.table2CB = new System.Windows.Forms.ComboBox();
            this.Поиск = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cartoteka1DataSet3 = new Coursework_BD.Cartoteka1DataSet3();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new Coursework_BD.Cartoteka1DataSet3TableAdapters.AuthorsTableAdapter();
            this.iDauthorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartoteka1DataSet4 = new Coursework_BD.Cartoteka1DataSet4();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Coursework_BD.Cartoteka1DataSet4TableAdapters.ReadersTableAdapter();
            this.iDreaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartoteka1DataSet5 = new Coursework_BD.Cartoteka1DataSet5();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Coursework_BD.Cartoteka1DataSet5TableAdapters.BooksTableAdapter();
            this.iDbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartoteka1DataSet6 = new Coursework_BD.Cartoteka1DataSet6();
            this.issuesbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issues_booksTableAdapter = new Coursework_BD.Cartoteka1DataSet6TableAdapters.Issues_booksTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDbookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDreaderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofreturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartoteka1DataSet7 = new Coursework_BD.Cartoteka1DataSet7();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresTableAdapter = new Coursework_BD.Cartoteka1DataSet7TableAdapters.GenresTableAdapter();
            this.iDgenresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Поиск.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesbooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorsDGV
            // 
            this.AuthorsDGV.AutoGenerateColumns = false;
            this.AuthorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDauthorsDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn});
            this.AuthorsDGV.DataSource = this.authorsBindingSource;
            this.AuthorsDGV.Location = new System.Drawing.Point(12, 28);
            this.AuthorsDGV.Name = "AuthorsDGV";
            this.AuthorsDGV.Size = new System.Drawing.Size(553, 189);
            this.AuthorsDGV.TabIndex = 0;
            // 
            // ReaderDGV
            // 
            this.ReaderDGV.AutoGenerateColumns = false;
            this.ReaderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReaderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDreaderDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.patronymicDataGridViewTextBoxColumn1,
            this.groupnumberDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.ReaderDGV.DataSource = this.readersBindingSource;
            this.ReaderDGV.Location = new System.Drawing.Point(584, 28);
            this.ReaderDGV.Name = "ReaderDGV";
            this.ReaderDGV.Size = new System.Drawing.Size(553, 189);
            this.ReaderDGV.TabIndex = 1;
            // 
            // BooksDGV
            // 
            this.BooksDGV.AutoGenerateColumns = false;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDbookDataGridViewTextBoxColumn,
            this.namebookDataGridViewTextBoxColumn,
            this.initialsDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.BooksDGV.DataSource = this.booksBindingSource;
            this.BooksDGV.Location = new System.Drawing.Point(12, 243);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.Size = new System.Drawing.Size(553, 189);
            this.BooksDGV.TabIndex = 2;
            // 
            // GenreDGV
            // 
            this.GenreDGV.AutoGenerateColumns = false;
            this.GenreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenreDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDgenresDataGridViewTextBoxColumn,
            this.genresDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn1});
            this.GenreDGV.DataSource = this.genresBindingSource;
            this.GenreDGV.Location = new System.Drawing.Point(12, 463);
            this.GenreDGV.Name = "GenreDGV";
            this.GenreDGV.Size = new System.Drawing.Size(553, 189);
            this.GenreDGV.TabIndex = 4;
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(585, 476);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(121, 58);
            this.UpdateBT.TabIndex = 5;
            this.UpdateBT.Text = "Обновить таблицы";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Авторы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Читатели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Книги на руках";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Жанры";
            // 
            // IssuedBooksDGV
            // 
            this.IssuedBooksDGV.AutoGenerateColumns = false;
            this.IssuedBooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedBooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDbookDataGridViewTextBoxColumn1,
            this.iDreaderDataGridViewTextBoxColumn1,
            this.dateofissuedDataGridViewTextBoxColumn,
            this.dateofreturnDataGridViewTextBoxColumn,
            this.returnedDataGridViewTextBoxColumn});
            this.IssuedBooksDGV.DataSource = this.issuesbooksBindingSource;
            this.IssuedBooksDGV.Location = new System.Drawing.Point(584, 243);
            this.IssuedBooksDGV.Name = "IssuedBooksDGV";
            this.IssuedBooksDGV.Size = new System.Drawing.Size(553, 189);
            this.IssuedBooksDGV.TabIndex = 16;
            // 
            // AuthorsLink
            // 
            this.AuthorsLink.AutoSize = true;
            this.AuthorsLink.Location = new System.Drawing.Point(409, 9);
            this.AuthorsLink.Name = "AuthorsLink";
            this.AuthorsLink.Size = new System.Drawing.Size(156, 13);
            this.AuthorsLink.TabIndex = 17;
            this.AuthorsLink.TabStop = true;
            this.AuthorsLink.Text = "Добавить запись в \"Авторы\"";
            this.AuthorsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorsLink_LinkClicked);
            // 
            // ReaderLink
            // 
            this.ReaderLink.AutoSize = true;
            this.ReaderLink.Location = new System.Drawing.Point(971, 9);
            this.ReaderLink.Name = "ReaderLink";
            this.ReaderLink.Size = new System.Drawing.Size(166, 13);
            this.ReaderLink.TabIndex = 18;
            this.ReaderLink.TabStop = true;
            this.ReaderLink.Text = "Добавить запись в \"Читатели\"";
            this.ReaderLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReaderLink_LinkClicked);
            // 
            // BooksLink
            // 
            this.BooksLink.AutoSize = true;
            this.BooksLink.Location = new System.Drawing.Point(417, 227);
            this.BooksLink.Name = "BooksLink";
            this.BooksLink.Size = new System.Drawing.Size(148, 13);
            this.BooksLink.TabIndex = 19;
            this.BooksLink.TabStop = true;
            this.BooksLink.Text = "Добавить запись в \"Книги\"";
            this.BooksLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BooksLink_LinkClicked);
            // 
            // IssuedBooksLink
            // 
            this.IssuedBooksLink.AutoSize = true;
            this.IssuedBooksLink.Location = new System.Drawing.Point(943, 227);
            this.IssuedBooksLink.Name = "IssuedBooksLink";
            this.IssuedBooksLink.Size = new System.Drawing.Size(194, 13);
            this.IssuedBooksLink.TabIndex = 20;
            this.IssuedBooksLink.TabStop = true;
            this.IssuedBooksLink.Text = "Добавить запись в \"Книги на руках\"";
            this.IssuedBooksLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IssuedBooksLink_LinkClicked);
            // 
            // GenreLink
            // 
            this.GenreLink.AutoSize = true;
            this.GenreLink.Location = new System.Drawing.Point(409, 447);
            this.GenreLink.Name = "GenreLink";
            this.GenreLink.Size = new System.Drawing.Size(155, 13);
            this.GenreLink.TabIndex = 21;
            this.GenreLink.TabStop = true;
            this.GenreLink.Text = "Добавить запись в \"Жанры\"";
            this.GenreLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GenreLink_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Поиск);
            this.tabControl1.Location = new System.Drawing.Point(728, 447);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 205);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tipCB);
            this.tabPage1.Controls.Add(this.AddBT);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nameStolbTB);
            this.tabPage1.Controls.Add(this.table1CB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Выберете тип столбца:";
            // 
            // tipCB
            // 
            this.tipCB.FormattingEnabled = true;
            this.tipCB.Location = new System.Drawing.Point(31, 114);
            this.tipCB.Name = "tipCB";
            this.tipCB.Size = new System.Drawing.Size(121, 21);
            this.tipCB.TabIndex = 31;
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(217, 94);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(121, 58);
            this.AddBT.TabIndex = 30;
            this.AddBT.Text = "Добавить столбец";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Название столбца:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Выберете таблицу";
            // 
            // nameStolbTB
            // 
            this.nameStolbTB.Location = new System.Drawing.Point(201, 45);
            this.nameStolbTB.Name = "nameStolbTB";
            this.nameStolbTB.Size = new System.Drawing.Size(148, 20);
            this.nameStolbTB.TabIndex = 27;
            // 
            // table1CB
            // 
            this.table1CB.FormattingEnabled = true;
            this.table1CB.Location = new System.Drawing.Point(31, 44);
            this.table1CB.Name = "table1CB";
            this.table1CB.Size = new System.Drawing.Size(121, 21);
            this.table1CB.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.numberTB);
            this.tabPage2.Controls.Add(this.idStrokCB);
            this.tabPage2.Controls.Add(this.DeleteBT);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.table2CB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удалить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Номер:";
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(201, 45);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(148, 20);
            this.numberTB.TabIndex = 37;
            // 
            // idStrokCB
            // 
            this.idStrokCB.FormattingEnabled = true;
            this.idStrokCB.Location = new System.Drawing.Point(31, 114);
            this.idStrokCB.Name = "idStrokCB";
            this.idStrokCB.Size = new System.Drawing.Size(121, 21);
            this.idStrokCB.TabIndex = 36;
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(217, 94);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(121, 58);
            this.DeleteBT.TabIndex = 35;
            this.DeleteBT.Text = "Удалить строку";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "ID строки";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Выберете таблицу";
            // 
            // table2CB
            // 
            this.table2CB.FormattingEnabled = true;
            this.table2CB.Location = new System.Drawing.Point(31, 44);
            this.table2CB.Name = "table2CB";
            this.table2CB.Size = new System.Drawing.Size(121, 21);
            this.table2CB.TabIndex = 31;
            // 
            // Поиск
            // 
            this.Поиск.Controls.Add(this.label12);
            this.Поиск.Controls.Add(this.textBox1);
            this.Поиск.Controls.Add(this.SearchBT);
            this.Поиск.Location = new System.Drawing.Point(4, 22);
            this.Поиск.Name = "Поиск";
            this.Поиск.Padding = new System.Windows.Forms.Padding(3);
            this.Поиск.Size = new System.Drawing.Size(390, 179);
            this.Поиск.TabIndex = 2;
            this.Поиск.Text = "Поиск";
            this.Поиск.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Введите значение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 40;
            // 
            // SearchBT
            // 
            this.SearchBT.Location = new System.Drawing.Point(134, 99);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(121, 58);
            this.SearchBT.TabIndex = 39;
            this.SearchBT.Text = "Начать поиск";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 58);
            this.button1.TabIndex = 26;
            this.button1.Text = "Даты возврата книг";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cartoteka1DataSet3
            // 
            this.cartoteka1DataSet3.DataSetName = "Cartoteka1DataSet3";
            this.cartoteka1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.cartoteka1DataSet3;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // iDauthorsDataGridViewTextBoxColumn
            // 
            this.iDauthorsDataGridViewTextBoxColumn.DataPropertyName = "ID_authors";
            this.iDauthorsDataGridViewTextBoxColumn.HeaderText = "ID_authors";
            this.iDauthorsDataGridViewTextBoxColumn.Name = "iDauthorsDataGridViewTextBoxColumn";
            this.iDauthorsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // initialsDataGridViewTextBoxColumn
            // 
            this.initialsDataGridViewTextBoxColumn.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn.Name = "initialsDataGridViewTextBoxColumn";
            // 
            // cartoteka1DataSet4
            // 
            this.cartoteka1DataSet4.DataSetName = "Cartoteka1DataSet4";
            this.cartoteka1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.cartoteka1DataSet4;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // iDreaderDataGridViewTextBoxColumn
            // 
            this.iDreaderDataGridViewTextBoxColumn.DataPropertyName = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn.HeaderText = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn.Name = "iDreaderDataGridViewTextBoxColumn";
            this.iDreaderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // patronymicDataGridViewTextBoxColumn1
            // 
            this.patronymicDataGridViewTextBoxColumn1.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn1.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn1.Name = "patronymicDataGridViewTextBoxColumn1";
            // 
            // groupnumberDataGridViewTextBoxColumn
            // 
            this.groupnumberDataGridViewTextBoxColumn.DataPropertyName = "Group_number";
            this.groupnumberDataGridViewTextBoxColumn.HeaderText = "Group_number";
            this.groupnumberDataGridViewTextBoxColumn.Name = "groupnumberDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // cartoteka1DataSet5
            // 
            this.cartoteka1DataSet5.DataSetName = "Cartoteka1DataSet5";
            this.cartoteka1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.cartoteka1DataSet5;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // iDbookDataGridViewTextBoxColumn
            // 
            this.iDbookDataGridViewTextBoxColumn.DataPropertyName = "ID_book";
            this.iDbookDataGridViewTextBoxColumn.HeaderText = "ID_book";
            this.iDbookDataGridViewTextBoxColumn.Name = "iDbookDataGridViewTextBoxColumn";
            this.iDbookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namebookDataGridViewTextBoxColumn
            // 
            this.namebookDataGridViewTextBoxColumn.DataPropertyName = "Name_book";
            this.namebookDataGridViewTextBoxColumn.HeaderText = "Name_book";
            this.namebookDataGridViewTextBoxColumn.Name = "namebookDataGridViewTextBoxColumn";
            // 
            // initialsDataGridViewTextBoxColumn1
            // 
            this.initialsDataGridViewTextBoxColumn1.DataPropertyName = "Initials";
            this.initialsDataGridViewTextBoxColumn1.HeaderText = "Initials";
            this.initialsDataGridViewTextBoxColumn1.Name = "initialsDataGridViewTextBoxColumn1";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "Quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "Quntity";
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // cartoteka1DataSet6
            // 
            this.cartoteka1DataSet6.DataSetName = "Cartoteka1DataSet6";
            this.cartoteka1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuesbooksBindingSource
            // 
            this.issuesbooksBindingSource.DataMember = "Issues_books";
            this.issuesbooksBindingSource.DataSource = this.cartoteka1DataSet6;
            // 
            // issues_booksTableAdapter
            // 
            this.issues_booksTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDbookDataGridViewTextBoxColumn1
            // 
            this.iDbookDataGridViewTextBoxColumn1.DataPropertyName = "ID_book";
            this.iDbookDataGridViewTextBoxColumn1.HeaderText = "ID_book";
            this.iDbookDataGridViewTextBoxColumn1.Name = "iDbookDataGridViewTextBoxColumn1";
            // 
            // iDreaderDataGridViewTextBoxColumn1
            // 
            this.iDreaderDataGridViewTextBoxColumn1.DataPropertyName = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn1.HeaderText = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn1.Name = "iDreaderDataGridViewTextBoxColumn1";
            // 
            // dateofissuedDataGridViewTextBoxColumn
            // 
            this.dateofissuedDataGridViewTextBoxColumn.DataPropertyName = "Date_of_issued";
            this.dateofissuedDataGridViewTextBoxColumn.HeaderText = "Date_of_issued";
            this.dateofissuedDataGridViewTextBoxColumn.Name = "dateofissuedDataGridViewTextBoxColumn";
            // 
            // dateofreturnDataGridViewTextBoxColumn
            // 
            this.dateofreturnDataGridViewTextBoxColumn.DataPropertyName = "Date_of_return";
            this.dateofreturnDataGridViewTextBoxColumn.HeaderText = "Date_of_return";
            this.dateofreturnDataGridViewTextBoxColumn.Name = "dateofreturnDataGridViewTextBoxColumn";
            // 
            // returnedDataGridViewTextBoxColumn
            // 
            this.returnedDataGridViewTextBoxColumn.DataPropertyName = "Returned";
            this.returnedDataGridViewTextBoxColumn.HeaderText = "Returned";
            this.returnedDataGridViewTextBoxColumn.Name = "returnedDataGridViewTextBoxColumn";
            // 
            // cartoteka1DataSet7
            // 
            this.cartoteka1DataSet7.DataSetName = "Cartoteka1DataSet7";
            this.cartoteka1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.cartoteka1DataSet7;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // iDgenresDataGridViewTextBoxColumn
            // 
            this.iDgenresDataGridViewTextBoxColumn.DataPropertyName = "ID_genres";
            this.iDgenresDataGridViewTextBoxColumn.HeaderText = "ID_genres";
            this.iDgenresDataGridViewTextBoxColumn.Name = "iDgenresDataGridViewTextBoxColumn";
            this.iDgenresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genresDataGridViewTextBoxColumn
            // 
            this.genresDataGridViewTextBoxColumn.DataPropertyName = "Genres";
            this.genresDataGridViewTextBoxColumn.HeaderText = "Genres";
            this.genresDataGridViewTextBoxColumn.Name = "genresDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GenreLink);
            this.Controls.Add(this.IssuedBooksLink);
            this.Controls.Add(this.BooksLink);
            this.Controls.Add(this.ReaderLink);
            this.Controls.Add(this.AuthorsLink);
            this.Controls.Add(this.IssuedBooksDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.GenreDGV);
            this.Controls.Add(this.BooksDGV);
            this.Controls.Add(this.ReaderDGV);
            this.Controls.Add(this.AuthorsDGV);
            this.Name = "Form1";
            this.Text = "Студенческая картотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReaderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenreDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Поиск.ResumeLayout(false);
            this.Поиск.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesbooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorsDGV;
        private System.Windows.Forms.DataGridView ReaderDGV;
        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.DataGridView GenreDGV;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView IssuedBooksDGV;
        private System.Windows.Forms.LinkLabel AuthorsLink;
        private System.Windows.Forms.LinkLabel ReaderLink;
        private System.Windows.Forms.LinkLabel BooksLink;
        private System.Windows.Forms.LinkLabel IssuedBooksLink;
        private System.Windows.Forms.LinkLabel GenreLink;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tipCB;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameStolbTB;
        private System.Windows.Forms.ComboBox table1CB;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox table2CB;
        private System.Windows.Forms.ComboBox idStrokCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Поиск;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchBT;
        private Cartoteka1DataSet3 cartoteka1DataSet3;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private Cartoteka1DataSet3TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDauthorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn;
        private Cartoteka1DataSet4 cartoteka1DataSet4;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private Cartoteka1DataSet4TableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDreaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private Cartoteka1DataSet5 cartoteka1DataSet5;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Cartoteka1DataSet5TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private Cartoteka1DataSet6 cartoteka1DataSet6;
        private System.Windows.Forms.BindingSource issuesbooksBindingSource;
        private Cartoteka1DataSet6TableAdapters.Issues_booksTableAdapter issues_booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbookDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDreaderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofreturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDataGridViewTextBoxColumn;
        private Cartoteka1DataSet7 cartoteka1DataSet7;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private Cartoteka1DataSet7TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDgenresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
    }
}

