using System;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Services;
using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        private DataService dataService;
        private ToolTip toolTip;

        public FormMain()
        {
            InitializeComponent();

            dataService = new DataService();
            toolTip = new ToolTip();

            LoadSampleData();
            UpdateInterface();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            // Кнопки
            buttonAddOwner_MBS.Click += ButtonAddOwner_MBS_Click;
            buttonAddStore_MBS.Click += ButtonAddStore_MBS_Click;
            buttonEditItem_MBS.Click += ButtonEditItem_MBS_Click;
            buttonDeleteItem_MBS.Click += ButtonDeleteItem_MBS_Click;
            buttonSaveData_MBS.Click += ButtonSaveData_MBS_Click;
            buttonLoadData_MBS.Click += ButtonLoadData_MBS_Click;
            buttonShowStats_MBS.Click += ButtonShowStats_MBS_Click;
            buttonShowChart_MBS.Click += ButtonShowChart_MBS_Click;
            buttonSearch_MBS.Click += ButtonSearch_MBS_Click;
        }

        private void SetupToolTips()
        {
            toolTip.SetToolTip(buttonAddOwner_MBS, "Добавить нового владельца магазина");
            toolTip.SetToolTip(buttonAddStore_MBS, "Добавить новый магазин");
            toolTip.SetToolTip(buttonEditItem_MBS, "Редактировать выбранный элемент");
            toolTip.SetToolTip(buttonDeleteItem_MBS, "Удалить выбранный элемент");
            toolTip.SetToolTip(buttonSaveData_MBS, "Сохранить все данные в CSV файлы");
            toolTip.SetToolTip(buttonLoadData_MBS, "Загрузить данные из CSV файлов");
            toolTip.SetToolTip(buttonShowStats_MBS, "Показать статистику по данным");
            toolTip.SetToolTip(buttonShowChart_MBS, "Показать графики и диаграммы");
        }

        private void SetupDataGridViews()
        {
            // Настройка DataGridView для владельцев
            dataGridViewOwners_MBS.Columns.Clear();

            dataGridViewOwners_MBS.Columns.Add("Id", "ID");
            dataGridViewOwners_MBS.Columns.Add("FullName", "ФИО");
            dataGridViewOwners_MBS.Columns.Add("Address", "Адрес");
            dataGridViewOwners_MBS.Columns.Add("Phone", "Телефон");
            dataGridViewOwners_MBS.Columns.Add("Capital", "Капитал (руб.)");

            dataGridViewOwners_MBS.Columns["Capital"].DefaultCellStyle.Format = "N2";
            dataGridViewOwners_MBS.Columns["Capital"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Настройка DataGridView для магазинов
            dataGridViewStores_MBS.Columns.Clear();

            dataGridViewStores_MBS.Columns.Add("Id", "ID");
            dataGridViewStores_MBS.Columns.Add("Name", "Название");
            dataGridViewStores_MBS.Columns.Add("Address", "Адрес");
            dataGridViewStores_MBS.Columns.Add("Phone", "Телефон");
            dataGridViewStores_MBS.Columns.Add("MonthlyRevenue", "Выручка (руб.)");

            dataGridViewStores_MBS.Columns["MonthlyRevenue"].DefaultCellStyle.Format = "N2";
            dataGridViewStores_MBS.Columns["MonthlyRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LoadSampleData()
        {
            try
            {
                // Тестовые владельцы
                dataService.AddOwner(new Owner { Id = 1, FullName = "Иванов И.И.", Address = "Москва", Phone = "111", Capital = 5000000 });
                dataService.AddOwner(new Owner { Id = 2, FullName = "Петрова А.С.", Address = "СПб", Phone = "222", Capital = 3500000 });
                dataService.AddOwner(new Owner { Id = 3, FullName = "Сидоров А.П.", Address = "Казань", Phone = "333", Capital = 2800000 });

                // Тестовые магазины
                dataService.AddStore(new Store { Id = 1, Name = "Магнит", Address = "Москва", Phone = "444", MonthlyRevenue = 1500000 });
                dataService.AddStore(new Store { Id = 2, Name = "Пятерочка", Address = "Москва", Phone = "555", MonthlyRevenue = 1200000 });
                dataService.AddStore(new Store { Id = 3, Name = "Дикси", Address = "СПб", Phone = "666", MonthlyRevenue = 980000 });

                UpdateDataGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridViews()
        {
            // Владельцы
            dataGridViewOwners_MBS.Rows.Clear();
            foreach (var owner in dataService.GetOwners())
            {
                dataGridViewOwners_MBS.Rows.Add(owner.Id, owner.FullName, owner.Address, owner.Phone, owner.Capital);
            }

            // Магазины
            dataGridViewStores_MBS.Rows.Clear();
            foreach (var store in dataService.GetStores())
            {
                dataGridViewStores_MBS.Rows.Add(store.Id, store.Name, store.Address, store.Phone, store.MonthlyRevenue);
            }
        }

        private void UpdateInterface()
        {
            toolStripStatusLabelDate_MBS.Text = DateTime.Now.ToString("dd.MM.yyyy");
            UpdateStatusInfo();
        }

        private void UpdateStatusInfo()
        {
            int ownerCount = dataService.GetOwners().Count;
            int storeCount = dataService.GetStoreCount();
            decimal totalCapital = dataService.GetTotalCapital();

            toolStripStatusLabelInfo_MBS.Text =
                $"Владельцев: {ownerCount} | Магазинов: {storeCount} | Капитал: {totalCapital:N2} руб.";
        }

        // ========== ОБРАБОТЧИКИ СОБЫТИЙ ==========

        private void ButtonAddOwner_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление владельца", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonAddStore_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавление магазина", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonEditItem_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDeleteItem_MBS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить элемент?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Элемент удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStatusInfo();
            }
        }

        private void ButtonSaveData_MBS_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";
            dialog.FileName = "data.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Сохранено: {dialog.FileName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonLoadData_MBS_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Загружено: {dialog.FileName}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridViews();
                UpdateStatusInfo();
            }
        }

        private void ButtonShowStats_MBS_Click(object sender, EventArgs e)
        {
            int ownerCount = dataService.GetOwners().Count;
            int storeCount = dataService.GetStoreCount();
            decimal totalCapital = dataService.GetTotalCapital();

            string stats = $"Владельцев: {ownerCount}\n" +
                          $"Магазинов: {storeCount}\n" +
                          $"Общий капитал: {totalCapital:N2} руб.";

            MessageBox.Show(stats, "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonShowChart_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Графики", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSearch_MBS_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_MBS.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show($"Поиск: {searchText}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Обработчики меню (если нужно, добавь позже)
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}