using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using CRUD.Logger;

namespace CRUD
{
    public class Database
    {
        private readonly string _connectionString;
        private readonly string _databaseFileName;
        private readonly ILogger _logger;

        public Database(string databaseFileName, ILogger logger)
        {
            _databaseFileName = databaseFileName;
            _connectionString = $"Data Source={databaseFileName};Version=3;";
            _logger = logger;
        }

        private void ExecuteQuery(string sql, SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public bool IsDatabaseCreated() { return File.Exists(_databaseFileName); }

        public void CreateDatabase()
        {
            if (!File.Exists(_databaseFileName))
            {
                SQLiteConnection.CreateFile(_databaseFileName);

                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    string commandText;

                    commandText = $"CREATE TABLE {Categories.TableName} " +
                                  $"({Categories.IdString} INTEGER PRIMARY KEY, " +
                                  $"{Categories.NameString} VARCHAR (256))";

                    ExecuteQuery(commandText, connection);

                    commandText = $"CREATE TABLE {Product.TableName} " +
                                  $"({Product.IdString} INTEGER PRIMARY KEY, " +
                                  $"{Product.NameString} VARCHAR(20) NOT NULL, " +
                                  $"{Product.CategoriesIdString}  INTEGER REFERENCES Categories(categoriesID), " +
                                  $"{Product.PriceString} REAL, " +
                                  $"{Product.DescriptionString} VARCHAR(500) NOT NULL)";

                    ExecuteQuery(commandText, connection);

                    commandText = $"CREATE TABLE {Customer.TableName} " +
                                  $"({Customer.IdString} INTEGER PRIMARY KEY, " +
                                  $"{Customer.NameString} VARCHAR(256) NOT NULL, " +
                                  $"{Customer.AddressString} VARCHAR(1024) NOT NULL)";

                    ExecuteQuery(commandText, connection);

                    commandText = $"CREATE TABLE {State.TableName} " +
                                  $"({State.IdString} INTEGER PRIMARY KEY, " +
                                  $"{State.NameString} VARCHAR (256))";

                    ExecuteQuery(commandText, connection);

                    commandText = $"CREATE TABLE {Orders.TableName} " +
                                  $"({Orders.IdString} INTEGER PRIMARY KEY, " +
                                  $"{Orders.CustomerIdString} INTEGER REFERENCES Customer(customerID), " +
                                  $"{Orders.PriceString} REAL, " +
                                  $"{Orders.StateIdString} INTEGER REFERENCES State(stateID))";

                    ExecuteQuery(commandText, connection);

                    commandText = $"CREATE TABLE {Items.TableName} " +
                                  $"({Items.IdString} INTEGER PRIMARY KEY, " +
                                  $"{Items.OrderIdString} INTEGER REFERENCES Orders(orderID), " +
                                  $"{Items.ProductIdString} INTEGER REFERENCES Product(productID), " +
                                  $"{Items.CountString} INTEGER, " +
                                  $"{Items.PriceString} REAL)";

                    ExecuteQuery(commandText, connection);

                    commandText =
                        $"INSERT INTO {Categories.TableName} ({Categories.IdString}, {Categories.NameString}) " +
                        "VALUES (1, 'drugstore'), (2, 'food'), (3, 'electronics')";

                    ExecuteQuery(commandText, connection);

                    commandText =
                        $"INSERT INTO {State.TableName} ({State.IdString}, {State.NameString}) " +
                        "VALUES (1, 'Created'), (2, 'Confirm'),(3, 'Sended'), (4, 'Terminated')";

                    ExecuteQuery(commandText, connection);
                }
            }
        }

