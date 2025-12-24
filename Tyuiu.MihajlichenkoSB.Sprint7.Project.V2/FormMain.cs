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

        // Панель для кнопок добавления
        private Panel panelAddButtons;
        private Button buttonAddOwnerTop;
        private Button buttonAddStoreTop;
        private Button buttonAddSupplierTop;

        public FormMain()
        {
            InitializeComponent();

            dataService = new DataService();
            toolTip = new ToolTip();

            CreateTopButtonsPanel(); // Создаем панель с кнопками наверху
            SetupDataGridViews();
            SetupToolTips();
            LoadSampleData();
            UpdateInterface();
            SetupEventHandlers();
        }

        private void CreateTopButtonsPanel()
        {
            // Создаем панель для кнопок
            panelAddButtons = new Panel();
            panelAddButtons.BackColor = Color.LightSteelBlue;
            panelAddButtons.Dock = DockStyle.Top;
            panelAddButtons.Height = 50;
            panelAddButtons.Padding = new Padding(10, 5, 10, 5);

            // Кнопка "Добавить владельца"
            buttonAddOwnerTop = new Button();
            buttonAddOwnerTop.Text = "➕ Добавить владельца";
            buttonAddOwnerTop.Size = new Size(180, 35);
            buttonAddOwnerTop.Location = new Point(10, 7);
            buttonAddOwnerTop.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            buttonAddOwnerTop.BackColor = Color.LightBlue;
            buttonAddOwnerTop.FlatStyle = FlatStyle.Flat;
            buttonAddOwnerTop.Click += ButtonAddOwner_MBS_Click;

            // Кнопка "Добавить магазин"
            buttonAddStoreTop = new Button();
            buttonAddStoreTop.Text = "🏪 Добавить магазин";
            buttonAddStoreTop.Size = new Size(180, 35);
            buttonAddStoreTop.Location = new Point(200, 7);
            buttonAddStoreTop.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            buttonAddStoreTop.BackColor = Color.LightGreen;
            buttonAddStoreTop.FlatStyle = FlatStyle.Flat;
            buttonAddStoreTop.Click += ButtonAddStore_MBS_Click;

            // Кнопка "Добавить поставщика"
            buttonAddSupplierTop = new Button();
            buttonAddSupplierTop.Text = "🚚 Добавить поставщика";
            buttonAddSupplierTop.Size = new Size(180, 35);
            buttonAddSupplierTop.Location = new Point(390, 7);
            buttonAddSupplierTop.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular);
            buttonAddSupplierTop.BackColor = Color.LightSalmon;
            buttonAddSupplierTop.FlatStyle = FlatStyle.Flat;
            buttonAddSupplierTop.Click += ButtonAddSupplier_MBS_Click;

            // Добавляем кнопки на панель
            panelAddButtons.Controls.Add(buttonAddOwnerTop);
            panelAddButtons.Controls.Add(buttonAddStoreTop);
            panelAddButtons.Controls.Add(buttonAddSupplierTop);

            // Добавляем панель на форму (после заголовка)
            this.Controls.Add(panelAddButtons);
            panelAddButtons.BringToFront();
        }

        private void SetupEventHandlers()
        {
            // Основные кнопки
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
            // Подсказки для верхних кнопок
            toolTip.SetToolTip(buttonAddOwnerTop, "Добавить нового владельца магазина");
            toolTip.SetToolTip(buttonAddStoreTop, "Добавить новый магазин");
            toolTip.SetToolTip(buttonAddSupplierTop, "Добавить нового поставщика");
            
            // Подсказки для остальных кнопок
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

            // Настройка DataGridView для поставщиков (новая вкладка)
            // Добавим позже, когда создадим вкладку
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
                dataService.AddStore(new Store { Id = 1, Name = "Магнит", Address = "Москва", Phone = "444", MonthlyRevenue = 1500000, OwnerId = 1 });
                dataService.AddStore(new Store { Id = 2, Name = "Пятерочка", Address = "Москва", Phone = "555", MonthlyRevenue = 1200000, OwnerId = 1 });
                dataService.AddStore(new Store { Id = 3, Name = "Дикси", Address = "СПб", Phone = "666", MonthlyRevenue = 980000, OwnerId = 2 });

                // Тестовые поставщики
                dataService.AddSupplier(new Supplier { Id = 1, FullName = "ООО 'Продукты+'" });
                dataService.AddSupplier(new Supplier { Id = 2, FullName = "ИП 'Снабжение'" });

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
                string ownerName = "Неизвестно";
                var owner = dataService.GetOwners().FirstOrDefault(o => o.Id == store.OwnerId);
                if (owner != null) ownerName = owner.FullName;

                dataGridViewStores_MBS.Rows.Add(store.Id, store.Name, store.Address, store.Phone, store.MonthlyRevenue, ownerName);
            }

            // Поставщики (если будет вкладка)
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
            int supplierCount = dataService.GetSuppliers().Count;
            decimal totalCapital = dataService.GetTotalCapital();

            toolStripStatusLabelInfo_MBS.Text =
                $"Владельцев: {ownerCount} | Магазинов: {storeCount} | Поставщиков: {supplierCount} | Капитал: {totalCapital:N2} руб.";
        }

        // ========== ОБРАБОТЧИКИ СОБЫТИЙ ==========

        private void ButtonAddOwner_MBS_Click(object sender, EventArgs e)
        {
            AddNewOwner();
        }

        private void AddNewOwner()
        {
            FormAddOwner form = new FormAddOwner();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Получаем следующий ID
                    int nextId = 1;
                    if (dataService.GetOwners().Count > 0)
                    {
                        nextId = dataService.GetOwners().Max(o => o.Id) + 1;
                    }

                    // Создаем нового владельца
                    Owner newOwner = new Owner
                    {
                        Id = nextId,
                        FullName = form.FullName,
                        Address = form.Address,
                        Phone = form.Phone,
                        Capital = form.Capital
                    };

                    // Добавляем в сервис
                    dataService.AddOwner(newOwner);

                    // Обновляем интерфейс
                    UpdateDataGridViews();
                    UpdateStatusInfo();

                    MessageBox.Show($"Владелец '{form.FullName}' успешно добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении владельца: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddStore_MBS_Click(object sender, EventArgs e)
        {
            AddNewStore();
        }

        private void AddNewStore()
        {
            // Проверяем, есть ли владельцы
            if (dataService.GetOwners().Count == 0)
            {
                MessageBox.Show("Сначала добавьте хотя бы одного владельца!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormAddStore form = new FormAddStore();
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

        private void ButtonAddSupplier_MBS_Click(object sender, EventArgs e)
        {
            AddNewSupplier();
        }

        private void AddNewSupplier()
        {
            FormAddSupplier form = new FormAddSupplier();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Получаем следующий ID
                    int nextId = 1;
                    if (dataService.GetSuppliers().Count > 0)
                    {
                        nextId = dataService.GetSuppliers().Max(s => s.Id) + 1;
                    }

                    // Создаем нового поставщика
                    Supplier newSupplier = new Supplier
                    {
                        Id = nextId,
                        FullName = form.FullName,
                        Address = form.Address,
                        Phone = form.Phone,
                        DeliveryCost = form.DeliveryCost
                    };

                    // Добавляем в сервис
                    dataService.AddSupplier(newSupplier);

                    // Обновляем интерфейс
                    UpdateStatusInfo();

                    MessageBox.Show($"Поставщик '{form.FullName}' успешно добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении поставщика: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonEditItem_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование будет реализовано в следующей версии", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteSelectedOwner()
        {
            if (dataGridViewOwners_MBS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите владельца для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dataGridViewOwners_MBS.SelectedRows[0];
            int ownerId = (int)selectedRow.Cells[0].Value;
            string ownerName = selectedRow.Cells[1].Value.ToString();

            // Проверяем, есть ли у владельца магазины
            var ownerStores = dataService.GetStores().Where(s => s.OwnerId == ownerId).ToList();
            if (ownerStores.Count > 0)
            {
                MessageBox.Show($"Нельзя удалить владельца {ownerName}, так как у него есть {ownerStores.Count} магазин(ов).\n" +
                    "Сначала удалите или перепривяжите магазины.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show($"Вы действительно хотите удалить владельца '{ownerName}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Находим и удаляем владельца
                    var owners = dataService.GetOwners();
                    var ownerToRemove = owners.FirstOrDefault(o => o.Id == ownerId);

                    if (ownerToRemove != null)
                    {
                        owners.Remove(ownerToRemove);
                        UpdateDataGridViews();
                        UpdateStatusInfo();

                        MessageBox.Show($"Владелец '{ownerName}' успешно удален!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении владельца: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            int supplierCount = dataService.GetSuppliers().Count;
            decimal totalCapital = dataService.GetTotalCapital();

            decimal totalRevenue = 0;
            if (dataService.GetStores().Count > 0)
            {
                totalRevenue = dataService.GetStores().Sum(s => s.MonthlyRevenue);
            }

            decimal totalDeliveryCost = 0;
            if (dataService.GetSuppliers().Count > 0)
            {
                totalDeliveryCost = dataService.GetSuppliers().Sum(s => s.DeliveryCost);
            }

            string stats = $"📊 СТАТИСТИКА СЕТИ МАГАЗИНОВ 📊\n\n" +
                          $"👥 Владельцев: {ownerCount}\n" +
                          $"🏪 Магазинов: {storeCount}\n" +
                          $"🚚 Поставщиков: {supplierCount}\n\n" +
                          $"💰 Общий капитал: {totalCapital:N2} руб.\n" +
                          $"💵 Общая месячная выручка: {totalRevenue:N2} руб.\n" +
                          $"📦 Общая стоимость доставки: {totalDeliveryCost:N2} руб.\n\n" +
                          $"📈 Средняя выручка на магазин: {(storeCount > 0 ? totalRevenue / storeCount : 0):N2} руб.";

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
                    string ownerName = "Неизвестно";
                    var owner = dataService.GetOwners().FirstOrDefault(o => o.Id == store.OwnerId);
                    if (owner != null) ownerName = owner.FullName;

                    dataGridViewStores_MBS.Rows.Add(store.Id, store.Name, store.Address, store.Phone, store.MonthlyRevenue, ownerName);
                }
            }

            toolStripStatusLabelInfo_MBS.Text = $"Найдено по запросу '{searchText}'";
        }

        // Обработчики меню
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ToolStripMenuItemAbout_MBS_Click(object sender, EventArgs e)
        {
            string about = @"🏪 СЕТЬ МАГАЗИНОВ - MBS 🏪
Версия 3.0

Полная система управления сетью магазинов.
Возможности:
👥 Управление владельцами
🏪 Управление магазинами
🚚 Управление поставщиками
💰 Анализ финансовых показателей
🔍 Поиск по всем данным
💾 Сохранение и загрузка данных

Разработчик: MihajlichenkoSB
Дата: 2024

💡 Используйте цветные кнопки вверху для быстрого добавления!";

            MessageBox.Show(about, "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemUserGuide_MBS_Click(object sender, EventArgs e)
        {
            string guide = @"📘 РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ 📘

🌈 ЦВЕТНЫЕ КНОПКИ ВВЕРХУ:
🔵 Светло-синяя - Добавить владельца
🟢 Светло-зеленая - Добавить магазин
🔴 Светло-оранжевая - Добавить поставщика

1. ДОБАВЛЕНИЕ ВЛАДЕЛЬЦА:
   - Нажмите синюю кнопку 'Добавить владельца'
   - Заполните ФИО, адрес, телефон, капитал
   - Нажмите 'Добавить'

2. ДОБАВЛЕНИЕ МАГАЗИНА:
   - Нажмите зеленую кнопку 'Добавить магазин'
   - Заполните данные магазина
   - Выберите владельца из списка
   - Нажмите 'Добавить'

3. ДОБАВЛЕНИЕ ПОСТАВЩИКА:
   - Нажмите оранжевую кнопку 'Добавить поставщика'
   - Заполните данные поставщика
   - Укажите стоимость доставки
   - Нажмите 'Добавить'

4. УДАЛЕНИЕ ДАННЫХ:
   - Выберите строку в таблице
   - Нажмите красную кнопку 'Удалить'
   - Подтвердите удаление

5. ПОИСК ДАННЫХ:
   - Введите текст в поле поиска
   - Выберите тип данных в фильтре
   - Нажмите 'Найти' или Enter

6. СТАТИСТИКА:
   - Нажмите 'Статистика' для просмотра
   - Показывает общие показатели сети

⚠ ВНИМАНИЕ: Нельзя удалить владельца, у которого есть магазины!";

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
            
            // Меняем цвет панели с кнопками
            if (panelAddButtons.BackColor == Color.LightSteelBlue)
                panelAddButtons.BackColor = Color.LightGray;
            else
                panelAddButtons.BackColor = Color.LightSteelBlue;
        }

        // Обработчик двойного клика по магазину
        private void dataGridViewStores_MBS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewStores_MBS.Rows[e.RowIndex];
                string storeName = row.Cells[1].Value.ToString();
                string address = row.Cells[2].Value.ToString();
                string revenue = row.Cells[4].Value.ToString();
                string owner = row.Cells[5].Value.ToString();

                string info = $"🏪 Магазин: {storeName}\n" +
                             $"📍 Адрес: {address}\n" +
                             $"💰 Выручка: {revenue} руб.\n" +
                             $"👤 Владелец: {owner}";

                MessageBox.Show(info, "Информация о магазине",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Обработчик двойного клика по владельцу
        private void dataGridViewOwners_MBS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewOwners_MBS.Rows[e.RowIndex];
                string ownerName = row.Cells[1].Value.ToString();
                string address = row.Cells[2].Value.ToString();
                string capital = row.Cells[4].Value.ToString();

                // Считаем магазины владельца
                int ownerId = (int)row.Cells[0].Value;
                int storeCount = dataService.GetStores().Count(s => s.OwnerId == ownerId);

                string info = $"👤 Владелец: {ownerName}\n" +
                             $"📍 Адрес: {address}\n" +
                             $"💰 Капитал: {capital} руб.\n" +
                             $"🏪 Магазинов: {storeCount}";

                MessageBox.Show(info, "Информация о владельце",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}