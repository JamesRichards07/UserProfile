# User Profile

Created from an [article](https://codewithmukesh.com/blog/user-management-in-aspnet-core-mvc/)
discussing custom user management in ASP.NET Core MVC with Identity. The project includes several of the features we have come to expect when setting up profile pages on social media.  

>Note: This project is only intended for a local environment as the primary purpose was to learn more about ASP.NET Core with Identity.

## Get Started
1. Clone this repo.
2. Open the BugTrackerv4.sln file.
3. Run the application  using IIS Express.

## Features
1. Authentication for Register/Login/Logout.
2. Ability to login via username or email.
2. Profile picture option.
3. Authorization based on dynamic role assignment for users.
5. Default admin info loaded on start. 

## Default Admin Info
*username:* test  
*email:* test@tester.com   
*password:* 123Pa$$word

## Authorization
*Developer* - Home/Profile  
*Manager* - Home/Profile  
*Supervisor* - Home/Profile and User Role Management

## Database
- MySQL

## Sources

- [Article by Mukesh Murugan](https://codewithmukesh.com/blog/user-management-in-aspnet-core-mvc/)