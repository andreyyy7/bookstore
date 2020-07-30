using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;

namespace Bookstore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Booklist booklist = new Booklist();

        // Нажатие на кнопку "Открыть XML" - Отображение книг из XML-файла
        private void openButton_Click(object sender, EventArgs e)
        {
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML File|*.xml";
            openFileDialog.DefaultExt = "xml";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    xmlInputData = File.ReadAllText(path);
                    booklist = ser.Deserialize<Booklist>(xmlInputData);
                    saveButton.Enabled = true;
                    removeButton.Enabled = true;
                    addButton.Enabled = true;
                    reportButton.Enabled = true;
                }
                UpdateDGV();
            }
            catch (InvalidOperationException)
            {
                string errorText = "Не удалось получить данные.";
                string errorCaption = "Ошибка";
                MessageBox.Show(errorText, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление таблицы с информацией о книгах
        public void UpdateDGV()
        {
            DGV.Rows.Clear();
            for (int i = 0; i < booklist.Books.Count; i++)
            {
                string title = booklist.Books[i].Title.Value;
                string authors = "";
                List<string> authorsList = booklist.Books[i].Authors;
                for (int j = 0; j < authorsList.Count; j++)
                {
                    authors += authorsList[j] + (j != authorsList.Count - 1 ? "; " : "");
                }
                string category = booklist.Books[i].Category;
                string price = booklist.Books[i].Price.ToString();
                DGV.Rows.Add(title, authors, category, price);
            }
        }

        // Нажатие на кнопку "Добавить запись" - Добавление книги
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Owner = this;
            addForm.Show();
        }

        // Нажатие на кнопку "Удалить запись" - Удаление выбранной книги
        private void removeButton_Click(object sender, EventArgs e)
        {
            Book book = booklist.Books[DGV.SelectedRows[0].Index];
            booklist.RemoveBook(book);
            UpdateDGV();
        }

        // Нажатие на кнопку "Сохранить XML" - Сохранение книг в XML-файл
        private void saveButton_Click(object sender, EventArgs e)
        {
            Serializer ser = new Serializer();
            string xmlOutputData = ser.Serialize<Booklist>(booklist);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML File|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, xmlOutputData);
            }
        }

        // Нажатие на кнопку "Отчет в HTML" - Генерация HTML-отчета с информацией о книгах
        private void reportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML File|*.html";
            saveFileDialog.DefaultExt = "html";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Serializer ser = new Serializer();
                string xmlOutputData = ser.Serialize<Booklist>(booklist);
                var enviroment = System.Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
                string xmlFilePath = Path.Combine(projectDirectory, "tempbooks.xml");
                using (StreamWriter sw = File.CreateText(xmlFilePath))
                {
                    sw.Write(xmlOutputData);
                }
                string xslFilePath = Path.Combine(projectDirectory, "books.xsl");
                var myXslTrans = new XslCompiledTransform();
                myXslTrans.Load(xslFilePath);
                myXslTrans.Transform(xmlFilePath, saveFileDialog.FileName);
                File.Delete(xmlFilePath);
            }
        }
    }
}
