using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI.Forms.Tours
{
    public partial class frmPackageList : Form
    {
        // Define SQL connection
        SqlConnection connection = new SqlConnection("ttmsDBConnectionString");

        // Array to store fetched images
        Image[] images;

        // Index to keep track of the current image being displayed
        int currentIndex = 0;

        public frmPackageList()
        {
            InitializeComponent();
        }

        public string SelectedPackage { get; private set; }

        private void btnBookPackage_Click(object sender, EventArgs e)
        {
            // Set SelectedPackage to the selected item in the combo box
            SelectedPackage = cbChoosePackage.SelectedItem?.ToString();
            this.Close(); // Close the TourPackageList form
        }

        private void FetchImagesForPackage(string selectedPackage)
        {
            try
            {
                // Open the database connection
                connection.Open();
                // SQL query to fetch images for the selected package
                string query = "SELECT TourItinerary.ImageData " +

                               "FROM TourPackage " +
                               "INNER JOIN TourDestination ON TourPackage.PackageID = TourDestination.PackageID " +
                               "INNER JOIN TourItinerary ON TourDestination.DestinationID = TourItinerary.DestinationID " +
                               "WHERE TourPackage.PackageName = @SelectedPackage";

                // Create SQL command with parameters
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedPackage", selectedPackage);

                // Execute SQL command
                SqlDataReader reader = command.ExecuteReader();

                // Read images into a list
                var imageList = new System.Collections.Generic.List<Image>();
                while (reader.Read())
                {
                    // Convert byte array to Image and add to the list
                    byte[] imageData = (byte[])reader["ImageData"];
                    Image image = Image.FromStream(new MemoryStream(imageData));
                    imageList.Add(image);
                }

                // Convert list to array
                images = imageList.ToArray();

                // Display the first image if available
                if (images.Length > 0)
                {
                    pbPackageImg.Image = images[0];
                    currentIndex = 0;
                }
                else
                {
                    MessageBox.Show("No images found for the selected package.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }


        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            // Get the selected package from the combo box
            string selectedPackage = cbChoosePackage.SelectedItem.ToString();
            // Fetch images for the selected package
            FetchImagesForPackage(selectedPackage);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (images != null && images.Length > 0)
            {
                // Update currentIndex to navigate to previous image
                currentIndex = (currentIndex - 1 + images.Length) % images.Length;
                // Display the image at currentIndex
                pbPackageImg.Image = images[currentIndex];
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (images != null && images.Length > 0)
            {
                // Update currentIndex to navigate to next image
                currentIndex = (currentIndex + 1) % images.Length;
                // Display the image at currentIndex
                pbPackageImg.Image = images[currentIndex];
            }
        }
    }
}
