using System;
using System.Drawing;
using System.Windows.Forms;
using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormAddStore : Form
    {
        public string StoreName { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public decimal MonthlyRevenue { get; private set; }
        public int OwnerId { get; private set; }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxRevenue;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelRevenue;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelTitle;

        public FormAddStore()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxRevenue = new System.Windows.Forms.TextBox();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(160, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить магазин";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название магазина:";

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(170, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);
            this.textBoxName.TabIndex = 0;

            // labelAddress
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(30, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(55, 20);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Адрес:";

            // textBoxAddress
            this.textBoxAddress.Location = new System.Drawing.Point(170, 107);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 27);
            this.textBoxAddress.TabIndex = 1;

            // labelPhone
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(30, 150);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 20);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "Телефон:";

            // textBoxPhone
            this.textBoxPhone.Location = new System.Drawing.Point(170, 147);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 27);
            this.textBoxPhone.TabIndex = 2;

            // labelRevenue
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Location = new System.Drawing.Point(30, 190);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(134, 20);
            this.labelRevenue.TabIndex = 1;
            this.labelRevenue.Text = "Месячная выручка:";

            // textBoxRevenue
            this.textBoxRevenue.Location = new System.Drawing.Point(170, 187);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.Size = new System.Drawing.Size(200, 27);
            this.textBoxRevenue.TabIndex = 3;
            this.textBoxRevenue.Text = "0";

            // labelOwner
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(30, 230);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(78, 20);
            this.labelOwner.TabIndex = 1;
            this.labelOwner.Text = "Владелец:";

            // comboBoxOwner
            this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(170, 227);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(200, 28);
            this.comboBoxOwner.TabIndex = 4;
            // Заполним тестовыми данными
            this.comboBoxOwner.Items.AddRange(new object[] {
            "Иванов И.И.",
            "Петрова А.С.",
            "Сидоров А.П."});

            // buttonOK
            this.buttonOK.Location = new System.Drawing.Point(100, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 35);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.Location = new System.Drawing.Point(210, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // FormAddStore
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.comboBoxOwner);
            this.Controls.Add(this.textBoxRevenue);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
                MonthlyRevenue = decimal.Parse(textBoxRevenue.Text);
                OwnerId = comboBoxOwner.SelectedIndex + 1; // ID начинаются с 1
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

            if (!decimal.TryParse(textBoxRevenue.Text, out decimal revenue) || revenue < 0)
            {
                MessageBox.Show("Введите корректную сумму выручки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRevenue.Focus();
                return false;
            }

            if (comboBoxOwner.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите владельца магазина", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxOwner.Focus();
                return false;
            }

            return true;
        }
    }
}