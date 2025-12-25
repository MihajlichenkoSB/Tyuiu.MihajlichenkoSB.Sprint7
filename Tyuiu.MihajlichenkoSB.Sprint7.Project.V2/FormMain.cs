using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        private Timer timerDateTime;
        private DataTable dataTableOwners;
        private DataTable dataTableStores;
        private DataTable dataTableSuppliers;

        public FormMain()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            // Настройка таймера для обновления времени
            timerDateTime = new Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();

            // Инициализация таблиц данных
            InitializeDataTables();

            // Настройка DataGridView
            ConfigureDataGridViews();

            // Установка значений по умолчанию
            comboBoxFilter_MBS.SelectedIndex = 0;
            UpdateDateTime();
            UpdateSummaryCounts();

            // Установка прогресс-бара
            toolStripProgressBar_MBS.Visible = false;

            // Установка начальных значений для фильтров
            dateTimePickerFrom_MBS.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerTo_MBS.Value = DateTime.Now;
        }

        private void InitializeDataTables()
        {
            // Таблица владельцев
            dataTableOwners = new DataTable("Owners");
            dataTableOwners.Columns.Add("ID", typeof(int));
            dataTableOwners.Columns.Add("ФИО", typeof(string));
            dataTableOwners.Columns.Add("Телефон", typeof(string));
            dataTableOwners.Columns.Add("Email", typeof(string));
            dataTableOwners.Columns.Add("Дата регистрации", typeof(DateTime));
            dataTableOwners.Columns.Add("Статус", typeof(string));
            dataTableOwners.Columns.Add("Примечания", typeof(string));

            // Таблица магазинов
            dataTableStores = new DataTable("Stores");
            dataTableStores.Columns.Add("ID", typeof(int));
            dataTableStores.Columns.Add("Название", typeof(string));
            dataTableStores.Columns.Add("Адрес", typeof(string));
            dataTableStores.Columns.Add("Владелец", typeof(string));
            dataTableStores.Columns.Add("Телефон", typeof(string));
            dataTableStores.Columns.Add("Площадь (м²)", typeof(decimal));
            dataTableStores.Columns.Add("Статус", typeof(string));
            dataTableStores.Columns.Add("Дата открытия", typeof(DateTime));

            // Таблица поставщиков
            dataTableSuppliers = new DataTable("Suppliers");
            dataTableSuppliers.Columns.Add("ID", typeof(int));
            dataTableSuppliers.Columns.Add("Компания", typeof(string));
            dataTableSuppliers.Columns.Add("Контактное лицо", typeof(string));
            dataTableSuppliers.Columns.Add("Телефон", typeof(string));
            dataTableSuppliers.Columns.Add("Email", typeof(string));
            dataTableSuppliers.Columns.Add("Товар", typeof(string));
            dataTableSuppliers.Columns.Add("Цена", typeof(decimal));
            dataTableSuppliers.Columns.Add("Статус", typeof(string));

            // Привязка таблиц к DataGridView
            dataGridViewOwners_MBS.DataSource = dataTableOwners;
            dataGridViewStores_MBS.DataSource = dataTableStores;
            dataGridViewSuppliers_MBS.DataSource = dataTableSuppliers;
        }

        private void ConfigureDataGridViews()
        {
            // Настройка стилей для всех DataGridView
            foreach (DataGridView grid in new[] { dataGridViewOwners_MBS, dataGridViewStores_MBS, dataGridViewSuppliers_MBS })
            {
                grid.AutoGenerateColumns = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;
                grid.ReadOnly = true;
                grid.AllowUserToAddRows = false;
                grid.AllowUserToDeleteRows = false;
                grid.AllowUserToResizeRows = false;
                grid.RowHeadersVisible = false;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Настройка чередования строк
                grid.RowsDefaultCellStyle.BackColor = Color.White;
                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            }
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            toolStripStatusLabelDate_MBS.Text = DateTime.Now.ToString("dd.MM.yyyy");
            toolStripStatusLabelTime_MBS.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UpdateSummaryCounts()
        {
            if (labelTotalOwners_MBS != null)
                labelTotalOwners_MBS.Text = dataTableOwners.Rows.Count.ToString();
            if (labelTotalStores_MBS != null)
                labelTotalStores_MBS.Text = dataTableStores.Rows.Count.ToString();
            if (labelTotalSuppliers_MBS != null)
                labelTotalSuppliers_MBS.Text = dataTableSuppliers.Rows.Count.ToString();
            if (toolStripStatusLabelCount_MBS != null)
                toolStripStatusLabelCount_MBS.Text = $"Записей: {dataTableOwners.Rows.Count + dataTableStores.Rows.Count + dataTableSuppliers.Rows.Count}";
        }

        #region Обработчики событий меню и панели инструментов

        private void ToolStripMenuItemExit_MBS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ToolStripMenuItemAbout_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Сеть магазинов - Управление данными\n" +
                "Версия 2.0\n" +
                "Разработано: MBS\n" +
                "© 2024 Все права защищены\n\n" +
                "Функции:\n" +
                "• Управление владельцами магазинов\n" +
                "• Управление магазинами\n" +
                "• Управление поставщиками\n" +
                "• Статистика и аналитика\n" +
                "• Экспорт/Импорт данных",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ToolStripMenuItemUserGuide_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "📚 Руководство пользователя\n\n" +
                "1. МЕНЮ:\n" +
                "   • Файл - работа с файлами, печать, выход\n" +
                "   • Данные - добавление, редактирование, удаление записей\n" +
                "   • Анализ - статистика, графики, отчеты\n" +
                "   • Вид - настройка интерфейса\n" +
                "   • Справка - руководство, обновления, о программе\n\n" +
                "2. ПАНЕЛЬ ИНСТРУМЕНТОВ:\n" +
                "   • Быстрый доступ к основным функциям\n" +
                "   • Иконки соответствуют пунктам меню\n\n" +
                "3. РАБОЧАЯ ОБЛАСТЬ:\n" +
                "   • Вкладки для разных типов данных\n" +
                "   • Таблицы с возможностью сортировки\n\n" +
                "4. ПАНЕЛЬ ПОИСКА:\n" +
                "   • Быстрый поиск по всем данным\n" +
                "   • Фильтрация по категориям\n\n" +
                "5. БОКОВАЯ ПАНЕЛЬ:\n" +
                "   • Быстрые действия\n" +
                "   • Расширенные фильтры\n" +
                "   • Сводная информация",
                "Руководство пользователя",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ButtonAddOwner_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                // Используем существующую форму FormAddOwner
                FormAddOwner form = new FormAddOwner();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Получаем данные из формы
                    // ВАЖНО: Убедитесь, что в FormAddOwner есть публичные свойства для получения данных
                    // Например: form.FullName, form.Phone, form.Email

                    // Добавление данных
                    dataTableOwners.Rows.Add(
                        dataTableOwners.Rows.Count + 1,
                        "Полученное ФИО", // Замените на form.FullName
                        "Полученный телефон", // Замените на form.Phone
                        "Полученный email", // Замените на form.Email
                        DateTime.Now,
                        "Активный",
                        "Добавлено через форму"
                    );

                    UpdateSummaryCounts();
                    toolStripStatusLabelInfo_MBS.Text = "Владелец успешно добавлен";
                    MessageBox.Show("Владелец добавлен", "Новый владелец успешно добавлен в базу данных.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при добавлении владельца", ex.Message);
            }
        }

        private void ButtonAddStore_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                // Используем существующую форму FormAddStore
                FormAddStore form = new FormAddStore();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Получаем данные из формы
                    // ВАЖНО: Убедитесь, что в FormAddStore есть публичные свойства

                    // Добавление данных
                    dataTableStores.Rows.Add(
                        dataTableStores.Rows.Count + 1,
                        "Название магазина", // Замените на form.StoreName
                        "Адрес магазина", // Замените на form.Address
                        "Иванов И.И.", // В реальном приложении будет выбранный владелец
                        "Телефон магазина", // Замените на form.Phone
                        100.0m, // Замените на form.Area
                        "Активный",
                        DateTime.Now
                    );

                    UpdateSummaryCounts();
                    toolStripStatusLabelInfo_MBS.Text = "Магазин успешно добавлен";
                    MessageBox.Show("Магазин добавлен", "Новый магазин успешно добавлен в базу данных.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при добавлении магазина", ex.Message);
            }
        }

        private void ButtonAddSupplier_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                // Используем существующую форму FormAddSupplier
                FormAddSupplier form = new FormAddSupplier();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Получаем данные из формы
                    // ВАЖНО: Убедитесь, что в FormAddSupplier есть публичные свойства

                    // Добавление данных
                    dataTableSuppliers.Rows.Add(
                        dataTableSuppliers.Rows.Count + 1,
                        "Название компании", // Замените на form.CompanyName
                        "Контактное лицо", // Замените на form.ContactPerson
                        "Телефон поставщика", // Замените на form.Phone
                        "email@example.com", // Замените на form.Email
                        "Товар", // Замените на form.Product
                        1000.0m, // Замените на form.Price
                        "Активный"
                    );

                    UpdateSummaryCounts();
                    toolStripStatusLabelInfo_MBS.Text = "Поставщик успешно добавлен";
                    MessageBox.Show("Поставщик добавлен", "Новый поставщик успешно добавлен в базу данных.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка при добавлении поставщика", ex.Message);
            }
        }

        private void ButtonEditItem_MBS_Click(object sender, EventArgs e)
        {
            DataGridView currentGrid = GetCurrentDataGridView();

            if (currentGrid != null && currentGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = currentGrid.SelectedRows[0].Index;
                toolStripStatusLabelInfo_MBS.Text = "Редактирование записи...";

                // Здесь будет логика открытия формы редактирования
                MessageBox.Show("Функция редактирования в разработке", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShowWarning("Предупреждение", "Выберите запись для редактирования");
            }
        }

        private void ButtonDeleteItem_MBS_Click(object sender, EventArgs e)
        {
            DataGridView currentGrid = GetCurrentDataGridView();

            if (currentGrid != null && currentGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataTable dataTable = GetCurrentDataTable();
                    if (dataTable != null)
                    {
                        int selectedIndex = currentGrid.SelectedRows[0].Index;
                        if (selectedIndex >= 0 && selectedIndex < dataTable.Rows.Count)
                        {
                            dataTable.Rows.RemoveAt(selectedIndex);
                            UpdateSummaryCounts();
                            toolStripStatusLabelInfo_MBS.Text = "Запись удалена";
                            MessageBox.Show("Удаление", "Запись успешно удалена",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                ShowWarning("Предупреждение", "Выберите запись для удаления");
            }
        }

        private void ButtonSearch_MBS_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_MBS.Text.Trim();
            string filterType = comboBoxFilter_MBS.SelectedItem?.ToString() ?? "Все категории";

            if (!string.IsNullOrEmpty(searchText))
            {
                SearchData(searchText, filterType);
                toolStripStatusLabelInfo_MBS.Text = $"Поиск: {searchText} ({filterType})";
            }
            else
            {
                ClearSearch();
            }
        }

        private void ButtonClearSearch_MBS_Click(object sender, EventArgs e)
        {
            ClearSearch();
        }

        private void ButtonApplyFilter_MBS_Click(object sender, EventArgs e)
        {
            ApplyAdvancedFilters();
        }

        private void ButtonResetFilter_MBS_Click(object sender, EventArgs e)
        {
            ResetAdvancedFilters();
        }

        private void ButtonLoadData_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Excel файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
                    openFileDialog.Title = "Загрузить данные";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        toolStripProgressBar_MBS.Visible = true;
                        toolStripProgressBar_MBS.Style = ProgressBarStyle.Marquee;
                        toolStripStatusLabelInfo_MBS.Text = "Загрузка данных...";

                        // Имитация загрузки данных
                        timerDateTime.Stop();
                        System.Threading.Thread.Sleep(2000);
                        timerDateTime.Start();

                        // Загрузка тестовых данных
                        LoadSampleData();

                        toolStripProgressBar_MBS.Visible = false;
                        toolStripStatusLabelInfo_MBS.Text = "Данные успешно загружены";
                        MessageBox.Show("Загрузка данных", "Данные успешно загружены из файла.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка загрузки данных", ex.Message);
            }
            finally
            {
                toolStripProgressBar_MBS.Visible = false;
            }
        }

        private void ButtonSaveData_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Excel файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
                    saveFileDialog.Title = "Сохранить данные";
                    saveFileDialog.FileName = $"СетьМагазинов_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        toolStripProgressBar_MBS.Visible = true;
                        toolStripProgressBar_MBS.Style = ProgressBarStyle.Marquee;
                        toolStripStatusLabelInfo_MBS.Text = "Сохранение данных...";

                        // Имитация сохранения данных
                        timerDateTime.Stop();
                        System.Threading.Thread.Sleep(1500);
                        timerDateTime.Start();

                        // В реальном приложении здесь будет логика сохранения в файл
                        string filePath = saveFileDialog.FileName;

                        toolStripProgressBar_MBS.Visible = false;
                        toolStripStatusLabelInfo_MBS.Text = $"Данные сохранены в: {Path.GetFileName(filePath)}";
                        MessageBox.Show("Сохранение данных", "Данные успешно сохранены в файл.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Ошибка сохранения данных", ex.Message);
            }
            finally
            {
                toolStripProgressBar_MBS.Visible = false;
            }
        }

        private void ButtonShowStats_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем простую форму статистики
                Form statsForm = new Form();
                statsForm.Text = "Статистика";
                statsForm.Size = new Size(400, 300);

                Label statsLabel = new Label();
                statsLabel.Text = GenerateReport();
                statsLabel.AutoSize = true;
                statsLabel.Location = new Point(20, 20);
                statsLabel.Font = new Font("Segoe UI", 10);

                statsForm.Controls.Add(statsLabel);
                statsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ShowError("Ошибка отображения статистики", ex.Message);
            }
        }

        private void ButtonShowChart_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Функция графиков в разработке", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка отображения графиков", ex.Message);
            }
        }

        private void ButtonQuickStats_MBS_Click(object sender, EventArgs e)
        {
            ButtonShowStats_MBS_Click(sender, e);
        }

        private void ButtonQuickChart_MBS_Click(object sender, EventArgs e)
        {
            ButtonShowChart_MBS_Click(sender, e);
        }

        private void ButtonQuickReport_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabelInfo_MBS.Text = "Генерация отчета...";

                // Имитация генерации отчета
                timerDateTime.Stop();
                System.Threading.Thread.Sleep(1000);
                timerDateTime.Start();

                string report = GenerateReport();

                MessageBox.Show(report, "Сводный отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabelInfo_MBS.Text = "Отчет сгенерирован";
            }
            catch (Exception ex)
            {
                ShowError("Ошибка генерации отчета", ex.Message);
            }
        }

        #endregion

        #region Вспомогательные методы

        private DataGridView GetCurrentDataGridView()
        {
            switch (tabControlMain_MBS.SelectedIndex)
            {
                case 0: return dataGridViewOwners_MBS;
                case 1: return dataGridViewStores_MBS;
                case 2: return dataGridViewSuppliers_MBS;
                default: return null;
            }
        }

        private DataTable GetCurrentDataTable()
        {
            switch (tabControlMain_MBS.SelectedIndex)
            {
                case 0: return dataTableOwners;
                case 1: return dataTableStores;
                case 2: return dataTableSuppliers;
                default: return null;
            }
        }

        private void SearchData(string searchText, string filterType)
        {
            try
            {
                // В реальном приложении здесь будет логика поиска
                // Это упрощенная реализация для демонстрации

                DataGridView currentGrid = GetCurrentDataGridView();
                if (currentGrid != null)
                {
                    foreach (DataGridViewRow row in currentGrid.Rows)
                    {
                        bool found = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                found = true;
                                break;
                            }
                        }
                        row.Visible = found;
                    }
                }

                MessageBox.Show($"Поиск", $"Найдено записей по запросу: {searchText}",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка поиска", ex.Message);
            }
        }

        private void ClearSearch()
        {
            textBoxSearch_MBS.Clear();

            foreach (DataGridView grid in new[] { dataGridViewOwners_MBS, dataGridViewStores_MBS, dataGridViewSuppliers_MBS })
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    row.Visible = true;
                }
            }

            toolStripStatusLabelInfo_MBS.Text = "Поиск очищен";
        }

        private void ApplyAdvancedFilters()
        {
            try
            {
                bool activeOnly = checkBoxActiveOnly_MBS.Checked;
                bool highPriority = checkBoxHighPriority_MBS.Checked;
                DateTime fromDate = dateTimePickerFrom_MBS.Value;
                DateTime toDate = dateTimePickerTo_MBS.Value;

                // В реальном приложении здесь будет логика фильтрации
                toolStripStatusLabelInfo_MBS.Text = "Фильтры применены";
                MessageBox.Show("Фильтры", "Расширенные фильтры успешно применены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка применения фильтров", ex.Message);
            }
        }

        private void ResetAdvancedFilters()
        {
            checkBoxActiveOnly_MBS.Checked = false;
            checkBoxHighPriority_MBS.Checked = false;
            dateTimePickerFrom_MBS.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerTo_MBS.Value = DateTime.Now;

            ClearSearch();
            toolStripStatusLabelInfo_MBS.Text = "Фильтры сброшены";
        }

        private void LoadSampleData()
        {
            // Очистка существующих данных
            dataTableOwners.Clear();
            dataTableStores.Clear();
            dataTableSuppliers.Clear();

            // Добавление тестовых данных владельцев
            dataTableOwners.Rows.Add(1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "ivanov@mail.ru", new DateTime(2020, 1, 15), "Активный", "Основатель сети");
            dataTableOwners.Rows.Add(2, "Петрова Анна Сергеевна", "+7 (999) 234-56-78", "petrova@mail.ru", new DateTime(2021, 3, 20), "Активный", "Инвестор");
            dataTableOwners.Rows.Add(3, "Сидоров Алексей Петрович", "+7 (999) 345-67-89", "sidorov@mail.ru", new DateTime(2022, 5, 10), "Неактивный", "Бывший владелец");

            // Добавление тестовых данных магазинов
            dataTableStores.Rows.Add(1, "Супермаркет 'Продукты'", "ул. Ленина, д. 10", "Иванов И.И.", "+7 (999) 111-22-33", 500.5m, "Активный", new DateTime(2020, 2, 1));
            dataTableStores.Rows.Add(2, "Магазин 'Одежда'", "ул. Мира, д. 25", "Петрова А.С.", "+7 (999) 222-33-44", 300.0m, "Активный", new DateTime(2021, 4, 15));
            dataTableStores.Rows.Add(3, "Торговый центр 'Мега'", "пр. Победы, д. 100", "Иванов И.И.", "+7 (999) 333-44-55", 1500.0m, "Активный", new DateTime(2022, 6, 1));

            // Добавление тестовых данных поставщиков
            dataTableSuppliers.Rows.Add(1, "ООО 'ПродуктСнаб'", "Смирнов А.А.", "+7 (999) 444-55-66", "smirnov@product.ru", "Продукты питания", 150000.0m, "Активный");
            dataTableSuppliers.Rows.Add(2, "ИП 'ТекстильТорг'", "Козлова М.И.", "+7 (999) 555-66-77", "kozlov@textile.ru", "Одежда и ткани", 80000.0m, "Активный");
            dataTableSuppliers.Rows.Add(3, "ЗАО 'ТехноСнаб'", "Волков П.С.", "+7 (999) 666-77-88", "volkov@techno.ru", "Электроника", 250000.0m, "Активный");

            UpdateSummaryCounts();
        }

        private string GenerateReport()
        {
            return $"📋 СВОДНЫЙ ОТЧЕТ\n" +
                   $"Дата формирования: {DateTime.Now:dd.MM.yyyy HH:mm}\n" +
                   $"----------------------------------------\n" +
                   $"📊 СТАТИСТИКА:\n" +
                   $"• Всего владельцев: {dataTableOwners.Rows.Count}\n" +
                   $"• Всего магазинов: {dataTableStores.Rows.Count}\n" +
                   $"• Всего поставщиков: {dataTableSuppliers.Rows.Count}\n" +
                   $"• Общее количество записей: {dataTableOwners.Rows.Count + dataTableStores.Rows.Count + dataTableSuppliers.Rows.Count}\n" +
                   $"----------------------------------------\n" +
                   $"📈 АКТИВНОСТЬ:\n" +
                   $"• Активных записей: {GetActiveCount()}\n" +
                   $"• Неактивных записей: {GetInactiveCount()}\n" +
                   $"----------------------------------------\n" +
                   $"💡 РЕКОМЕНДАЦИИ:\n" +
                   $"• Добавить больше поставщиков\n" +
                   $"• Проверить неактивные записи\n" +
                   $"• Обновить контактную информацию";
        }

        private int GetActiveCount()
        {
            int count = 0;
            foreach (DataRow row in dataTableOwners.Rows)
                if (row["Статус"].ToString() == "Активный") count++;
            foreach (DataRow row in dataTableStores.Rows)
                if (row["Статус"].ToString() == "Активный") count++;
            foreach (DataRow row in dataTableSuppliers.Rows)
                if (row["Статус"].ToString() == "Активный") count++;
            return count;
        }

        private int GetInactiveCount()
        {
            int count = 0;
            foreach (DataRow row in dataTableOwners.Rows)
                if (row["Статус"].ToString() == "Неактивный") count++;
            foreach (DataRow row in dataTableStores.Rows)
                if (row["Статус"].ToString() == "Неактивный") count++;
            foreach (DataRow row in dataTableSuppliers.Rows)
                if (row["Статус"].ToString() == "Неактивный") count++;
            return count;
        }

        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            toolStripStatusLabelInfo_MBS.Text = $"Ошибка: {title}";
        }

        private void ShowWarning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Дополнительные обработчики событий

        private void TextBoxSearch_MBS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonSearch_MBS_Click(sender, e);
                e.Handled = true;
            }
        }

        private void TabControlMain_MBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSummaryCounts();
            string[] tabNames = { "Владельцы", "Магазины", "Поставщики" };
            if (tabControlMain_MBS.SelectedIndex >= 0 && tabControlMain_MBS.SelectedIndex < tabNames.Length)
            {
                toolStripStatusLabelInfo_MBS.Text = $"Активная вкладка: {tabNames[tabControlMain_MBS.SelectedIndex]}";
            }
        }

        private void ToolStripMenuItemTheme_MBS_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Изменение темы оформления
            string theme = e.ClickedItem.Text;
            toolStripStatusLabelInfo_MBS.Text = $"Тема изменена на: {theme}";

            // В реальном приложении здесь будет логика смены темы
            Color backgroundColor = Color.White;
            Color textColor = Color.Black;

            switch (theme)
            {
                case "Светлая":
                    backgroundColor = Color.White;
                    textColor = Color.Black;
                    break;
                case "Темная":
                    backgroundColor = Color.FromArgb(45, 45, 48);
                    textColor = Color.White;
                    break;
                case "Синяя":
                    backgroundColor = Color.FromArgb(240, 240, 245);
                    textColor = Color.FromArgb(0, 122, 204);
                    break;
            }

            this.BackColor = backgroundColor;
            this.ForeColor = textColor;
        }

        private void ToolStripMenuItemToolbar_MBS_Click(object sender, EventArgs e)
        {
            toolStripMain_MBS.Visible = toolStripMenuItemToolbar_MBS.Checked;
        }

        private void ToolStripMenuItemStatusbar_MBS_Click(object sender, EventArgs e)
        {
            statusStripMain_MBS.Visible = toolStripMenuItemStatusbar_MBS.Checked;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Загрузка данных при запуске
            LoadSampleData();
            toolStripStatusLabelInfo_MBS.Text = "Приложение загружено и готово к работе";
        }

        // Обработчики для меню (добавьте эти методы)
        private void ToolStripMenuItemLoadData_MBS_Click(object sender, EventArgs e)
        {
            ButtonLoadData_MBS_Click(sender, e);
        }

        private void ToolStripMenuItemSaveData_MBS_Click(object sender, EventArgs e)
        {
            ButtonSaveData_MBS_Click(sender, e);
        }

        private void ToolStripMenuItemPrint_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция печати в разработке", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemNew_MBS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Создать новую базу данных? Все несохраненные данные будут потеряны.", "Новый файл",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataTableOwners.Clear();
                dataTableStores.Clear();
                dataTableSuppliers.Clear();
                UpdateSummaryCounts();
                toolStripStatusLabelInfo_MBS.Text = "Создана новая база данных";
            }
        }

        private void ToolStripMenuItemRefresh_MBS_Click(object sender, EventArgs e)
        {
            UpdateSummaryCounts();
            ClearSearch();
            toolStripStatusLabelInfo_MBS.Text = "Данные обновлены";
        }

        private void ToolStripMenuItemExport_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция экспорта в разработке", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemCheckUpdates_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверка обновлений...\nУ вас установлена последняя версия.", "Обновления",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Обработчики событий для кнопок на панели инструментов

        private void toolStripButtonNew_MBS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemNew_MBS_Click(sender, e);
        }

        private void toolStripButtonPrint_MBS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemPrint_MBS_Click(sender, e);
        }

        private void toolStripButtonRefresh_MBS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemRefresh_MBS_Click(sender, e);
        }

        private void toolStripButtonExport_MBS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemExport_MBS_Click(sender, e);
        }

        #endregion

        private void groupBoxSummary_MBS_Enter(object sender, EventArgs e)
        {

        }

        private void labelOwnersCount_MBS_Click(object sender, EventArgs e)
        {

        }
    }
}