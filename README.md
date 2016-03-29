# PostgreSqlASPNetCorePOC
POC to make PostgreSql + NpgSql work with Entity Framework using Code First

**Steps for Windows:**

- Install PostgreSql for Windows using the right installer from the following page
Note: Install pgAdminIII when installing PostgreSql.

[http://www.enterprisedb.com/products-services-training/pgdownload#windows](http://www.enterprisedb.com/products-services-training/pgdownload#windows)

- Once PostgreSql and pgAdminIII are installed, open up pgAdminIII and make sure you can access the server and its default DB.

- Create a new LoginRole "pocuser" (or whatever you provider in your config file) and in its Role privileges tab, give access to everything.

- Clone the repo

- Restore Nuget Packages on both the projects and make sure everything builds

- Open Package Manager Console and navigate to the Entities project folder. This is important to run the dnx code first commands in the right folder.

- Run the following command

*dnx ef database update*

This should create a new database in PostgreSql and create the necessary tables.
- Run the application. This will also seed some sample data provider in Seeder.

- For the POC, hit the following link to get sample Products data.

[http://localhost:1465/api/products](http://localhost:1465/api/products)
[http://localhost:1465/api/products/3721d2ce-f654-4d44-886d-ee51d87f797b](http://localhost:1465/api/products/3721d2ce-f654-4d44-886d-ee51d87f797b)


Steps for Mac:

There are some additional steps to get the app working on Mac vs Windows.

- Install PostgreSql from here

[http://www.enterprisedb.com/products-services-training/pgdownload#windows](http://www.enterprisedb.com/products-services-training/pgdownload#windows)

- Download and install Postgres.app from here. This is the easiest way to get the PostgreSql Server up and running.

[http://postgresapp.com/](http://postgresapp.com/)

- Start the server by running Postgres.app application. OSX should ask you to add this app to its Applications list. Once started,
it will add an elephant icon in the top menu/tool bar section.

- Follow these instructions to install .NET Core on Mac

[http://docs.asp.net/en/latest/getting-started/installing-on-mac.html](http://docs.asp.net/en/latest/getting-started/installing-on-mac.html)

- To make sure the installations worked, run the following commands and check the result

*dnvm --version*

Result
My machine shows 1.0.0-rc1-15540

*dnx --version*

Result
Microsoft .NET Execution environment
 Version:      1.0.0-rc1-16231
 Type:         CoreClr
 Architecture: x64
 OS Name:      Darwin
 OS Version:   10.10
 Runtime Id:   osx.10.10-x64

- Once this installations are done, clone the git repository on mac

- Open terminal and navigate to the Entities project folder. This is important to run the dnx code first commands in the right folder.

- Run the following command to restore packages

*dnu restore*

- Once all the necessary pagackes are installed, run the EF migration command

*sudo dnx ef database update*

Note: Make sure run with sudo, otherwise you might see socket exceptions. Sometimes running as sudo also throws an error. I tried the same command couple times later and it worked. Things are still not 100% there yet).

This should create the DB and the tables.

- Once the DB is successfully created, switch to the Web project and run 

*dnu restore*

to restore packages from nuget.

- Once all the packages are downloaded, run the app using the command

*dnx web*

- Navigate to api test urls (make sure to use the right port that the app starts in)

[http://localhost:5000/api/products](http://localhost:5000/api/products)
[http://localhost:5000/api/products/3721d2ce-f654-4d44-886d-ee51d87f797b](http://localhost:5000/api/products/3721d2ce-f654-4d44-886d-ee51d87f797b)


