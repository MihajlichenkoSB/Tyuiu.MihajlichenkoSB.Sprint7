using System;
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
        public decimal Area { get; private set; }

        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxArea;
        private Button buttonOK;
        private Button buttonCancel;
        private Label labelTitle;
        private Label labelName;
        private Label labelAddress;
        private Label labelPhone;
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
            this.textBoxArea = new TextBox();
            this.buttonOK = new Button();
            this.buttonCancel = new Button();
            this.labelTitle = new Label();
            this.labelName = new Label();
            this.labelAddress = new Label();
            this.labelPhone = new Label();
            this.labelArea = new Label();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTitle.Location = new Point(120, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(160, 28);
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

            // labelArea
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new Point(30, 190);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new Size(134, 20);
            this.labelArea.TabIndex = 1;
            this.labelArea.Text = "Площадь (м²):";

            // textBoxArea
            this.textBoxArea.Location = new Point(170, 187);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new Size(200, 27);
            this.textBoxArea.TabIndex = 3;
            this.textBoxArea.Text = "0";

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

            // FormAddStore
            this.AcceptButton = this.buttonOK;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelArea);
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

            if (!decimal.TryParse(textBoxArea.Text, out decimal area) || area < 0)
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