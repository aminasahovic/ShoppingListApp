# ShoppingListApp

This app enables the creation of shopping lists for items.. Each shopper can create a list to which they can add items. Additionally, shoppers can view and remove items from their lists. There's a limit in place: an item can only be added once to a single list, and a single item cannot be added to more than three different shopping lists.
 
## Technologies Used
- Angular
- .NET
- SqlServer

## Installation and Usage
- Clone the repository.

### Frontend
- Install dependencies: `npm install`.
- Start the application using `npm start` or `ng serve`.

### Backend
- **Note on Connection String:**
  - Update the connection string in the appsettings.json file to match your environment within the DbContext (OnConfiguring method).
 
- **Database Setup and Migration:**
  - Execute: `update-database` in the Package Manager Console.

- **Swagger API Data Generation:**
  - You can generate data for shoppers and items through the Swagger API. The API is named Data.

## Additional Notes
If you have any questions or encounter issues while starting up, feel free to contact me via email asahovic01@gmail.com.

Feel free to create and manage your shopping lists! 
