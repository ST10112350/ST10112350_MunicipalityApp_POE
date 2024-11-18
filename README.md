# ST10112350_MunicipalityApp_POE


## Prerequisites
- Visual Studio 2022
- .NET Framework 4.8

## Cloning the Project from GitHub
1. **Open Visual Studio 2022**.
2. **Clone Repository**:
   - Go to `File > Clone Repository`.
   - In the `Repository URL` field, paste the URL of your GitHub repository: `https://github.com/ST10112350/ST10112350_MunicipalityApp_POE`.
   - Choose a local path where you want to clone the repository.
   - Click `Clone`.

## Installing Required Packages
To use JSON functionality in the project, you need to install the `System.Text.Json` package.

### Steps to Install System.Text.Json Package
1. **Open the NuGet Package Manager**:
   - Go to `Tools > NuGet Package Manager > Manage NuGet Packages for Solution`.
2. **Browse and Install**:
   - In the `Browse` tab, search for `System.Text.Json`.
   - Select the package from the list and choose the project in which you want to install it.
   - Click `Install` and follow the prompts to complete the installation.

## Compiling the Project
   - After cloning, open the project by going to `File > Open > Project/Solution`.
   **Build the Project**:
   - Go to `Build > Build Solution` or press `Ctrl+Shift+B`.
   - Ensure there are no build errors.

## Project Structure and Storage
- **Forms**:
  -  MenuForm.cs`: Project starts on this form, and is used to navigate between Reporting Issues, Local Events and Announcements and Service Request Status.
  - `ReportIssuesForm.cs`: The main form for reporting issues.
  - `EventsAnnouncementsForm.cs`: Form for view and searching event information. And viewing Announcements.
  -  ServiceRequestStatusForm.cs`: Form to view the status of service requests

- **Classes**:
  - `IssueClass.cs`: Defines the structure of an issue.
  - `IssueManager.cs`: Manages the collection of issues.
  - `FormController.cs`: Manages form navigation and controls.
  - `EventClass.cs` and `AnnouncementClass.cs`: Manage events and announcements.


## Navigation using the Menu Strip
The application features a menu strip on top of each page for easy navigation.

### Menu Strip Items
- **Home**:
- **Menu**:
- **News**:
- **About us**:

##How data is stored
- **Issues**:
Issues are stored in a List<IssueClass> within the IssueManager.

- **Events**:
Events: Stored in a Dictionary<string, EventClass> in the EventManager.

- **Announcements**:
Stored in a Dictionary<string, AnnouncementClass> in the AnnouncementManager

- **Service Requests**:
Stored and managed using a custom binary search tree implemented in the BinarySearchTree<T> class, with priority requests managed using a MaxHeap.

-------------------------------------------------------------------------------------------------------------------

How to: 
Submitting an Issue
Open the Application: Launch the MunicipalityApp.

Navigate to Report Issues Form

Fill in the Details:

Name: Enter your name.

Email: Enter your email address.

Phone: Enter your phone number.

Date: Select the date from the date picker.

Location: Enter the location of the issue.

Category: Select the issue category from the dropdown.

Description: Enter a detailed description of the issue.

Attach File (Optional): Click the Attach button to browse and attach a file.

Submit: Click the Submit button. A success message will confirm the issue has been reported.

Viewing Issues
Open the Application: Launch the MunicipalityApp.

Navigate to Issues List on the left on the ReportIssueForm

View Details:

Click on any issue listed in the issues_listbox to see its details in a pop-up.

Deleting an Issue
Click on the issue you want to delete in the issues_listbox.

Delete Issue: Check the Delete radio button to confirm deletion.
-------------------------------------------------------------------------------------------------------------------

Viewing Events and Announcements
Open the Application: Launch the MunicipalityApp.

Navigate to Events and Announcements Form

Select an event from the event_box to see its details.

Use the search and filter functionalities to find specific events.

View Announcement Details:

Announcements show up in the Announcements_listbox
-------------------------------------------------------------------------------------------------------------------
Managing Service Requests with Priority
Open the Application: Launch the MunicipalityApp.

Navigate to Service Requests Status Form

View Service Requests: A list of all service requests will be displayed. The highest priority requests can be managed using the priority queue implemented in the MaxHeap class.

-------------------------------------------------------------------------------------------------------------------
