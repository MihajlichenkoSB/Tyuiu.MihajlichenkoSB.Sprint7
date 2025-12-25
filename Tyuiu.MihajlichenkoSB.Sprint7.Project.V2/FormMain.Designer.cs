namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain_MBS = new MenuStrip();
            toolStripMenuItemFile_MBS = new ToolStripMenuItem();
            toolStripMenuItemLoadData_MBS = new ToolStripMenuItem();
            toolStripMenuItemSaveData_MBS = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemExit_MBS = new ToolStripMenuItem();
            toolStripMenuItemData_MBS = new ToolStripMenuItem();
            toolStripMenuItemAddOwner_MBS = new ToolStripMenuItem();
            toolStripMenuItemAddStore_MBS = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemEdit_MBS = new ToolStripMenuItem();
            toolStripMenuItemDelete_MBS = new ToolStripMenuItem();
            toolStripMenuItemAnalysis_MBS = new ToolStripMenuItem();
            toolStripMenuItemStats_MBS = new ToolStripMenuItem();
            toolStripMenuItemCharts_MBS = new ToolStripMenuItem();
            toolStripMenuItemHelp_MBS = new ToolStripMenuItem();
            toolStripMenuItemUserGuide_MBS = new ToolStripMenuItem();
            toolStripMenuItemAbout_MBS = new ToolStripMenuItem();
            statusStripMain_MBS = new StatusStrip();
            toolStripStatusLabelInfo_MBS = new ToolStripStatusLabel();
            toolStripStatusLabelDate_MBS = new ToolStripStatusLabel();
            toolStripStatusLabelTime_MBS = new ToolStripStatusLabel();
            labelTitle_MBS = new Label();
            panelSearch_MBS = new Panel();
            labelSearch_MBS = new Label();
            textBoxSearch_MBS = new TextBox();
            buttonSearch_MBS = new Button();
            comboBoxFilter_MBS = new ComboBox();
            tabControlMain_MBS = new TabControl();
            tabPageOwners_MBS = new TabPage();
            dataGridViewOwners_MBS = new DataGridView();
            tabPageStores_MBS = new TabPage();
            dataGridViewStores_MBS = new DataGridView();
            panelControls_MBS = new Panel();
            buttonAddOwner_MBS = new Button();
            buttonAddStore_MBS = new Button();
            buttonEditItem_MBS = new Button();
            buttonDeleteItem_MBS = new Button();
            buttonSaveData_MBS = new Button();
            buttonLoadData_MBS = new Button();
            buttonShowStats_MBS = new Button();
            buttonShowChart_MBS = new Button();
            menuStripMain_MBS.SuspendLayout();
            statusStripMain_MBS.SuspendLayout();
            panelSearch_MBS.SuspendLayout();
            tabControlMain_MBS.SuspendLayout();
            tabPageOwners_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwners_MBS).BeginInit();
            tabPageStores_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStores_MBS).BeginInit();
            panelControls_MBS.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain_MBS
            // 
            menuStripMain_MBS.ImageScalingSize = new Size(20, 20);
            menuStripMain_MBS.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile_MBS, toolStripMenuItemData_MBS, toolStripMenuItemAnalysis_MBS, toolStripMenuItemHelp_MBS });
            menuStripMain_MBS.Location = new Point(0, 0);
            menuStripMain_MBS.Name = "menuStripMain_MBS";
            menuStripMain_MBS.Padding = new Padding(5, 2, 0, 2);
            menuStripMain_MBS.Size = new Size(1000, 28);
            menuStripMain_MBS.TabIndex = 0;
            menuStripMain_MBS.Text = "menuStripMain_MBS";
            // 
            // toolStripMenuItemFile_MBS
            // 
            toolStripMenuItemFile_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemLoadData_MBS, toolStripMenuItemSaveData_MBS, toolStripSeparator1, toolStripMenuItemExit_MBS });
            toolStripMenuItemFile_MBS.Name = "toolStripMenuItemFile_MBS";
            toolStripMenuItemFile_MBS.Size = new Size(59, 24);
            toolStripMenuItemFile_MBS.Text = "Файл";
            // 
            // toolStripMenuItemLoadData_MBS
            // 
            toolStripMenuItemLoadData_MBS.Name = "toolStripMenuItemLoadData_MBS";
            toolStripMenuItemLoadData_MBS.Size = new Size(223, 26);
            toolStripMenuItemLoadData_MBS.Text = "Загрузить данные";
            toolStripMenuItemLoadData_MBS.Click += ButtonLoadData_MBS_Click;
            // 
            // toolStripMenuItemSaveData_MBS
            // 
            toolStripMenuItemSaveData_MBS.Name = "toolStripMenuItemSaveData_MBS";
            toolStripMenuItemSaveData_MBS.Size = new Size(223, 26);
            toolStripMenuItemSaveData_MBS.Text = "Сохранить данные";
            toolStripMenuItemSaveData_MBS.Click += ButtonSaveData_MBS_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(220, 6);
            // 
            // toolStripMenuItemExit_MBS
            // 
            toolStripMenuItemExit_MBS.Name = "toolStripMenuItemExit_MBS";
            toolStripMenuItemExit_MBS.Size = new Size(223, 26);
            toolStripMenuItemExit_MBS.Text = "Выход";
            toolStripMenuItemExit_MBS.Click += ToolStripMenuItemExit_Click;
            // 
            // toolStripMenuItemData_MBS
            // 
            toolStripMenuItemData_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddOwner_MBS, toolStripMenuItemAddStore_MBS, toolStripSeparator2, toolStripMenuItemEdit_MBS, toolStripMenuItemDelete_MBS });
            toolStripMenuItemData_MBS.Name = "toolStripMenuItemData_MBS";
            toolStripMenuItemData_MBS.Size = new Size(78, 24);
            toolStripMenuItemData_MBS.Text = "Данные";
            // 
            // toolStripMenuItemAddOwner_MBS
            // 
            toolStripMenuItemAddOwner_MBS.Name = "toolStripMenuItemAddOwner_MBS";
            toolStripMenuItemAddOwner_MBS.Size = new Size(236, 26);
            toolStripMenuItemAddOwner_MBS.Text = "Добавить владельца";
            toolStripMenuItemAddOwner_MBS.Click += ButtonAddOwner_MBS_Click;
            // 
            // toolStripMenuItemAddStore_MBS
            // 
            toolStripMenuItemAddStore_MBS.Name = "toolStripMenuItemAddStore_MBS";
            toolStripMenuItemAddStore_MBS.Size = new Size(236, 26);
            toolStripMenuItemAddStore_MBS.Text = "Добавить магазин";
            toolStripMenuItemAddStore_MBS.Click += ButtonAddStore_MBS_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(233, 6);
            // 
            // toolStripMenuItemEdit_MBS
            // 
            toolStripMenuItemEdit_MBS.Name = "toolStripMenuItemEdit_MBS";
            toolStripMenuItemEdit_MBS.Size = new Size(236, 26);
            toolStripMenuItemEdit_MBS.Text = "Редактировать";
            toolStripMenuItemEdit_MBS.Click += ButtonEditItem_MBS_Click;
            // 
            // toolStripMenuItemDelete_MBS
            // 
            toolStripMenuItemDelete_MBS.Name = "toolStripMenuItemDelete_MBS";
            toolStripMenuItemDelete_MBS.Size = new Size(236, 26);
            toolStripMenuItemDelete_MBS.Text = "Удалить";
            toolStripMenuItemDelete_MBS.Click += ButtonDeleteItem_MBS_Click;
            // 
            // toolStripMenuItemAnalysis_MBS
            // 
            toolStripMenuItemAnalysis_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemStats_MBS, toolStripMenuItemCharts_MBS });
            toolStripMenuItemAnalysis_MBS.Name = "toolStripMenuItemAnalysis_MBS";
            toolStripMenuItemAnalysis_MBS.Size = new Size(74, 24);
            toolStripMenuItemAnalysis_MBS.Text = "Анализ";
            // 
            // toolStripMenuItemStats_MBS
            // 
            toolStripMenuItemStats_MBS.Name = "toolStripMenuItemStats_MBS";
            toolStripMenuItemStats_MBS.Size = new Size(167, 26);
            toolStripMenuItemStats_MBS.Text = "Статистика";
            toolStripMenuItemStats_MBS.Click += ButtonShowStats_MBS_Click;
            // 
            // toolStripMenuItemCharts_MBS
            // 
            toolStripMenuItemCharts_MBS.Name = "toolStripMenuItemCharts_MBS";
            toolStripMenuItemCharts_MBS.Size = new Size(167, 26);
            toolStripMenuItemCharts_MBS.Text = "Графики";
            toolStripMenuItemCharts_MBS.Click += ButtonShowChart_MBS_Click;
            // 
            // toolStripMenuItemHelp_MBS
            // 
            toolStripMenuItemHelp_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemUserGuide_MBS, toolStripMenuItemAbout_MBS });
            toolStripMenuItemHelp_MBS.Name = "toolStripMenuItemHelp_MBS";
            toolStripMenuItemHelp_MBS.Size = new Size(81, 24);
            toolStripMenuItemHelp_MBS.Text = "Справка";
            // 
            // toolStripMenuItemUserGuide_MBS
            // 
            toolStripMenuItemUserGuide_MBS.Name = "toolStripMenuItemUserGuide_MBS";
            toolStripMenuItemUserGuide_MBS.Size = new Size(278, 26);
            toolStripMenuItemUserGuide_MBS.Text = "Руководство пользователя";
            toolStripMenuItemUserGuide_MBS.Click += ToolStripMenuItemUserGuide_MBS_Click;
            // 
            // toolStripMenuItemAbout_MBS
            // 
            toolStripMenuItemAbout_MBS.Name = "toolStripMenuItemAbout_MBS";
            toolStripMenuItemAbout_MBS.Size = new Size(278, 26);
            toolStripMenuItemAbout_MBS.Text = "О программе";
            toolStripMenuItemAbout_MBS.Click += ToolStripMenuItemAbout_MBS_Click;
            // 
            // statusStripMain_MBS
            // 
            statusStripMain_MBS.ImageScalingSize = new Size(20, 20);
            statusStripMain_MBS.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo_MBS, toolStripStatusLabelDate_MBS, toolStripStatusLabelTime_MBS });
            statusStripMain_MBS.Location = new Point(0, 674);
            statusStripMain_MBS.Name = "statusStripMain_MBS";
            statusStripMain_MBS.Padding = new Padding(1, 0, 12, 0);
            statusStripMain_MBS.Size = new Size(1000, 26);
            statusStripMain_MBS.TabIndex = 2;
            statusStripMain_MBS.Text = "statusStripMain_MBS";
            // 
            // toolStripStatusLabelInfo_MBS
            // 
            toolStripStatusLabelInfo_MBS.Name = "toolStripStatusLabelInfo_MBS";
            toolStripStatusLabelInfo_MBS.Size = new Size(845, 20);
            toolStripStatusLabelInfo_MBS.Spring = true;
            toolStripStatusLabelInfo_MBS.Text = "Готово";
            toolStripStatusLabelInfo_MBS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelDate_MBS
            // 
            toolStripStatusLabelDate_MBS.Name = "toolStripStatusLabelDate_MBS";
            toolStripStatusLabelDate_MBS.Size = new Size(79, 20);
            toolStripStatusLabelDate_MBS.Text = "01.01.2024";
            // 
            // toolStripStatusLabelTime_MBS
            // 
            toolStripStatusLabelTime_MBS.Name = "toolStripStatusLabelTime_MBS";
            toolStripStatusLabelTime_MBS.Size = new Size(63, 20);
            toolStripStatusLabelTime_MBS.Text = "00:00:00";
            // 
            // labelTitle_MBS
            // 
            labelTitle_MBS.BackColor = SystemColors.ActiveCaption;
            labelTitle_MBS.Dock = DockStyle.Top;
            labelTitle_MBS.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_MBS.ForeColor = Color.DarkBlue;
            labelTitle_MBS.Location = new Point(0, 28);
            labelTitle_MBS.Name = "labelTitle_MBS";
            labelTitle_MBS.Size = new Size(1000, 60);
            labelTitle_MBS.TabIndex = 3;
            labelTitle_MBS.Text = "СЕТЬ МАГАЗИНОВ";
            labelTitle_MBS.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle_MBS.Click += labelTitle_MBS_Click;
            // 
            // panelSearch_MBS
            // 
            panelSearch_MBS.BackColor = SystemColors.ControlLight;
            panelSearch_MBS.Controls.Add(labelSearch_MBS);
            panelSearch_MBS.Controls.Add(textBoxSearch_MBS);
            panelSearch_MBS.Controls.Add(buttonSearch_MBS);
            panelSearch_MBS.Controls.Add(comboBoxFilter_MBS);
            panelSearch_MBS.Dock = DockStyle.Top;
            panelSearch_MBS.Location = new Point(0, 88);
            panelSearch_MBS.Name = "panelSearch_MBS";
            panelSearch_MBS.Size = new Size(1000, 45);
            panelSearch_MBS.TabIndex = 4;
            // 
            // labelSearch_MBS
            // 
            labelSearch_MBS.AutoSize = true;
            labelSearch_MBS.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch_MBS.Location = new Point(12, 12);
            labelSearch_MBS.Name = "labelSearch_MBS";
            labelSearch_MBS.Size = new Size(65, 20);
            labelSearch_MBS.TabIndex = 0;
            labelSearch_MBS.Text = "Поиск:";
            // 
            // textBoxSearch_MBS
            // 
            textBoxSearch_MBS.Location = new Point(79, 10);
            textBoxSearch_MBS.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch_MBS.Name = "textBoxSearch_MBS";
            textBoxSearch_MBS.Size = new Size(250, 27);
            textBoxSearch_MBS.TabIndex = 1;
            textBoxSearch_MBS.KeyPress += TextBoxSearch_MBS_KeyPress;
            // 
            // buttonSearch_MBS
            // 
            buttonSearch_MBS.Location = new Point(335, 9);
            buttonSearch_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonSearch_MBS.Name = "buttonSearch_MBS";
            buttonSearch_MBS.Size = new Size(100, 28);
            buttonSearch_MBS.TabIndex = 2;
            buttonSearch_MBS.Text = "Найти";
            buttonSearch_MBS.UseVisualStyleBackColor = true;
            buttonSearch_MBS.Click += ButtonSearch_MBS_Click;
            // 
            // comboBoxFilter_MBS
            // 
            comboBoxFilter_MBS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter_MBS.FormattingEnabled = true;
            comboBoxFilter_MBS.Items.AddRange(new object[] { "Все", "Владельцы", "Магазины", "Поставщики" });
            comboBoxFilter_MBS.Location = new Point(441, 10);
            comboBoxFilter_MBS.Margin = new Padding(3, 2, 3, 2);
            comboBoxFilter_MBS.Name = "comboBoxFilter_MBS";
            comboBoxFilter_MBS.Size = new Size(180, 28);
            comboBoxFilter_MBS.TabIndex = 3;
            // 
            // tabControlMain_MBS
            // 
            tabControlMain_MBS.Controls.Add(tabPageOwners_MBS);
            tabControlMain_MBS.Controls.Add(tabPageStores_MBS);
            tabControlMain_MBS.Dock = DockStyle.Fill;
            tabControlMain_MBS.Location = new Point(0, 133);
            tabControlMain_MBS.Margin = new Padding(3, 2, 3, 2);
            tabControlMain_MBS.Name = "tabControlMain_MBS";
            tabControlMain_MBS.SelectedIndex = 0;
            tabControlMain_MBS.Size = new Size(1000, 491);
            tabControlMain_MBS.TabIndex = 5;
            // 
            // tabPageOwners_MBS
            // 
            tabPageOwners_MBS.Controls.Add(dataGridViewOwners_MBS);
            tabPageOwners_MBS.Location = new Point(4, 29);
            tabPageOwners_MBS.Margin = new Padding(3, 2, 3, 2);
            tabPageOwners_MBS.Name = "tabPageOwners_MBS";
            tabPageOwners_MBS.Padding = new Padding(3, 2, 3, 2);
            tabPageOwners_MBS.Size = new Size(992, 458);
            tabPageOwners_MBS.TabIndex = 0;
            tabPageOwners_MBS.Text = "Владельцы магазинов";
            tabPageOwners_MBS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOwners_MBS
            // 
            dataGridViewOwners_MBS.AllowUserToAddRows = false;
            dataGridViewOwners_MBS.AllowUserToDeleteRows = false;
            dataGridViewOwners_MBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOwners_MBS.Dock = DockStyle.Fill;
            dataGridViewOwners_MBS.Location = new Point(3, 2);
            dataGridViewOwners_MBS.Margin = new Padding(3, 2, 3, 2);
            dataGridViewOwners_MBS.Name = "dataGridViewOwners_MBS";
            dataGridViewOwners_MBS.ReadOnly = true;
            dataGridViewOwners_MBS.RowHeadersWidth = 51;
            dataGridViewOwners_MBS.RowTemplate.Height = 24;
            dataGridViewOwners_MBS.Size = new Size(986, 454);
            dataGridViewOwners_MBS.TabIndex = 0;
            dataGridViewOwners_MBS.CellContentClick += dataGridViewOwners_MBS_CellContentClick;
            dataGridViewOwners_MBS.CellDoubleClick += dataGridViewOwners_MBS_CellDoubleClick;
            // 
            // tabPageStores_MBS
            // 
            tabPageStores_MBS.Controls.Add(dataGridViewStores_MBS);
            tabPageStores_MBS.Location = new Point(4, 29);
            tabPageStores_MBS.Margin = new Padding(3, 2, 3, 2);
            tabPageStores_MBS.Name = "tabPageStores_MBS";
            tabPageStores_MBS.Padding = new Padding(3, 2, 3, 2);
            tabPageStores_MBS.Size = new Size(992, 458);
            tabPageStores_MBS.TabIndex = 1;
            tabPageStores_MBS.Text = "Магазины";
            tabPageStores_MBS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStores_MBS
            // 
            dataGridViewStores_MBS.AllowUserToAddRows = false;
            dataGridViewStores_MBS.AllowUserToDeleteRows = false;
            dataGridViewStores_MBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStores_MBS.Dock = DockStyle.Fill;
            dataGridViewStores_MBS.Location = new Point(3, 2);
            dataGridViewStores_MBS.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStores_MBS.Name = "dataGridViewStores_MBS";
            dataGridViewStores_MBS.ReadOnly = true;
            dataGridViewStores_MBS.RowHeadersWidth = 51;
            dataGridViewStores_MBS.RowTemplate.Height = 24;
            dataGridViewStores_MBS.Size = new Size(986, 454);
            dataGridViewStores_MBS.TabIndex = 0;
            dataGridViewStores_MBS.CellDoubleClick += dataGridViewStores_MBS_CellDoubleClick;
            // 
            // panelControls_MBS
            // 
            panelControls_MBS.BackColor = SystemColors.ControlLightLight;
            panelControls_MBS.Controls.Add(buttonAddOwner_MBS);
            panelControls_MBS.Controls.Add(buttonAddStore_MBS);
            panelControls_MBS.Controls.Add(buttonEditItem_MBS);
            panelControls_MBS.Controls.Add(buttonDeleteItem_MBS);
            panelControls_MBS.Controls.Add(buttonSaveData_MBS);
            panelControls_MBS.Controls.Add(buttonLoadData_MBS);
            panelControls_MBS.Controls.Add(buttonShowStats_MBS);
            panelControls_MBS.Controls.Add(buttonShowChart_MBS);
            panelControls_MBS.Dock = DockStyle.Bottom;
            panelControls_MBS.Location = new Point(0, 624);
            panelControls_MBS.Margin = new Padding(3, 2, 3, 2);
            panelControls_MBS.Name = "panelControls_MBS";
            panelControls_MBS.Size = new Size(1000, 50);
            panelControls_MBS.TabIndex = 6;
            // 
            // buttonAddOwner_MBS
            // 
            buttonAddOwner_MBS.Location = new Point(10, 10);
            buttonAddOwner_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonAddOwner_MBS.Name = "buttonAddOwner_MBS";
            buttonAddOwner_MBS.Size = new Size(120, 30);
            buttonAddOwner_MBS.TabIndex = 0;
            buttonAddOwner_MBS.Text = "Добавить владельца";
            buttonAddOwner_MBS.UseVisualStyleBackColor = true;
            buttonAddOwner_MBS.Click += ButtonAddOwner_MBS_Click;
            // 
            // buttonAddStore_MBS
            // 
            buttonAddStore_MBS.Location = new Point(140, 10);
            buttonAddStore_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonAddStore_MBS.Name = "buttonAddStore_MBS";
            buttonAddStore_MBS.Size = new Size(120, 30);
            buttonAddStore_MBS.TabIndex = 1;
            buttonAddStore_MBS.Text = "Добавить магазин";
            buttonAddStore_MBS.UseVisualStyleBackColor = true;
            buttonAddStore_MBS.Click += ButtonAddStore_MBS_Click;
            // 
            // buttonEditItem_MBS
            // 
            buttonEditItem_MBS.Location = new Point(270, 10);
            buttonEditItem_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonEditItem_MBS.Name = "buttonEditItem_MBS";
            buttonEditItem_MBS.Size = new Size(120, 30);
            buttonEditItem_MBS.TabIndex = 2;
            buttonEditItem_MBS.Text = "Редактировать";
            buttonEditItem_MBS.UseVisualStyleBackColor = true;
            buttonEditItem_MBS.Click += ButtonEditItem_MBS_Click;
            // 
            // buttonDeleteItem_MBS
            // 
            buttonDeleteItem_MBS.Location = new Point(400, 10);
            buttonDeleteItem_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteItem_MBS.Name = "buttonDeleteItem_MBS";
            buttonDeleteItem_MBS.Size = new Size(120, 30);
            buttonDeleteItem_MBS.TabIndex = 3;
            buttonDeleteItem_MBS.Text = "Удалить";
            buttonDeleteItem_MBS.UseVisualStyleBackColor = true;
            buttonDeleteItem_MBS.Click += ButtonDeleteItem_MBS_Click;
            // 
            // buttonSaveData_MBS
            // 
            buttonSaveData_MBS.Location = new Point(530, 10);
            buttonSaveData_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonSaveData_MBS.Name = "buttonSaveData_MBS";
            buttonSaveData_MBS.Size = new Size(120, 30);
            buttonSaveData_MBS.TabIndex = 4;
            buttonSaveData_MBS.Text = "Сохранить";
            buttonSaveData_MBS.UseVisualStyleBackColor = true;
            buttonSaveData_MBS.Click += ButtonSaveData_MBS_Click;
            // 
            // buttonLoadData_MBS
            // 
            buttonLoadData_MBS.Location = new Point(660, 10);
            buttonLoadData_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonLoadData_MBS.Name = "buttonLoadData_MBS";
            buttonLoadData_MBS.Size = new Size(120, 30);
            buttonLoadData_MBS.TabIndex = 5;
            buttonLoadData_MBS.Text = "Загрузить";
            buttonLoadData_MBS.UseVisualStyleBackColor = true;
            buttonLoadData_MBS.Click += ButtonLoadData_MBS_Click;
            // 
            // buttonShowStats_MBS
            // 
            buttonShowStats_MBS.Location = new Point(790, 10);
            buttonShowStats_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonShowStats_MBS.Name = "buttonShowStats_MBS";
            buttonShowStats_MBS.Size = new Size(100, 30);
            buttonShowStats_MBS.TabIndex = 6;
            buttonShowStats_MBS.Text = "Статистика";
            buttonShowStats_MBS.UseVisualStyleBackColor = true;
            buttonShowStats_MBS.Click += ButtonShowStats_MBS_Click;
            // 
            // buttonShowChart_MBS
            // 
            buttonShowChart_MBS.Location = new Point(900, 10);
            buttonShowChart_MBS.Margin = new Padding(3, 2, 3, 2);
            buttonShowChart_MBS.Name = "buttonShowChart_MBS";
            buttonShowChart_MBS.Size = new Size(90, 30);
            buttonShowChart_MBS.TabIndex = 7;
            buttonShowChart_MBS.Text = "График";
            buttonShowChart_MBS.UseVisualStyleBackColor = true;
            buttonShowChart_MBS.Click += ButtonShowChart_MBS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(tabControlMain_MBS);
            Controls.Add(panelControls_MBS);
            Controls.Add(panelSearch_MBS);
            Controls.Add(labelTitle_MBS);
            Controls.Add(statusStripMain_MBS);
            Controls.Add(menuStripMain_MBS);
            MainMenuStrip = menuStripMain_MBS;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сеть магазинов - MBS";
            menuStripMain_MBS.ResumeLayout(false);
            menuStripMain_MBS.PerformLayout();
            statusStripMain_MBS.ResumeLayout(false);
            statusStripMain_MBS.PerformLayout();
            panelSearch_MBS.ResumeLayout(false);
            panelSearch_MBS.PerformLayout();
            tabControlMain_MBS.ResumeLayout(false);
            tabPageOwners_MBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwners_MBS).EndInit();
            tabPageStores_MBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStores_MBS).EndInit();
            panelControls_MBS.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadData_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSaveData_MBS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemData_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddOwner_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddStore_MBS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAnalysis_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStats_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCharts_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUserGuide_MBS;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_MBS;
        private System.Windows.Forms.StatusStrip statusStripMain_MBS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo_MBS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate_MBS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime_MBS;
        private System.Windows.Forms.Label labelTitle_MBS;
        private System.Windows.Forms.Panel panelSearch_MBS;
        private System.Windows.Forms.Label labelSearch_MBS;
        private System.Windows.Forms.TextBox textBoxSearch_MBS;
        private System.Windows.Forms.Button buttonSearch_MBS;
        private System.Windows.Forms.ComboBox comboBoxFilter_MBS;
        private System.Windows.Forms.TabControl tabControlMain_MBS;
        private System.Windows.Forms.TabPage tabPageOwners_MBS;
        private System.Windows.Forms.DataGridView dataGridViewOwners_MBS;
        private System.Windows.Forms.TabPage tabPageStores_MBS;
        private System.Windows.Forms.DataGridView dataGridViewStores_MBS;
        private System.Windows.Forms.Panel panelControls_MBS;
        private System.Windows.Forms.Button buttonAddOwner_MBS;
        private System.Windows.Forms.Button buttonAddStore_MBS;
        private System.Windows.Forms.Button buttonEditItem_MBS;
        private System.Windows.Forms.Button buttonDeleteItem_MBS;
        private System.Windows.Forms.Button buttonSaveData_MBS;
        private System.Windows.Forms.Button buttonLoadData_MBS;
        private System.Windows.Forms.Button buttonShowStats_MBS;
        private System.Windows.Forms.Button buttonShowChart_MBS;
    }
}