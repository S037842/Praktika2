using System;
using System.Data.SQLite;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace OL_PRAKTIKA
{
    public class SQL
    {
        //http://zetcode.com/csharp/sqlite/
        //https://www.codeguru.com/csharp/.net/net_data/using-sqlite-in-a-c-application.html

        private static SQLiteConnection SQLITE_CONNECTION;

        public SQL()
        {
            SQLITE_CONNECTION = createConnection();

            createTable();

            if (!userExists("student", "student"))
                insertUser("student", "student", 1, "student", "student", 0);

            if (!userExists("lecturer", "lecturer"))
                insertUser("lecturer", "lecturer", 2, "lecturer", "lecturer", 0);

            if (!userExists("admin", "admin"))
                insertUser("admin", "admin", 3, "admin", "admin", 0);
        }

        static SQLiteConnection createConnection()
        {
            SQLITE_CONNECTION = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");

            try
            {
                SQLITE_CONNECTION.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return SQLITE_CONNECTION;
        }

        private static void createTable()
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Mark (Subject INT, Student INT, Mark INT, Date DATE, FOREIGN KEY (Student) REFERENCES User (rowid), FOREIGN KEY (Subject) REFERENCES Subject (rowid))";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Role (Name VARCHAR(16))";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS sGroup (Name VARCHAR(32))";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Subject (Name VARCHAR(32), Lecturer INT)";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS User (Username VARCHAR(32), Password VARCHAR(32), Role INT, Name VARCHAR(32), Surname VARCHAR(32), sGroup INT, FOREIGN KEY (Role) REFERENCES Role (rowid), FOREIGN KEY (sGroup) REFERENCES sGroup (rowid))";
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        static void insertUser(string Username, string Password, int Role, string Name, string Surname, int sGroup)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("INSERT INTO User (Username, Password, Role, Name, Surname, sGroup) " +
                    "VALUES('{0}', '{1}', '{2}','{3}','{4}','{5}');", Username, Password, Role, Name, Surname, sGroup);

                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public bool userExists(string Username, string Password)
        {
            bool result = false;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = string.Format("SELECT * FROM User WHERE Username='{0}' AND Password='{1}'", Username, Password);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                        result = sqlite_datareader.HasRows;
                }
            }
            return result;
        }

        public int getUserRole(string Username, string Password)
        {
            int result = 0;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = string.Format("SELECT * FROM User WHERE Username='{0}' AND Password='{1}'", Username, Password);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                        result = sqlite_datareader.GetInt32(3);
                }
            }
            return result;
        }

        static void insertSubject(string Name, int Lecturer)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("INSERT INTO Subject (Name, Lecturer) VALUES('{0}', '{1}');", Name, Lecturer);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        static void insertStudentGroup(string Name)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("INSERT INTO sGroup Name = {0};", Name);
                sqlite_cmd.ExecuteNonQuery();
            }
        }
    }
}
