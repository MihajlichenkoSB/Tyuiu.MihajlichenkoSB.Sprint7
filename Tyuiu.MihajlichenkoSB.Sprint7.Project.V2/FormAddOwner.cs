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
        public decimal Capital { get; private set; }

        private TextBox textBoxFullName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxCapital;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
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
            this.textBoxCapital = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelCapital = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(180, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить владельца";

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

            // labelCapital
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new Point(30, 190);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new Size(68, 20);
            this.labelCapital.TabIndex = 1;
            this.labelCapital.Text = "Капитал:";

            // textBoxCapital
            this.textBoxCapital.Location = new Point(170, 187);
            this.textBoxCapital.Name = "textBoxCapital";
            this.textBoxCapital.Size = new Size(200, 27);
            this.textBoxCapital.TabIndex = 3;
            this.textBoxCapital.Text = "0";

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

            // FormAddOwner
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxCapital);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelCapital);
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
                Capital = decimal.Parse(textBoxCapital.Text);
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
                MessageBox.Show("Введите ФИО владельца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес владельца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон владельца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxCapital.Text, out decimal capital) || capital < 0)
            {
                MessageBox.Show("Введите корректную сумму капитала", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCapital.Focus();
                return false;
            }

            return true;
        }
    }
}