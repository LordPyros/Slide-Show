using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Slide_Show
{
    public partial class SlideShowForm : Form
    {
        // Keeps track of whether the slide show is paused or not, false = paused.
        bool playing = true;
        // Becomes false if there are no images in target folder
        bool imagesExist = true;
        // Keeps track of which image is currently being displayed (matches the index of the image List)
        int counter = 0;
        // Contains the file names of all images in the target folder
        List<string> images = new List<string>();

        public SlideShowForm(string imageSize, string imagePath, int imageSpeed)
        {
            InitializeComponent();

            if (Directory.Exists(imagePath))
            {
                // Get filenames of all image files in target folder
                images = Directory.EnumerateFiles(imagePath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(i => i.EndsWith(".gif", StringComparison.OrdinalIgnoreCase)
                || i.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                || i.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                || i.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                .ToList();
            }

            // Check target location contains images
            if (images.Count == 0)
            {
                imagesExist = false;
                // Set image to NoImage.jpg
                pictureBox1.Image = Properties.Resources.NoImages;
            }
            else
                // Display first image from list in PictureBox
                pictureBox1.Image = Image.FromFile(images[counter]);

            // Set the interval for image changes
            timer1.Interval = imageSpeed;

            // Set the size mode for images
            SetImageSize(imageSize);
        }

        private void SlideShowForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Close Slideshow if ESC pressed
                case Keys.Escape:
                    Close();
                    break;
                // Pause Slideshow if SPACE pressed
                case Keys.Space:
                    playing = !playing;
                    break;
                // Change to previous image if Left arrow pressed
                case Keys.Left:
                    ChangeToPreviousImage();
                    break;
                // Change to next image if Right arrow pressed
                case Keys.Right:
                    ChangeToNextImage();
                    break;
                // Moves the slideshow along to a desired point
                case Keys.D0:
                    AdjustCounter(0);
                    break;
                case Keys.D1:
                    AdjustCounter(1);
                    break;
                case Keys.D2:
                    AdjustCounter(2);
                    break;
                case Keys.D3:
                    AdjustCounter(3);
                    break;
                case Keys.D4:
                    AdjustCounter(4);
                    break;
                case Keys.D5:
                    AdjustCounter(5);
                    break;
                case Keys.D6:
                    AdjustCounter(6);
                    break;
                case Keys.D7:
                    AdjustCounter(7);
                    break;
                case Keys.D8:
                    AdjustCounter(8);
                    break;
                case Keys.D9:
                    AdjustCounter(9);
                    break;
            }
        }

        private void ChangeToNextImage()
        {
            if (imagesExist)
            {
                // Increase the image counter by 1
                counter++;

                // If at the last image, reset the counter back to the start
                if (counter == images.Count)
                    counter = 0;

                // Display the next image in the list
                pictureBox1.Image = Image.FromFile(images[counter]);

                // Restart the timer (This prevents the image from changing too quickly if the last image was changed using the arrow keys)
                ResetTimer();
            }
        }
        private void ChangeToPreviousImage()
        {
            if (imagesExist)
            {
                // Descrease the image counter by 1
                counter--;

                // If at the first image, set the counter to the last image
                if (counter == -1)
                    counter = images.Count - 1;

                // Display the previous image in the list
                pictureBox1.Image = Image.FromFile(images[counter]);

                // Restart the timer (This prevents the image from changing too quickly if the last image was changed using the arrow keys)
                ResetTimer();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // If the Slideshow is not paused, change to the next image
            if (playing)
                ChangeToNextImage();
        }

        private void SetImageSize(string imageSize)
        {
            // Check for desired image size
            switch (imageSize)
            {
                case "Stretched":
                    // Set images to be displayed in stretched format
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Actual Size":
                    // Set images to be displayed at their actual size 
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    // Set images to be displayed in Fit to screen format
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
        private void ResetTimer()
        {
            // Restart Timer with full time remaining
            if (playing)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void AdjustCounter(int input)
        {
            // This allows the user to skip through the image collection
            // Eg. pressing "9" would display an image 90% through the collection
            // pressing "2" would display an image 20% through the collection
            // pressing "0" returns the slideshow to the beginning
            
            //check there is 1 or more images or do nothing
            if (imagesExist)
            {
                // set the counter 
                counter = (images.Count * input) / 10;
                // display the image
                pictureBox1.Image = Image.FromFile(images[counter]);
                // restart the timer
                ResetTimer();
            }
        }
    }
}
