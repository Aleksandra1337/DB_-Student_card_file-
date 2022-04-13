
namespace Coursework_BD
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IssuedBooksDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PainBT = new System.Windows.Forms.Button();
            this.ClearBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cartoteka1DataSet8 = new Coursework_BD.Cartoteka1DataSet8();
            this.issuesbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issues_booksTableAdapter = new Coursework_BD.Cartoteka1DataSet8TableAdapters.Issues_booksTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDbookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDreaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofissuedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofreturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesbooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // IssuedBooksDGV
            // 
            this.IssuedBooksDGV.AutoGenerateColumns = false;
            this.IssuedBooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssuedBooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDbookDataGridViewTextBoxColumn,
            this.iDreaderDataGridViewTextBoxColumn,
            this.dateofissuedDataGridViewTextBoxColumn,
            this.dateofreturnDataGridViewTextBoxColumn,
            this.returnedDataGridViewTextBoxColumn});
            this.IssuedBooksDGV.DataSource = this.issuesbooksBindingSource;
            this.IssuedBooksDGV.Location = new System.Drawing.Point(12, 39);
            this.IssuedBooksDGV.Name = "IssuedBooksDGV";
            this.IssuedBooksDGV.Size = new System.Drawing.Size(603, 224);
            this.IssuedBooksDGV.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Таблица книг";
            // 
            // PainBT
            // 
            this.PainBT.Location = new System.Drawing.Point(320, 279);
            this.PainBT.Name = "PainBT";
            this.PainBT.Size = new System.Drawing.Size(121, 58);
            this.PainBT.TabIndex = 19;
            this.PainBT.Text = "Показать состояние";
            this.PainBT.UseVisualStyleBackColor = true;
            this.PainBT.Click += new System.EventHandler(this.PainBT_Click);
            // 
            // ClearBT
            // 
            this.ClearBT.Location = new System.Drawing.Point(466, 279);
            this.ClearBT.Name = "ClearBT";
            this.ClearBT.Size = new System.Drawing.Size(121, 58);
            this.ClearBT.TabIndex = 21;
            this.ClearBT.Text = "Очистить состояние";
            this.ClearBT.UseVisualStyleBackColor = true;
            this.ClearBT.Click += new System.EventHandler(this.ClearBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Красный - дата возврата подходит к концу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Серый - дата возврата просрочена";
            // 
            // cartoteka1DataSet8
            // 
            this.cartoteka1DataSet8.DataSetName = "Cartoteka1DataSet8";
            this.cartoteka1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuesbooksBindingSource
            // 
            this.issuesbooksBindingSource.DataMember = "Issues_books";
            this.issuesbooksBindingSource.DataSource = this.cartoteka1DataSet8;
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
            // iDbookDataGridViewTextBoxColumn
            // 
            this.iDbookDataGridViewTextBoxColumn.DataPropertyName = "ID_book";
            this.iDbookDataGridViewTextBoxColumn.HeaderText = "ID_book";
            this.iDbookDataGridViewTextBoxColumn.Name = "iDbookDataGridViewTextBoxColumn";
            // 
            // iDreaderDataGridViewTextBoxColumn
            // 
            this.iDreaderDataGridViewTextBoxColumn.DataPropertyName = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn.HeaderText = "ID_reader";
            this.iDreaderDataGridViewTextBoxColumn.Name = "iDreaderDataGridViewTextBoxColumn";
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
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearBT);
            this.Controls.Add(this.PainBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IssuedBooksDGV);
            this.Name = "Form8";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssuedBooksDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartoteka1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesbooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IssuedBooksDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PainBT;
        private System.Windows.Forms.Button ClearBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Cartoteka1DataSet8 cartoteka1DataSet8;
        private System.Windows.Forms.BindingSource issuesbooksBindingSource;
        private Cartoteka1DataSet8TableAdapters.Issues_booksTableAdapter issues_booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDbookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDreaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofissuedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofreturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDataGridViewTextBoxColumn;
    }
}