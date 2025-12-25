using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormAddSupplier : Form
    {
        public string CompanyName { get; private set; }
        public string ContactPerson { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Product { get; private set; }

        private TextBox textBoxCompanyName;
        private TextBox textBoxContactPerson;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxProduct;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelCompanyName;
        private Label labelContactPerson;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelProduct;

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxCompanyName = new TextBox();
            this.textBoxContactPerson = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxProduct = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelCompanyName = new Label();
            this.labelContactPerson = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelEmail = new Label();
            this.labelProduct = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить поставщика";

            // labelCompanyName
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new Point(20, 70);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new Size(123, 20);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "Название компании:";

            // textBoxCompanyName
            this.textBoxCompanyName.Location = new Point(150, 67);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new Size(250, 27);
            this.textBoxCompanyName.TabIndex = 0;
            this.textBoxCompanyName.PlaceholderText = "ООО 'ПродуктСнаб'";

            // labelContactPerson
            this.labelContactPerson.AutoSize = true;
            this.labelContactPerson.Location = new Point(20, 110);
            this.labelContactPerson.Name = "labelContactPerson";
            this.labelContactPerson.Size = new Size(124, 20);
            this.labelContactPerson.TabIndex = 1;
            this.labelContactPerson.Text = "Контактное лицо:";

            // textBoxContactPerson
            this.textBoxContactPerson.Location = new Point(150, 107);
            this.textBoxContactPerson.Name = "textBoxContactPerson";
            this.textBoxContactPerson.Size = new Size(250, 27);
            this.textBoxContactPerson.TabIndex = 1;
            this.textBoxContactPerson.PlaceholderText = "Смирнов А.А.";

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(20, 150);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(55, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Адрес:";

            // textBoxAddress
            this.textBoxAddress.Location = new Point(150, 147);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(250, 27);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.PlaceholderText = "ул. Заводская, д. 15";

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(20, 190);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(72, 20);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Телефон:";

            // textBoxPhone
            this.textBoxPhone.Location = new Point(150, 187);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(250, 27);
            this.textBoxPhone.TabIndex = 3;
            this.textBoxPhone.PlaceholderText = "+7 (999) 444-55-66";

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(20, 230);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(55, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";

            // textBoxEmail
            this.textBoxEmail.Location = new Point(150, 227);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(250, 27);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.PlaceholderText = "info@company.ru";

            // labelProduct
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new Point(20, 270);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new Size(62, 20);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Товар:";

            // textBoxProduct
            this.textBoxProduct.Location = new Point(150, 267);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new Size(250, 27);
            this.textBoxProduct.TabIndex = 5;
            this.textBoxProduct.PlaceholderText = "Продукты питания";

            // buttonOK
            this.buttonOK.BackColor = Color.FromArgb(155, 89, 182);
            this.buttonOK.FlatStyle = FlatStyle.Flat;
            this.buttonOK.ForeColor = Color.White;
            this.buttonOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonOK.Location = new Point(150, 320);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(120, 35);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.BackColor = Color.FromArgb(240, 240, 240);
            this.buttonCancel.FlatStyle = FlatStyle.Flat;
            this.buttonCancel.Font = new Font("Segoe UI", 9F);
            this.buttonCancel.Location = new Point(280, 320);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(120, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddSupplier
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(430, 380);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxContactPerson);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelContactPerson);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddSupplier";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Добавить поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                CompanyName = textBoxCompanyName.Text;
                ContactPerson = textBoxContactPerson.Text;
                Address = textBoxAddress.Text;
                Phone = textBoxPhone.Text;
                Email = textBoxEmail.Text;
                Product = textBoxProduct.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text))
            {
                MessageBox.Show("Введите название компании", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCompanyName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxContactPerson.Text))
            {
                MessageBox.Show("Введите контактное лицо", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContactPerson.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес компании", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон компании", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Введите корректный email", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxProduct.Text))
            {
                MessageBox.Show("Введите название товара", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxProduct.Focus();
                return false;
            }

            return true;
        }
    }
}