namespace Bookstore
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleTb = new System.Windows.Forms.TextBox();
            this.coverTb = new System.Windows.Forms.TextBox();
            this.categoryTb = new System.Windows.Forms.TextBox();
            this.author1Tb = new System.Windows.Forms.TextBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.priceNumUD = new System.Windows.Forms.NumericUpDown();
            this.yearNumUd = new System.Windows.Forms.NumericUpDown();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.removeAuthorButton = new System.Windows.Forms.Button();
            this.author2Tb = new System.Windows.Forms.TextBox();
            this.author3Tb = new System.Windows.Forms.TextBox();
            this.author4Tb = new System.Windows.Forms.TextBox();
            this.author5Tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumUd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Книга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор(ы)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Язык";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Год";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Обложка";
            // 
            // titleTb
            // 
            this.titleTb.Location = new System.Drawing.Point(55, 9);
            this.titleTb.Name = "titleTb";
            this.titleTb.Size = new System.Drawing.Size(156, 20);
            this.titleTb.TabIndex = 7;
            this.titleTb.TextChanged += new System.EventHandler(this.titleTb_TextChanged);
            // 
            // coverTb
            // 
            this.coverTb.Location = new System.Drawing.Point(71, 35);
            this.coverTb.Name = "coverTb";
            this.coverTb.Size = new System.Drawing.Size(140, 20);
            this.coverTb.TabIndex = 8;
            // 
            // categoryTb
            // 
            this.categoryTb.Location = new System.Drawing.Point(78, 62);
            this.categoryTb.Name = "categoryTb";
            this.categoryTb.Size = new System.Drawing.Size(133, 20);
            this.categoryTb.TabIndex = 9;
            // 
            // author1Tb
            // 
            this.author1Tb.Location = new System.Drawing.Point(69, 88);
            this.author1Tb.Name = "author1Tb";
            this.author1Tb.Size = new System.Drawing.Size(142, 20);
            this.author1Tb.TabIndex = 13;
            this.author1Tb.Tag = "0";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthorButton.Location = new System.Drawing.Point(14, 112);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(24, 24);
            this.addAuthorButton.TabIndex = 14;
            this.addAuthorButton.Text = "+";
            this.addAuthorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addBookButton
            // 
            this.addBookButton.Enabled = false;
            this.addBookButton.Location = new System.Drawing.Point(268, 112);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(94, 36);
            this.addBookButton.TabIndex = 15;
            this.addBookButton.Text = "Добавить";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // priceNumUD
            // 
            this.priceNumUD.DecimalPlaces = 2;
            this.priceNumUD.Location = new System.Drawing.Point(281, 10);
            this.priceNumUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.priceNumUD.Name = "priceNumUD";
            this.priceNumUD.Size = new System.Drawing.Size(108, 20);
            this.priceNumUD.TabIndex = 16;
            // 
            // yearNumUd
            // 
            this.yearNumUd.Location = new System.Drawing.Point(281, 34);
            this.yearNumUd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearNumUd.Name = "yearNumUd";
            this.yearNumUd.Size = new System.Drawing.Size(108, 20);
            this.yearNumUd.TabIndex = 17;
            // 
            // langComboBox
            // 
            this.langComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Location = new System.Drawing.Point(281, 61);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(108, 21);
            this.langComboBox.TabIndex = 18;
            // 
            // removeAuthorButton
            // 
            this.removeAuthorButton.Enabled = false;
            this.removeAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAuthorButton.Location = new System.Drawing.Point(39, 112);
            this.removeAuthorButton.Name = "removeAuthorButton";
            this.removeAuthorButton.Size = new System.Drawing.Size(24, 24);
            this.removeAuthorButton.TabIndex = 19;
            this.removeAuthorButton.Text = "-";
            this.removeAuthorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.removeAuthorButton.UseVisualStyleBackColor = true;
            this.removeAuthorButton.Click += new System.EventHandler(this.removeAuthorButton_Click);
            // 
            // author2Tb
            // 
            this.author2Tb.Location = new System.Drawing.Point(69, 114);
            this.author2Tb.Name = "author2Tb";
            this.author2Tb.Size = new System.Drawing.Size(142, 20);
            this.author2Tb.TabIndex = 20;
            this.author2Tb.Tag = "1";
            this.author2Tb.Visible = false;
            // 
            // author3Tb
            // 
            this.author3Tb.Location = new System.Drawing.Point(69, 140);
            this.author3Tb.Name = "author3Tb";
            this.author3Tb.Size = new System.Drawing.Size(142, 20);
            this.author3Tb.TabIndex = 21;
            this.author3Tb.Tag = "2";
            this.author3Tb.Visible = false;
            // 
            // author4Tb
            // 
            this.author4Tb.Location = new System.Drawing.Point(69, 166);
            this.author4Tb.Name = "author4Tb";
            this.author4Tb.Size = new System.Drawing.Size(142, 20);
            this.author4Tb.TabIndex = 22;
            this.author4Tb.Tag = "3";
            this.author4Tb.Visible = false;
            // 
            // author5Tb
            // 
            this.author5Tb.Location = new System.Drawing.Point(69, 192);
            this.author5Tb.Name = "author5Tb";
            this.author5Tb.Size = new System.Drawing.Size(142, 20);
            this.author5Tb.TabIndex = 23;
            this.author5Tb.Tag = "4";
            this.author5Tb.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 252);
            this.Controls.Add(this.author5Tb);
            this.Controls.Add(this.author4Tb);
            this.Controls.Add(this.author3Tb);
            this.Controls.Add(this.author2Tb);
            this.Controls.Add(this.removeAuthorButton);
            this.Controls.Add(this.langComboBox);
            this.Controls.Add(this.yearNumUd);
            this.Controls.Add(this.priceNumUD);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.author1Tb);
            this.Controls.Add(this.categoryTb);
            this.Controls.Add(this.coverTb);
            this.Controls.Add(this.titleTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleTb;
        private System.Windows.Forms.TextBox coverTb;
        private System.Windows.Forms.TextBox categoryTb;
        private System.Windows.Forms.TextBox author1Tb;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.NumericUpDown priceNumUD;
        private System.Windows.Forms.NumericUpDown yearNumUd;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.Button removeAuthorButton;
        private System.Windows.Forms.TextBox author2Tb;
        private System.Windows.Forms.TextBox author3Tb;
        private System.Windows.Forms.TextBox author4Tb;
        private System.Windows.Forms.TextBox author5Tb;
    }
}