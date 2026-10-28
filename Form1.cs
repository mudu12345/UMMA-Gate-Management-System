using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace UmmaGateManagement
{
    public partial class btnclear : Form
    {
        public btnclear()
        {
            InitializeComponent();

            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("Staff");
            cmbCategory.Items.Add("Student");
            cmbCategory.Items.Add("Visitor");
            cmbCategory.Items.Add("Vehicle");

            cmbCategory.SelectedIndex = 0;

            cmbMovement.Items.Clear();
            cmbMovement.Items.Add("Entry");
            cmbMovement.Items.Add("Exit");
            cmbMovement.SelectedIndex = 0;

            // ADD THIS LINE HERE
            LoadRecords();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtIDNumber.Clear();
            txtVehicleNumber.Clear();
            txtPurpose.Clear();

            cmbCategory.SelectedIndex = 0;
            cmbMovement.SelectedIndex = 0;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string idNumber = txtIDNumber.Text.Trim();
            string category = cmbCategory.Text;
            string vehicleNumber = txtVehicleNumber.Text.Trim();
            string movement = cmbMovement.Text;
            string purpose = txtPurpose.Text.Trim();

            // Validate required fields
            if (fullName == "" || idNumber == "" || purpose == "")
            {
                MessageBox.Show(
                    "Please fill in Full Name, ID Number and Purpose.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedIndex == -1 ||
                cmbMovement.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a Category and Movement.",
                    "Missing Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Add record to the table
            dgvRecords.Rows.Add(
                fullName, idNumber, category,
                  vehicleNumber, movement,
              DateTime.Now.ToString("dd/MM/yyyy HH:mm"));


            SaveRecords();
            MessageBox.Show("Record deleted successfully.");


            MessageBox.Show("Gate record registered successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Clear input fields
            txtFullName.Clear();
            txtIDNumber.Clear();
            txtVehicleNumber.Clear();
            txtPurpose.Clear();

            cmbCategory.SelectedIndex = 0;
            cmbMovement.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (searchText == "")
            {
                MessageBox.Show("Please enter a name, ID number or vehicle number.");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string fullName = Convert.ToString(row.Cells["colFullName"].Value) ?? "";
                string idNumber = Convert.ToString(row.Cells["colIdNumber"].Value) ?? "";
                string vehicleNumber = Convert.ToString(row.Cells["colVehicleNumber"].Value) ?? "";

                if (fullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    idNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                    vehicleNumber.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dgvRecords.CurrentCell = row.Cells[0];
                    dgvRecords.FirstDisplayedScrollingRowIndex = row.Index;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                MessageBox.Show("Record found!");
            }
            else
            {
                MessageBox.Show("No matching record found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.",
                                "No Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvRecords.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvRecords.Rows.Remove(row);
                    }
                }

                MessageBox.Show("Record deleted successfully.");
            }
        }
        private void SaveRecords()
        {
            string filePath = Path.Combine(
                Application.StartupPath,
                "GateRecords.csv");

            using (StreamWriter writer = new StreamWriter(
                filePath, false, Encoding.UTF8))
            {
                writer.WriteLine(
                    "Full Name,ID Number,Category,Vehicle Number,Movement,Date Time");

                foreach (DataGridViewRow row in dgvRecords.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    string[] values = new string[6];

                    for (int i = 0; i < 6; i++)
                    {
                        string value =
                            Convert.ToString(row.Cells[i].Value) ?? "";

                        values[i] = "\"" +
                            value.Replace("\"", "\"\"") + "\"";
                    }

                    writer.WriteLine(string.Join(",", values));
                }
            }

        }
        private void LoadRecords()
        {
            string filePath = Path.Combine(
                Application.StartupPath,
                "GateRecords.csv");

            if (!File.Exists(filePath))
                return;

            dgvRecords.Rows.Clear();

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                // Skip the CSV header
                reader.ReadLine();

                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = ParseCsvLine(line);

                    if (values.Length == 6)
                    {
                        dgvRecords.Rows.Add(
                            values[0],
                            values[1],
                            values[2],
                            values[3],
                            values[4],
                            values[5]);
                    }
                }
            }
        }
        private string[] ParseCsvLine(string line)
        {
            var values = new List<string>();
            var current = new StringBuilder();
            bool insideQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    if (insideQuotes &&
                        i + 1 < line.Length &&
                        line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        insideQuotes = !insideQuotes;
                    }
                }
                else if (c == ',' && !insideQuotes)
                {
                    values.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }

            values.Add(current.ToString());
            return values.ToArray();
        }
    }
   
}
