using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class UserPanelForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public UserPanelForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void CreateRouteColumns(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("id", "Id");
            dataGrid.Columns.Add("name", "Name");
            dataGrid.Columns.Add("description", "Description");
            dataGrid.Columns.Add("start_location", "Start Location");
            dataGrid.Columns.Add("end_location", "End Location");
        }

        private void CreateReviewColumns(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("id", "Id");
            dataGrid.Columns.Add("user_id", "User Id");
            dataGrid.Columns.Add("poi_id", "Points Of Interest");
            dataGrid.Columns.Add("description", "Description");
            dataGrid.Columns.Add("rating", "rating");
        }

        private void CreateLocationColumns(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("id", "Id");
            dataGrid.Columns.Add("name", "Name");
            dataGrid.Columns.Add("description", "Description");
        }

        private void CreateAttractionColumns(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("id", "Id");
            dataGrid.Columns.Add("location_id", "Location Id");
            dataGrid.Columns.Add("name", "Name");
            dataGrid.Columns.Add("description", "Description");
            dataGrid.Columns.Add("route", "Route");
        }

        private void CreateEstablishementColumns(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();

            dataGrid.Columns.Add("id", "Id");
            dataGrid.Columns.Add("location_id", "Location Id");
            dataGrid.Columns.Add("name", "Name");
            dataGrid.Columns.Add("category", "Category");
            dataGrid.Columns.Add("description", "Description");
            dataGrid.Columns.Add("rating", "Rating");
        }

        private void ReadRoutesSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void ReadReviewsSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4));
        }

        private void ReadLocationsSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        private void ReadAttractionsSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4));
        }

        private void ReadEstablishmentsSingleRow(DataGridView dataGrid, IDataRecord record)
        {
            dataGrid.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5));
        }

        private void SetRoutesDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Routes";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadRoutesSingleRow(dataGrid, reader);
                    }

                    reader.Close();
                }
            }
        }

        private void SetReviewsDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Reviews";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadReviewsSingleRow(dataGrid, reader);
                    }

                    reader.Close();
                }
            }
        }

        private void SetLocationDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Locations";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadLocationsSingleRow(dataGrid, reader);
                    }

                    reader.Close();
                }
            }
        }

        private void SetAttractionDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM PointOfInterest";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadAttractionsSingleRow(dataGrid, reader);
                    }

                    reader.Close();
                }
            }
        }

        private void SetEstablishmentDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Establishments";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ReadEstablishmentsSingleRow(dataGrid, reader);
                    }

                    reader.Close();
                }
            }
        }

        private void routesButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Routes";
            tableTitleLabel.Visible = true;
            dataGridView.Visible = true;
            titleLabel.Visible = false;
            CreateRouteColumns(dataGridView);
            SetRoutesDataGrid(dataGridView);
        }

        private void reviewsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Reviews";
            tableTitleLabel.Visible = true;
            dataGridView.Visible = true;
            titleLabel.Visible = false;
            CreateReviewColumns(dataGridView);
            SetReviewsDataGrid(dataGridView);
        }

        private void locationsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Locations";
            tableTitleLabel.Visible = true;
            dataGridView.Visible = true;
            titleLabel.Visible = false;
            CreateLocationColumns(dataGridView);
            SetLocationDataGrid(dataGridView);
        }

        private void poiButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Points Of Interest";
            tableTitleLabel.Visible = true;
            dataGridView.Visible = true;
            titleLabel.Visible = false;
            CreateAttractionColumns(dataGridView);
            SetAttractionDataGrid(dataGridView);
        }

        private void establishmentsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Establishments";
            tableTitleLabel.Visible = true;
            dataGridView.Visible = true;
            titleLabel.Visible = false;
            CreateEstablishementColumns(dataGridView);
            SetEstablishmentDataGrid(dataGridView);
        }

        private void hideInfoButton_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = true;
            tableTitleLabel.Visible = false;
            dataGridView.Visible = false;
        }
    }
}
