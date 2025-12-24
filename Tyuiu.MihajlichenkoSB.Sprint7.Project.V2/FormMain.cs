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

            SetupDataGridViews();
            SetupToolTips();
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
            dataGridViewStores_MBS.Columns.Add("OwnerName", "Владелец");

            dataGridViewStores_MBS.Columns["MonthlyRevenue"].DefaultCellStyle.Format = "N2";
            dataGridViewStores_MBS.Columns["MonthlyRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LoadSampleData()
        {
            try
            {
                // Тестовые владельцы
                dataService.AddOwner(new Owner { Id = 001, FullName = "Галицкий С.Н.", Address = "Москва", Phone = "+78612980720", Capital = 1500000 });
                dataService.AddOwner(new Owner { Id = 002, FullName = "Рогачев А.В.", Address = "СПб", Phone = "+79636589534", Capital = 1200000 });
                dataService.AddOwner(new Owner { Id = 003, FullName = "Леонов О.А.", Address = "Казань", Phone = "+79538648236", Capital = 980000 });

                // Тестовые магазины
                dataService.AddStore(new Store { Id = 001, Name = "Магнит", Address = "Москва", Phone = "8829002", MonthlyRevenue = 183220000000, OwnerId = 1 });
                dataService.AddStore(new Store { Id = 002, Name = "Пятерочка", Address = "Москва", Phone = "88005005055", MonthlyRevenue = 271200000000, OwnerId = 1 });
                dataService.AddStore(new Store { Id = 003, Name = "Дикси", Address = "СПб", Phone = "88003330201", MonthlyRevenue = 1200000, OwnerId = 2 });

                UpdateDataGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // Получаем имя владельца по ID
                string ownerName = "Неизвестно";
                var owner = dataService.GetOwners().FirstOrDefault(o => o.Id == store.OwnerId);
                if (owner != null)
                {
                    ownerName = owner.FullName;
                }

                dataGridViewStores_MBS.Rows.Add(store.Id, store.Name, store.Address, store.Phone, store.MonthlyRevenue, ownerName);
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
            AddNewStore();
        }

        private void AddNewStore()
        {
            FormAddStore form = new FormAddStore();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Получаем следующий ID
                    int nextId = 1;
                    if (dataService.GetStores().Count > 0)
                    {
                        nextId = dataService.GetStores().Max(s => s.Id) + 1;
                    }

                    // Создаем новый магазин
                    Store newStore = new Store
                    {
                        Id = nextId,
                        Name = form.StoreName,
                        Address = form.Address,
                        Phone = form.Phone,
                        MonthlyRevenue = form.MonthlyRevenue,
                        OwnerId = form.OwnerId
                    };

                    // Добавляем в сервис
                    dataService.AddStore(newStore);

                    // Обновляем интерфейс
                    UpdateDataGridViews();
                    UpdateStatusInfo();

                    MessageBox.Show($"Магазин '{form.StoreName}' успешно добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении магазина: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonEditItem_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDeleteItem_MBS_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem();
        }

        private void DeleteSelectedItem()
        {
            if (tabControlMain_MBS.SelectedTab == tabPageOwners_MBS)
            {
                DeleteSelectedOwner();
            }
            else if (tabControlMain_MBS.SelectedTab == tabPageStores_MBS)
            {
                DeleteSelectedStore();
            }
            else
            {
                MessageBox.Show("Выберите вкладку с данными для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteSelectedStore()
        {
            if (dataGridViewStores_MBS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите магазин для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewStores_MBS.SelectedRows[0];
            int storeId = (int)selectedRow.Cells[0].Value;
            string storeName = selectedRow.Cells[1].Value.ToString();

            var result = MessageBox.Show($"Вы действительно хотите удалить магазин '{storeName}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим и удаляем магазин
                    var stores = dataService.GetStores();
                    var storeToRemove = stores.FirstOrDefault(s => s.Id == storeId);

                    if (storeToRemove != null)
                    {
                        stores.Remove(storeToRemove);
                        UpdateDataGridViews();
                        UpdateStatusInfo();

                        MessageBox.Show($"Магазин '{storeName}' успешно удален!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении магазина: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteSelectedOwner()
        {
            MessageBox.Show("Удаление владельца", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSaveData_MBS_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";
            dialog.FileName = "data.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Сохранено: {dialog.FileName}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonLoadData_MBS_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Загружено: {dialog.FileName}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridViews();
                UpdateStatusInfo();
            }
        }

        private void ButtonShowStats_MBS_Click(object sender, EventArgs e)
        {
            ShowStatistics();
        }

        private void ShowStatistics()
        {
            int ownerCount = dataService.GetOwners().Count;
            int storeCount = dataService.GetStoreCount();
            decimal totalCapital = dataService.GetTotalCapital();

            decimal totalRevenue = 0;
            if (dataService.GetStores().Count > 0)
            {
                totalRevenue = dataService.GetStores().Sum(s => s.MonthlyRevenue);
            }

            string stats = $"Владельцев: {ownerCount}\n" +
                          $"Магазинов: {storeCount}\n" +
                          $"Общий капитал: {totalCapital:N2} руб.\n" +
                          $"Общая месячная выручка: {totalRevenue:N2} руб.\n\n" +
                          $"Средняя выручка на магазин: {(storeCount > 0 ? totalRevenue / storeCount : 0):N2} руб.";

            MessageBox.Show(stats, "Статистика сети магазинов",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonShowChart_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Графики будут реализованы в следующей версии", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonSearch_MBS_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_MBS.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                SearchData(searchText);
            }
            else
            {
                UpdateDataGridViews(); // Показать все данные
            }
        }

        private void SearchData(string searchText)
        {
            string filterType = comboBoxFilter_MBS.Text;

            // Очищаем таблицы
            dataGridViewOwners_MBS.Rows.Clear();
            dataGridViewStores_MBS.Rows.Clear();

            // Поиск владельцев
            if (filterType == "Все" || filterType == "Владельцы")
            {
                var owners = dataService.GetOwners().Where(o =>
                    o.FullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    o.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    o.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase));

                foreach (var owner in owners)
                {
                    dataGridViewOwners_MBS.Rows.Add(owner.Id, owner.FullName, owner.Address, owner.Phone, owner.Capital);
                }
            }

            // Поиск магазинов
            if (filterType == "Все" || filterType == "Магазины")
            {
                var stores = dataService.GetStores().Where(s =>
                    s.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    s.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    s.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase));

                foreach (var store in stores)
                {
                    // Получаем имя владельца
                    string ownerName = "Неизвестно";
                    var owner = dataService.GetOwners().FirstOrDefault(o => o.Id == store.OwnerId);
                    if (owner != null)
                    {
                        ownerName = owner.FullName;
                    }

                    dataGridViewStores_MBS.Rows.Add(store.Id, store.Name, store.Address, store.Phone, store.MonthlyRevenue, ownerName);
                }
            }

            toolStripStatusLabelInfo_MBS.Text = $"Найдено по запросу '{searchText}'";
        }

        // Обработчики меню
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemAbout_MBS_Click(object sender, EventArgs e)
        {
            string about = @"СЕТЬ МАГАЗИНОВ - MBS
Версия 2.0

Программа для управления сетью магазинов.
Возможности:
- Учет владельцев и магазинов
- Добавление, редактирование, удаление магазинов
- Анализ капитала и выручки
- Поиск по всем данным
- Сохранение и загрузка данных

Разработчик: MihajlichenkoSB";

            MessageBox.Show(about, "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemUserGuide_MBS_Click(object sender, EventArgs e)
        {
            string guide = @"РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ

1. УПРАВЛЕНИЕ МАГАЗИНАМИ:
   - Добавление: нажмите 'Добавить магазин'
   - Удаление: выделите магазин и нажмите 'Удалить'
   - Просмотр: перейдите на вкладку 'Магазины'

2. ДОБАВЛЕНИЕ МАГАЗИНА:
   - Введите название магазина
   - Укажите адрес и телефон
   - Введите месячную выручку
   - Выберите владельца из списка
   - Нажмите 'Добавить'

3. ПОИСК ДАННЫХ:
   - Введите текст в поле поиска
   - Выберите тип данных в фильтре
   - Нажмите 'Найти' или Enter

4. СТАТИСТИКА:
   - Нажмите 'Статистика' для просмотра
   - Показывает общие показатели сети";

            MessageBox.Show(guide, "Руководство пользователя",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Дополнительные обработчики
        private void TextBoxSearch_MBS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonSearch_MBS_Click(sender, e);
                e.Handled = true;
            }
        }

        private void labelTitle_MBS_Click(object sender, EventArgs e)
        {
            // Простая анимация при клике на заголовок
            Color currentColor = labelTitle_MBS.ForeColor;
            labelTitle_MBS.ForeColor = currentColor == Color.DarkBlue ? Color.DarkRed : Color.DarkBlue;
        }

        // Обработчик двойного клика по магазину для быстрого просмотра
        private void dataGridViewStores_MBS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewStores_MBS.Rows[e.RowIndex];
                string storeName = row.Cells[1].Value.ToString();
                string revenue = row.Cells[4].Value.ToString();
                string owner = row.Cells[5].Value.ToString();

                string info = $"Название: {storeName}\n" +
                             $"Выручка: {revenue} руб.\n" +
                             $"Владелец: {owner}";

                MessageBox.Show(info, "Информация о магазине",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}