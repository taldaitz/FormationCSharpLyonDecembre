using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== SELECT en mode connecté ==");
            Program.ConnectedSelect();

            Console.WriteLine();

            Console.WriteLine("== UPDATE en mode connecté ==");
            Program.ConnectedUpdate();

            Console.WriteLine();

            Console.WriteLine("== SELECT en mode déconnecté ==");
            Program.DisconnectedSelect();

            Console.WriteLine();

            Console.WriteLine("== UPDATE en mode déconnecté ==");
            Program.DisconnectedUpdate();

            Console.ReadLine();
        }

        #region requête SELECT en mode connecté
        static void ConnectedSelect()
        {
            // Connexion à la base de données
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI";

            // Requête SQL
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connexion; // Connexion instanciée auparavant
            selectCommand.CommandText = "SELECT ContactName FROM Customers";

            SqlDataReader reader; // Contiendra les données

            try
            {
                connexion.Open(); // Ouverture de la connexion
                reader = selectCommand.ExecuteReader(); // Exécution de la requête SQL

                while (reader.Read())
                {
                    // Affichage des données
                    Console.WriteLine(reader["ContactName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Affiche des erreurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fermeture de la connexion à la base de données
                connexion.Close();
            }
        }
        #endregion

        #region requête UPDATE en mode connecté
        static void ConnectedUpdate()
        {
            // Connexion à la base de données
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI";

            // Requête SQL
            SqlCommand updateCommand = new SqlCommand("UPDATE Customers SET ContactName = 'Aymeric Lagier' WHERE CustomerID = 'ALFKI'");
            updateCommand.Connection = connexion;

            int lignesModifiees = 0; // Nombre de lignes modifiées par la requête 
            try
            {
                connexion.Open(); // Ouverture de la connexion
                lignesModifiees = updateCommand.ExecuteNonQuery(); // Exécution de la requête SQL

                Console.WriteLine("{0} ligne(s) modifiée(s)", lignesModifiees.ToString());
            }
            catch (Exception ex)
            {
                // Affiche des erreurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fermeture de la connexion à la base de données
                connexion.Close();
            }
        }
        #endregion

        #region requête SELECT en mode déconnecté
        static void DisconnectedSelect()
        {
            // Connexion à la base de données
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI";

            // Requête SQL
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.Connection = connexion; // Connexion instanciée auparavant
            selectCommand.CommandText = "SELECT * FROM Customers";

            SqlDataAdapter adapter = new SqlDataAdapter(selectCommand); // Permet de lire les données
            DataSet data = new DataSet(); // Contiendra les données

            try
            {
                connexion.Open(); // Ouverture de la connexion
                adapter.Fill(data, "Customers"); // Récupère les données
            }
            catch (Exception ex)
            {
                // Affiche des erreurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fermeture de la connexion à la base de données
                connexion.Close();
            }

            // Affichage dans la console
            foreach (DataRow row in data.Tables["Customers"].Rows)
            {
                Console.WriteLine(row["ContactName"]);
            }
        }
        #endregion

        #region requête UPDATE en mode déconnecté
        static void DisconnectedUpdate()
        {
            // Connexion à la base de données
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=SSPI";

            // Requête SQL (SELECT)
            SqlCommand selectCommand = new SqlCommand();
            selectCommand.CommandText = "SELECT City, Country FROM Customers WHERE Country = 'UK'";
            selectCommand.Connection = connexion;

            //Requête SQL (UPDATE)
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.CommandText = "UPDATE Customers SET City = @City WHERE Country = @Country";
            updateCommand.Connection = connexion;

            // Paramètres
            updateCommand.Parameters.Add("@City", SqlDbType.NVarChar, 100, "City");
            updateCommand.Parameters.Add("@Country", SqlDbType.NVarChar, 100, "Country");

            SqlDataAdapter adapter = new SqlDataAdapter(); // Permet de lire les données
            adapter.SelectCommand = selectCommand; // Définitiion la requête SELECT 
            adapter.UpdateCommand = updateCommand; // Définitiion la requête UPDATE

            DataSet data = new DataSet(); // Contiendra les données

            try
            {
                connexion.Open(); // Ouverture de la connexion
                adapter.Fill(data, "Customers"); // Récupère les données
            }
            catch (Exception ex)
            {
                // Affiche des erreurs
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fermeture de la connexion à la base de données
                connexion.Close();
            }

            // Modification du champ "City"
            foreach (DataRow row in data.Tables["Customers"].Rows)
            {
                row["City"] = "London";   
            }

            int lignesModifiees = 0; // Nombre de lignes modifiées
            lignesModifiees = adapter.Update(data.Tables["Customers"]); // Modification dans la base de données

            Console.WriteLine("{0} ligne(s) modifiée(s)", lignesModifiees);
        }
        #endregion
    }
}
