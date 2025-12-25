using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormAddStore : Form
    {
        public string StoreName { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public decimal Area { get; private set; }

        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxArea;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelArea;

        public FormAddStore()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxEmail = new TextBox();
            this.textBoxArea = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelEmail = new Label();
            this.labelArea = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(160, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить магазин";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(20, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(122, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название магазина:";

            // textBoxName
            this.textBoxName.Location = new Point(150, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(250, 27);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.PlaceholderText = "Супермаркет 'Продукты'";

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
            this.textBoxAddress.PlaceholderText = "ул. Ленина, д. 10";

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
            this.textBoxPhone.PlaceholderText = "+7 (999) 111-22-33";

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
            this.textBoxEmail.PlaceholderText = "info@store.ru";

            // labelArea
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new Point(20, 230);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new Size(134, 20);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Площадь (м²):";

            // textBoxArea
            this.textBoxArea.Location = new Point(150, 227);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new Size(250, 27);
            this.textBoxArea.TabIndex = 4;
            this.textBoxArea.PlaceholderText = "150.5";

            // buttonOK
            this.buttonOK.BackColor = Color.FromArgb(52, 152, 219);
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

            // FormAddStore
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(430, 340);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddStore";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Добавить магазин";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                StoreName = textBoxName.Text;
                Address = textBoxAddress.Text;
                Phone = textBoxPhone.Text;
                Email = textBoxEmail.Text;

                if (decimal.TryParse(textBoxArea.Text, out decimal area))
                {
                    Area = area;
                }
                else
                {
                    Area = 0;
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
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название магазина", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес магазина", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон магазина", "Ошибка",
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

            if (!decimal.TryParse(textBoxArea.Text, out decimal area) || area <= 0)
            {
                MessageBox.Show("Введите корректную площадь", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxArea.Focus();
                return false;
            }

            return true;
        }
    }
}