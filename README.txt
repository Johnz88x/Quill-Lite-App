Creating an application for our Product Quill Lite Shawls


2024-06-10 


1420
Step-by-Step Process to Create "Quill Lite" Application

Define Requirements
- **Objective**: Develop a lightweight application to manage quill Lite application, incorporating CRUD (Create, Read, Update, Delete) operations.
1545
- **Components**: Utilize existing MVC structure with additional controllers, models, views, and potentially services.
- **User Interface**: Create intuitive views for listing quill shawls, adding new quill shawls, editing existing ones, and deleting them.

1706

Update Models
- **Quill Model (`Quill.cs`)**:
- Defined properties such as `Brand`, `Material`, `Rating`, `SizeFit`, `Color`, `Price` etc., based on the attributes that describe a quill.

1750
- Implemented data annotations for validation (e.g., `[Required]`, `[StringLength]`) where necessary.

2024-06-11 

Create Controllers
- **QuillsController (`QuillsController.cs`)**:
- Implement CRUD actions:
- **Index Action**: Display a list of all quills.
- **Create Action**: Render a form to add a new quill.

0914

- **Edit Action**: Render a form to edit an existing quill.
- **Delete Action**: Handle POST request to delete a quill.

1157

- Utilize Dependency Injection (DI) to inject necessary services (e.g., database context, repository).

#### 4. Update Views
- **Quill Views (`Quill` folder)**:
  - **Index.cshtml**: Display a table listing all quills with options to edit or delete each quill.
1633

- **Create.cshtml**: Form to create a new quill.
- **Edit.cshtml**: Form to edit an existing quill.
- **Delete.cshtml**: Confirmation page to delete a quill.

1824

- Ensure views are responsive and provide user-friendly feedback (e.g., validation messages).


1906
 Configure Routes
- **Route Configuration (`Startup.cs`)**:
  - Ensure appropriate routing is set up to map URLs to `QuillsController` actions (e.g., `/quills`, `/quills/create`).

2150
Implement Data Persistence
- **Database Context and Migration**:
- Use Entity Framework Core to define a database context (`ApplicationDbContext`) if not already defined.
- Implement migration files to create necessary database tables (e.g., `InitialCreate.cs`).

2241

Test and Debug
- **Unit Testing**:
- Write unit tests to verify controller actions.
- Test views for proper rendering and functionality (e.g., form submissions, error handling).

2024-06-12 Group Theta Web Application Made using : VS , .NET 7


1443
Enhance User Experience
- **Validation and Error Handling**:
- Implement client-side and server-side validation to ensure data integrity.
- Handle exceptions gracefully with error views (`ErrorViewModel.cs`) and appropriate error messages.

Dand Monitor
- **Deployment**:
- Deploy the application to a hosting environment (e.g., Azure App Service, AWS EC2).
- Configure deployment settings including environment variables in `appsettings.json`.

1458
Document and Maintain
- **Documentation**:
- Document the project structure, dependencies, and deployment procedures.
- Update documentation as changes and enhancements are made.

24-06-12

1900

Added the new model Quill.cs
-The fields create, delete, details, edit was automatically created.

1910
-Did the migration

1920
-The initial migration was completed successfully
-The database was created
-20240613061051_InitialCreate.cs 

1925
-Then tried added values to the database
-the data was added successfully.
1935
-change background layout
-Edited the _layout.cshtml for adding background image
-In the stylesheet in the body added the URL for background.
-The URL is added so that we can use images from online.

2000
-Add an image in the list for display the product

2010
-Then edited the file quill.cs in order to add the imagepath to get the file.
-Also added the ImageFile used for handling the uploaded image

2020
-Also editted the create and edit files

2025
-In create.cshtml added the form-group to upload the image

2030
-Also edited the QuillsController.cs to handle the upload in the controller
-_hostEnvironment was added to handle the image upload

2045
-Display the image in views
-edited Views/Quills/Index.cshtml file 
-The body part added the content for displaying the product image

2100
-Updated the database
-Add Migration Quill_Lite_AppContext.cs
-Update database

2110
-Image migration completed successfully
-20240613061942_AddImage

2120
-Added images tried the application

2130
-Successfully updated the application to display the products

2200
-Added 5 contents to the Database inorder to display the contents 
-Included images to the products

2210
-Made some changes to the HomePage to change the background image.
-The background image was changed successfully and completed successfully

2250
Edited the Create.cshtml file for the attributes and included all the atributed 

2024-06-14
1430
- I made some changes in index file to make a new url

2024-06-17
2000
Need to change the 'Edit', 'Details', 'Delete' actions in the App page to look like buttons
Checked the _layout.cshtml file and needed no changes

2020
Checked the index.cshtml in QUills folder
Found the code where to edit

2025
Editted the code to add buttons format for all the above.

2030
The buttons was added in <form> method in the format
Ran the code and found some errors when added with @for each format
Removed the foreach and added only the <form> method

2045
Made the necessary changes and build the file without any errors

2050
Success...the application was initiated

2024-06-19
2100
Need to add the ABout Us Page

2105
There is already a page mentioned privacy 
Need to change the name of the page to About Us

2120
Opened the _Layout.cshtml file 
Used Ctrl-F to find the privacy
Changed the name to 'About Us' instead of 'Privacy'

2130
Saved the file 
Build wthout any errors...successfully

2140
Need to add contents to the page About Us

2200
Need to add one more field to the App

2205
Opened the Quill.cs file
Added the Design field

2210
Then did the Add-Migration
The migration was specified error because there was more than one database 
So need to specify the database
Using Context specified the database

2215
The migration completed successfully
20240620044827_DesignCreate.cs 

2220
Then need to uodate the database
When updating also needed to specify the database
Specified the database using the Context and updated
The database was updated successfully.

2225
Need to add the specific fields in the all the other files
First editted the Index.cshtml file to add Design field
then editted the Index.cshtml file to add the deisgn field
then editted the Edit.cshtml file to add the deisgn field
then editted the create.cshtml file to add the deisgn field
then editted the Delete.cshtml file to add the deisgn field
then editted the Details.cshtml file to add the deisgn field

2240
Then saved the files
Build the program to check for any errors.
The application compledted successfully without any errors.


