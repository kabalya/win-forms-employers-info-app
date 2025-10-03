using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Web.Configuration;
using System.Windows.Forms;
using TestTaskProject.Entitys;

namespace TestTaskProject
{
    public partial class FormListEmployers : Form
    {
        Thread thread;
        public FormListEmployers()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }


        private void ButtonBeginSearch_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string typeOfSort, sortBy;

            try
            {
                table.Columns.Add(ColumnsNames.FullName, typeof(string));
                table.Columns.Add(ColumnsNames.Status, typeof(string));
                table.Columns.Add(ColumnsNames.Department, typeof(string));
                table.Columns.Add(ColumnsNames.Post, typeof(string));
                table.Columns.Add(ColumnsNames.DateEmploy, typeof(DateTime));
                table.Columns.Add(ColumnsNames.DateUnemploy, typeof(DateTime));

                dataGridView1.DataSource = table;

                typeOfSort = "ASC";
                sortBy = GetSelectedSortColumn();
                if (sortBy is null) radioButtonDoNotSort.Checked = true;

                if (radioButtonDESC.Checked)
                {
                    typeOfSort = "DESC";
                }
                else
                {
                    radioButtonASC.Checked = true;
                }

                using (SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["MyDbConnection"].ToString()))
                using (SqlCommand cmd = new SqlCommand(StoredProceduresNames.ListOfPersons, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FilterStatus", string.IsNullOrWhiteSpace(textBoxStatus.Text) ? (object)DBNull.Value : textBoxStatus.Text);
                    cmd.Parameters.AddWithValue("@FilterDepartment", string.IsNullOrWhiteSpace(textBoxDepartment.Text) ? (object)DBNull.Value : textBoxDepartment.Text);
                    cmd.Parameters.AddWithValue("@FilterPost", string.IsNullOrWhiteSpace(textBoxPost.Text) ? (object)DBNull.Value : textBoxPost.Text);
                    cmd.Parameters.AddWithValue("@FilterNamePart", string.IsNullOrWhiteSpace(textBoxPartName.Text) ? (object)DBNull.Value : textBoxPartName.Text);
                    cmd.Parameters.AddWithValue("@SortBy", sortBy ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@TypeOfSort", typeOfSort);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader.GetString(0);
                            string status = reader.GetString(1);
                            string department = reader.GetString(2);
                            string post = reader.GetString(3);
                            string dateEmploy = reader.IsDBNull(4) ? null : reader.GetDateTime(4).ToString("yyyy-MM-dd");
                            string dateUnemploy = reader.IsDBNull(5) ? null : reader.GetDateTime(5).ToString("yyyy-MM-dd");

                            table.Rows.Add(fullName, status, department, post, dateEmploy, dateUnemploy);

                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedSortColumn()
        {
            var radioButtonDictionary = new Dictionary<RadioButton, string>
            {
                [radioButtonStatus] = "status",
                [radioButtonDepartment] = "department",
                [radioButtonPost] = "post",
                [radioButtonName] = "Name",
                [radioButtonDateOfEmploy] = "date_employ",
                [radioButtonDateOfEnemploy] = "date_unemploy"
            };

            return radioButtonDictionary.FirstOrDefault(x => x.Key.Checked).Value;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "Full name")
                return;
            
            if (dataGridView1.Rows[e.RowIndex].Cells[ColumnsNames.Status].Value.ToString().Equals("Fired"))
            {
                e.CellStyle.BackColor = Color.LightCoral;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[ColumnsNames.DateUnemploy].Value != DBNull.Value)
            {
                e.CellStyle.BackColor = Color.LightCoral;
                e.CellStyle.ForeColor = Color.White;
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
