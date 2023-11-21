2023-10-31 1124
Went to Startip.cs commented out (/*options => options.SignIn.RequireConfirmedAccount = true*/)
Created a new git repo and connected to GitHub.
For debugging added 2 breakpoints in HomeController.cs

1128
Went to Bootstrap choose the theme (Flatly)

1130
Downloaded the bootstrap.css file
Went to the wwwroots folder>dist>css>Changed the name of the default boostrap.css file
Added the downloaded Bootstrap.css for my theme.Changed the content from site.css file from the provided assignment 2 folder
In the views folder>_layout.cshtml>changed the file name to bootstrap.css
Changed the nav (navbar-dark bg-primary)
Removed text-dark from line 23 and 25
Added dropdown menu in _layout.cshtml.

Error: I ran into an error it is not working.
Solution: Didn't completed the code that is why it was not running
	<li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                Content Management
                            </a>
                            <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                                <a class="dropdown-item" href="#">Action</a>
                                <a class="dropdown-item" href="#">Another Action</a>
                                <div class="dropdown-divider"></div>
                                <a class="dropdown-item" href="#">Something else here</a>
                            </div>
                        </li>

1138
Added 3 new projects namely:
	MehaksBooks.DataAccess
	MehaksBooks.Models
	MehaksBooks.Utility

Install 2 nuget packages: Microsoft.EntityFrameworkCore.Relational version 5.0.1 for data project only.
	Core.SqlServer version 5.0.1

1145
Delete Migration folder from data project.
Install Identity.EntityFerameworkCore
Modified the namespace in ApplicationDbContext.cs
Delete default Class1.cs files from all folders.

1150
Movel Models folder to model project and delete the original folder.
Modify the namespace in Views>Shared>ErrorModels
Add project reference to actual project of DataAccess and Models project
Rename the models folder as ViewModels and even change the namespace in ErrorViewModels.cs file.
Built the project and it run 

1158
Now modified the Startup.cs.

1200
Coming to the Utility project create a new class named SD.cs
Modified class statement: public static class SD
Added project reference of utility project to main project.
And models and utility projects to data project.

1215
Added new area to Areas folder named Customers.
Changed the route in Startup.cs file.
Move controller to area controller folder and delete the views and models.
Added namespace in Areas>Customer>Views>Home file
Ohh damn we run ikto an error.
Error: Invalid syntax unable to file Index.cshtml
Solution: I have named the folder as Customers but the route goes to customer area so change the folder name to Customer.

1230
Moved the _ViewStart and _ViewStart.cshtml into Customer folder.
Ran the application and it worked.
Now created a new area named Admin.
Updated the Github repos.

1448
Starting with Part 2 of the Assignmnet.
Checked the appsettings.json with the slides.
Then added the migrations through console screen with the command add-migration AddDefaultIdentityMigration
**The most important part for this running command is to change the default project for this to MehaksBooks.DataAccess in console screen.**

2023-11-02 1054
Came back to work!!
Updated database and checked sql server.

1106
Added new class to .Models project named Category.cs.
Then add migration through console .DataAccess project with command: add-migration AddCategoryToDb
Named: 20231102151912_AddCategoryToDb.cs 
Now modify the new migration.
Also added namespace and content to ApplicaionDbContext.cs
        public DbSet<Category> Categories { get; set; }

1121
Try to readd the migration but there is a dulplication error to resolve it I delete and recreated the migration.
Commint it to Github.

1124
Now let's move to part 2.
Created new folder in .DataAccess project named Respository then further a subfolder name IRespository.
Then added a new interface name IRepository.cs and modify it to add accordingly.

1225
Created files in subfolder namely ICategoryRepository.cs that is an interface and a new file in folder CategoryRepository.cs and modify data.

1304
Created ISP_Call interface and SP_Call.cs class and made alterations.
Updated SP_Call.cs.

2023-11-04 1540
Added UnitOfWork class and interface
modeiffied it and linked it through StartUp.cs

1606
Added a new controller named CategoryController.cs

1619
Added a new index page for category added the content provided in CategoryIndex.txt.
Modified the _Layout.cshtml to show in the notification.

2023-11-06 1645
Moving forward added new editing and creating concept to the file by editing to work on it.

1720
Now added content to category.js and commit the code.

2023-11-15 1637
(Section 1)
As I begin with part 1 the first step was to create new model class names CoverType.cs and made changes into it as we have to Category.cs
After doing that I added migration name in DataAccess Project with the name AddCoverTypeToDb.
The index we got for migration was : 20231115205934

1641
Added new repository for CoverType and added the content similar for category and made changes according to the file.
Then made changes in UnitOfWork class and IUnitOfWork interface to add CoverType into them.
Then I ran into error since I have to make changes in ApplicationDbContent.
Now update the database and save the changes.

1735
Added ICoverTypeRepository and CoverTypeRepository to link the methods in it.
Update database and run the application to see it's functionality.

2023-11-21 0835
Added a new class in .Models Project named Product.
Change the code according to the provided code and move ahead.
Added reference to this file in ApplicationDbContext.cs.
Tried to add migration for products but ran into an error.

0915
Error was that I ran the command in wrong project then I changed the project name to DataAccess and ran the command again.
Then I got the migration that wworks with index: 202311211140317 
name is addProductToDb
Then I tried to update the database but crashed into an error again.

0945
After checking the code I realised i have to make some changes and migration and update database with it.
And finally it worked.
Then added IProductReposiory and ProductRepository and modify update method in it.
Then added product to IUnitOfWork and UnitOfWork.
Push to github.

1024
(Section 2)
Added ProductController to Area/Admin
then change it to the according code.
Created ProductVM class in ViewModel folder To hold Product object and select list for Category and CoverType.
For this class we have to download a new packagenamed Microsoft.AspNetCore.Mvc.ViewFeatures.
Added the code to this class but commented the Upsert method as instructed.
Then added API Calls in the file.

1100 
Added Index View in Product Folder.
Copied the code from Category Index page and made suggested changes to add the data according to products.
Added product.js and modify it similar to other js files.
Tried to run the application but it gets an exception and in the instructions it is said we should continue even if we have an exception.

1115
(Section 3)
Created a new view named Upsert.cshtml and add the provided code.
made changes in script part of the code and run the code. It still shows the exception but it's okay.
Going to ProductController uncomment the upsert method and add a new post method as well into it.
