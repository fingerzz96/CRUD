using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace CRUD
{
    public class Database
    {
        private string databaseFileName;
        private string connectionString;

        public Database(string databaseFileName)
        {
            this.databaseFileName = databaseFileName;
            connectionString = $"Data Source={databaseFileName};Version=3;";
        }

        private void ExecuteQuery(string sql, SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public bool IsDatabaseCreated()
        {
            if (File.Exists(databaseFileName))
            {
                return true;
            }

            return false;
        }

        public void CreateDatabase()
        {
            if (!File.Exists(databaseFileName))
            {
                SQLiteConnection.CreateFile(databaseFileName);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
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
                }
            }
        }

        public void InsertProduct(string name, int categorieId, int price, string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"INSERT INTO {Product.TableName}" +
                    $"({Product.NameString}, " +
                    $"{Product.CategoriesIdString}, " +
                    $"{Product.PriceString}, " +
                    $"{Product.DescriptionString}) " +
                    $"VALUES (@{Product.NameString}, @{Product.CategoriesIdString}, @{Product.PriceString}, @{Product.DescriptionString})";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
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

        public void UpdateProduct(long id, string name, int categorieId, int price, string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"UPDATE {Product.TableName} SET " +
                    $"{Product.NameString} = @{Product.NameString}, " +
                    $"{Product.CategoriesIdString} = @{Product.CategoriesIdString}, " +
                    $"{Product.PriceString} = @{Product.PriceString}, " +
                    $"{Product.DescriptionString} = @{Product.DescriptionString} " +
                    $"WHERE {Product.IdString} = @{Product.IdString}";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
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

        public void DeleteProduct(long id, string name, int categorieId, int price, string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"DELETE FROM {Product.TableName} WHERE {Product.IdString} = @{Product.IdString}";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
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

        public List<Product> ReturnAllAdminProducts()
        {
            List<Product> products = new List<Product>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Product.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = Convert.ToInt32(reader[Product.IdString]);
                            string name = Convert.ToString((string) reader[Product.NameString]);
                            int categorieId = Convert.ToInt32(reader[Product.CategoriesIdString]);
                            double price = Convert.ToDouble(reader[Product.PriceString]);
                            string description = Convert.ToString(reader[Product.DescriptionString]);

                            Product product = new Product(id, name, categorieId, price, description);
                            products.Add(product);
                        }
                    }
                }

                connection.Close();
            }

            return products;
        }


        public List<Orders> ReturnAllUserOrder(int userId)
        {
            List<Orders> orders = new List<Orders>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText = $"SELECT * FROM {Orders.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long id = (long) reader[Orders.IdString];
                            long stateId = (long) reader[Orders.StateIdString];
                            long customerId = (long) reader[Orders.CustomerIdString];
                            long price = (long) reader[Orders.PriceString];

                            Orders order = new Orders((int) id, (int) stateId, (int) customerId, (int) price);
                            if (order.CustomerId == customerId)
                            {
                                orders.Add(order);
                            }
                        }
                    }
                }

                connection.Close();
            }

            return orders;
        }

        //End of class
    }
}