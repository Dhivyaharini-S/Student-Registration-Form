using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace FormBrowse
{
    public partial class Form1 : Form
    {
        private Bitmap currentFrame;
        private FilterInfoCollection cameraDevices;
        private VideoCaptureDevice cameraSource;
        private Bitmap currentCameraFrame;

        public Form1()
        {
            InitializeComponent();

            cmbExperience.SelectedIndex = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image =
                    Image.FromFile(openFile.FileName);

                picPhoto.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image == null)
            {
                MessageBox.Show("Please upload your photo.");
                return;
            }

            // Name check
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            // Gender
            string gender = "";

            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            // Marital status
            string maritalStatus = "";

            if (rbMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else if (rbUnMarried.Checked)
            {
                maritalStatus = "Unmarried";
            }
            else
            {
                MessageBox.Show("Please select marital status.");
                return;
            }

            // Qualification
            string qualification = "";

            if (chkDiploma.Checked)
            {
                qualification = qualification + "Diploma ";
            }

            if (chkUG.Checked)
            {
                qualification = qualification + "UG ";
            }

            if (chkPG.Checked)
            {
                qualification = qualification + "PG ";
            }

            if (qualification == "")
            {
                MessageBox.Show("Please select qualification.");
                return;
            }

            // Experience
            if (cmbExperience.SelectedIndex == -1)
            {
                MessageBox.Show("Please select experience.");
                return;
            }

            string experience = cmbExperience.SelectedItem.ToString();

            // Project details check
            if (rtbProject.Text.Trim() == "")
            {
                MessageBox.Show("Please enter project details.");
                rtbProject.Focus();
                return;
            }

            // Display all details
            string details =
                "Name: " + txtName.Text + "\n" +
                "Date of Birth: " + dtpDOB.Value.ToString("dd MMMM yyyy") + "\n" +
                "Gender: " + gender + "\n" +
                "Marital Status: " + maritalStatus + "\n" +
                "Qualification: " + qualification + "\n" +
                "Experience: " + experience + "\n" +
                "About Project: " + rtbProject.Text;

            MessageBox.Show(
                details,
                "Submitted Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();

            dtpDOB.Value = DateTime.Today;

            rbMale.Checked = false;
            rbFemale.Checked = false;

            rbMarried.Checked = false;
            rbUnMarried.Checked = false;

            chkDiploma.Checked = false;
            chkUG.Checked = false;
            chkPG.Checked = false;

            cmbExperience.SelectedIndex = 0;

            rtbProject.Clear();

            if (picPhoto.Image != null)
            {
                picPhoto.Image.Dispose();
                picPhoto.Image = null;
            }

            txtName.Focus();

            MessageBox.Show(
                "Form cleared successfully.",
                "Reset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (picPhoto.Image == null)
            {
                MessageBox.Show("Please upload or capture a photo.");
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.Width = 1000;
            printPreviewDialog1.Height = 700;

            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Font titleFont =
                new Font("Arial", 20, FontStyle.Bold);

            Font headingFont =
                new Font("Arial", 13, FontStyle.Bold);

            Font normalFont =
                new Font("Arial", 11, FontStyle.Regular);

            Pen borderPen =
                new Pen(Color.Black, 2);

            int pageLeft = 70;
            int pageTop = 60;
            int pageWidth = 680;
            int pageHeight = 950;

            // Main page border
            graphics.DrawRectangle(
                borderPen,
                pageLeft,
                pageTop,
                pageWidth,
                pageHeight);

            // Title
            string title = "STUDENT REGISTRATION DETAILS";

            SizeF titleSize =
                graphics.MeasureString(title, titleFont);

            float titleX =
                pageLeft + (pageWidth - titleSize.Width) / 2;

            graphics.DrawString(
                title,
                titleFont,
                Brushes.Black,
                titleX,
                pageTop + 25);

            // Title line
            graphics.DrawLine(
                Pens.Black,
                pageLeft + 30,
                pageTop + 75,
                pageLeft + pageWidth - 30,
                pageTop + 75);

            // Photo
            if (picPhoto.Image != null)
            {
                graphics.DrawImage(
                    picPhoto.Image,
                    pageLeft + pageWidth - 180,
                    pageTop + 100,
                    120,
                    140);

                graphics.DrawRectangle(
                    Pens.Black,
                    pageLeft + pageWidth - 180,
                    pageTop + 100,
                    120,
                    140);
            }

            // Selected gender
            string gender = "";

            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            // Selected marital status
            string maritalStatus = "";

            if (rbMarried.Checked)
            {
                maritalStatus = "Married";
            }
            else if (rbUnMarried.Checked)
            {
                maritalStatus = "Unmarried";
            }

            // Selected qualifications
            string qualification = "";

            if (chkDiploma.Checked)
            {
                qualification += "Diploma, ";
            }

            if (chkUG.Checked)
            {
                qualification += "UG, ";
            }

            if (chkPG.Checked)
            {
                qualification += "PG, ";
            }

            qualification =
                qualification.TrimEnd(' ', ',');

            string experience = "";

            if (cmbExperience.SelectedIndex != -1)
            {
                experience =
                    cmbExperience.SelectedItem.ToString();
            }

            int labelX = pageLeft + 45;
            int valueX = pageLeft + 230;
            int currentY = pageTop + 115;
            int rowGap = 48;

            // Details heading
            graphics.DrawString(
                "PERSONAL DETAILS",
                headingFont,
                Brushes.Black,
                labelX,
                currentY);

            currentY += 55;

            DrawPrintRow(
                graphics,
                normalFont,
                "Name",
                txtName.Text,
                labelX,
                valueX,
                currentY);

            currentY += rowGap;

            DrawPrintRow(
                graphics,
                normalFont,
                "Date of Birth",
                dtpDOB.Value.ToString("dd MMMM yyyy"),
                labelX,
                valueX,
                currentY);

            currentY += rowGap;

            DrawPrintRow(
                graphics,
                normalFont,
                "Gender",
                gender,
                labelX,
                valueX,
                currentY);

            currentY += rowGap;

            DrawPrintRow(
                graphics,
                normalFont,
                "Marital Status",
                maritalStatus,
                labelX,
                valueX,
                currentY);

            currentY += rowGap;

            DrawPrintRow(
                graphics,
                normalFont,
                "Qualification",
                qualification,
                labelX,
                valueX,
                currentY);

            currentY += rowGap;

            DrawPrintRow(
                graphics,
                normalFont,
                "Experience",
                experience,
                labelX,
                valueX,
                currentY);

            currentY += 65;

            graphics.DrawString(
                "PROJECT DETAILS",
                headingFont,
                Brushes.Black,
                labelX,
                currentY);

            currentY += 45;

            RectangleF projectBox =
                new RectangleF(
                    labelX,
                    currentY,
                    pageWidth - 90,
                    180);

            graphics.DrawRectangle(
                Pens.Black,
                Rectangle.Round(projectBox));

            graphics.DrawString(
                rtbProject.Text,
                normalFont,
                Brushes.Black,
                projectBox);

            // Footer
            graphics.DrawString(
                "Generated from Student Registration Form",
                new Font("Arial", 9, FontStyle.Italic),
                Brushes.Gray,
                pageLeft + 200,
                pageTop + pageHeight - 35);

            titleFont.Dispose();
            headingFont.Dispose();
            normalFont.Dispose();
            borderPen.Dispose();

            e.HasMorePages = false;
        }
        private void DrawPrintRow(Graphics graphics,Font font,string label,string value,int labelX,int valueX,int y)
        {
            graphics.DrawString(  label,
                font,
                Brushes.Black,
                labelX,
                y);

            graphics.DrawString(
                ":",
                font,
                Brushes.Black,
                valueX - 20,
                y);

            graphics.DrawString(
                value,
                font,
                Brushes.Black,
                valueX,
                y);
        }

        private void btnPrint2_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Print error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStartCamera_Click_1(object sender, EventArgs e)
        {
            cameraDevices = new FilterInfoCollection(
        FilterCategory.VideoInputDevice);

            if (cameraDevices.Count == 0)
            {
                MessageBox.Show("No camera found.");
                return;
            }

            cameraSource = new VideoCaptureDevice(
                cameraDevices[0].MonikerString);

            cameraSource.NewFrame += CameraSource_NewFrame;

            cameraSource.Start();
        }

        private void CameraSource_NewFrame(
    object sender,
    NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

            if (currentFrame != null)
            {
                currentFrame.Dispose();
            }

            currentFrame = (Bitmap)frame.Clone();

            if (picCamera.InvokeRequired)
            {
                picCamera.BeginInvoke(new Action(() =>
                {
                    Image oldImage = picCamera.Image;

                    picCamera.Image = (Bitmap)frame.Clone();
                    picCamera.SizeMode = PictureBoxSizeMode.Zoom;

                    if (oldImage != null)
                    {
                        oldImage.Dispose();
                    }

                    frame.Dispose();
                }));
            }
            else
            {
                Image oldImage = picCamera.Image;

                picCamera.Image = (Bitmap)frame.Clone();
                picCamera.SizeMode = PictureBoxSizeMode.Zoom;

                if (oldImage != null)
                {
                    oldImage.Dispose();
                }

                frame.Dispose();
            }
        }

        private void btnCaptureCamera_Click(object sender, EventArgs e)
        {
            if (currentFrame == null)
            {
                MessageBox.Show("Start camera first.");
                return;
            }

            if (picPhoto1.Image != null)
            {
                picPhoto1.Image.Dispose();
            }

            picPhoto1.Image = (Bitmap)currentFrame.Clone();
            picPhoto1.SizeMode = PictureBoxSizeMode.Zoom;

            MessageBox.Show("Photo captured successfully.");
        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            if (cameraSource != null &&
        cameraSource.IsRunning)
            {
                cameraSource.SignalToStop();
                cameraSource.WaitForStop();
            }

            if (picCamera.Image != null)
            {
                picCamera.Image.Dispose();
                picCamera.Image = null;
            }

            MessageBox.Show("Camera stopped.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cameraSource != null &&
        cameraSource.IsRunning)
            {
                cameraSource.SignalToStop();
                cameraSource.WaitForStop();
            }
        }
    }
}