using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormAddSupplier : Form
    {
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Product { get; private set; }

        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxProduct;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelProduct;

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxFullName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxProduct = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelProduct = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить поставщика";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(30, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(46, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО:";

            // textBoxFullName
            this.textBoxFullName.Location = new Point(170, 67);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new Size(200, 27);
            this.textBoxFullName.TabIndex = 0;

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new Point(30, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new Size(55, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Адрес:";

            // textBoxAddress
            this.textBoxAddress.Location = new Point(170, 107);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new Size(200, 27);
            this.textBoxAddress.TabIndex = 1;

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new Point(30, 150);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new Size(72, 20);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Телефон:";

            // textBoxPhone
            this.textBoxPhone.Location = new Point(170, 147);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new Size(200, 27);
            this.textBoxPhone.TabIndex = 2;

            // labelProduct
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new Point(30, 190);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new Size(62, 20);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Товар:";

            // textBoxProduct
            this.textBoxProduct.Location = new Point(170, 187);
            this.textBoxProduct.Name = "textBoxProduct";
            this.textBoxProduct.Size = new Size(200, 27);
            this.textBoxProduct.TabIndex = 3;

            // buttonOK
            this.buttonOK.BackColor = Color.FromArgb(0, 122, 204);
            this.buttonOK.FlatStyle = FlatStyle.Flat;
            this.buttonOK.ForeColor = Color.White;
            this.buttonOK.Location = new Point(100, 240);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(100, 35);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.BackColor = Color.FromArgb(240, 240, 240);
            this.buttonCancel.FlatStyle = FlatStyle.Flat;
            this.buttonCancel.Location = new Point(210, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(100, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddSupplier
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxProduct);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
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
                FullName = textBoxFullName.Text;
                Address = textBoxAddress.Text;
                Phone = textBoxPhone.Text;
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
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введите ФИО поставщика", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес поставщика", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон поставщика", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
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