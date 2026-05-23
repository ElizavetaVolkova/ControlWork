using BudgetTracker.Classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlWorkVolkovaEliz
{
    public partial class MainForm : Form
    {
        private Budget budget;
        private DateTime currentMonth;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            SubscribeEvents();
        }

        private void LoadData()
        {
            budget = FileManager.LoadData();
            monthlyLimitNumeric.Value = budget.MonthlyLimit;
            currentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            monthDataTimePicker.Value = currentMonth;
            cmbCategoryFilter.SelectedIndex = 0;
            RefreshGrid();
        }

        private void SaveData()
        {
            FileManager.SaveData(budget);
        }

        private void RefreshGrid()
        {
            currentMonth = new DateTime(monthDataTimePicker.Value.Year, monthDataTimePicker.Value.Month, 1);

            var filtered = budget.Consumptions
                .Where(c => c.Date.Year == currentMonth.Year && c.Date.Month == currentMonth.Month);

            string category = cmbCategoryFilter.SelectedItem?.ToString();
            if (category != "Все" && category != null)
                filtered = filtered.Where(c => c.Category == category);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtered.OrderBy(c => c.Date).ToList();

            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].Visible = false;

            if (dataGridView1.Columns["IsEssential"] != null)
                dataGridView1.Columns["IsEssential"].HeaderText = "Обязательная трата";

            UpdateProgressBar();
        }

        private void UpdateProgressBar()
        {
            decimal spent = 0;
            foreach (var c in budget.Consumptions)
            {
                if (c.Date.Year == currentMonth.Year && c.Date.Month == currentMonth.Month)
                    spent = spent + c.Amount;
            }

            decimal limit = budget.MonthlyLimit;

            if (limit > 0)
            {
                int percent = (int)((spent / limit) * 100);
                if (percent > 100) percent = 100;
                statusBar.Value = percent;

                if (spent > limit)
                {
                    statusBar.BackColor = Color.LightCoral;
                }
                else
                {
                    statusBar.BackColor = SystemColors.Control;
                }
            }
            else
            {
                statusBar.Value = 0;
                statusBar.BackColor = SystemColors.Control;
            }
        }

        private void SubscribeEvents()
        {    
            deleteConsumptionButton.Click += buttonDelete_Click;
            clearMonthConsumptions.Click += buttonClearMonth_Click;
            showStatisticsButton.Click += buttonShowStats_Click;
            monthlyLimitNumeric.ValueChanged += MonthlyLimit_ValueChanged;
            cmbCategoryFilter.SelectedIndexChanged += (s, e) => RefreshGrid();
            monthDataTimePicker.ValueChanged += (s, e) => RefreshGrid();
            dataGridView1.DoubleClick += (s, e) => EditConsumption();
        }


        private void EditConsumption()
        {
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Consumption selected = dataGridView1.CurrentRow.DataBoundItem as Consumption;
                if (selected != null)
                {
                    DialogResult result = MessageBox.Show("Удалить расход \"" + selected.Title + "\"?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        budget.Consumptions.Remove(selected);
                        SaveData();
                        RefreshGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите расход для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClearMonth_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var c in budget.Consumptions)
            {
                if (c.Date.Year == currentMonth.Year && c.Date.Month == currentMonth.Month)
                    count = count + 1;
            }

            if (count == 0)
            {
                MessageBox.Show("За выбранный месяц нет расходов.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Удалить все расходы за " + currentMonth.ToString("MMMM yyyy") + " (" + count + " записей)?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                budget.Consumptions.RemoveAll(c => c.Date.Year == currentMonth.Year && c.Date.Month == currentMonth.Month);
                SaveData();
                RefreshGrid();
            }
        }

        private void buttonShowStats_Click(object sender, EventArgs e)
        {
            var categoryTotals = new System.Collections.Generic.Dictionary<string, decimal>();

            foreach (var c in budget.Consumptions)
            {
                if (c.Date.Year == currentMonth.Year && c.Date.Month == currentMonth.Month)
                {
                    if (categoryTotals.ContainsKey(c.Category))
                        categoryTotals[c.Category] = categoryTotals[c.Category] + c.Amount;
                    else
                        categoryTotals[c.Category] = c.Amount;
                }
            }

            if (categoryTotals.Count == 0)
            {
                MessageBox.Show("Нет данных за выбранный месяц.", "Статистика", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = "";
                foreach (var item in categoryTotals)
                {
                    message = message + item.Key + ": " + item.Value.ToString("F2") + " ₽\n";
                }
                MessageBox.Show(message, "Статистика за " + currentMonth.ToString("MMMM yyyy"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MonthlyLimit_ValueChanged(object sender, EventArgs e)
        {
            budget.MonthlyLimit = monthlyLimitNumeric.Value;
            SaveData();
            RefreshGrid();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }
    }
}