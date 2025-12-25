using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormAddOwner : Form
    {
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public decimal Capital { get; private set; }

        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxCapital;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelCapital;

        public FormAddOwner()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxFullName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxCapital = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelEmail = new Label();
            this.labelCapital = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить владельца";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(20, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(46, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО:";

            // textBoxFullName
            this.textBoxFullName.Location = new Point(150, 67);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new Size(250, 27);
            this.textBoxFullName.TabIndex = 0;
            this.textBoxFullName.PlaceholderText = "Иванов Иван Иванович";

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(20, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(55, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Адрес:";

            // textBoxAddress
            this.textBoxAddress.Location = new Point(150, 107);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(250, 27);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.PlaceholderText = "ул. Ленина, д. 10, кв. 5";

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(20, 150);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(72, 20);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Телефон:";

            // textBoxPhone
            this.textBoxPhone.Location = new Point(150, 147);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(250, 27);
            this.textBoxPhone.TabIndex = 2;
            this.textBoxPhone.PlaceholderText = "+7 (999) 123-45-67";

            // labelEmail
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new Point(20, 190);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new Size(55, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";

            // textBoxEmail
            this.textBoxEmail.Location = new Point(150, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new Size(250, 27);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.PlaceholderText = "example@mail.ru";

            // labelCapital
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new Point(20, 230);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new Size(68, 20);
            this.labelCapital.TabIndex = 1;
            this.labelCapital.Text = "Капитал:";

            // textBoxCapital
            this.textBoxCapital.Location = new Point(150, 227);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new Size(250, 27);
            this.textBoxCapital.TabIndex = 4;
            this.textBoxCapital.PlaceholderText = "1000000";

            // buttonOK
            this.buttonOK.BackColor = Color.FromArgb(46, 204, 113);
            this.buttonOK.FlatStyle = FlatStyle.Flat;
            this.buttonOK.ForeColor = Color.White;
            this.buttonOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.buttonOK.Location = new Point(150, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(120, 35);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.BackColor = Color.FromArgb(240, 240, 240);
            this.buttonCancel.FlatStyle = FlatStyle.Flat;
            this.buttonCancel.Font = new Font("Segoe UI", 9F);
            this.buttonCancel.Location = new Point(280, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(120, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddOwner
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(430, 340);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddOwner";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Добавить владельца";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                FullName = textBoxFullName.Text;
                Address = textBoxAddress.Text;
                Phone = textBoxPhone.Text;
                Email = textBoxEmail.Text;

                if (decimal.TryParse(textBoxCapital.Text, out decimal capital))
                {
                    Capital = capital;
                }
                else
                {
                    Capital = 0;
                }

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
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введите ФИО владельца", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес владельца", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон владельца", "Ошибка",
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

            if (!decimal.TryParse(textBoxCapital.Text, out decimal capital) || capital < 0)
            {
                MessageBox.Show("Введите корректную сумму капитала", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCapital.Focus();
                return false;
            }

            return true;
        }
    }
}