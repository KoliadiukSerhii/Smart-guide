using System;
using System.Collections;
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
    public partial class AdminPanel : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        private enum ButtonPressed
        {
            ADD_ROUTE,
            ADD_REVIEW,
            ADD_LOCATION,
            ADD_ATTRACTION,
            ADD_ESTABLISHMENT,

            DELETE_ROUTE,
            DELETE_REVIEW,
            DELETE_LOCATION,
            DELETE_ATTRACTION,
            DELETE_ESTABLISHMENT
        };

        private ButtonPressed? buttonPressed = null;

        public AdminPanel()
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
        
        private void HideDeleteAndAddButtons()
        {
            workWithCurrentInfoLabel.Visible = false;
            routesLabel.Visible = false;
            reviewsLabel.Visible = false;
            locationsLabel.Visible = false;
            attractionsLabel.Visible = false;
            establishmentsLabel.Visible = false;

            showCurrentInfo.Visible = false;
            currentInfoLabel.Visible = false;

            addRoute.Visible = false;
            deleteRoute.Visible = false;

            addReview.Visible = false;
            deleteReview.Visible = false;

            addLocation.Visible = false;
            deleteLocation.Visible = false;

            addAttraction.Visible = false;
            deleteAttraction.Visible = false;

            addEstablishment.Visible = false;
            deleteEstablishment.Visible = false;
        }

        private void showCurrentInfo_Click(object sender, EventArgs e)
        {
            HideDeleteAndAddButtons();

            hideButton.Visible = true;
            showRoutesButton.Visible = true;
            showLocationsButton.Visible = true;
            showEstablishmentsButton.Visible = true;
            showReviewsButton.Visible = true;
            showAttractionsButton.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            workWithCurrentInfoLabel.Visible = true;
            routesLabel.Visible = true;
            reviewsLabel.Visible = true;
            locationsLabel.Visible = true;
            attractionsLabel.Visible = true;
            establishmentsLabel.Visible = true;

            showCurrentInfo.Visible = true;
            currentInfoLabel.Visible = true;

            addRoute.Visible = true;
            deleteRoute.Visible = true;

            addReview.Visible = true;
            deleteReview.Visible = true;

            addLocation.Visible = true;
            deleteLocation.Visible = true;

            addAttraction.Visible = true;
            deleteAttraction.Visible = true;

            addEstablishment.Visible = true;
            deleteEstablishment.Visible = true;

            dataGridViewAdmin.Visible = false;
            hideButton.Visible = false;
            showRoutesButton.Visible = false;
            showLocationsButton.Visible = false;
            showEstablishmentsButton.Visible = false;
            showReviewsButton.Visible = false;
            showAttractionsButton.Visible = false;
            tableTitleLabel.Visible = false;

            inputLabel1.Visible = false;
            inputLabel2.Visible = false;
            inputLabel3.Visible = false;
            inputLabel4.Visible = false;
            inputLabel5.Visible = false;

            inputBox1.Visible = false;
            inputBox2.Visible = false;
            inputBox3.Visible = false;
            inputBox4.Visible = false;
            inputBox5.Visible = false;

            inputLabel1.Text = string.Empty;
            inputLabel2.Text = string.Empty;
            inputLabel3.Text = string.Empty;
            inputLabel4.Text = string.Empty;
            inputLabel5.Text = string.Empty;

            inputBox1.Text = string.Empty;
            inputBox2.Text = string.Empty;
            inputBox3.Text = string.Empty;
            inputBox4.Text = string.Empty;
            inputBox5.Text = string.Empty;
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

        private void showRoutesButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Routes";
            tableTitleLabel.Visible = true;
            dataGridViewAdmin.Visible = true;
            CreateRouteColumns(dataGridViewAdmin);
            SetRoutesDataGrid(dataGridViewAdmin);
        }

        private void showLocationsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Locations";
            tableTitleLabel.Visible = true;
            dataGridViewAdmin.Visible = true;
            CreateLocationColumns(dataGridViewAdmin);
            SetLocationDataGrid(dataGridViewAdmin);
        }

        private void showEstablishmentsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Establishments";
            tableTitleLabel.Visible = true;
            dataGridViewAdmin.Visible = true;
            CreateEstablishementColumns(dataGridViewAdmin);
            SetEstablishmentDataGrid(dataGridViewAdmin);
        }

        private void showReviewsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Reviews";
            tableTitleLabel.Visible = true;
            dataGridViewAdmin.Visible = true;
            CreateReviewColumns(dataGridViewAdmin);
            SetReviewsDataGrid(dataGridViewAdmin);
        }

        private void showAttractionsButton_Click(object sender, EventArgs e)
        {
            tableTitleLabel.Text = "Points Of Interest";
            tableTitleLabel.Visible = true;
            dataGridViewAdmin.Visible = true;
            CreateAttractionColumns(dataGridViewAdmin);
            SetAttractionDataGrid(dataGridViewAdmin);
        }

        private void addRoute_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.ADD_ROUTE;

            inputLabel1.Text = "Enter route name:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            inputLabel2.Text = "Enter route description:";
            inputLabel2.Visible = true;
            inputBox2.Visible = true;

            inputLabel3.Text = "Enter start location:";
            inputLabel3.Visible = true;
            inputBox3.Visible = true;

            inputLabel4.Text = "Enter end location:";
            inputLabel4.Visible = true;
            inputBox4.Visible = true;

            HideDeleteAndAddButtons();
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void deleteRoute_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.DELETE_ROUTE;

            inputLabel1.Text = "Enter route id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            HideDeleteAndAddButtons();
            deleteButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.ADD_REVIEW;

            inputLabel1.Text = "Enter user id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            inputLabel2.Text = "Enter poi id:";
            inputLabel2.Visible = true;
            inputBox2.Visible = true;

            inputLabel3.Text = "Enter description:";
            inputLabel3.Visible = true;
            inputBox3.Visible = true;

            inputLabel4.Text = "Enter rating:";
            inputLabel4.Visible = true;
            inputBox4.Visible = true;

            HideDeleteAndAddButtons();
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void deleteReview_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.DELETE_REVIEW;

            inputLabel1.Text = "Enter review id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            HideDeleteAndAddButtons();
            deleteButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void addLocation_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.ADD_LOCATION;

            inputLabel1.Text = "Enter location name:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            inputLabel2.Text = "Enter location description:";
            inputLabel2.Visible = true;
            inputBox2.Visible = true;

            HideDeleteAndAddButtons();
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void deleteLocation_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.DELETE_LOCATION;

            inputLabel1.Text = "Enter location id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            HideDeleteAndAddButtons();
            deleteButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void addAttraction_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.ADD_ATTRACTION;

            inputLabel1.Text = "Enter location id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            inputLabel2.Text = "Enter poi name:";
            inputLabel2.Visible = true;
            inputBox2.Visible = true;

            inputLabel3.Text = "Enter description:";
            inputLabel3.Visible = true;
            inputBox3.Visible = true;

            inputLabel4.Text = "Enter route:";
            inputLabel4.Visible = true;
            inputBox4.Visible = true;

            HideDeleteAndAddButtons();
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void deleteAttraction_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.DELETE_ATTRACTION;

            inputLabel1.Text = "Enter poi id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            HideDeleteAndAddButtons();
            deleteButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void addEstablishment_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.ADD_ESTABLISHMENT;

            inputLabel1.Text = "Enter location id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            inputLabel2.Text = "Enter name:";
            inputLabel2.Visible = true;
            inputBox2.Visible = true;

            inputLabel3.Text = "Enter category:";
            inputLabel3.Visible = true;
            inputBox3.Visible = true;

            inputLabel4.Text = "Enter description:";
            inputLabel4.Visible = true;
            inputBox4.Visible = true;

            inputLabel5.Text = "Enter rating:";
            inputLabel5.Visible = true;
            inputBox5.Visible = true;

            HideDeleteAndAddButtons();
            addButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void deleteEstablishment_Click(object sender, EventArgs e)
        {
            buttonPressed = ButtonPressed.DELETE_ESTABLISHMENT;

            inputLabel1.Text = "Enter establishment id:";
            inputLabel1.Visible = true;
            inputBox1.Visible = true;

            HideDeleteAndAddButtons();
            deleteButton.Visible = true;
            cancelButton.Visible = true;
        }

        private void CancelButtonHideControls()
        {
            inputLabel1.Visible = false;
            inputLabel2.Visible = false;
            inputLabel3.Visible = false;
            inputLabel4.Visible = false;
            inputLabel5.Visible = false;

            inputBox1.Visible = false;
            inputBox2.Visible = false;
            inputBox3.Visible = false;
            inputBox4.Visible = false;
            inputBox5.Visible = false;

            inputLabel1.Text = string.Empty;
            inputLabel2.Text = string.Empty;
            inputLabel3.Text = string.Empty;
            inputLabel4.Text = string.Empty;
            inputLabel5.Text = string.Empty;

            inputBox1.Text = string.Empty;
            inputBox2.Text = string.Empty;
            inputBox3.Text = string.Empty;
            inputBox4.Text = string.Empty;
            inputBox5.Text = string.Empty;

            workWithCurrentInfoLabel.Visible = true;
            routesLabel.Visible = true;
            reviewsLabel.Visible = true;
            locationsLabel.Visible = true;
            attractionsLabel.Visible = true;
            establishmentsLabel.Visible = true;

            showCurrentInfo.Visible = true;
            currentInfoLabel.Visible = true;

            addRoute.Visible = true;
            deleteRoute.Visible = true;

            addReview.Visible = true;
            deleteReview.Visible = true;

            addLocation.Visible = true;
            deleteLocation.Visible = true;

            addAttraction.Visible = true;
            deleteAttraction.Visible = true;

            addEstablishment.Visible = true;
            deleteEstablishment.Visible = true;

            dataGridViewAdmin.Visible = false;
            hideButton.Visible = false;
            showRoutesButton.Visible = false;
            showLocationsButton.Visible = false;
            showEstablishmentsButton.Visible = false;
            showReviewsButton.Visible = false;
            showAttractionsButton.Visible = false;
            tableTitleLabel.Visible = false;
            deleteButton.Visible = false;
            addButton.Visible = false;
            cancelButton.Visible = false;
            buttonPressed = null;
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            CancelButtonHideControls();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch(buttonPressed)
            {
                case ButtonPressed.ADD_ROUTE:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO Routes (name, description, start_location, end_location) VALUES (@Name, @Description, @StartLocation, @EndLocation);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Name", inputBox1.Text);
                            command.Parameters.AddWithValue("@Description", inputBox2.Text);
                            command.Parameters.AddWithValue("@StartLocation", Convert.ToInt32(inputBox3.Text));
                            command.Parameters.AddWithValue("@EndLocation", Convert.ToInt32(inputBox4.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New route successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    
                    break;
                case ButtonPressed.ADD_REVIEW:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO Reviews (user_id, poi_id, description, rating) VALUES (@UserId, @PoiId, @Description, @Rating);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@UserId", Convert.ToInt32(inputBox1.Text));
                            command.Parameters.AddWithValue("@PoiId", Convert.ToInt32(inputBox2.Text));
                            command.Parameters.AddWithValue("@Description", inputBox3.Text);
                            command.Parameters.AddWithValue("@Rating", Convert.ToInt32(inputBox4.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New review successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                case ButtonPressed.ADD_LOCATION:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO Locations (name, description) VALUES (@Name, @Description);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Name", inputBox1.Text);
                            command.Parameters.AddWithValue("@Description", inputBox2.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New location successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }

                    break;
                case ButtonPressed.ADD_ATTRACTION:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO PointOfInterest (location_id, name, description, route) VALUES (@LocationId, @Name, @Description, @Route);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@LocationId", Convert.ToInt32(inputBox1.Text));
                            command.Parameters.AddWithValue("@Name", inputBox2.Text);
                            command.Parameters.AddWithValue("@Description", inputBox3.Text);
                            command.Parameters.AddWithValue("@Route", inputBox4.Text);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New attraction successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }

                    break;
                case ButtonPressed.ADD_ESTABLISHMENT:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertQuery = "INSERT INTO Establishments (location_id, name, category, description, rating) VALUES (@LocationId, @Name, @Category, @Description, @Rating);";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@LocationId", Convert.ToInt32(inputBox1.Text));
                            command.Parameters.AddWithValue("@Name", inputBox2.Text);
                            command.Parameters.AddWithValue("@Category", inputBox3.Text);
                            command.Parameters.AddWithValue("@Description", inputBox4.Text);
                            command.Parameters.AddWithValue("@Rating", Convert.ToInt32(inputBox5.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("New establishment successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }

                    break;
                default:
                    MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            inputBox1.Text = string.Empty;
            inputBox2.Text = string.Empty;
            inputBox3.Text = string.Empty;
            inputBox4.Text = string.Empty;
            inputBox5.Text = string.Empty;

            CancelButtonHideControls();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (buttonPressed)
            {
                case ButtonPressed.DELETE_ROUTE:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletionQuery = "DELETE FROM Routes WHERE id = @RouteId";

                        using (SqlCommand command = new SqlCommand(deletionQuery, connection))
                        {
                            command.Parameters.AddWithValue("@RouteId", Convert.ToInt32(inputBox1.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Route successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                case ButtonPressed.DELETE_REVIEW:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletionQuery = "DELETE FROM Reviews WHERE id = @ReviewId";

                        using (SqlCommand command = new SqlCommand(deletionQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ReviewId", Convert.ToInt32(inputBox1.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Review successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                case ButtonPressed.DELETE_LOCATION:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletionQuery = "DELETE FROM Locations WHERE id = @LocationId";

                        using (SqlCommand command = new SqlCommand(deletionQuery, connection))
                        {
                            command.Parameters.AddWithValue("@LocationId", Convert.ToInt32(inputBox1.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Location successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                case ButtonPressed.DELETE_ATTRACTION:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletionQuery = "DELETE FROM PointOfInterest WHERE id = @PoiId";

                        using (SqlCommand command = new SqlCommand(deletionQuery, connection))
                        {
                            command.Parameters.AddWithValue("@PoiId", Convert.ToInt32(inputBox1.Text));

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Attraction successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    break;
                case ButtonPressed.DELETE_ESTABLISHMENT:
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletionQuery = "DELETE FROM Establishments WHERE id = @EstablishmentId";

                        using (SqlCommand command = new SqlCommand(deletionQuery, connection))
                        {
                            command.Parameters.AddWithValue("@EstablishmentId", Convert.ToInt32(inputBox1.Text));
                            
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Establishment successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    
                    break;
                default:
                    MessageBox.Show("An unexpected error occurred. Try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            inputBox1.Text = string.Empty;
            inputBox2.Text = string.Empty;
            inputBox3.Text = string.Empty;
            inputBox4.Text = string.Empty;
            inputBox5.Text = string.Empty;

            CancelButtonHideControls();
        }
    }
}
