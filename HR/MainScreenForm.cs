using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace HR
{
    public partial class MainScreenForm : Form
    {

        private DatabaseConnector dbConnector;
        public MainScreenForm()
        {
            InitializeComponent();
            dbConnector = new DatabaseConnector();

        }

     

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Show the panel for adding an employee
            panelAddEmployee.Visible = true;
            panelAddEmployee.BringToFront();

            // Hide other panels
            panelAllEmployees.Visible = false;
            // Add similar lines for other panels if needed

        }

        private void allEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoadEmployeesData();

            // Show the panel for all employees
            panelAllEmployees.Visible = true;
            panelAllEmployees.BringToFront();

            // Hide other panels
            panelAddEmployee.Visible = false;
            // Add similar lines for other panels if needed
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Perform sign out logic (e.g., close the current form or open a login form)
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void saveEmpBtn_Click(object sender, EventArgs e)
        {
            // Retrieve data from field controls
            string emp_code = empCode.Text;
            string emp_name = empName.Text;
            string emp_position = position.Text;
            string emp_address = address.Text;
            string national_id = nationalID.Text;

            // Construct the SQL query
            string query = "INSERT INTO employees (emp_code, name, position, address, national_id) " +
                           "VALUES (@emp_code, @emp_name, @emp_position, @emp_address, @national_id)";

            try
            {
                dbConnector.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnector.Connection))
                {
                    // Set parameters
                    cmd.Parameters.AddWithValue("@emp_code", emp_code);
                    cmd.Parameters.AddWithValue("@emp_name", emp_name);
                    cmd.Parameters.AddWithValue("@emp_position", emp_position);
                    cmd.Parameters.AddWithValue("@emp_address", emp_address);
                    cmd.Parameters.AddWithValue("@national_id", national_id);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم إضافة الموظف بنجاح!");


                        // Clear the text fields
                        empCode.Text = "";
                        empName.Text = "";
                        position.Text = "";
                        address.Text = "";
                        nationalID.Text = "";


                    }
                    else
                    {
                        MessageBox.Show("فشل في إضافة الموظف.");
                    }
                }



            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }


        private void LoadEmployeesData()
        {
            // Assume dbConnector is your DatabaseConnector instance

            string query = "SELECT * FROM employees";

            try
            {
                dbConnector.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnector.Connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Map columns from DataTable to DataGridView
                        dataGridViewEmployees.Columns["idCol"].DataPropertyName = "id";
                        dataGridViewEmployees.Columns["emp_codeCol"].DataPropertyName = "emp_code";
                        dataGridViewEmployees.Columns["nameCol"].DataPropertyName = "name";
                        dataGridViewEmployees.Columns["positionCol"].DataPropertyName = "position";
                        dataGridViewEmployees.Columns["addressCol"].DataPropertyName = "address";
                        dataGridViewEmployees.Columns["nationalIDCol"].DataPropertyName = "national_id";

                        // Bind the DataTable to the DataGridView
                        dataGridViewEmployees.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                // Get the value from the selected row's "emp_id" column
                int selectedEmpId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["idCol"].Value);

                // Display a confirmation message
                DialogResult result = MessageBox.Show("هل أنت متأكد من حذف الموظف؟", "التأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform the delete operation
                    DeleteEmployee(selectedEmpId);

                    // Reload data after deletion
                    LoadEmployeesData();
                }
            }
            else
            {
                MessageBox.Show("فضلاً حدد احد الموظفين أولاً.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void DeleteEmployee(int empId)
        {

            string query = "DELETE FROM employees WHERE id = @empId";

            try
            {
                dbConnector.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnector.Connection))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم حذف الموظف بنجاح!", "تم بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("فشل في حذف الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
               
                            int selectedEmpId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["idCol"].Value);

                btnSaveChanges.Visible = true;
            }
            else
            {
                MessageBox.Show("حدد صف للتعديل.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateEmployee(int empId, string empCode, string empName, string position, string address, string nationalId)
        {
            // Assume dbConnector is your DatabaseConnector instance

            string query = "UPDATE employees SET emp_code = @empCode, name = @empName, position = @position, address = @address, national_id = @nationalId WHERE id = @empId";

            try
            {
                dbConnector.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, dbConnector.Connection))
                {
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@empCode", empCode);
                    cmd.Parameters.AddWithValue("@empName", empName);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@nationalId", nationalId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("تم تعديل الموظف بنجاح!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("فشل في تعديل الموظف.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log, show error message, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                dbConnector.CloseConnection();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Get the updated values from the textboxes
            // Get the values from the selected row
            int selectedEmpId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["idCol"].Value);
            string empCode = dataGridViewEmployees.SelectedRows[0].Cells["emp_codeCol"].Value.ToString();
            string empName = dataGridViewEmployees.SelectedRows[0].Cells["nameCol"].Value.ToString();
            string position = dataGridViewEmployees.SelectedRows[0].Cells["positionCol"].Value.ToString();
            string address = dataGridViewEmployees.SelectedRows[0].Cells["addressCol"].Value.ToString();
            string nationalId = dataGridViewEmployees.SelectedRows[0].Cells["nationalIDCol"].Value.ToString();

            // Perform the update operation
            UpdateEmployee(selectedEmpId, empCode, empName, position, address, nationalId);

            // Reload data after update
            LoadEmployeesData();

            // Hide the "Save Changes" button or perform other actions as needed
            btnSaveChanges.Visible = false;
        }
    }





}
