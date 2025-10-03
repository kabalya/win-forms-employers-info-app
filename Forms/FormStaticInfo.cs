using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TestTaskProject.Entitys;

namespace TestTaskProject
{
    public partial class FormStaticInfo : Form
    {
        Thread thread;
        public FormStaticInfo()
        {
            InitializeComponent();
        }
                
        private void ButtonBeginSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string storedProcedure, defaultStatus;

            try
            {

                storedProcedure = ValdateRadioButtons(table);
                ValidateDateRange();

                table.Columns.Add(ColumnsNames.Count, typeof(int));
                defaultStatus = "Working";
                dataGridView2.DataSource = table;

                using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyDbConnection"].ToString()))
                using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (comboBoxStatus.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxStatus.SelectedItem.ToString())) comboBoxStatus.SelectedIndex = 1;

                    cmd.Parameters.AddWithValue("@StatusName", comboBoxStatus.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxStatus.SelectedItem.ToString()) ? defaultStatus : comboBoxStatus.SelectedItem.ToString()); // Привет читающему :)  
                    cmd.Parameters.AddWithValue("@StartDate", dateTimePickerStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateTimePickerEndDate.Value);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dateEmploy = reader.GetDateTime(0);
                            int count = reader.GetInt32(1);

                            table.Rows.Add(dateEmploy, count);

                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message, "Ошибка Базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValdateRadioButtons(DataTable table)
        {
            if (!radioButtonFired.Checked && !radioButtonHired.Checked)
            {
                radioButtonFired.Checked = true;
                table.Columns.Add(ColumnsNames.DateUnemploy, typeof(DateTime));
                return StoredProceduresNames.UnemployedStatisticPerDay;

            }
            else if (radioButtonHired.Checked)
            {
                table.Columns.Add(ColumnsNames.DateEmploy, typeof(DateTime));
                return StoredProceduresNames.EmployedStatisticPerDay;
            }
            else
            {

                table.Columns.Add(ColumnsNames.DateUnemploy, typeof(DateTime));
                return StoredProceduresNames.UnemployedStatisticPerDay;
            }
        }

        private void ValidateDateRange()
        {
            if (dateTimePickerEndDate.Value.AddSeconds(1) < dateTimePickerStartDate.Value)
            {
                MessageBox.Show("Дата окончания не может быть раньше даты начала!","Ошибка ввода",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ButtonBackToStartForm_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(OpenFormStart);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void OpenFormStart(object obj)
        {
            Application.Run(new FormStart());
        }
    }
}
