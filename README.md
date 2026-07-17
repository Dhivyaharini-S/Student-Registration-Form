# Student Registration Form with Photo Upload and Camera Capture

A C# Windows Forms application developed using the .NET Framework. This project provides a simple and user-friendly registration form where users can enter personal information, upload a photo from their computer, or capture a live photo using the system camera.

The application also includes form validation, reset functionality, print preview, and the ability to save registration details as a PDF.

## Project Features

- Upload a photo from the computer using the Browse button
- Open the laptop or external webcam
- Display live camera preview
- Capture a current photo using the camera
- Stop the camera safely
- Enter the user's name
- Select date of birth
- Select gender
- Select marital status
- Select multiple qualifications
- Choose experience level
- Enter project details
- Validate required form fields
- Submit and display entered details
- Reset all form fields
- Print registration details
- Preview the document before printing
- Save registration details as a PDF
- Include the uploaded or captured photo in the output

## Technologies Used

- C#
- Windows Forms
- .NET Framework
- Visual Studio
- AForge.Video
- AForge.Video.DirectShow
- System.Drawing
- System.Drawing.Printing

## Application Workflow

1. Open the Student Registration Form.
2. Upload a photo using the Browse button or start the camera.
3. Capture a live photo using the Capture button.
4. Enter the required personal details.
5. Select gender and marital status.
6. Select the required qualification.
7. Choose the experience level.
8. Enter information about the project.
9. Click the Submit button to validate and display the entered details.
10. Use the Reset button to clear the form.
11. Click the Print / Save PDF button to open the print preview.
12. Select Microsoft Print to PDF to save the registration details as a PDF.

## Form Fields

The registration form contains the following fields:

- Upload Photo
- Live Camera Capture
- Name
- Date of Birth
- Gender
- Marital Status
- Qualification
- Experience
- About the Project

## Buttons

### Browse

Allows the user to select and upload an image from the computer.

### Start Camera

Opens the available laptop or external webcam and displays the live camera preview.

### Capture Photo

Captures the current frame from the live camera and displays it as the user's photo.

### Stop Camera

Stops the currently running camera safely.

### Submit

Validates the entered information and displays the submitted registration details.

### Reset

Clears all the entered details and resets the form controls.

### Print / Save PDF

Opens the print preview and allows the user to print the registration details or save them as a PDF.

## Camera Support

This project uses the following NuGet packages for camera functionality:

- AForge.Video
- AForge.Video.DirectShow

The camera packages can be installed using the NuGet Package Manager in Visual Studio.

Search for:

AForge.Video.DirectShow

Install the package and rebuild the project before running the camera functionality.

## How to Run the Project

1. Clone or download this repository.
2. Open the solution file (`.sln`) using Visual Studio.
3. Make sure the project is opened as a Windows Forms App (.NET Framework) project.
4. Restore or install the required NuGet packages.
5. Build the solution.
6. Press `F5` or click the Start button to run the application.
7. Allow camera access if Windows requests camera permission.

## Camera Permission

If the camera does not open, check the Windows camera privacy settings.

Go to:

Settings → Privacy & Security → Camera

Enable camera access and allow desktop applications to access the camera.

Also make sure that applications such as Zoom, Microsoft Teams, Google Meet, or the Windows Camera application are not currently using the camera.

## PDF Export

The application uses Windows Forms printing functionality to generate a print preview.

To save the registration details as a PDF:

1. Complete the registration form.
2. Click Print / Save PDF.
3. Open the Print dialog.
4. Select Microsoft Print to PDF.
5. Choose the file location.
6. Enter a PDF file name.
7. Save the PDF.

## Project Output

The final application allows users to complete a registration form, upload or capture a photo, submit their personal details, reset the form, preview the registration information, and save the final output as a PDF.

## Future Enhancements

The project can be further improved by adding:

- Database integration using SQL Server
- User login and authentication
- Email and mobile number fields
- Automatic age calculation
- Save and retrieve registration records
- Search and update registered users
- Delete registration records
- Export data to Excel
- Improved modern user interface
- Dark and light themes

## Author

**S. Dhivyaharini**

C# Windows Forms Developer

