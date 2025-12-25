using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    public partial class FormMain : Form
    {
        private Button buttonAddOwner_MBS;
        private Button buttonAddStore_MBS;
        private Button buttonAddSupplier_MBS;

        private DataTable dataTableOwners;
        private DataTable dataTableStores;
        private DataTable dataTableSuppliers;
        private Timer timerDateTime;

        public FormMain()
        {
            InitializeComponent();


            // ============ СОЗДАЕМ И НАСТРАИВАЕМ КНОПКИ ============
            CreateAddButtons();

            // Инициализация таймера для обновления времени
            timerDateTime = new Timer();
            timerDateTime.Interval = 1000;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();

            // Обработчики для основных кнопок (они уже есть в Designer)
            buttonSearch_MBS.Click += ButtonSearch_MBS_Click;
            buttonClearSearch_MBS.Click += ButtonClearSearch_MBS_Click;
            buttonApplyFilter_MBS.Click += ButtonApplyFilter_MBS_Click;
            buttonResetFilter_MBS.Click += ButtonResetFilter_MBS_Click;
            buttonQuickStats_MBS.Click += ButtonQuickStats_MBS_Click;
            buttonQuickChart_MBS.Click += ButtonQuickChart_MBS_Click;
            buttonQuickReport_MBS.Click += ButtonQuickReport_MBS_Click;

            // Обработчики для новых кнопок добавления
            buttonAddOwner_MBS.Click += ButtonAddOwner_MBS_Click;
            buttonAddStore_MBS.Click += ButtonAddStore_MBS_Click;
            buttonAddSupplier_MBS.Click += ButtonAddSupplier_MBS_Click;

            // Обработчики для кнопок панели инструментов
            toolStripButtonAddOwner_MBS.Click += ToolStripMenuItemAddOwner_MBS_Click;
            toolStripButtonAddStore_MBS.Click += ToolStripMenuItemAddStore_MBS_Click;
            toolStripButtonAddSupplier_MBS.Click += ToolStripMenuItemAddSupplier_MBS_Click;
            toolStripButtonNew_MBS.Click += ToolStripMenuItemNew_MBS_Click;
            toolStripButtonSave_MBS.Click += ToolStripMenuItemSaveData_MBS_Click;
            toolStripButtonLoad_MBS.Click += ToolStripMenuItemLoadData_MBS_Click;
            toolStripButtonPrint_MBS.Click += ToolStripMenuItemPrint_MBS_Click;
            toolStripButtonRefresh_MBS.Click += ToolStripMenuItemRefresh_MBS_Click;
            toolStripButtonStats_MBS.Click += ToolStripMenuItemStats_MBS_Click;
            toolStripButtonChart_MBS.Click += ToolStripMenuItemCharts_MBS_Click;
            toolStripButtonReport_MBS.Click += ToolStripMenuItemReport_MBS_Click;
            toolStripButtonHelp_MBS.Click += ToolStripMenuItemUserGuide_MBS_Click;

            // Меню
            toolStripMenuItemExit_MBS.Click += ToolStripMenuItemExit_MBS_Click;
            toolStripMenuItemAbout_MBS.Click += ToolStripMenuItemAbout_MBS_Click;
            toolStripMenuItemUserGuide_MBS.Click += ToolStripMenuItemUserGuide_MBS_Click;
            toolStripMenuItemVideoGuide_MBS.Click += ToolStripMenuItemVideoGuide_MBS_Click;
            toolStripMenuItemCheckUpdates_MBS.Click += ToolStripMenuItemCheckUpdates_MBS_Click;

            // Меню добавления
            toolStripMenuItemAddOwner_MBS.Click += ToolStripMenuItemAddOwner_MBS_Click;
            toolStripMenuItemAddStore_MBS.Click += ToolStripMenuItemAddStore_MBS_Click;
            toolStripMenuItemAddSupplier_MBS.Click += ToolStripMenuItemAddSupplier_MBS_Click;
            toolStripMenuItemNew_MBS.Click += ToolStripMenuItemNew_MBS_Click;
            toolStripMenuItemLoadData_MBS.Click += ToolStripMenuItemLoadData_MBS_Click;
            toolStripMenuItemSaveData_MBS.Click += ToolStripMenuItemSaveData_MBS_Click;
            toolStripMenuItemSaveAs_MBS.Click += ToolStripMenuItemSaveAs_MBS_Click;
            toolStripMenuItemPrint_MBS.Click += ToolStripMenuItemPrint_MBS_Click;
            toolStripMenuItemRefresh_MBS.Click += ToolStripMenuItemRefresh_MBS_Click;
            toolStripMenuItemStats_MBS.Click += ToolStripMenuItemStats_MBS_Click;
            toolStripMenuItemCharts_MBS.Click += ToolStripMenuItemCharts_MBS_Click;
            toolStripMenuItemReport_MBS.Click += ToolStripMenuItemReport_MBS_Click;
            toolStripMenuItemExport_MBS.Click += ToolStripMenuItemExport_MBS_Click;
            toolStripMenuItemEdit_MBS.Click += ToolStripMenuItemEdit_MBS_Click;
            toolStripMenuItemDelete_MBS.Click += ToolStripMenuItemDelete_MBS_Click;

            // Обработчики для меню вида
            toolStripMenuItemToolbar_MBS.CheckedChanged += ToolStripMenuItemToolbar_MBS_CheckedChanged;
            toolStripMenuItemStatusbar_MBS.CheckedChanged += ToolStripMenuItemStatusbar_MBS_CheckedChanged;
            toolStripMenuItemLight_MBS.Click += ToolStripMenuItemLight_MBS_Click;
            toolStripMenuItemDark_MBS.Click += ToolStripMenuItemDark_MBS_Click;
            toolStripMenuItemBlue_MBS.Click += ToolStripMenuItemBlue_MBS_Click;

            // Обработчики для других событий
            textBoxSearch_MBS.KeyPress += TextBoxSearch_MBS_KeyPress;
            tabControlMain_MBS.SelectedIndexChanged += TabControlMain_MBS_SelectedIndexChanged;
            this.Load += FormMain_Load;

            InitializeApplication();
        }

        private void CreateAddButtons()
        {
            // Кнопка "Добавить владельца" (зеленая)
            buttonAddOwner_MBS = new Button();
            buttonAddOwner_MBS.Name = "buttonAddOwner_MBS";
            buttonAddOwner_MBS.Text = "➕ Владелец";
            buttonAddOwner_MBS.BackColor = Color.FromArgb(46, 204, 113);
            buttonAddOwner_MBS.ForeColor = Color.White;
            buttonAddOwner_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddOwner_MBS.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            buttonAddOwner_MBS.Location = new Point(760, 15);
            buttonAddOwner_MBS.Size = new Size(130, 30);
            buttonAddOwner_MBS.UseVisualStyleBackColor = false;
            panelSearch_MBS.Controls.Add(buttonAddOwner_MBS);

            // Кнопка "Добавить магазин" (синяя)
            buttonAddStore_MBS = new Button();
            buttonAddStore_MBS.Name = "buttonAddStore_MBS";
            buttonAddStore_MBS.Text = "➕ Магазин";
            buttonAddStore_MBS.BackColor = Color.FromArgb(52, 152, 219);
            buttonAddStore_MBS.ForeColor = Color.White;
            buttonAddStore_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddStore_MBS.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            buttonAddStore_MBS.Location = new Point(900, 15);
            buttonAddStore_MBS.Size = new Size(130, 30);
            buttonAddStore_MBS.UseVisualStyleBackColor = false;
            panelSearch_MBS.Controls.Add(buttonAddStore_MBS);

            // Кнопка "Добавить поставщика" (фиолетовая)
            buttonAddSupplier_MBS = new Button();
            buttonAddSupplier_MBS.Name = "buttonAddSupplier_MBS";
            buttonAddSupplier_MBS.Text = "➕ Поставщик";
            buttonAddSupplier_MBS.BackColor = Color.FromArgb(155, 89, 182);
            buttonAddSupplier_MBS.ForeColor = Color.White;
            buttonAddSupplier_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddSupplier_MBS.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            buttonAddSupplier_MBS.Location = new Point(1040, 15);
            buttonAddSupplier_MBS.Size = new Size(130, 30);
            buttonAddSupplier_MBS.UseVisualStyleBackColor = false;
            panelSearch_MBS.Controls.Add(buttonAddSupplier_MBS);
        }

        private void InitializeApplication()
        {
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

            // Загрузка тестовых данных
            LoadSampleData();
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

            // Таблица магазинов
            dataTableStores = new DataTable("Stores");
            dataTableStores.Columns.Add("ID", typeof(int));
            dataTableStores.Columns.Add("Название", typeof(string));
            dataTableStores.Columns.Add("Адрес", typeof(string));
            dataTableStores.Columns.Add("Владелец", typeof(string));
            dataTableStores.Columns.Add("Телефон", typeof(string));
            dataTableStores.Columns.Add("Площадь (м²)", typeof(decimal));
            dataTableStores.Columns.Add("Статус", typeof(string));

            // Таблица поставщиков
            dataTableSuppliers = new DataTable("Suppliers");
            dataTableSuppliers.Columns.Add("ID", typeof(int));
            dataTableSuppliers.Columns.Add("Компания", typeof(string));
            dataTableSuppliers.Columns.Add("Контактное лицо", typeof(string));
            dataTableSuppliers.Columns.Add("Телефон", typeof(string));
            dataTableSuppliers.Columns.Add("Email", typeof(string));
            dataTableSuppliers.Columns.Add("Товар", typeof(string));
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
                grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            }
        }

        #region Обработчики событий таймера и обновлений

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
            labelTotalOwners_MBS.Text = dataTableOwners.Rows.Count.ToString();
            labelTotalStores_MBS.Text = dataTableStores.Rows.Count.ToString();
            labelTotalSuppliers_MBS.Text = dataTableSuppliers.Rows.Count.ToString();
            toolStripStatusLabelCount_MBS.Text = $"Записей: {dataTableOwners.Rows.Count + dataTableStores.Rows.Count + dataTableSuppliers.Rows.Count}";
        }

        #endregion

        #region Обработчики событий новых кнопок добавления

        private void ButtonAddOwner_MBS_Click(object sender, EventArgs e)
        {
            AddNewOwner();
        }

        private void ButtonAddStore_MBS_Click(object sender, EventArgs e)
        {
            AddNewStore();
        }

        private void ButtonAddSupplier_MBS_Click(object sender, EventArgs e)
        {
            AddNewSupplier();
        }

        #endregion

        #region Обработчики событий меню

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
                "© 2025 Все права защищены\n\n" +
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

        private void ToolStripMenuItemVideoGuide_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Видео-руководство доступно на нашем сайте.\n" +
                "Ссылка: https://www.example.com/video-guide",
                "Видео-руководство",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ToolStripMenuItemCheckUpdates_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Проверка обновлений...\nУ вас установлена последняя версия.",
                "Обновления",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ToolStripMenuItemAddOwner_MBS_Click(object sender, EventArgs e)
        {
            AddNewOwner();
        }

        private void ToolStripMenuItemAddStore_MBS_Click(object sender, EventArgs e)
        {
            AddNewStore();
        }

        private void ToolStripMenuItemAddSupplier_MBS_Click(object sender, EventArgs e)
        {
            AddNewSupplier();
        }

        private void ToolStripMenuItemLoadData_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                    openFileDialog.Title = "Загрузить данные";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        toolStripProgressBar_MBS.Visible = true;
                        toolStripProgressBar_MBS.Style = ProgressBarStyle.Marquee;
                        toolStripStatusLabelInfo_MBS.Text = "Загрузка данных...";

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

        private void ToolStripMenuItemSaveData_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                    saveFileDialog.Title = "Сохранить данные";
                    saveFileDialog.FileName = $"СетьМагазинов_{DateTime.Now:yyyyMMdd_HHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        toolStripProgressBar_MBS.Visible = true;
                        toolStripProgressBar_MBS.Style = ProgressBarStyle.Marquee;
                        toolStripStatusLabelInfo_MBS.Text = "Сохранение данных...";

                        toolStripProgressBar_MBS.Visible = false;
                        toolStripStatusLabelInfo_MBS.Text = $"Данные сохранены в: {saveFileDialog.FileName}";
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

        private void ToolStripMenuItemSaveAs_MBS_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemSaveData_MBS_Click(sender, e);
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

        private void ToolStripMenuItemStats_MBS_Click(object sender, EventArgs e)
        {
            ButtonQuickStats_MBS_Click(sender, e);
        }

        private void ToolStripMenuItemCharts_MBS_Click(object sender, EventArgs e)
        {
            ButtonQuickChart_MBS_Click(sender, e);
        }

        private void ToolStripMenuItemReport_MBS_Click(object sender, EventArgs e)
        {
            ButtonQuickReport_MBS_Click(sender, e);
        }

        private void ToolStripMenuItemExport_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция экспорта в разработке", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemEdit_MBS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция редактирования в разработке", "Информация",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemDelete_MBS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранную запись?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Здесь будет логика удаления выбранной записи
                toolStripStatusLabelInfo_MBS.Text = "Запись удалена";
            }
        }

        #endregion

        #region Методы добавления новых записей

        private void AddNewOwner()
        {
            try
            {
                FormAddOwner form = new FormAddOwner();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataTableOwners.Rows.Add(
                        dataTableOwners.Rows.Count + 1,
                        form.FullName,
                        form.Phone,
                        "example@mail.ru",
                        DateTime.Now,
                        "Активный"
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

        private void AddNewStore()
        {
            try
            {
                FormAddStore form = new FormAddStore();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataTableStores.Rows.Add(
                        dataTableStores.Rows.Count + 1,
                        form.StoreName,
                        form.Address,
                        "Иванов И.И.",
                        form.Phone,
                        form.Area,
                        "Активный"
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

        private void AddNewSupplier()
        {
            try
            {
                FormAddSupplier form = new FormAddSupplier();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dataTableSuppliers.Rows.Add(
                        dataTableSuppliers.Rows.Count + 1,
                        "Название компании",
                        form.FullName,
                        form.Phone,
                        "email@example.com",
                        form.Product,
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

        #endregion

        #region Обработчики событий кнопок поиска и фильтров

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
            try
            {
                bool activeOnly = checkBoxActiveOnly_MBS.Checked;
                bool highPriority = checkBoxHighPriority_MBS.Checked;
                DateTime fromDate = dateTimePickerFrom_MBS.Value;
                DateTime toDate = dateTimePickerTo_MBS.Value;

                toolStripStatusLabelInfo_MBS.Text = "Фильтры применены";
                MessageBox.Show($"Фильтры применены:\n" +
                    $"Только активные: {activeOnly}\n" +
                    $"Высокий приоритет: {highPriority}\n" +
                    $"Дата от: {fromDate:dd.MM.yyyy}\n" +
                    $"Дата до: {toDate:dd.MM.yyyy}",
                    "Фильтры применены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Ошибка применения фильтров", ex.Message);
            }
        }

        private void ButtonResetFilter_MBS_Click(object sender, EventArgs e)
        {
            checkBoxActiveOnly_MBS.Checked = false;
            checkBoxHighPriority_MBS.Checked = false;
            dateTimePickerFrom_MBS.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerTo_MBS.Value = DateTime.Now;

            ClearSearch();
            toolStripStatusLabelInfo_MBS.Text = "Фильтры сброшены";
        }

        private void ButtonQuickStats_MBS_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void ButtonQuickChart_MBS_Click(object sender, EventArgs e)
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

        private void ButtonQuickReport_MBS_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabelInfo_MBS.Text = "Генерация отчета...";

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

        #region Обработчики событий меню вида

        private void ToolStripMenuItemToolbar_MBS_CheckedChanged(object sender, EventArgs e)
        {
            toolStripMain_MBS.Visible = toolStripMenuItemToolbar_MBS.Checked;
        }

        private void ToolStripMenuItemStatusbar_MBS_CheckedChanged(object sender, EventArgs e)
        {
            statusStripMain_MBS.Visible = toolStripMenuItemStatusbar_MBS.Checked;
        }

        private void ToolStripMenuItemLight_MBS_Click(object sender, EventArgs e)
        {
            ApplyTheme("Светлая");
        }

        private void ToolStripMenuItemDark_MBS_Click(object sender, EventArgs e)
        {
            ApplyTheme("Темная");
        }

        private void ToolStripMenuItemBlue_MBS_Click(object sender, EventArgs e)
        {
            ApplyTheme("Синяя");
        }

        private void ApplyTheme(string themeName)
        {
            toolStripMenuItemLight_MBS.Checked = false;
            toolStripMenuItemDark_MBS.Checked = false;
            toolStripMenuItemBlue_MBS.Checked = false;

            switch (themeName)
            {
                case "Светлая":
                    toolStripMenuItemLight_MBS.Checked = true;
                    this.BackColor = Color.White;
                    this.ForeColor = Color.Black;
                    panelSidebar_MBS.BackColor = Color.FromArgb(240, 240, 245);
                    break;
                case "Темная":
                    toolStripMenuItemDark_MBS.Checked = true;
                    this.BackColor = Color.FromArgb(45, 45, 48);
                    this.ForeColor = Color.White;
                    panelSidebar_MBS.BackColor = Color.FromArgb(60, 60, 65);
                    break;
                case "Синяя":
                    toolStripMenuItemBlue_MBS.Checked = true;
                    this.BackColor = Color.FromArgb(240, 240, 245);
                    this.ForeColor = Color.FromArgb(0, 122, 204);
                    panelSidebar_MBS.BackColor = Color.FromArgb(230, 230, 235);
                    break;
            }

            toolStripStatusLabelInfo_MBS.Text = $"Тема изменена на: {themeName}";
        }

        #endregion

        #region Другие обработчики событий

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            toolStripStatusLabelInfo_MBS.Text = "Приложение загружено и готово к работе";
        }

        #endregion

        #region Вспомогательные методы

        private void SearchData(string searchText, string filterType)
        {
            try
            {
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

        private void LoadSampleData()
        {
            // Очистка существующих данных
            dataTableOwners.Clear();
            dataTableStores.Clear();
            dataTableSuppliers.Clear();

            // Добавление тестовых данных владельцев
            dataTableOwners.Rows.Add(1, "Иванов Иван Иванович", "+7 (999) 123-45-67", "ivanov@mail.ru", new DateTime(2020, 1, 15), "Активный");
            dataTableOwners.Rows.Add(2, "Петрова Анна Сергеевна", "+7 (999) 234-56-78", "petrova@mail.ru", new DateTime(2021, 3, 20), "Активный");
            dataTableOwners.Rows.Add(3, "Сидоров Алексей Петрович", "+7 (999) 345-67-89", "sidorov@mail.ru", new DateTime(2022, 5, 10), "Неактивный");

            // Добавление тестовых данных магазинов
            dataTableStores.Rows.Add(1, "Супермаркет 'Продукты'", "ул. Ленина, д. 10", "Иванов И.И.", "+7 (999) 111-22-33", 500.5m, "Активный");
            dataTableStores.Rows.Add(2, "Магазин 'Одежда'", "ул. Мира, д. 25", "Петрова А.С.", "+7 (999) 222-33-44", 300.0m, "Активный");
            dataTableStores.Rows.Add(3, "Торговый центр 'Мега'", "пр. Победы, д. 100", "Иванов И.И.", "+7 (999) 333-44-55", 1500.0m, "Активный");

            // Добавление тестовых данных поставщиков
            dataTableSuppliers.Rows.Add(1, "ООО 'ПродуктСнаб'", "Смирнов А.А.", "+7 (999) 444-55-66", "smirnov@product.ru", "Продукты питания", "Активный");
            dataTableSuppliers.Rows.Add(2, "ИП 'ТекстильТорг'", "Козлова М.И.", "+7 (999) 555-66-77", "kozlov@textile.ru", "Одежда и ткани", "Активный");
            dataTableSuppliers.Rows.Add(3, "ЗАО 'ТехноСнаб'", "Волков П.С.", "+7 (999) 666-77-88", "volkov@techno.ru", "Электроника", "Активный");

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

        #endregion

        #region Пустые обработчики для Designer

        private void groupBoxSummary_MBS_Enter(object sender, EventArgs e) { }

        private void labelOwnersCount_MBS_Click(object sender, EventArgs e) { }

        private void buttonQuickReport_MBS_Click_1(object sender, EventArgs e)
        {
            ButtonQuickReport_MBS_Click(sender, e);
        }

        private void buttonApplyFilter_MBS_Click_1(object sender, EventArgs e)
        {
            ButtonApplyFilter_MBS_Click(sender, e);
        }

        #endregion
    }
}