using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace CRUD
{
    public class Database
    {
        private string databaseFileName;
        private string connectionString;

        public Database()
        {
            databaseFileName = "database.sqlite";
            connectionString = $"Data Source={databaseFileName};Version=3;";
        }

        private void ExecuteQuery(string sql, SQLiteConnection connection)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
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
                                  $"{Product.CategoriesString}  INTEGER REFERENCES Categories(categoriesID), " +
                                  $"{Product.PriceString} REAL, " +
                                  $"{Product.DiscountString} REAL, " +
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

        public void InsertProduct(string name, string categories, int price, int discount, string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"INSERT INTO {Product.TableName}" +
                    $"({Product.NameString}, " +
                    $"{Product.CategoriesString}, " +
                    $"{Product.PriceString}, " +
                    $"{Product.DescriptionString})";

                using (SQLiteCommand command = new SQLiteCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue($"@{Product.NameString}", name);
                    command.Parameters.AddWithValue($"@{Product.CategoriesString}", categories);
                    command.Parameters.AddWithValue($"@{Product.PriceString}", price);
                    command.Parameters.AddWithValue($"@{Product.DiscountString}", discount);
                    command.Parameters.AddWithValue($"@{Product.DescriptionString}", description);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void UpdateProduct(long id, string name, string categories, int price, int discount, string description)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"UPDATE {Product.TableName} SET" +
                    $"{Product.NameString} = {name}, " +
                    $"{Product.CategoriesString} = {categories}, " +
                    $"{Product.PriceString} = {price}, " +
                    $"{Product.DiscountString} = {discount}, " +
                    $"{Product.DescriptionString} = {description}" +
                    $"WHERE {Product.IdString} = {id}";

                using (SQLiteCommand command = new SQLiteCommand(commandText,connection))
                {
                    command.Parameters.AddWithValue($"@{Product.NameString}", name);
                    command.Parameters.AddWithValue($"@{Product.CategoriesString}", categories);
                    command.Parameters.AddWithValue($"@{Product.PriceString}", price);
                    command.Parameters.AddWithValue($"@{Product.DiscountString}", discount);
                    command.Parameters.AddWithValue($"@{Product.DescriptionString}", description);
                    command.Parameters.AddWithValue($@"{Product.IdString}", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduct(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string commandText =
                    $"DELETE FROM {Product.TableName} WHERE {Product.IdString} = {id}";

                using (SQLiteCommand command = new SQLiteCommand(commandText,connection))
                {
                    command.Parameters.AddWithValue($@"{Product.IdString}", id);
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
                            long id = (long) reader[Product.IdString];
                            string name = (string) reader[Product.NameString];
                            string categories = (string) reader[Product.CategoriesString];
                            int price = (int) reader[Product.PriceString];
                            int discount = (int) reader[Product.DiscountString];
                            string description = (string) reader[Product.DescriptionString];

                            Product product = new Product(id, name, categories, price, discount, description);
                            products.Add(product);
                        }
                    }
                }

                connection.Close();
            }

            return products;
        }

        //End of class
    }
}