using System.Windows.Forms;
using System.Drawing;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            menuStripMain_MBS = new MenuStrip();
            toolStripMenuItemFile_MBS = new ToolStripMenuItem();
            toolStripMenuItemNew_MBS = new ToolStripMenuItem();
            toolStripMenuItemLoadData_MBS = new ToolStripMenuItem();
            toolStripMenuItemSaveData_MBS = new ToolStripMenuItem();
            toolStripMenuItemSaveAs_MBS = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemPrint_MBS = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItemExit_MBS = new ToolStripMenuItem();
            toolStripMenuItemData_MBS = new ToolStripMenuItem();
            toolStripMenuItemAddOwner_MBS = new ToolStripMenuItem();
            toolStripMenuItemAddStore_MBS = new ToolStripMenuItem();
            toolStripMenuItemAddSupplier_MBS = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItemEdit_MBS = new ToolStripMenuItem();
            toolStripMenuItemDelete_MBS = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripMenuItemRefresh_MBS = new ToolStripMenuItem();
            toolStripMenuItemAnalysis_MBS = new ToolStripMenuItem();
            toolStripMenuItemStats_MBS = new ToolStripMenuItem();
            toolStripMenuItemCharts_MBS = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripMenuItemReport_MBS = new ToolStripMenuItem();
            toolStripMenuItemExport_MBS = new ToolStripMenuItem();
            toolStripMenuItemView_MBS = new ToolStripMenuItem();
            toolStripMenuItemToolbar_MBS = new ToolStripMenuItem();
            toolStripMenuItemStatusbar_MBS = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripMenuItemTheme_MBS = new ToolStripMenuItem();
            toolStripMenuItemLight_MBS = new ToolStripMenuItem();
            toolStripMenuItemDark_MBS = new ToolStripMenuItem();
            toolStripMenuItemBlue_MBS = new ToolStripMenuItem();
            toolStripMenuItemHelp_MBS = new ToolStripMenuItem();
            toolStripMenuItemUserGuide_MBS = new ToolStripMenuItem();
            toolStripMenuItemVideoGuide_MBS = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripMenuItemCheckUpdates_MBS = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripMenuItemAbout_MBS = new ToolStripMenuItem();
            toolStripMain_MBS = new ToolStrip();
            toolStripButtonNew_MBS = new ToolStripButton();
            toolStripButtonAddOwner_MBS = new ToolStripButton();
            toolStripButtonAddStore_MBS = new ToolStripButton();
            toolStripButtonAddSupplier_MBS = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripButtonEdit_MBS = new ToolStripButton();
            toolStripButtonDelete_MBS = new ToolStripButton();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripButtonSave_MBS = new ToolStripButton();
            toolStripButtonLoad_MBS = new ToolStripButton();
            toolStripButtonPrint_MBS = new ToolStripButton();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripButtonStats_MBS = new ToolStripButton();
            toolStripButtonChart_MBS = new ToolStripButton();
            toolStripButtonReport_MBS = new ToolStripButton();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripButtonHelp_MBS = new ToolStripButton();
            statusStripMain_MBS = new StatusStrip();
            toolStripStatusLabelInfo_MBS = new ToolStripStatusLabel();
            toolStripProgressBar_MBS = new ToolStripProgressBar();
            toolStripStatusLabelCount_MBS = new ToolStripStatusLabel();
            toolStripStatusLabelDate_MBS = new ToolStripStatusLabel();
            toolStripStatusLabelTime_MBS = new ToolStripStatusLabel();
            panelHeader_MBS = new Panel();
            labelTitle_MBS = new Label();
            labelSubtitle_MBS = new Label();
            pictureBoxLogo_MBS = new PictureBox();
            panelSearch_MBS = new Panel();
            buttonAddSupplier_MBS = new Button();
            buttonAddStore_MBS = new Button();
            buttonAddOwner_MBS = new Button();
            buttonClearSearch_MBS = new Button();
            buttonSearch_MBS = new Button();
            textBoxSearch_MBS = new TextBox();
            labelSearch_MBS = new Label();
            comboBoxFilter_MBS = new ComboBox();
            labelFilter_MBS = new Label();
            tabControlMain_MBS = new TabControl();
            tabPageOwners_MBS = new TabPage();
            dataGridViewOwners_MBS = new DataGridView();
            tabPageStores_MBS = new TabPage();
            dataGridViewStores_MBS = new DataGridView();
            tabPageSuppliers_MBS = new TabPage();
            dataGridViewSuppliers_MBS = new DataGridView();
            panelSidebar_MBS = new Panel();
            groupBoxAddActions_MBS = new GroupBox();
            buttonAddSupplierSidebar_MBS = new Button();
            buttonAddStoreSidebar_MBS = new Button();
            buttonAddOwnerSidebar_MBS = new Button();
            groupBoxSummary_MBS = new GroupBox();
            labelTotalStores_MBS = new Label();
            labelTotalOwners_MBS = new Label();
            labelTotalSuppliers_MBS = new Label();
            labelStoresCount_MBS = new Label();
            labelOwnersCount_MBS = new Label();
            labelSuppliersCount_MBS = new Label();
            groupBoxFilters_MBS = new GroupBox();
            checkBoxActiveOnly_MBS = new CheckBox();
            checkBoxHighPriority_MBS = new CheckBox();
            dateTimePickerFrom_MBS = new DateTimePicker();
            labelFrom_MBS = new Label();
            labelTo_MBS = new Label();
            dateTimePickerTo_MBS = new DateTimePicker();
            buttonApplyFilter_MBS = new Button();
            buttonResetFilter_MBS = new Button();
            groupBoxQuickActions_MBS = new GroupBox();
            buttonQuickStats_MBS = new Button();
            buttonQuickChart_MBS = new Button();
            buttonQuickReport_MBS = new Button();
            menuStripMain_MBS.SuspendLayout();
            toolStripMain_MBS.SuspendLayout();
            statusStripMain_MBS.SuspendLayout();
            panelHeader_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_MBS).BeginInit();
            panelSearch_MBS.SuspendLayout();
            tabControlMain_MBS.SuspendLayout();
            tabPageOwners_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwners_MBS).BeginInit();
            tabPageStores_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStores_MBS).BeginInit();
            tabPageSuppliers_MBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_MBS).BeginInit();
            panelSidebar_MBS.SuspendLayout();
            groupBoxAddActions_MBS.SuspendLayout();
            groupBoxSummary_MBS.SuspendLayout();
            groupBoxFilters_MBS.SuspendLayout();
            groupBoxQuickActions_MBS.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain_MBS
            // 
            menuStripMain_MBS.BackColor = Color.FromArgb(51, 51, 76);
            menuStripMain_MBS.ImageScalingSize = new Size(20, 20);
            menuStripMain_MBS.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile_MBS, toolStripMenuItemData_MBS, toolStripMenuItemAnalysis_MBS, toolStripMenuItemView_MBS, toolStripMenuItemHelp_MBS });
            menuStripMain_MBS.Location = new Point(0, 0);
            menuStripMain_MBS.Name = "menuStripMain_MBS";
            menuStripMain_MBS.Size = new Size(1200, 28);
            menuStripMain_MBS.TabIndex = 0;
            menuStripMain_MBS.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile_MBS
            // 
            toolStripMenuItemFile_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemNew_MBS, toolStripMenuItemLoadData_MBS, toolStripMenuItemSaveData_MBS, toolStripMenuItemSaveAs_MBS, toolStripSeparator1, toolStripMenuItemPrint_MBS, toolStripSeparator2, toolStripMenuItemExit_MBS });
            toolStripMenuItemFile_MBS.ForeColor = Color.White;
            toolStripMenuItemFile_MBS.Name = "toolStripMenuItemFile_MBS";
            toolStripMenuItemFile_MBS.Size = new Size(59, 24);
            toolStripMenuItemFile_MBS.Text = "Файл";
            // 
            // toolStripMenuItemNew_MBS
            // 
            toolStripMenuItemNew_MBS.Name = "toolStripMenuItemNew_MBS";
            toolStripMenuItemNew_MBS.ShortcutKeys = Keys.Control | Keys.N;
            toolStripMenuItemNew_MBS.Size = new Size(274, 26);
            toolStripMenuItemNew_MBS.Text = "Новый";
            // 
            // toolStripMenuItemLoadData_MBS
            // 
            toolStripMenuItemLoadData_MBS.Name = "toolStripMenuItemLoadData_MBS";
            toolStripMenuItemLoadData_MBS.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuItemLoadData_MBS.Size = new Size(274, 26);
            toolStripMenuItemLoadData_MBS.Text = "Загрузить данные";
            // 
            // toolStripMenuItemSaveData_MBS
            // 
            toolStripMenuItemSaveData_MBS.Name = "toolStripMenuItemSaveData_MBS";
            toolStripMenuItemSaveData_MBS.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItemSaveData_MBS.Size = new Size(274, 26);
            toolStripMenuItemSaveData_MBS.Text = "Сохранить данные";
            // 
            // toolStripMenuItemSaveAs_MBS
            // 
            toolStripMenuItemSaveAs_MBS.Name = "toolStripMenuItemSaveAs_MBS";
            toolStripMenuItemSaveAs_MBS.Size = new Size(274, 26);
            toolStripMenuItemSaveAs_MBS.Text = "Сохранить как...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(271, 6);
            // 
            // toolStripMenuItemPrint_MBS
            // 
            toolStripMenuItemPrint_MBS.Name = "toolStripMenuItemPrint_MBS";
            toolStripMenuItemPrint_MBS.ShortcutKeys = Keys.Control | Keys.P;
            toolStripMenuItemPrint_MBS.Size = new Size(274, 26);
            toolStripMenuItemPrint_MBS.Text = "Печать";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(271, 6);
            // 
            // toolStripMenuItemExit_MBS
            // 
            toolStripMenuItemExit_MBS.Name = "toolStripMenuItemExit_MBS";
            toolStripMenuItemExit_MBS.ShortcutKeys = Keys.Alt | Keys.F4;
            toolStripMenuItemExit_MBS.Size = new Size(274, 26);
            toolStripMenuItemExit_MBS.Text = "Выход";
            // 
            // toolStripMenuItemData_MBS
            // 
            toolStripMenuItemData_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAddOwner_MBS, toolStripMenuItemAddStore_MBS, toolStripMenuItemAddSupplier_MBS, toolStripSeparator3, toolStripMenuItemEdit_MBS, toolStripMenuItemDelete_MBS, toolStripSeparator4, toolStripMenuItemRefresh_MBS });
            toolStripMenuItemData_MBS.ForeColor = Color.White;
            toolStripMenuItemData_MBS.Name = "toolStripMenuItemData_MBS";
            toolStripMenuItemData_MBS.Size = new Size(77, 24);
            toolStripMenuItemData_MBS.Text = "Данные";
            // 
            // toolStripMenuItemAddOwner_MBS
            // 
            toolStripMenuItemAddOwner_MBS.Name = "toolStripMenuItemAddOwner_MBS";
            toolStripMenuItemAddOwner_MBS.ShortcutKeys = Keys.Control | Keys.Shift | Keys.O;
            toolStripMenuItemAddOwner_MBS.Size = new Size(344, 26);
            toolStripMenuItemAddOwner_MBS.Text = "Добавить владельца";
            // 
            // toolStripMenuItemAddStore_MBS
            // 
            toolStripMenuItemAddStore_MBS.Name = "toolStripMenuItemAddStore_MBS";
            toolStripMenuItemAddStore_MBS.ShortcutKeys = Keys.Control | Keys.Shift | Keys.M;
            toolStripMenuItemAddStore_MBS.Size = new Size(344, 26);
            toolStripMenuItemAddStore_MBS.Text = "Добавить магазин";
            // 
            // toolStripMenuItemAddSupplier_MBS
            // 
            toolStripMenuItemAddSupplier_MBS.Name = "toolStripMenuItemAddSupplier_MBS";
            toolStripMenuItemAddSupplier_MBS.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            toolStripMenuItemAddSupplier_MBS.Size = new Size(344, 26);
            toolStripMenuItemAddSupplier_MBS.Text = "Добавить поставщика";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(341, 6);
            // 
            // toolStripMenuItemEdit_MBS
            // 
            toolStripMenuItemEdit_MBS.Name = "toolStripMenuItemEdit_MBS";
            toolStripMenuItemEdit_MBS.ShortcutKeys = Keys.Control | Keys.E;
            toolStripMenuItemEdit_MBS.Size = new Size(344, 26);
            toolStripMenuItemEdit_MBS.Text = "Редактировать";
            // 
            // toolStripMenuItemDelete_MBS
            // 
            toolStripMenuItemDelete_MBS.Name = "toolStripMenuItemDelete_MBS";
            toolStripMenuItemDelete_MBS.ShortcutKeys = Keys.Delete;
            toolStripMenuItemDelete_MBS.Size = new Size(344, 26);
            toolStripMenuItemDelete_MBS.Text = "Удалить";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(341, 6);
            // 
            // toolStripMenuItemRefresh_MBS
            // 
            toolStripMenuItemRefresh_MBS.Name = "toolStripMenuItemRefresh_MBS";
            toolStripMenuItemRefresh_MBS.ShortcutKeys = Keys.F5;
            toolStripMenuItemRefresh_MBS.Size = new Size(344, 26);
            toolStripMenuItemRefresh_MBS.Text = "Обновить";
            // 
            // toolStripMenuItemAnalysis_MBS
            // 
            toolStripMenuItemAnalysis_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemStats_MBS, toolStripMenuItemCharts_MBS, toolStripSeparator5, toolStripMenuItemReport_MBS, toolStripMenuItemExport_MBS });
            toolStripMenuItemAnalysis_MBS.ForeColor = Color.White;
            toolStripMenuItemAnalysis_MBS.Name = "toolStripMenuItemAnalysis_MBS";
            toolStripMenuItemAnalysis_MBS.Size = new Size(74, 24);
            toolStripMenuItemAnalysis_MBS.Text = "Анализ";
            // 
            // toolStripMenuItemStats_MBS
            // 
            toolStripMenuItemStats_MBS.Name = "toolStripMenuItemStats_MBS";
            toolStripMenuItemStats_MBS.ShortcutKeys = Keys.Control | Keys.T;
            toolStripMenuItemStats_MBS.Size = new Size(223, 26);
            toolStripMenuItemStats_MBS.Text = "Статистика";
            // 
            // toolStripMenuItemCharts_MBS
            // 
            toolStripMenuItemCharts_MBS.Name = "toolStripMenuItemCharts_MBS";
            toolStripMenuItemCharts_MBS.ShortcutKeys = Keys.Control | Keys.G;
            toolStripMenuItemCharts_MBS.Size = new Size(223, 26);
            toolStripMenuItemCharts_MBS.Text = "Графики";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(220, 6);
            // 
            // toolStripMenuItemReport_MBS
            // 
            toolStripMenuItemReport_MBS.Name = "toolStripMenuItemReport_MBS";
            toolStripMenuItemReport_MBS.ShortcutKeys = Keys.Control | Keys.R;
            toolStripMenuItemReport_MBS.Size = new Size(223, 26);
            toolStripMenuItemReport_MBS.Text = "Отчет";
            // 
            // toolStripMenuItemExport_MBS
            // 
            toolStripMenuItemExport_MBS.Name = "toolStripMenuItemExport_MBS";
            toolStripMenuItemExport_MBS.Size = new Size(223, 26);
            toolStripMenuItemExport_MBS.Text = "Экспорт";
            // 
            // toolStripMenuItemView_MBS
            // 
            toolStripMenuItemView_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemToolbar_MBS, toolStripMenuItemStatusbar_MBS, toolStripSeparator6, toolStripMenuItemTheme_MBS });
            toolStripMenuItemView_MBS.ForeColor = Color.White;
            toolStripMenuItemView_MBS.Name = "toolStripMenuItemView_MBS";
            toolStripMenuItemView_MBS.Size = new Size(53, 24);
            toolStripMenuItemView_MBS.Text = "Вид";
            // 
            // toolStripMenuItemToolbar_MBS
            // 
            toolStripMenuItemToolbar_MBS.Checked = true;
            toolStripMenuItemToolbar_MBS.CheckOnClick = true;
            toolStripMenuItemToolbar_MBS.CheckState = CheckState.Checked;
            toolStripMenuItemToolbar_MBS.Name = "toolStripMenuItemToolbar_MBS";
            toolStripMenuItemToolbar_MBS.Size = new Size(248, 26);
            toolStripMenuItemToolbar_MBS.Text = "Панель инструментов";
            // 
            // toolStripMenuItemStatusbar_MBS
            // 
            toolStripMenuItemStatusbar_MBS.Checked = true;
            toolStripMenuItemStatusbar_MBS.CheckOnClick = true;
            toolStripMenuItemStatusbar_MBS.CheckState = CheckState.Checked;
            toolStripMenuItemStatusbar_MBS.Name = "toolStripMenuItemStatusbar_MBS";
            toolStripMenuItemStatusbar_MBS.Size = new Size(248, 26);
            toolStripMenuItemStatusbar_MBS.Text = "Строка состояния";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(245, 6);
            // 
            // toolStripMenuItemTheme_MBS
            // 
            toolStripMenuItemTheme_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemLight_MBS, toolStripMenuItemDark_MBS, toolStripMenuItemBlue_MBS });
            toolStripMenuItemTheme_MBS.Name = "toolStripMenuItemTheme_MBS";
            toolStripMenuItemTheme_MBS.Size = new Size(248, 26);
            toolStripMenuItemTheme_MBS.Text = "Тема оформления";
            // 
            // toolStripMenuItemLight_MBS
            // 
            toolStripMenuItemLight_MBS.Name = "toolStripMenuItemLight_MBS";
            toolStripMenuItemLight_MBS.Size = new Size(149, 26);
            toolStripMenuItemLight_MBS.Text = "Светлая";
            // 
            // toolStripMenuItemDark_MBS
            // 
            toolStripMenuItemDark_MBS.Checked = true;
            toolStripMenuItemDark_MBS.CheckState = CheckState.Checked;
            toolStripMenuItemDark_MBS.Name = "toolStripMenuItemDark_MBS";
            toolStripMenuItemDark_MBS.Size = new Size(149, 26);
            toolStripMenuItemDark_MBS.Text = "Темная";
            // 
            // toolStripMenuItemBlue_MBS
            // 
            toolStripMenuItemBlue_MBS.Name = "toolStripMenuItemBlue_MBS";
            toolStripMenuItemBlue_MBS.Size = new Size(149, 26);
            toolStripMenuItemBlue_MBS.Text = "Синяя";
            // 
            // toolStripMenuItemHelp_MBS
            // 
            toolStripMenuItemHelp_MBS.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemUserGuide_MBS, toolStripMenuItemVideoGuide_MBS, toolStripSeparator7, toolStripMenuItemCheckUpdates_MBS, toolStripSeparator8, toolStripMenuItemAbout_MBS });
            toolStripMenuItemHelp_MBS.ForeColor = Color.White;
            toolStripMenuItemHelp_MBS.Name = "toolStripMenuItemHelp_MBS";
            toolStripMenuItemHelp_MBS.Size = new Size(83, 24);
            toolStripMenuItemHelp_MBS.Text = "Справка";
            // 
            // toolStripMenuItemUserGuide_MBS
            // 
            toolStripMenuItemUserGuide_MBS.Name = "toolStripMenuItemUserGuide_MBS";
            toolStripMenuItemUserGuide_MBS.ShortcutKeys = Keys.F1;
            toolStripMenuItemUserGuide_MBS.Size = new Size(309, 26);
            toolStripMenuItemUserGuide_MBS.Text = "Руководство пользователя";
            // 
            // toolStripMenuItemVideoGuide_MBS
            // 
            toolStripMenuItemVideoGuide_MBS.Name = "toolStripMenuItemVideoGuide_MBS";
            toolStripMenuItemVideoGuide_MBS.Size = new Size(309, 26);
            toolStripMenuItemVideoGuide_MBS.Text = "Видео-руководство";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(306, 6);
            // 
            // toolStripMenuItemCheckUpdates_MBS
            // 
            toolStripMenuItemCheckUpdates_MBS.Name = "toolStripMenuItemCheckUpdates_MBS";
            toolStripMenuItemCheckUpdates_MBS.Size = new Size(309, 26);
            toolStripMenuItemCheckUpdates_MBS.Text = "Проверить обновления";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(306, 6);
            // 
            // toolStripMenuItemAbout_MBS
            // 
            toolStripMenuItemAbout_MBS.Name = "toolStripMenuItemAbout_MBS";
            toolStripMenuItemAbout_MBS.Size = new Size(309, 26);
            toolStripMenuItemAbout_MBS.Text = "О программе";
            // 
            // toolStripMain_MBS
            // 
            toolStripMain_MBS.BackColor = Color.FromArgb(64, 64, 64);
            toolStripMain_MBS.ImageScalingSize = new Size(20, 20);
            toolStripMain_MBS.Items.AddRange(new ToolStripItem[] { toolStripButtonNew_MBS, toolStripButtonAddOwner_MBS, toolStripButtonAddStore_MBS, toolStripButtonAddSupplier_MBS, toolStripSeparator9, toolStripButtonEdit_MBS, toolStripButtonDelete_MBS, toolStripSeparator10, toolStripButtonSave_MBS, toolStripButtonLoad_MBS, toolStripButtonPrint_MBS, toolStripSeparator11, toolStripButtonStats_MBS, toolStripButtonChart_MBS, toolStripButtonReport_MBS, toolStripSeparator12, toolStripButtonHelp_MBS });
            toolStripMain_MBS.Location = new Point(0, 28);
            toolStripMain_MBS.Name = "toolStripMain_MBS";
            toolStripMain_MBS.Size = new Size(1200, 27);
            toolStripMain_MBS.TabIndex = 1;
            toolStripMain_MBS.Text = "toolStrip1";
            // 
            // toolStripButtonNew_MBS
            // 
            toolStripButtonNew_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNew_MBS.ForeColor = Color.White;
            toolStripButtonNew_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew_MBS.Name = "toolStripButtonNew_MBS";
            toolStripButtonNew_MBS.Size = new Size(29, 24);
            toolStripButtonNew_MBS.Text = "Новый";
            // 
            // toolStripButtonAddOwner_MBS
            // 
            toolStripButtonAddOwner_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddOwner_MBS.ForeColor = Color.White;
            toolStripButtonAddOwner_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddOwner_MBS.Name = "toolStripButtonAddOwner_MBS";
            toolStripButtonAddOwner_MBS.Size = new Size(29, 24);
            toolStripButtonAddOwner_MBS.Text = "Добавить владельца";
            // 
            // toolStripButtonAddStore_MBS
            // 
            toolStripButtonAddStore_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddStore_MBS.ForeColor = Color.White;
            toolStripButtonAddStore_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddStore_MBS.Name = "toolStripButtonAddStore_MBS";
            toolStripButtonAddStore_MBS.Size = new Size(29, 24);
            toolStripButtonAddStore_MBS.Text = "Добавить магазин";
            // 
            // toolStripButtonAddSupplier_MBS
            // 
            toolStripButtonAddSupplier_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddSupplier_MBS.ForeColor = Color.White;
            toolStripButtonAddSupplier_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddSupplier_MBS.Name = "toolStripButtonAddSupplier_MBS";
            toolStripButtonAddSupplier_MBS.Size = new Size(29, 24);
            toolStripButtonAddSupplier_MBS.Text = "Добавить поставщика";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 27);
            // 
            // toolStripButtonEdit_MBS
            // 
            toolStripButtonEdit_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEdit_MBS.ForeColor = Color.White;
            toolStripButtonEdit_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit_MBS.Name = "toolStripButtonEdit_MBS";
            toolStripButtonEdit_MBS.Size = new Size(29, 24);
            toolStripButtonEdit_MBS.Text = "Редактировать";
            // 
            // toolStripButtonDelete_MBS
            // 
            toolStripButtonDelete_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelete_MBS.ForeColor = Color.White;
            toolStripButtonDelete_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete_MBS.Name = "toolStripButtonDelete_MBS";
            toolStripButtonDelete_MBS.Size = new Size(29, 24);
            toolStripButtonDelete_MBS.Text = "Удалить";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 27);
            // 
            // toolStripButtonSave_MBS
            // 
            toolStripButtonSave_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSave_MBS.ForeColor = Color.White;
            toolStripButtonSave_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave_MBS.Name = "toolStripButtonSave_MBS";
            toolStripButtonSave_MBS.Size = new Size(29, 24);
            toolStripButtonSave_MBS.Text = "Сохранить";
            // 
            // toolStripButtonLoad_MBS
            // 
            toolStripButtonLoad_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonLoad_MBS.ForeColor = Color.White;
            toolStripButtonLoad_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonLoad_MBS.Name = "toolStripButtonLoad_MBS";
            toolStripButtonLoad_MBS.Size = new Size(29, 24);
            toolStripButtonLoad_MBS.Text = "Загрузить";
            // 
            // toolStripButtonPrint_MBS
            // 
            toolStripButtonPrint_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonPrint_MBS.ForeColor = Color.White;
            toolStripButtonPrint_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonPrint_MBS.Name = "toolStripButtonPrint_MBS";
            toolStripButtonPrint_MBS.Size = new Size(29, 24);
            toolStripButtonPrint_MBS.Text = "Печать";
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 27);
            // 
            // toolStripButtonStats_MBS
            // 
            toolStripButtonStats_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStats_MBS.ForeColor = Color.White;
            toolStripButtonStats_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonStats_MBS.Name = "toolStripButtonStats_MBS";
            toolStripButtonStats_MBS.Size = new Size(29, 24);
            toolStripButtonStats_MBS.Text = "Статистика";
            // 
            // toolStripButtonChart_MBS
            // 
            toolStripButtonChart_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonChart_MBS.ForeColor = Color.White;
            toolStripButtonChart_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonChart_MBS.Name = "toolStripButtonChart_MBS";
            toolStripButtonChart_MBS.Size = new Size(29, 24);
            toolStripButtonChart_MBS.Text = "Графики";
            // 
            // toolStripButtonReport_MBS
            // 
            toolStripButtonReport_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonReport_MBS.ForeColor = Color.White;
            toolStripButtonReport_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonReport_MBS.Name = "toolStripButtonReport_MBS";
            toolStripButtonReport_MBS.Size = new Size(29, 24);
            toolStripButtonReport_MBS.Text = "Отчет";
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 27);
            // 
            // toolStripButtonHelp_MBS
            // 
            toolStripButtonHelp_MBS.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonHelp_MBS.ForeColor = Color.White;
            toolStripButtonHelp_MBS.ImageTransparentColor = Color.Magenta;
            toolStripButtonHelp_MBS.Name = "toolStripButtonHelp_MBS";
            toolStripButtonHelp_MBS.Size = new Size(29, 24);
            toolStripButtonHelp_MBS.Text = "Справка";
            // 
            // statusStripMain_MBS
            // 
            statusStripMain_MBS.BackColor = Color.FromArgb(51, 51, 76);
            statusStripMain_MBS.ImageScalingSize = new Size(20, 20);
            statusStripMain_MBS.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInfo_MBS, toolStripProgressBar_MBS, toolStripStatusLabelCount_MBS, toolStripStatusLabelDate_MBS, toolStripStatusLabelTime_MBS });
            statusStripMain_MBS.Location = new Point(0, 850);
            statusStripMain_MBS.Name = "statusStripMain_MBS";
            statusStripMain_MBS.Size = new Size(1200, 30);
            statusStripMain_MBS.TabIndex = 2;
            statusStripMain_MBS.Text = "statusStrip1";
            // 
            // toolStripStatusLabelInfo_MBS
            // 
            toolStripStatusLabelInfo_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripStatusLabelInfo_MBS.ForeColor = Color.White;
            toolStripStatusLabelInfo_MBS.Name = "toolStripStatusLabelInfo_MBS";
            toolStripStatusLabelInfo_MBS.Size = new Size(890, 24);
            toolStripStatusLabelInfo_MBS.Spring = true;
            toolStripStatusLabelInfo_MBS.Text = "Готово к работе";
            toolStripStatusLabelInfo_MBS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar_MBS
            // 
            toolStripProgressBar_MBS.Name = "toolStripProgressBar_MBS";
            toolStripProgressBar_MBS.Size = new Size(100, 24);
            toolStripProgressBar_MBS.Style = ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabelCount_MBS
            // 
            toolStripStatusLabelCount_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripStatusLabelCount_MBS.ForeColor = Color.White;
            toolStripStatusLabelCount_MBS.Name = "toolStripStatusLabelCount_MBS";
            toolStripStatusLabelCount_MBS.Size = new Size(88, 24);
            toolStripStatusLabelCount_MBS.Text = "Записей: 0";
            // 
            // toolStripStatusLabelDate_MBS
            // 
            toolStripStatusLabelDate_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripStatusLabelDate_MBS.ForeColor = Color.White;
            toolStripStatusLabelDate_MBS.Name = "toolStripStatusLabelDate_MBS";
            toolStripStatusLabelDate_MBS.Size = new Size(93, 24);
            toolStripStatusLabelDate_MBS.Text = "01.01.2024";
            // 
            // toolStripStatusLabelTime_MBS
            // 
            toolStripStatusLabelTime_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            toolStripStatusLabelTime_MBS.ForeColor = Color.White;
            toolStripStatusLabelTime_MBS.Name = "toolStripStatusLabelTime_MBS";
            toolStripStatusLabelTime_MBS.Size = new Size(76, 24);
            toolStripStatusLabelTime_MBS.Text = "00:00:00";
            // 
            // panelHeader_MBS
            // 
            panelHeader_MBS.BackColor = Color.FromArgb(0, 122, 204);
            panelHeader_MBS.Controls.Add(labelTitle_MBS);
            panelHeader_MBS.Controls.Add(labelSubtitle_MBS);
            panelHeader_MBS.Controls.Add(pictureBoxLogo_MBS);
            panelHeader_MBS.Dock = DockStyle.Top;
            panelHeader_MBS.Location = new Point(0, 55);
            panelHeader_MBS.Name = "panelHeader_MBS";
            panelHeader_MBS.Size = new Size(1200, 100);
            panelHeader_MBS.TabIndex = 3;
            // 
            // labelTitle_MBS
            // 
            labelTitle_MBS.AutoSize = true;
            labelTitle_MBS.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_MBS.ForeColor = Color.White;
            labelTitle_MBS.Location = new Point(120, 20);
            labelTitle_MBS.Name = "labelTitle_MBS";
            labelTitle_MBS.Size = new Size(381, 54);
            labelTitle_MBS.TabIndex = 0;
            labelTitle_MBS.Text = "СЕТЬ МАГАЗИНОВ";
            // 
            // labelSubtitle_MBS
            // 
            labelSubtitle_MBS.AutoSize = true;
            labelSubtitle_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            labelSubtitle_MBS.ForeColor = Color.White;
            labelSubtitle_MBS.Location = new Point(125, 74);
            labelSubtitle_MBS.Name = "labelSubtitle_MBS";
            labelSubtitle_MBS.Size = new Size(440, 23);
            labelSubtitle_MBS.TabIndex = 2;
            labelSubtitle_MBS.Text = "Управление владельцами, магазинами, поставщиками";
            // 
            // pictureBoxLogo_MBS
            // 
            pictureBoxLogo_MBS.Location = new Point(20, 10);
            pictureBoxLogo_MBS.Name = "pictureBoxLogo_MBS";
            pictureBoxLogo_MBS.Size = new Size(80, 80);
            pictureBoxLogo_MBS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo_MBS.TabIndex = 1;
            pictureBoxLogo_MBS.TabStop = false;
            // 
            // panelSearch_MBS
            // 
            panelSearch_MBS.BackColor = Color.White;
            panelSearch_MBS.BorderStyle = BorderStyle.FixedSingle;
            panelSearch_MBS.Controls.Add(buttonAddSupplier_MBS);
            panelSearch_MBS.Controls.Add(buttonAddStore_MBS);
            panelSearch_MBS.Controls.Add(buttonAddOwner_MBS);
            panelSearch_MBS.Controls.Add(buttonClearSearch_MBS);
            panelSearch_MBS.Controls.Add(buttonSearch_MBS);
            panelSearch_MBS.Controls.Add(textBoxSearch_MBS);
            panelSearch_MBS.Controls.Add(labelSearch_MBS);
            panelSearch_MBS.Controls.Add(comboBoxFilter_MBS);
            panelSearch_MBS.Controls.Add(labelFilter_MBS);
            panelSearch_MBS.Dock = DockStyle.Top;
            panelSearch_MBS.Location = new Point(0, 155);
            panelSearch_MBS.Name = "panelSearch_MBS";
            panelSearch_MBS.Size = new Size(1200, 60);
            panelSearch_MBS.TabIndex = 4;
            // 
            // buttonAddSupplier_MBS
            // 
            buttonAddSupplier_MBS.BackColor = Color.FromArgb(155, 89, 182);
            buttonAddSupplier_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddSupplier_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddSupplier_MBS.ForeColor = Color.White;
            buttonAddSupplier_MBS.Location = new Point(1040, 15);
            buttonAddSupplier_MBS.Name = "buttonAddSupplier_MBS";
            buttonAddSupplier_MBS.Size = new Size(130, 30);
            buttonAddSupplier_MBS.TabIndex = 8;
            buttonAddSupplier_MBS.Text = "➕ Поставщик";
            buttonAddSupplier_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonAddStore_MBS
            // 
            buttonAddStore_MBS.BackColor = Color.FromArgb(52, 152, 219);
            buttonAddStore_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddStore_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddStore_MBS.ForeColor = Color.White;
            buttonAddStore_MBS.Location = new Point(900, 15);
            buttonAddStore_MBS.Name = "buttonAddStore_MBS";
            buttonAddStore_MBS.Size = new Size(130, 30);
            buttonAddStore_MBS.TabIndex = 7;
            buttonAddStore_MBS.Text = "➕ Магазин";
            buttonAddStore_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonAddOwner_MBS
            // 
            buttonAddOwner_MBS.BackColor = Color.FromArgb(46, 204, 113);
            buttonAddOwner_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddOwner_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddOwner_MBS.ForeColor = Color.White;
            buttonAddOwner_MBS.Location = new Point(760, 15);
            buttonAddOwner_MBS.Name = "buttonAddOwner_MBS";
            buttonAddOwner_MBS.Size = new Size(130, 30);
            buttonAddOwner_MBS.TabIndex = 6;
            buttonAddOwner_MBS.Text = "➕ Владелец";
            buttonAddOwner_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonClearSearch_MBS
            // 
            buttonClearSearch_MBS.BackColor = Color.FromArgb(240, 240, 240);
            buttonClearSearch_MBS.FlatStyle = FlatStyle.Flat;
            buttonClearSearch_MBS.Font = new Font("Segoe UI", 9F);
            buttonClearSearch_MBS.Location = new Point(630, 15);
            buttonClearSearch_MBS.Name = "buttonClearSearch_MBS";
            buttonClearSearch_MBS.Size = new Size(100, 30);
            buttonClearSearch_MBS.TabIndex = 5;
            buttonClearSearch_MBS.Text = "Очистить";
            buttonClearSearch_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonSearch_MBS
            // 
            buttonSearch_MBS.BackColor = Color.FromArgb(0, 122, 204);
            buttonSearch_MBS.FlatStyle = FlatStyle.Flat;
            buttonSearch_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSearch_MBS.ForeColor = Color.White;
            buttonSearch_MBS.Location = new Point(520, 15);
            buttonSearch_MBS.Name = "buttonSearch_MBS";
            buttonSearch_MBS.Size = new Size(100, 30);
            buttonSearch_MBS.TabIndex = 4;
            buttonSearch_MBS.Text = "Найти";
            buttonSearch_MBS.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch_MBS
            // 
            textBoxSearch_MBS.Font = new Font("Segoe UI", 10F);
            textBoxSearch_MBS.Location = new Point(90, 15);
            textBoxSearch_MBS.Name = "textBoxSearch_MBS";
            textBoxSearch_MBS.Size = new Size(250, 30);
            textBoxSearch_MBS.TabIndex = 1;
            // 
            // labelSearch_MBS
            // 
            labelSearch_MBS.AutoSize = true;
            labelSearch_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSearch_MBS.Location = new Point(20, 18);
            labelSearch_MBS.Name = "labelSearch_MBS";
            labelSearch_MBS.Size = new Size(68, 23);
            labelSearch_MBS.TabIndex = 0;
            labelSearch_MBS.Text = "Поиск:";
            // 
            // comboBoxFilter_MBS
            // 
            comboBoxFilter_MBS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter_MBS.Font = new Font("Segoe UI", 10F);
            comboBoxFilter_MBS.FormattingEnabled = true;
            comboBoxFilter_MBS.Items.AddRange(new object[] { "Все категории", "Владельцы", "Магазины", "Поставщики", "Активные", "Неактивные" });
            comboBoxFilter_MBS.Location = new Point(434, 15);
            comboBoxFilter_MBS.Name = "comboBoxFilter_MBS";
            comboBoxFilter_MBS.Size = new Size(80, 31);
            comboBoxFilter_MBS.TabIndex = 3;
            // 
            // labelFilter_MBS
            // 
            labelFilter_MBS.AutoSize = true;
            labelFilter_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelFilter_MBS.Location = new Point(350, 18);
            labelFilter_MBS.Name = "labelFilter_MBS";
            labelFilter_MBS.Size = new Size(78, 23);
            labelFilter_MBS.TabIndex = 2;
            labelFilter_MBS.Text = "Фильтр:";
            // 
            // tabControlMain_MBS
            // 
            tabControlMain_MBS.Controls.Add(tabPageOwners_MBS);
            tabControlMain_MBS.Controls.Add(tabPageStores_MBS);
            tabControlMain_MBS.Controls.Add(tabPageSuppliers_MBS);
            tabControlMain_MBS.Dock = DockStyle.Fill;
            tabControlMain_MBS.Font = new Font("Segoe UI", 10F);
            tabControlMain_MBS.Location = new Point(300, 215);
            tabControlMain_MBS.Name = "tabControlMain_MBS";
            tabControlMain_MBS.SelectedIndex = 0;
            tabControlMain_MBS.Size = new Size(900, 635);
            tabControlMain_MBS.TabIndex = 5;
            // 
            // tabPageOwners_MBS
            // 
            tabPageOwners_MBS.BackColor = Color.White;
            tabPageOwners_MBS.Controls.Add(dataGridViewOwners_MBS);
            tabPageOwners_MBS.Location = new Point(4, 32);
            tabPageOwners_MBS.Name = "tabPageOwners_MBS";
            tabPageOwners_MBS.Padding = new Padding(3);
            tabPageOwners_MBS.Size = new Size(892, 599);
            tabPageOwners_MBS.TabIndex = 0;
            tabPageOwners_MBS.Text = "👤  Владельцы";
            // 
            // dataGridViewOwners_MBS
            // 
            dataGridViewOwners_MBS.AllowUserToAddRows = false;
            dataGridViewOwners_MBS.AllowUserToDeleteRows = false;
            dataGridViewOwners_MBS.AllowUserToResizeRows = false;
            dataGridViewOwners_MBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOwners_MBS.BackgroundColor = Color.White;
            dataGridViewOwners_MBS.BorderStyle = BorderStyle.None;
            dataGridViewOwners_MBS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewOwners_MBS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOwners_MBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOwners_MBS.ColumnHeadersHeight = 40;
            dataGridViewOwners_MBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewOwners_MBS.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOwners_MBS.Dock = DockStyle.Fill;
            dataGridViewOwners_MBS.EnableHeadersVisualStyles = false;
            dataGridViewOwners_MBS.GridColor = Color.FromArgb(240, 240, 240);
            dataGridViewOwners_MBS.Location = new Point(3, 3);
            dataGridViewOwners_MBS.MultiSelect = false;
            dataGridViewOwners_MBS.Name = "dataGridViewOwners_MBS";
            dataGridViewOwners_MBS.ReadOnly = true;
            dataGridViewOwners_MBS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOwners_MBS.RowHeadersVisible = false;
            dataGridViewOwners_MBS.RowHeadersWidth = 51;
            dataGridViewOwners_MBS.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridViewOwners_MBS.RowTemplate.Height = 35;
            dataGridViewOwners_MBS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOwners_MBS.Size = new Size(886, 593);
            dataGridViewOwners_MBS.TabIndex = 0;
            // 
            // tabPageStores_MBS
            // 
            tabPageStores_MBS.BackColor = Color.White;
            tabPageStores_MBS.Controls.Add(dataGridViewStores_MBS);
            tabPageStores_MBS.Location = new Point(4, 32);
            tabPageStores_MBS.Name = "tabPageStores_MBS";
            tabPageStores_MBS.Padding = new Padding(3);
            tabPageStores_MBS.Size = new Size(892, 599);
            tabPageStores_MBS.TabIndex = 1;
            tabPageStores_MBS.Text = "🏪  Магазины";
            // 
            // dataGridViewStores_MBS
            // 
            dataGridViewStores_MBS.AllowUserToAddRows = false;
            dataGridViewStores_MBS.AllowUserToDeleteRows = false;
            dataGridViewStores_MBS.AllowUserToResizeRows = false;
            dataGridViewStores_MBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStores_MBS.BackgroundColor = Color.White;
            dataGridViewStores_MBS.BorderStyle = BorderStyle.None;
            dataGridViewStores_MBS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewStores_MBS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewStores_MBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewStores_MBS.ColumnHeadersHeight = 40;
            dataGridViewStores_MBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewStores_MBS.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewStores_MBS.Dock = DockStyle.Fill;
            dataGridViewStores_MBS.EnableHeadersVisualStyles = false;
            dataGridViewStores_MBS.GridColor = Color.FromArgb(240, 240, 240);
            dataGridViewStores_MBS.Location = new Point(3, 3);
            dataGridViewStores_MBS.MultiSelect = false;
            dataGridViewStores_MBS.Name = "dataGridViewStores_MBS";
            dataGridViewStores_MBS.ReadOnly = true;
            dataGridViewStores_MBS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewStores_MBS.RowHeadersVisible = false;
            dataGridViewStores_MBS.RowHeadersWidth = 51;
            dataGridViewStores_MBS.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridViewStores_MBS.RowTemplate.Height = 35;
            dataGridViewStores_MBS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStores_MBS.Size = new Size(886, 593);
            dataGridViewStores_MBS.TabIndex = 1;
            // 
            // tabPageSuppliers_MBS
            // 
            tabPageSuppliers_MBS.BackColor = Color.White;
            tabPageSuppliers_MBS.Controls.Add(dataGridViewSuppliers_MBS);
            tabPageSuppliers_MBS.Location = new Point(4, 32);
            tabPageSuppliers_MBS.Name = "tabPageSuppliers_MBS";
            tabPageSuppliers_MBS.Padding = new Padding(3);
            tabPageSuppliers_MBS.Size = new Size(892, 599);
            tabPageSuppliers_MBS.TabIndex = 2;
            tabPageSuppliers_MBS.Text = "🚚  Поставщики";
            // 
            // dataGridViewSuppliers_MBS
            // 
            dataGridViewSuppliers_MBS.AllowUserToAddRows = false;
            dataGridViewSuppliers_MBS.AllowUserToDeleteRows = false;
            dataGridViewSuppliers_MBS.AllowUserToResizeRows = false;
            dataGridViewSuppliers_MBS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers_MBS.BackgroundColor = Color.White;
            dataGridViewSuppliers_MBS.BorderStyle = BorderStyle.None;
            dataGridViewSuppliers_MBS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSuppliers_MBS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers_MBS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewSuppliers_MBS.ColumnHeadersHeight = 40;
            dataGridViewSuppliers_MBS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(229, 243, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewSuppliers_MBS.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewSuppliers_MBS.Dock = DockStyle.Fill;
            dataGridViewSuppliers_MBS.EnableHeadersVisualStyles = false;
            dataGridViewSuppliers_MBS.GridColor = Color.FromArgb(240, 240, 240);
            dataGridViewSuppliers_MBS.Location = new Point(3, 3);
            dataGridViewSuppliers_MBS.MultiSelect = false;
            dataGridViewSuppliers_MBS.Name = "dataGridViewSuppliers_MBS";
            dataGridViewSuppliers_MBS.ReadOnly = true;
            dataGridViewSuppliers_MBS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSuppliers_MBS.RowHeadersVisible = false;
            dataGridViewSuppliers_MBS.RowHeadersWidth = 51;
            dataGridViewSuppliers_MBS.RowTemplate.DefaultCellStyle.Padding = new Padding(5);
            dataGridViewSuppliers_MBS.RowTemplate.Height = 35;
            dataGridViewSuppliers_MBS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers_MBS.Size = new Size(886, 593);
            dataGridViewSuppliers_MBS.TabIndex = 1;
            // 
            // panelSidebar_MBS
            // 
            panelSidebar_MBS.BackColor = Color.FromArgb(240, 240, 245);
            panelSidebar_MBS.Controls.Add(groupBoxAddActions_MBS);
            panelSidebar_MBS.Controls.Add(groupBoxSummary_MBS);
            panelSidebar_MBS.Controls.Add(groupBoxFilters_MBS);
            panelSidebar_MBS.Controls.Add(groupBoxQuickActions_MBS);
            panelSidebar_MBS.Dock = DockStyle.Left;
            panelSidebar_MBS.Location = new Point(0, 215);
            panelSidebar_MBS.Name = "panelSidebar_MBS";
            panelSidebar_MBS.Size = new Size(300, 635);
            panelSidebar_MBS.TabIndex = 6;
            // 
            // groupBoxAddActions_MBS
            // 
            groupBoxAddActions_MBS.Controls.Add(buttonAddOwnerSidebar_MBS);
            groupBoxAddActions_MBS.Controls.Add(buttonAddStoreSidebar_MBS);
            groupBoxAddActions_MBS.Controls.Add(buttonAddSupplierSidebar_MBS);
            groupBoxAddActions_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxAddActions_MBS.Location = new Point(15, 10);
            groupBoxAddActions_MBS.Name = "groupBoxAddActions_MBS";
            groupBoxAddActions_MBS.Size = new Size(270, 150);
            groupBoxAddActions_MBS.TabIndex = 0;
            groupBoxAddActions_MBS.TabStop = false;
            groupBoxAddActions_MBS.Text = "Быстрое добавление";
            // 
            // buttonAddOwnerSidebar_MBS
            // 
            buttonAddOwnerSidebar_MBS.BackColor = Color.FromArgb(46, 204, 113);
            buttonAddOwnerSidebar_MBS.Dock = DockStyle.Top;
            buttonAddOwnerSidebar_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddOwnerSidebar_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddOwnerSidebar_MBS.ForeColor = Color.White;
            buttonAddOwnerSidebar_MBS.Location = new Point(3, 25);
            buttonAddOwnerSidebar_MBS.Margin = new Padding(5);
            buttonAddOwnerSidebar_MBS.Name = "buttonAddOwnerSidebar_MBS";
            buttonAddOwnerSidebar_MBS.Size = new Size(264, 35);
            buttonAddOwnerSidebar_MBS.TabIndex = 0;
            buttonAddOwnerSidebar_MBS.Text = "➕ Добавить владельца";
            buttonAddOwnerSidebar_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonAddStoreSidebar_MBS
            // 
            buttonAddStoreSidebar_MBS.BackColor = Color.FromArgb(52, 152, 219);
            buttonAddStoreSidebar_MBS.Dock = DockStyle.Top;
            buttonAddStoreSidebar_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddStoreSidebar_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddStoreSidebar_MBS.ForeColor = Color.White;
            buttonAddStoreSidebar_MBS.Location = new Point(3, 60);
            buttonAddStoreSidebar_MBS.Margin = new Padding(5);
            buttonAddStoreSidebar_MBS.Name = "buttonAddStoreSidebar_MBS";
            buttonAddStoreSidebar_MBS.Size = new Size(264, 35);
            buttonAddStoreSidebar_MBS.TabIndex = 1;
            buttonAddStoreSidebar_MBS.Text = "➕ Добавить магазин";
            buttonAddStoreSidebar_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonAddSupplierSidebar_MBS
            // 
            buttonAddSupplierSidebar_MBS.BackColor = Color.FromArgb(155, 89, 182);
            buttonAddSupplierSidebar_MBS.Dock = DockStyle.Top;
            buttonAddSupplierSidebar_MBS.FlatStyle = FlatStyle.Flat;
            buttonAddSupplierSidebar_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAddSupplierSidebar_MBS.ForeColor = Color.White;
            buttonAddSupplierSidebar_MBS.Location = new Point(3, 95);
            buttonAddSupplierSidebar_MBS.Margin = new Padding(5);
            buttonAddSupplierSidebar_MBS.Name = "buttonAddSupplierSidebar_MBS";
            buttonAddSupplierSidebar_MBS.Size = new Size(264, 35);
            buttonAddSupplierSidebar_MBS.TabIndex = 2;
            buttonAddSupplierSidebar_MBS.Text = "➕ Добавить поставщика";
            buttonAddSupplierSidebar_MBS.UseVisualStyleBackColor = false;
            // groupBoxSummary_MBS
            // 
            groupBoxSummary_MBS.Controls.Add(labelTotalStores_MBS);
            groupBoxSummary_MBS.Controls.Add(labelTotalOwners_MBS);
            groupBoxSummary_MBS.Controls.Add(labelTotalSuppliers_MBS);
            groupBoxSummary_MBS.Controls.Add(labelStoresCount_MBS);
            groupBoxSummary_MBS.Controls.Add(labelOwnersCount_MBS);
            groupBoxSummary_MBS.Controls.Add(labelSuppliersCount_MBS);
            groupBoxSummary_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxSummary_MBS.Location = new Point(15, 160);
            groupBoxSummary_MBS.Name = "groupBoxSummary_MBS";
            groupBoxSummary_MBS.Size = new Size(270, 70);
            groupBoxSummary_MBS.TabIndex = 2;
            groupBoxSummary_MBS.TabStop = false;
            groupBoxSummary_MBS.Text = "Сводка";
            // 
            // labelTotalStores_MBS
            // 
            labelTotalStores_MBS.AutoSize = true;
            labelTotalStores_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalStores_MBS.Location = new Point(200, 47);
            labelTotalStores_MBS.Name = "labelTotalStores_MBS";
            labelTotalStores_MBS.Size = new Size(18, 20);
            labelTotalStores_MBS.TabIndex = 5;
            labelTotalStores_MBS.Text = "0";
            // 
            // labelTotalOwners_MBS
            // 
            labelTotalOwners_MBS.AutoSize = true;
            labelTotalOwners_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalOwners_MBS.Location = new Point(200, 20);
            labelTotalOwners_MBS.Name = "labelTotalOwners_MBS";
            labelTotalOwners_MBS.Size = new Size(18, 20);
            labelTotalOwners_MBS.TabIndex = 4;
            labelTotalOwners_MBS.Text = "0";
            // 
            // labelTotalSuppliers_MBS
            // 
            labelTotalSuppliers_MBS.AutoSize = true;
            labelTotalSuppliers_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotalSuppliers_MBS.Location = new Point(200, 65);
            labelTotalSuppliers_MBS.Name = "labelTotalSuppliers_MBS";
            labelTotalSuppliers_MBS.Size = new Size(18, 20);
            labelTotalSuppliers_MBS.TabIndex = 3;
            labelTotalSuppliers_MBS.Text = "0";
            // 
            // labelStoresCount_MBS
            // 
            labelStoresCount_MBS.AutoSize = true;
            labelStoresCount_MBS.Font = new Font("Segoe UI", 9F);
            labelStoresCount_MBS.Location = new Point(20, 47);
            labelStoresCount_MBS.Name = "labelStoresCount_MBS";
            labelStoresCount_MBS.Size = new Size(83, 20);
            labelStoresCount_MBS.TabIndex = 2;
            labelStoresCount_MBS.Text = "Магазины:";
            // 
            // labelOwnersCount_MBS
            // 
            labelOwnersCount_MBS.AutoSize = true;
            labelOwnersCount_MBS.Font = new Font("Segoe UI", 9F);
            labelOwnersCount_MBS.Location = new Point(20, 20);
            labelOwnersCount_MBS.Name = "labelOwnersCount_MBS";
            labelOwnersCount_MBS.Size = new Size(89, 20);
            labelOwnersCount_MBS.TabIndex = 1;
            labelOwnersCount_MBS.Text = "Владельцы:";
            // 
            // labelSuppliersCount_MBS
            // 
            labelSuppliersCount_MBS.AutoSize = true;
            labelSuppliersCount_MBS.Font = new Font("Segoe UI", 9F);
            labelSuppliersCount_MBS.Location = new Point(20, 65);
            labelSuppliersCount_MBS.Name = "labelSuppliersCount_MBS";
            labelSuppliersCount_MBS.Size = new Size(98, 20);
            labelSuppliersCount_MBS.TabIndex = 0;
            labelSuppliersCount_MBS.Text = "Поставщики:";
            // 
            // groupBoxFilters_MBS
            // 
            groupBoxFilters_MBS.Controls.Add(checkBoxActiveOnly_MBS);
            groupBoxFilters_MBS.Controls.Add(checkBoxHighPriority_MBS);
            groupBoxFilters_MBS.Controls.Add(dateTimePickerFrom_MBS);
            groupBoxFilters_MBS.Controls.Add(labelFrom_MBS);
            groupBoxFilters_MBS.Controls.Add(labelTo_MBS);
            groupBoxFilters_MBS.Controls.Add(dateTimePickerTo_MBS);
            groupBoxFilters_MBS.Controls.Add(buttonApplyFilter_MBS);
            groupBoxFilters_MBS.Controls.Add(buttonResetFilter_MBS);
            groupBoxFilters_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFilters_MBS.Location = new Point(15, 240);
            groupBoxFilters_MBS.Name = "groupBoxFilters_MBS";
            groupBoxFilters_MBS.Size = new Size(270, 190);
            groupBoxFilters_MBS.TabIndex = 1;
            groupBoxFilters_MBS.TabStop = false;
            groupBoxFilters_MBS.Text = "Расширенные фильтры";
            // 
            // checkBoxActiveOnly_MBS
            // 
            checkBoxActiveOnly_MBS.AutoSize = true;
            checkBoxActiveOnly_MBS.Font = new Font("Segoe UI", 9F);
            checkBoxActiveOnly_MBS.Location = new Point(20, 35);
            checkBoxActiveOnly_MBS.Name = "checkBoxActiveOnly_MBS";
            checkBoxActiveOnly_MBS.Size = new Size(150, 24);
            checkBoxActiveOnly_MBS.TabIndex = 0;
            checkBoxActiveOnly_MBS.Text = "Только активные";
            checkBoxActiveOnly_MBS.UseVisualStyleBackColor = true;
            // 
            // checkBoxHighPriority_MBS
            // 
            checkBoxHighPriority_MBS.AutoSize = true;
            checkBoxHighPriority_MBS.Font = new Font("Segoe UI", 9F);
            checkBoxHighPriority_MBS.Location = new Point(20, 60);
            checkBoxHighPriority_MBS.Name = "checkBoxHighPriority_MBS";
            checkBoxHighPriority_MBS.Size = new Size(170, 24);
            checkBoxHighPriority_MBS.TabIndex = 1;
            checkBoxHighPriority_MBS.Text = "Высокий приоритет";
            checkBoxHighPriority_MBS.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFrom_MBS
            // 
            dateTimePickerFrom_MBS.Font = new Font("Segoe UI", 8F);
            dateTimePickerFrom_MBS.Format = DateTimePickerFormat.Short;
            dateTimePickerFrom_MBS.Location = new Point(70, 90);
            dateTimePickerFrom_MBS.Name = "dateTimePickerFrom_MBS";
            dateTimePickerFrom_MBS.Size = new Size(180, 25);
            dateTimePickerFrom_MBS.TabIndex = 2;
            // 
            // labelFrom_MBS
            // 
            labelFrom_MBS.AutoSize = true;
            labelFrom_MBS.Font = new Font("Segoe UI", 9F);
            labelFrom_MBS.Location = new Point(20, 93);
            labelFrom_MBS.Name = "labelFrom_MBS";
            labelFrom_MBS.Size = new Size(29, 20);
            labelFrom_MBS.TabIndex = 3;
            labelFrom_MBS.Text = "От:";
            // 
            // labelTo_MBS
            // 
            labelTo_MBS.AutoSize = true;
            labelTo_MBS.Font = new Font("Segoe UI", 9F);
            labelTo_MBS.Location = new Point(20, 123);
            labelTo_MBS.Name = "labelTo_MBS";
            labelTo_MBS.Size = new Size(31, 20);
            labelTo_MBS.TabIndex = 5;
            labelTo_MBS.Text = "До:";
            // 
            // dateTimePickerTo_MBS
            // 
            dateTimePickerTo_MBS.Font = new Font("Segoe UI", 8F);
            dateTimePickerTo_MBS.Format = DateTimePickerFormat.Short;
            dateTimePickerTo_MBS.Location = new Point(70, 120);
            dateTimePickerTo_MBS.Name = "dateTimePickerTo_MBS";
            dateTimePickerTo_MBS.Size = new Size(180, 25);
            dateTimePickerTo_MBS.TabIndex = 4;
            // 
            // buttonApplyFilter_MBS
            // 
            buttonApplyFilter_MBS.BackColor = Color.FromArgb(0, 122, 204);
            buttonApplyFilter_MBS.FlatStyle = FlatStyle.Flat;
            buttonApplyFilter_MBS.Font = new Font("Segoe UI", 9F);
            buttonApplyFilter_MBS.ForeColor = Color.White;
            buttonApplyFilter_MBS.Location = new Point(20, 150);
            buttonApplyFilter_MBS.Name = "buttonApplyFilter_MBS";
            buttonApplyFilter_MBS.Size = new Size(110, 30);
            buttonApplyFilter_MBS.TabIndex = 6;
            buttonApplyFilter_MBS.Text = "Применить";
            buttonApplyFilter_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonResetFilter_MBS
            // 
            buttonResetFilter_MBS.BackColor = Color.FromArgb(240, 240, 240);
            buttonResetFilter_MBS.FlatStyle = FlatStyle.Flat;
            buttonResetFilter_MBS.Font = new Font("Segoe UI", 9F);
            buttonResetFilter_MBS.Location = new Point(140, 150);
            buttonResetFilter_MBS.Name = "buttonResetFilter_MBS";
            buttonResetFilter_MBS.Size = new Size(110, 30);
            buttonResetFilter_MBS.TabIndex = 7;
            buttonResetFilter_MBS.Text = "Сбросить";
            buttonResetFilter_MBS.UseVisualStyleBackColor = false;
            // 
            // groupBoxQuickActions_MBS
            // 
            groupBoxQuickActions_MBS.Controls.Add(buttonQuickStats_MBS);
            groupBoxQuickActions_MBS.Controls.Add(buttonQuickChart_MBS);
            groupBoxQuickActions_MBS.Controls.Add(buttonQuickReport_MBS);
            groupBoxQuickActions_MBS.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxQuickActions_MBS.Location = new Point(15, 440);
            groupBoxQuickActions_MBS.Name = "groupBoxQuickActions_MBS";
            groupBoxQuickActions_MBS.Size = new Size(270, 140);
            groupBoxQuickActions_MBS.TabIndex = 3;
            groupBoxQuickActions_MBS.TabStop = false;
            groupBoxQuickActions_MBS.Text = "Быстрые действия";
            // 
            // buttonQuickStats_MBS
            // 
            buttonQuickStats_MBS.BackColor = Color.FromArgb(52, 152, 219);
            buttonQuickStats_MBS.FlatStyle = FlatStyle.Flat;
            buttonQuickStats_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuickStats_MBS.ForeColor = Color.White;
            buttonQuickStats_MBS.Location = new Point(20, 35);
            buttonQuickStats_MBS.Name = "buttonQuickStats_MBS";
            buttonQuickStats_MBS.Size = new Size(230, 30);
            buttonQuickStats_MBS.TabIndex = 0;
            buttonQuickStats_MBS.Text = "📊  Статистика";
            buttonQuickStats_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonQuickChart_MBS
            // 
            buttonQuickChart_MBS.BackColor = Color.FromArgb(46, 204, 113);
            buttonQuickChart_MBS.FlatStyle = FlatStyle.Flat;
            buttonQuickChart_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuickChart_MBS.ForeColor = Color.White;
            buttonQuickChart_MBS.Location = new Point(20, 70);
            buttonQuickChart_MBS.Name = "buttonQuickChart_MBS";
            buttonQuickChart_MBS.Size = new Size(230, 30);
            buttonQuickChart_MBS.TabIndex = 1;
            buttonQuickChart_MBS.Text = "📈  Графики";
            buttonQuickChart_MBS.UseVisualStyleBackColor = false;
            // 
            // buttonQuickReport_MBS
            // 
            buttonQuickReport_MBS.BackColor = Color.FromArgb(155, 89, 182);
            buttonQuickReport_MBS.FlatStyle = FlatStyle.Flat;
            buttonQuickReport_MBS.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonQuickReport_MBS.ForeColor = Color.White;
            buttonQuickReport_MBS.Location = new Point(20, 105);
            buttonQuickReport_MBS.Name = "buttonQuickReport_MBS";
            buttonQuickReport_MBS.Size = new Size(230, 30);
            buttonQuickReport_MBS.TabIndex = 2;
            buttonQuickReport_MBS.Text = "📋  Отчет";
            buttonQuickReport_MBS.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 880);
            Controls.Add(tabControlMain_MBS);
            Controls.Add(panelSidebar_MBS);
            Controls.Add(panelSearch_MBS);
            Controls.Add(panelHeader_MBS);
            Controls.Add(toolStripMain_MBS);
            Controls.Add(statusStripMain_MBS);
            Controls.Add(menuStripMain_MBS);
            Font = new Font("Segoe UI", 9F);
            MainMenuStrip = menuStripMain_MBS;
            MinimumSize = new Size(1000, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сеть магазинов • Управление данными";
            menuStripMain_MBS.ResumeLayout(false);
            menuStripMain_MBS.PerformLayout();
            toolStripMain_MBS.ResumeLayout(false);
            toolStripMain_MBS.PerformLayout();
            statusStripMain_MBS.ResumeLayout(false);
            statusStripMain_MBS.PerformLayout();
            panelHeader_MBS.ResumeLayout(false);
            panelHeader_MBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_MBS).EndInit();
            panelSearch_MBS.ResumeLayout(false);
            panelSearch_MBS.PerformLayout();
            tabControlMain_MBS.ResumeLayout(false);
            tabPageOwners_MBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOwners_MBS).EndInit();
            tabPageStores_MBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStores_MBS).EndInit();
            tabPageSuppliers_MBS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers_MBS).EndInit();
            panelSidebar_MBS.ResumeLayout(false);
            groupBoxAddActions_MBS.ResumeLayout(false);
            groupBoxSummary_MBS.ResumeLayout(false);
            groupBoxSummary_MBS.PerformLayout();
            groupBoxFilters_MBS.ResumeLayout(false);
            groupBoxFilters_MBS.PerformLayout();
            groupBoxQuickActions_MBS.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_MBS;
        private ToolStripMenuItem toolStripMenuItemFile_MBS;
        private ToolStripMenuItem toolStripMenuItemNew_MBS;
        private ToolStripMenuItem toolStripMenuItemLoadData_MBS;
        private ToolStripMenuItem toolStripMenuItemSaveData_MBS;
        private ToolStripMenuItem toolStripMenuItemSaveAs_MBS;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemPrint_MBS;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItemExit_MBS;
        private ToolStripMenuItem toolStripMenuItemData_MBS;
        private ToolStripMenuItem toolStripMenuItemAddOwner_MBS;
        private ToolStripMenuItem toolStripMenuItemAddStore_MBS;
        private ToolStripMenuItem toolStripMenuItemAddSupplier_MBS;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItemEdit_MBS;
        private ToolStripMenuItem toolStripMenuItemDelete_MBS;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItemRefresh_MBS;
        private ToolStripMenuItem toolStripMenuItemAnalysis_MBS;
        private ToolStripMenuItem toolStripMenuItemStats_MBS;
        private ToolStripMenuItem toolStripMenuItemCharts_MBS;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItemReport_MBS;
        private ToolStripMenuItem toolStripMenuItemExport_MBS;
        private ToolStripMenuItem toolStripMenuItemView_MBS;
        private ToolStripMenuItem toolStripMenuItemToolbar_MBS;
        private ToolStripMenuItem toolStripMenuItemStatusbar_MBS;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItemTheme_MBS;
        private ToolStripMenuItem toolStripMenuItemLight_MBS;
        private ToolStripMenuItem toolStripMenuItemDark_MBS;
        private ToolStripMenuItem toolStripMenuItemBlue_MBS;
        private ToolStripMenuItem toolStripMenuItemHelp_MBS;
        private ToolStripMenuItem toolStripMenuItemUserGuide_MBS;
        private ToolStripMenuItem toolStripMenuItemVideoGuide_MBS;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem toolStripMenuItemCheckUpdates_MBS;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem toolStripMenuItemAbout_MBS;
        private ToolStrip toolStripMain_MBS;
        private ToolStripButton toolStripButtonNew_MBS;
        private ToolStripButton toolStripButtonAddOwner_MBS;
        private ToolStripButton toolStripButtonAddStore_MBS;
        private ToolStripButton toolStripButtonAddSupplier_MBS;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripButton toolStripButtonEdit_MBS;
        private ToolStripButton toolStripButtonDelete_MBS;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripButton toolStripButtonSave_MBS;
        private ToolStripButton toolStripButtonLoad_MBS;
        private ToolStripButton toolStripButtonPrint_MBS;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripButton toolStripButtonStats_MBS;
        private ToolStripButton toolStripButtonChart_MBS;
        private ToolStripButton toolStripButtonReport_MBS;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButtonHelp_MBS;
        private StatusStrip statusStripMain_MBS;
        private ToolStripStatusLabel toolStripStatusLabelInfo_MBS;
        private ToolStripProgressBar toolStripProgressBar_MBS;
        private ToolStripStatusLabel toolStripStatusLabelCount_MBS;
        private ToolStripStatusLabel toolStripStatusLabelDate_MBS;
        private ToolStripStatusLabel toolStripStatusLabelTime_MBS;
        private Panel panelHeader_MBS;
        private Label labelTitle_MBS;
        private PictureBox pictureBoxLogo_MBS;
        private Label labelSubtitle_MBS;
        private Panel panelSearch_MBS;
        private Button buttonClearSearch_MBS;
        private Button buttonSearch_MBS;
        private TextBox textBoxSearch_MBS;
        private Label labelSearch_MBS;
        private ComboBox comboBoxFilter_MBS;
        private Label labelFilter_MBS;
        private TabControl tabControlMain_MBS;
        private TabPage tabPageOwners_MBS;
        private DataGridView dataGridViewOwners_MBS;
        private TabPage tabPageStores_MBS;
        private DataGridView dataGridViewStores_MBS;
        private TabPage tabPageSuppliers_MBS;
        private DataGridView dataGridViewSuppliers_MBS;
        private Panel panelSidebar_MBS;
        private GroupBox groupBoxQuickActions_MBS;
        private Button buttonQuickStats_MBS;
        private Button buttonQuickChart_MBS;
        private Button buttonQuickReport_MBS;
        private GroupBox groupBoxFilters_MBS;
        private CheckBox checkBoxActiveOnly_MBS;
        private CheckBox checkBoxHighPriority_MBS;
        private DateTimePicker dateTimePickerFrom_MBS;
        private Label labelFrom_MBS;
        private Label labelTo_MBS;
        private DateTimePicker dateTimePickerTo_MBS;
        private Button buttonApplyFilter_MBS;
        private Button buttonResetFilter_MBS;
        private GroupBox groupBoxSummary_MBS;
        private Label labelTotalStores_MBS;
        private Label labelTotalOwners_MBS;
        private Label labelTotalSuppliers_MBS;
        private Label labelStoresCount_MBS;
        private Label labelOwnersCount_MBS;
        private Label labelSuppliersCount_MBS;
        private Button buttonAddOwner_MBS;
        private Button buttonAddStore_MBS;
        private Button buttonAddSupplier_MBS;
        private GroupBox groupBoxAddActions_MBS;
        private Button buttonAddOwnerSidebar_MBS;
        private Button buttonAddStoreSidebar_MBS;
        private Button buttonAddSupplierSidebar_MBS;
    }
}