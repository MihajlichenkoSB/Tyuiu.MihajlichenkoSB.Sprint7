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
        public decimal DeliveryCost { get; private set; }

        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxDeliveryCost;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelDeliveryCost;

        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxFullName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxDeliveryCost = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelDeliveryCost = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 25);
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

            // labelDeliveryCost
            this.labelDeliveryCost.AutoSize = true;
            this.labelDeliveryCost.Location = new Point(30, 190);
            this.labelDeliveryCost.Name = "labelDeliveryCost";
            this.labelDeliveryCost.Size = new Size(134, 20);
            this.labelDeliveryCost.TabIndex = 1;
            this.labelDeliveryCost.Text = "Стоимость доставки:";

            // textBoxDeliveryCost
            this.textBoxDeliveryCost.Location = new Point(170, 187);
            this.textBoxDeliveryCost.Name = "textBoxDeliveryCost";
            this.textBoxDeliveryCost.Size = new Size(200, 27);
            this.textBoxDeliveryCost.TabIndex = 3;
            this.textBoxDeliveryCost.Text = "0";

            // buttonOK
            this.buttonOK.Location = new Point(100, 240);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(100, 35);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.Location = new Point(210, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(100, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddSupplier
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxDeliveryCost);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelDeliveryCost);
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
                DeliveryCost = decimal.Parse(textBoxDeliveryCost.Text);
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
                MessageBox.Show("Введите ФИО поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон поставщика", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxDeliveryCost.Text, out decimal cost) || cost < 0)
            {
                MessageBox.Show("Введите корректную стоимость доставки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDeliveryCost.Focus();
                return false;
            }

            return true;
        }
    }
}