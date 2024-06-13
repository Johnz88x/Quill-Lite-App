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
Successfully updated the application to display the products

2200
Added 5 contents to the Database inorder to display the contents 
Included images to the products

2210
Made some changes to the HomePage to change the background image.
The background image was changed successfully and completed successfully
