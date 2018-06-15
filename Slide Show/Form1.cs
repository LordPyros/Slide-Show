using System;
using System.IO;
using System.Windows.Forms;

namespace Slide_Show
{
    public partial class Form1 : Form
    {
        // Holds the path of the target image folder
        string folderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        public Form1()
        {
            InitializeComponent();
            // Fill ComboBox
            PopulateComboBox();
            // Load the default settings
            InitialSettings();
            // If saved settings exist, use those instead
            LoadSettings();
        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            // Create new FolderBrowserDialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                // Set Description
                Description = "Select Pictures Folder",
                // Set folder to start in
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };
            // If a folder is selected
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // get the path
                folderLocation = folderBrowserDialog.SelectedPath;
                // Update the text of the Path label to the new location
                PathLb.Text = folderLocation;
            }
        }

        private void StartSlideShowBtn_Click(object sender, EventArgs e)
        {
            // save current settings to a file
            SaveSettings();
            // open the slideshow form and send user preferences
            SlideShowForm ssf = new SlideShowForm(ImageSizeCb.Text, folderLocation, (trackBar1.Value * 1000));
            ssf.ShowDialog();
        }

        private void PopulateComboBox()
        {
            // Fill the ComboBox with image size options
            ImageSizeCb.Items.Add("Stretched");
            ImageSizeCb.Items.Add("Fit Screen");
            ImageSizeCb.Items.Add("Actual Size");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Update the text of the track bar label when the trackBar slider is moved
            trackBarValueLb.Text = trackBar1.Value.ToString() + " Seconds";
        }

        private void LoadSettings()
        {
            // If file exists
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Slide Show\\Settings.txt"))
            {
                // read file to string
                string textFromFile = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Slide Show\\Settings.txt");
                // split string
                string[] valuesForControls = textFromFile.Split(',');
                // Check the string split into 3 parts (1 for each setting)
                if (valuesForControls.Length == 3)
                {
                    // Update text in ComboBox
                    ImageSizeCb.Text = valuesForControls[0];

                    // Update text for the image path label
                    PathLb.Text = valuesForControls[1];
                    // Set the folder location
                    folderLocation = valuesForControls[1];

                    // check value from file is a valid number
                    try
                    {
                        int num = Int32.Parse(valuesForControls[2]);
                        if (num > 0 && num < 61)
                        {
                            // Update the TrackBar
                            trackBar1.Value = num;
                            // Update the Trackbar label text
                            trackBarValueLb.Text = valuesForControls[2] + " Seconds";
                        }
                    }
                    catch
                    {
                        // no code required, default will be loaded
                    }
                }
            }
        }

        private void SaveSettings()
        {
            // Create folder if it doesn't exist
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Slide Show");
            // Save/overwrite file
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Slide Show\\Settings.txt",
                ImageSizeCb.Text + "," + folderLocation + "," + trackBar1.Value.ToString());
        }

        private void RestoreDefaultsBtn_Click(object sender, EventArgs e)
        {
            // Set folder location back to My Picures
            folderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // Set controls and labels back to default values
            InitialSettings();
            // Save
            SaveSettings();
        }

        private void InitialSettings()
        {
            // Set the text of the Path label to default (folderLocation is always set to default before this method gets called)
            PathLb.Text = folderLocation;
            // Set text of the ComboBox to default
            ImageSizeCb.Text = "Fit Screen";
            // Set TrackBar value to default
            trackBar1.Value = 3;
            // Set the text of the TrackBar label to match the TrackBar's current value
            trackBarValueLb.Text = trackBar1.Value.ToString() + " Seconds";
        }
    }
}
