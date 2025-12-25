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

        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxRevenue;
        private ComboBox comboBoxOwner;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
        private Label labelRevenue;
        private Label labelOwner;

        // Добавим список владельцев
        private System.Collections.Generic.List<Owner> ownersList;

        public FormAddStore(System.Collections.Generic.List<Owner> owners)
        {
            ownersList = owners;
            InitializeComponent();
            LoadOwnersToComboBox();
        }

        private void LoadOwnersToComboBox()
        {
            comboBoxOwner.Items.Clear();
            foreach (var owner in ownersList)
            {
                comboBoxOwner.Items.Add(owner.FullName);
            }
            if (comboBoxOwner.Items.Count > 0)
            {
                comboBoxOwner.SelectedIndex = 0;
            }
        }

        private void InitializeComponent()
        {
            this.textBoxName = new TextBox();
            this.textBoxAddress = new TextBox();
            this.textBoxPhone = new TextBox();
            this.textBoxRevenue = new TextBox();
            this.comboBoxOwner = new ComboBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelRevenue = new Label();
            this.labelOwner = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(160, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Добавить магазин";

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new Point(30, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new Size(122, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название магазина:";

            // textBoxName
            this.textBoxName.Location = new Point(170, 67);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(200, 27);
            this.textBoxName.TabIndex = 0;

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

            // labelRevenue
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Location = new Point(30, 190);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new Size(134, 20);
            this.labelRevenue.TabIndex = 1;
            this.labelRevenue.Text = "Месячная выручка:";

            // textBoxRevenue
            this.textBoxRevenue.Location = new Point(170, 187);
            this.textBoxRevenue.Name = "textBoxRevenue";
            this.textBoxRevenue.Size = new Size(200, 27);
            this.textBoxRevenue.TabIndex = 3;
            this.textBoxRevenue.Text = "0";

            // labelOwner
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new Point(30, 230);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new Size(78, 20);
            this.labelOwner.TabIndex = 1;
            this.labelOwner.Text = "Владелец:";

            // comboBoxOwner
            this.comboBoxOwner.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new Point(170, 227);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new Size(200, 28);
            this.comboBoxOwner.TabIndex = 4;

            // buttonOK
            this.buttonOK.Location = new Point(100, 280);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(100, 35);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Добавить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new EventHandler(this.buttonOK_Click);

            // buttonCancel
            this.buttonCancel.Location = new Point(210, 280);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(100, 35);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);

            // FormAddStore
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(400, 340);
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
                MessageBox.Show("Введите название магазина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Введите адрес магазина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
            {
                MessageBox.Show("Введите телефон магазина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPhone.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxRevenue.Text, out decimal revenue) || revenue < 0)
            {
                MessageBox.Show("Введите корректную сумму выручки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRevenue.Focus();
                return false;
            }

            if (comboBoxOwner.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите владельца магазина", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxOwner.Focus();
                return false;
            }

            return true;
        }
    }
}