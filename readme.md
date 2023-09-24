# TheCashier Web API Project

This is an ASP.NET Web API project developed for the Oceantecsa task "TheCashier". The project provides a set of features to manage products and calculate the total price in a cashier system. The API documentation is available on the Swagger endpoint. The project utilizes a MySQL database for data storage.

## Features

### Calculate Total Price

- The API includes functionality to calculate the total price of selected products.
- You can provide a list of product IDs or other identifiers to calculate the cumulative price.
- This feature helps in determining the total cost of items in a transaction.

# Sample Input and Output

## Sample Input

```json
[
  {
    "productDTO": {
      "name": "بوتاسيوم",
      "price": 0.28
    },
    "qty": 5
  },
  {
    "productDTO": {
      "name": "zeet",
      "price": 10
    },
    "qty": 2
  },
  {
    "productDTO": {
      "name": "zeet",
      "price": 5
    },
    "qty": 6
  }
]
```

# Sample Output

```json
{
  "sum": 51.4,
  "discount": 5.300368,
  "deliveryAmount": 20,
  "tax": 9.9149448,
  "totalAmount": 76.0145768
}
```

### Add Product

- The API allows you to add new products to the cashier system.
- You can provide the necessary information such as product name, category, barcode, and other relevant details.
- This feature enables you to expand your product inventory easily.

### List Products

- The API provides a comprehensive listing of products available in the cashier system.
- You can apply filters based on category, name, and barcode to retrieve specific products.
- This feature helps you quickly search and retrieve the desired products.

### Update Product

- The API allows you to update the details of existing products.
- You can modify information such as product name, category, barcode, and other relevant details.
- This feature ensures that you can keep the product information up to date as needed.

### Delete Product

- The API provides the capability to delete products from the cashier system.
- You can remove unwanted or outdated products from the inventory.
- This feature helps you maintain an accurate and relevant product database.

## API Documentation

The API documentation is available on the Swagger endpoint. It provides detailed information on each endpoint, including request and response formats, authentication requirements, and example usage. Please refer to the Swagger documentation for a complete understanding of the available API endpoints.

## Database

The project utilizes a MySQL database for data storage. The database schema and configuration details can be found in the project's database scripts or migrations. Please ensure that you have the appropriate MySQL server set up and configured before running the project.

## Getting Started

To use this project, follow these steps:

1. Clone the repository to your local machine.
2. Set up the necessary dependencies and environment, including MySQL.
3. Configure the database connection string in the project's configuration files.
4. Run the project using your preferred development environment or the .NET CLI.
5. Access the API endpoints to interact with the features mentioned above.

## Contact

For any inquiries or further information, please contact me at [mohammadazhari535@gmail.com]

Thank you for using TheCashier Web API Project! We hope it serves your cashier system needs effectively.

```

```
