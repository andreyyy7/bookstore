using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Bookstore
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        List<TextBox> authorsTextboxes = new List<TextBox>();

        // Нажатие на кнопку "Добавить" - Добавление книги
        private void addBookButton_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.Owner as Form1;
            string category = categoryTb.Text;
            string cover = coverTb.Text;
            string titleValue = titleTb.Text;
            string language = langComboBox.SelectedValue.ToString();
            int year = Convert.ToInt32(yearNumUd.Value);
            double price = Convert.ToDouble(priceNumUD.Value);
            List<string> authors = new List<string>();
            foreach (TextBox tb in authorsTextboxes)
            {
                if (tb.Visible && tb.Text != "")
                {
                    authors.Add(tb.Text);
                }
            }
            mainForm.booklist.AddBook(category, cover, titleValue, language, authors, year, price);
            mainForm.UpdateDGV();
            this.Close();
        }

        // Запуск окна добавления книги
        private void AddForm_Load(object sender, EventArgs e)
        {
            // Заполнение комбобокса языками
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            var enviroment = System.Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            string path = Path.Combine(projectDirectory, "Languages.txt");
            var lines = File.ReadLines(path);
            foreach (string line in lines)
            {
                comboSource.Add(line.Split(' ')[0], line.Split(' ')[1]);
            }
            langComboBox.DataSource = new BindingSource(comboSource, null);
            langComboBox.DisplayMember = "Value";
            langComboBox.ValueMember = "Key";

            // Заполнение списка текстбоксов авторов 
            authorsTextboxes.Add(author1Tb);
            authorsTextboxes.Add(author2Tb);
            authorsTextboxes.Add(author3Tb);
            authorsTextboxes.Add(author4Tb);
            authorsTextboxes.Add(author5Tb);

            // Максимальный год издания книги как текущий
            yearNumUd.Maximum = DateTime.Now.Year;
        }

        // Нажатие на кнопку "+" - Добавление автора
        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            removeAuthorButton.Enabled = true;
            for (int i = authorsTextboxes.Count - 2; i >= 0; i--)
            {
                if (authorsTextboxes[i].Visible)
                {
                    authorsTextboxes[i + 1].Visible = true;
                }
            }
            if (authorsTextboxes[authorsTextboxes.Count - 1].Visible)
            {
                addAuthorButton.Enabled = false;
            }
        }

        // Нажатие на кнопку "-" - Удаление автора
        private void removeAuthorButton_Click(object sender, EventArgs e)
        {
            addAuthorButton.Enabled = true;
            if (!authorsTextboxes[2].Visible)
            {
                removeAuthorButton.Enabled = false;
            }
            for (int i = authorsTextboxes.Count - 1; i > 0; i--)
            {
                if (authorsTextboxes[i].Visible)
                {
                    authorsTextboxes[i].Visible = false;
                    authorsTextboxes[i].Text = "";
                    return;
                }
            }
        }

        private void titleTb_TextChanged(object sender, EventArgs e)
        {
            addBookButton.Enabled = titleTb.Text == "" ? false : true;
        }
    }
}
