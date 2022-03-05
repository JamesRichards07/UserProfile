# User Profile

Created from an [article](https://codewithmukesh.com/blog/user-management-in-aspnet-core-mvc/)
discussing custom user management in ASP.NET Core MVC with Identity. The project includes several of the features we have come to expect when setting up profile pages on social media.  

## Features
1. Authentication for Register/Login/Logout.
2. Ability to login via username or email.
2. Profile picture option.
3. Authorization based on dynamic role assignment for users.
5. Default user loaded on start. 

## Default User Info
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