        public void InsertProduct(string name, long categorieId, double price, string description)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"INSERT INTO {Product.TableName}" +
                    $"({Product.NameString}, " +
                    $"{Product.CategoriesIdString}, " +
                    $"{Product.PriceString}, " +
                    $"{Product.DescriptionString}) " +
                    $"VALUES (@{Product.NameString}, @{Product.CategoriesIdString}, @{Product.PriceString}, @{Product.DescriptionString})";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.NameString}", name);
                    command.Parameters.AddWithValue($"@{Product.CategoriesIdString}", categorieId);
                    command.Parameters.AddWithValue($"@{Product.PriceString}", price);
                    command.Parameters.AddWithValue($"@{Product.DescriptionString}", description);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void UpdateProduct(long id, string name, long categorieId, double price, string description)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"UPDATE {Product.TableName} SET " +
                    $"{Product.NameString} = @{Product.NameString}, " +
                    $"{Product.CategoriesIdString} = @{Product.CategoriesIdString}, " +
                    $"{Product.PriceString} = @{Product.PriceString}, " +
                    $"{Product.DescriptionString} = @{Product.DescriptionString} " +
                    $"WHERE {Product.IdString} = @{Product.IdString}";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.NameString}", name);
                    command.Parameters.AddWithValue($"@{Product.CategoriesIdString}", categorieId);
                    command.Parameters.AddWithValue($"@{Product.PriceString}", price);
                    command.Parameters.AddWithValue($"@{Product.DescriptionString}", description);
                    command.Parameters.AddWithValue($"@{Product.IdString}", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(long id, string name, long categorieId, double price, string description)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"DELETE FROM {Product.TableName} WHERE {Product.IdString} = @{Product.IdString}";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.IdString}", id);
                    command.Parameters.AddWithValue($"@{Product.NameString}", name);
                    command.Parameters.AddWithValue($"@{Product.CategoriesIdString}", categorieId);
                    command.Parameters.AddWithValue($"@{Product.PriceString}", price);
                    command.Parameters.AddWithValue($"@{Product.DescriptionString}", description);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateNewCustomer(string nameSurname, string address)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var commandText =
                    $"INSERT INTO {Customer.TableName}" +
                    $"({Customer.NameString}, " +
                    $"{Customer.AddressString}) " +
                    $"VALUES (@{Customer.NameString}, @{Customer.AddressString})";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Customer.NameString}", nameSurname);
                    command.Parameters.AddWithValue($"@{Customer.AddressString}", address);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void CreateOrder(long userId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"INSERT INTO {Orders.TableName} " +
                    $"({Orders.IdString}, " +
                    $"{Orders.CustomerIdString}, " +
                    $"{Orders.PriceString}, " +
                    $"{Orders.StateIdString}) " +
                    $"VALUES (@{Orders.IdString}, @{Orders.CustomerIdString}, @{Orders.PriceString}, @{Orders.StateIdString})";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"{Orders.CustomerIdString}", userId);
                    command.Parameters.AddWithValue($"{Orders.PriceString}", "0");
                    command.Parameters.AddWithValue($"{Orders.StateIdString}", "1");
                }

                var log = $"{DateTime.Now} Customer with {userId} created order";
            }
        }

        public void UpdateOrderTotalPrice(long id, double price)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"UPDATE {Orders.TableName} " +
                    $"SET {Orders.PriceString} = @{Orders.PriceString} " +
                    $"WHERE {Orders.IdString} = @{Orders.IdString}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.IdString}", id);
                    command.Parameters.AddWithValue($"@{Orders.PriceString}", price);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void CreateOrderItem(Items items, long orderId)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var commandText =
                    $"INSERT INTO {Items.TableName} " +
                    $"({Items.OrderIdString}, " +
                    $"{Items.ProductIdString}, " +
                    $"{Items.CountString}) " +
                    $"VALUES(@{Items.OrderIdString}, @{Items.ProductIdString}, @{Items.CountString})";

                using (var orderItemCommand = new SQLiteCommand(commandText, connection))
                {
                    orderItemCommand.Parameters.AddWithValue($"@{Items.OrderIdString}", orderId);
                    orderItemCommand.Parameters.AddWithValue($"@{Items.ProductIdString}", items.ProductId);
                    orderItemCommand.Parameters.AddWithValue($"@{Items.CountString}", items.Count);
                    orderItemCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void UpdateOrderStatus(long id, long state)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"UPDATE {Orders.TableName} SET {Orders.StateIdString} = @{Orders.StateIdString} WHERE {Orders.IdString} = @{Orders.IdString}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.IdString}", id);
                    command.Parameters.AddWithValue($"@{Orders.StateIdString}", state);
                    command.ExecuteNonQuery();
                }

                var log = $"{DateTime.Now} {state} order of {id} past succesfully";
                _logger.Log(log);
                connection.Close();
            }
        }

        public List<Product> ReturnAllProducts()
        {
            var products = new List<Product>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText = $"SELECT * FROM {Product.TableName}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Product.IdString]);
                            var name = Convert.ToString((string) reader[Product.NameString]);
                            var categorieId = Convert.ToInt32(reader[Product.CategoriesIdString]);
                            var price = Convert.ToDouble(reader[Product.PriceString]);
                            var description = Convert.ToString(reader[Product.DescriptionString]);

                            var product = new Product(id, name, categorieId, price, description);
                            products.Add(product);
                        }
                    }
                }

                connection.Close();
            }

            return products;
        }


        public List<Orders> ReturnAllUserOrders(long userId)
        {
            var orderses = new List<Orders>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText = $"SELECT * FROM {Orders.TableName}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Orders.IdString]);
                            long stateId = Convert.ToInt32(reader[Orders.StateIdString]);
                            long customerId = Convert.ToInt32(reader[Orders.CustomerIdString]);
                            long price = Convert.ToInt32(reader[Orders.PriceString]);

                            var order = new Orders(id, customerId, price, stateId);
                            if (order.CustomerId == userId) orderses.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orderses;
        }


        public List<Orders> ReturnaAllOrders()
        {
            var orderses = new List<Orders>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"SELECT * FROM {Orders.TableName}";

                using (var command = new SQLiteCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Orders.IdString]);
                            long stateId = Convert.ToInt32(reader[Orders.StateIdString]);
                            long customerId = Convert.ToInt32(reader[Orders.CustomerIdString]);
                            long price = Convert.ToInt32(reader[Orders.PriceString]);

                            var order = new Orders(id, customerId, price, stateId);
                            orderses.Add(order);
                        }
                    }
                }

                connection.Close();
            }

            return orderses;
        }

        public List<Items> ReturnAllItemsesOrder()
        {
            var orderItems = new List<Items>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText = $"SELECT * FROM {Items.TableName}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Items.IdString]);
                            long ordersId = Convert.ToInt32(reader[Items.OrderIdString]);
                            long productId = Convert.ToInt32(reader[Items.ProductIdString]);
                            long count = Convert.ToInt32(reader[Items.CountString]);
                            long price = Convert.ToInt32(reader[Items.PriceString]);

                            var items = new Items(id, ordersId, productId, count, price);
                            orderItems.Add(items);
                        }
                    }
                }

                connection.Close();
            }

            return orderItems;
        }


        public List<Customer> ReturnAllCustomers()
        {
            var customers = new List<Customer>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"SELECT * FROM {Customer.TableName}";
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Customer.IdString]);
                            var name = Convert.ToString(reader[Customer.NameString]);
                            var address = Convert.ToString(reader[Customer.AddressString]);

                            var customer = new Customer(id, name, address);
                            customers.Add(customer);
                        }
                    }
                }

                connection.Close();
            }

            return customers;
        }

        //End of class
    }
}