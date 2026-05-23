namespace ControlWorkVolkovaEliz
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            addConsumptionButton = new Button();
            editConsumptionButton = new Button();
            deleteConsumptionButton = new Button();
            clearMonthConsumptions = new Button();
            monthlyLimitNumeric = new NumericUpDown();
            statusBar = new ProgressBar();
            cmbCategoryFilter = new ComboBox();
            monthDataTimePicker = new DateTimePicker();
            showStatisticsButton = new Button();
            limitLabel = new Label();
            filterLabel = new Label();
            monthPickerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthlyLimitNumeric).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 280);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1202, 414);
            dataGridView1.TabIndex = 0;
            // 
            // addConsumptionButton
            // 
            addConsumptionButton.BackColor = SystemColors.ActiveCaption;
            addConsumptionButton.Location = new Point(42, 101);
            addConsumptionButton.Name = "addConsumptionButton";
            addConsumptionButton.Size = new Size(180, 50);
            addConsumptionButton.TabIndex = 1;
            addConsumptionButton.Text = "Добавить расход";
            addConsumptionButton.UseVisualStyleBackColor = false;
            // 
            // editConsumptionButton
            // 
            editConsumptionButton.BackColor = SystemColors.ActiveCaption;
            editConsumptionButton.Location = new Point(240, 101);
            editConsumptionButton.Name = "editConsumptionButton";
            editConsumptionButton.Size = new Size(180, 50);
            editConsumptionButton.TabIndex = 2;
            editConsumptionButton.Text = "Редактировать выбранный";
            editConsumptionButton.UseVisualStyleBackColor = false;
            // 
            // deleteConsumptionButton
            // 
            deleteConsumptionButton.BackColor = SystemColors.GradientActiveCaption;
            deleteConsumptionButton.Location = new Point(438, 101);
            deleteConsumptionButton.Name = "deleteConsumptionButton";
            deleteConsumptionButton.Size = new Size(180, 50);
            deleteConsumptionButton.TabIndex = 3;
            deleteConsumptionButton.Text = "Удалить выбранный";
            deleteConsumptionButton.UseVisualStyleBackColor = false;
            // 
            // clearMonthConsumptions
            // 
            clearMonthConsumptions.BackColor = SystemColors.HotTrack;
            clearMonthConsumptions.ForeColor = SystemColors.ButtonHighlight;
            clearMonthConsumptions.Location = new Point(636, 101);
            clearMonthConsumptions.Name = "clearMonthConsumptions";
            clearMonthConsumptions.Size = new Size(200, 50);
            clearMonthConsumptions.TabIndex = 4;
            clearMonthConsumptions.Text = "Очистить траты за месяц";
            clearMonthConsumptions.UseVisualStyleBackColor = false;
            // 
            // monthlyLimitNumeric
            // 
            monthlyLimitNumeric.DecimalPlaces = 2;
            monthlyLimitNumeric.Location = new Point(150, 15);
            monthlyLimitNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            monthlyLimitNumeric.Name = "monthlyLimitNumeric";
            monthlyLimitNumeric.Size = new Size(150, 27);
            monthlyLimitNumeric.TabIndex = 1;
            monthlyLimitNumeric.ThousandsSeparator = true;
            // 
            // statusBar
            // 
            statusBar.Location = new Point(12, 55);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(1168, 25);
            statusBar.TabIndex = 2;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.Items.AddRange(new object[] { "Все", "Еда", "Транспорт", "Развлечения", "Здоровье", "Остальное" });
            cmbCategoryFilter.Location = new Point(140, 225);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(150, 28);
            cmbCategoryFilter.TabIndex = 6;
            // 
            // monthDataTimePicker
            // 
            monthDataTimePicker.CustomFormat = "MMMM yyyy";
            monthDataTimePicker.Format = DateTimePickerFormat.Custom;
            monthDataTimePicker.Location = new Point(400, 225);
            monthDataTimePicker.Name = "monthDataTimePicker";
            monthDataTimePicker.ShowUpDown = true;
            monthDataTimePicker.Size = new Size(160, 27);
            monthDataTimePicker.TabIndex = 8;
            // 
            // showStatisticsButton
            // 
            showStatisticsButton.BackColor = SystemColors.ActiveCaption;
            showStatisticsButton.Location = new Point(860, 101);
            showStatisticsButton.Name = "showStatisticsButton";
            showStatisticsButton.Size = new Size(180, 50);
            showStatisticsButton.TabIndex = 9;
            showStatisticsButton.Text = "Показать статистику";
            showStatisticsButton.UseVisualStyleBackColor = false;
            // 
            // limitLabel
            // 
            limitLabel.Location = new Point(12, 15);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(130, 25);
            limitLabel.TabIndex = 0;
            limitLabel.Text = "Лимит на месяц (₽):";
            // 
            // filterLabel
            // 
            filterLabel.Location = new Point(12, 225);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(130, 25);
            filterLabel.TabIndex = 5;
            filterLabel.Text = "Фильтрация";
            // 
            // monthPickerLabel
            // 
            monthPickerLabel.Location = new Point(330, 225);
            monthPickerLabel.Name = "monthPickerLabel";
            monthPickerLabel.Size = new Size(60, 25);
            monthPickerLabel.TabIndex = 7;
            monthPickerLabel.Text = "Месяц:";
            // 
            // MainForm
            // 
            ClientSize = new Size(1192, 692);
            Controls.Add(limitLabel);
            Controls.Add(monthlyLimitNumeric);
            Controls.Add(statusBar);
            Controls.Add(filterLabel);
            Controls.Add(cmbCategoryFilter);
            Controls.Add(monthPickerLabel);
            Controls.Add(monthDataTimePicker);
            Controls.Add(showStatisticsButton);
            Controls.Add(dataGridView1);
            Controls.Add(addConsumptionButton);
            Controls.Add(editConsumptionButton);
            Controls.Add(deleteConsumptionButton);
            Controls.Add(clearMonthConsumptions);
            Name = "MainForm";
            Text = "Трекер расходов";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthlyLimitNumeric).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
        private Button addConsumptionButton;
        private Button editConsumptionButton;
        private Button deleteConsumptionButton;
        private Button clearMonthConsumptions;
        private NumericUpDown monthlyLimitNumeric;
        private ProgressBar statusBar;
        private ComboBox cmbCategoryFilter;
        private DateTimePicker monthDataTimePicker;
        private Button showStatisticsButton;
        private Label limitLabel;
        private Label filterLabel;
        private Label monthPickerLabel;
    }
}