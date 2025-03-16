# Book Store and Stock Management Application

This project is a **Book Store and Stock Management Application** developed using **C#** and **SQLite**. It allows users to browse, purchase, and manage books in a bookstore. It includes features for managing books, user registration, and tracking purchases.

## Features

- **User Registration & Authentication**: Users can register and authenticate their accounts securely.
- **Book Management**: Admins can add, update, and delete books from the store.
- **Book Search & Filtering**: Users can search for books by title, author, genre, and other criteria.
- **Shopping Cart**: Users can add books to the cart, select quantities, and proceed with purchases.
- **Stock Management**: Admins can track book stock levels and update inventory.
- **Purchase History**: Users can view their past purchases and details.

## Database

The application uses an **SQLite** database to manage data. The following tables are included:

- **Books**: Stores information about books such as title, author, publisher, price, etc.
- **Users**: Stores user information, including login credentials and personal details.
- **UserBooks**: A many-to-many relationship table to track which books a user has purchased and in what quantity.

## Installation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/ahmetkale35/bookstore-and-stock-management-application.git
   ` ``` `
- 2.Open the project in Visual Studio (or your preferred C# development environment).
- 3.Restore the NuGet packages and dependencies.
- 4.Build the project.
- 5.Run the application and start managing the bookstore.

## Technologies Used
- C#: For developing the application logic and user interface.
- SQLite: For managing the database and storing book and user data.
- Visual Studio: For development and debugging.

## License
- This project is licensed under the MIT License - see the LICENSE file for details.

## ScreenShoots

![login2](https://github.com/user-attachments/assets/74c7d30e-7025-466f-af87-8e92932a6f3b)

![main1](https://github.com/user-attachments/assets/9b6a4357-2b4f-4e52-9817-5c6f11b350ce)

![main2](https://github.com/user-attachments/assets/a98ce129-383b-4c58-8e91-9a0b29d1589a)

![sepet](https://github.com/user-attachments/assets/978fd5b1-2c18-4892-865a-91e830864bf5)

![admin1](https://github.com/user-attachments/assets/a18f2688-b2e1-4d66-81ca-adfbd6d84660)

![admin2](https://github.com/user-attachments/assets/91350b18-a6d1-4da5-b228-8517cb9a51da)




