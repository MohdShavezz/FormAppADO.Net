using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            dataTable = new DataTable();
            InitializeComponent();
        }

        private int currentRow = 0;
        private DataTable dataTable;
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (id.Text == "" || name.Text == "" || age.Text == "")
                {
                    MessageBox.Show("All fields Required..");
                }
                else
                {
                    string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(ConString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Student VALUES (@id,@name,@age) ", conn);
                        cmd.Parameters.AddWithValue("@id", int.Parse(id.Text));
                        cmd.Parameters.AddWithValue("@name", name.Text);
                        cmd.Parameters.AddWithValue("@age", float.Parse(age.Text));
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        MessageBox.Show("Inserted...");
                        id.Text = "";
                        name.Text = "";
                        age.Text = "";
                        id.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("OOPs, something went wrong.\n" + ex.Message);
            }
            Console.ReadLine();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("wanna delete...?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
                    using (SqlConnection conn = new SqlConnection(ConString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE Student WHERE id=@id ", conn);
                        cmd.Parameters.AddWithValue("@id", int.Parse(id.Text));
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        MessageBox.Show("Deleted...");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            Console.ReadLine();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Student SET name=@name,age=@age WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(id.Text));
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@age", float.Parse(age.Text));
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    MessageBox.Show("Updated...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            Console.ReadLine();

        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            Console.ReadLine();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(id.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow firstRow = dataTable.Rows[0];

                        // Assuming you have TextBox controls on the form to display the data
                        id.Text = firstRow["id"].ToString();
                        name.Text = firstRow["name"].ToString();
                        age.Text = firstRow["age"].ToString();
                    }
                    else
                    {
                        // Handle case when no rows are returned
                        // Clear the input fields or show a message indicating no data found
                        id.Text = "";
                        name.Text = "";
                        age.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            Console.ReadLine();
        }



        private void First_Click(object sender, EventArgs e)
        {
            string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                // Display the first row in the DataGridView
                if (dataTable.Rows.Count > 0)
                {
                    DataRow firstRow = dataTable.Rows[0];

                    // Assuming you have TextBox controls on the form to display the data
                    id.Text = firstRow["id"].ToString();
                    name.Text = firstRow["name"].ToString();
                    age.Text = firstRow["age"].ToString();
                }
                else
                {
                    // Handle case when no rows are returned
                    // Clear the input fields or show a message indicating no data found
                    id.Text = "";
                    name.Text = "";
                    age.Text = "";
                }
            }
        }

        private void Last_Click(object sender, EventArgs e)
        {
            string ConString = "data Source=SHAVEZ;Initial Catalog=crudForm;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(ConString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student", conn);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                // Display the first row in the DataGridView
                if (dataTable.Rows.Count > 0)
                {
                    DataRow firstRow = dataTable.Rows[dataTable.Rows.Count - 1];

                    // Assuming you have TextBox controls on the form to display the data
                    id.Text = firstRow["id"].ToString();
                    name.Text = firstRow["name"].ToString();
                    age.Text = firstRow["age"].ToString();
                }
                else
                {
                    // Handle case when no rows are returned
                    // Clear the input fields or show a message indicating no data found
                    id.Text = "";
                    name.Text = "";
                    age.Text = "";
                }
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentRow < dataTable.Rows.Count - 1)
            {
                currentRow++;
                DisplayRow(currentRow);
            }
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            if (currentRow > 0)
            {
                currentRow--;
                DisplayRow(currentRow);
            }
        }

        private void DisplayRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataTable.Rows.Count)
            {
                DataRow row = dataTable.Rows[rowIndex];
                // Assuming you have TextBox controls on the form to display the data
                id.Text = row["id"].ToString();
                name.Text = row["name"].ToString();
                age.Text = row["age"].ToString();

                // Highlight the corresponding row in the DataGridView
                dataGridView1.ClearSelection();
                dataGridView1.Rows[rowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve the desired column values from the selected row
                id.Text = selectedRow.Cells["Id"].Value.ToString();
                name.Text = selectedRow.Cells["Name"].Value.ToString();
                age.Text = selectedRow.Cells["Age"].Value.ToString();
                
            }
        }
    }
}