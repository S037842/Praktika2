using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Mark (id INTEGER PRIMARY KEY AUTOINCREMENT, Subject INT, Student INT, Mark INT, " +
                    "FOREIGN KEY (Student) REFERENCES User (id), FOREIGN KEY (Subject) REFERENCES Subject (id))";

                sqlite_cmd.ExecuteNonQuery();

                //sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Role (id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(16))";
                //sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS sGroup (id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(32))";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS Subject (id INTEGER PRIMARY KEY AUTOINCREMENT, Name VARCHAR(32), Lecturer INT, sGroup INT, FOREIGN KEY (sGroup) REFERENCES sGroup (id))";
                sqlite_cmd.ExecuteNonQuery();

                sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS User (id INTEGER PRIMARY KEY AUTOINCREMENT, Username VARCHAR(32), Password VARCHAR(32), Role INT, Name VARCHAR(32), " +
                    "Surname VARCHAR(32), sGroup INT, FOREIGN KEY (sGroup) REFERENCES sGroup (id))";

                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void insertUser(string Username, string Password, int Role, string Name, string Surname, int sGroup)
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

        public void insertSubject(string Name, int Lecturer)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("INSERT INTO Subject (Name, Lecturer) VALUES('{0}', '{1}');", Name, Lecturer);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void insertStudentGroup(string Name)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("INSERT INTO sGroup (Name) VALUES('{0}');", Name);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void deleteStudentGroup(int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("DELETE FROM sGroup WHERE rowid = '{0}';", id);
                MessageBox.Show(sqlite_cmd.CommandText);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public bool bStudentGroupExists(string Name)
        {
            bool result = false;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM sGroup WHERE Name = '{0}'", Name);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.HasRows;
                    }
                }
            }
            return result;
        }

        public List<Group> readStudentGroup()
        {
            List<Group> result = new List<Group>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = "SELECT id, Name FROM sGroup";

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        Group G = new Group();

                        G.setId(sqlite_datareader.GetInt32(0));
                        G.setName(sqlite_datareader.GetString(1));

                        result.Add(G);
                    }
                }
            }
            return result;
        }

        public bool bStudentExists(string Name, string Surname)
        {
            bool result = false;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM User WHERE Name = '{0}' AND Surname = '{1}' AND Role = '1'", Name, Surname);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.HasRows;
                    }
                }
            }
            return result;
        }

        public List<Student> readStudent()
        {
            List<Student> result = new List<Student>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = "SELECT * FROM User";

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        if (sqlite_datareader.GetInt32(3) == 1)
                        {
                            Student S = new Student();

                            //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                            S.setId(sqlite_datareader.GetInt32(0));
                            S.setName(sqlite_datareader.GetString(1));
                            S.setSurname(sqlite_datareader.GetString(2));

                            result.Add(S);
                        }
                    }
                }
            }
            return result;
        }

        public void deleteUser(int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("DELETE FROM User WHERE id = '{0}';", id);
                sqlite_cmd.ExecuteNonQuery();
            }
        }




        public bool bSubjectExists(string Name)
        {
            bool result = false;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Subject WHERE Name = '{0}'", Name);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.HasRows;
                    }
                }
            }
            return result;
        }

        public List<Subject> readSubject()
        {
            List<Subject> result = new List<Subject>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = "SELECT * FROM Subject";

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        Subject S = new Subject();

                        //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                        S.setId(sqlite_datareader.GetInt32(0));
                        S.setName(sqlite_datareader.GetString(1));
                        S.setLecturer(sqlite_datareader.GetInt32(2));

                        result.Add(S);
                    }
                }
            }
            return result;
        }

        public void deleteSubject(int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("DELETE FROM Subject WHERE id = '{0}'", id);
                sqlite_cmd.ExecuteNonQuery();
            }
        }



        public bool bLecturerExists(string Name, string Surname)
        {
            bool result = false;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM User WHERE Name = '{0}' AND Surname = '{1}' AND Role = '2'", Name, Surname);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.HasRows;
                    }
                }
            }
            return result;
        }

        public List<Lecturer> readLecturer()
        {
            List<Lecturer> result = new List<Lecturer>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = "SELECT * FROM User";

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        if (sqlite_datareader.GetInt32(3) == 2)
                        {
                            Lecturer L = new Lecturer();

                            //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                            L.setId(sqlite_datareader.GetInt32(0));
                            L.setName(sqlite_datareader.GetString(1));
                            L.setSurname(sqlite_datareader.GetString(2));

                            result.Add(L);
                        }
                    }
                }
            }
            return result;
        }

        public void updateSubjectGroup(int sGroup, int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("UPDATE Subject SET sGroup = '{0}' WHERE id = '{1}'", sGroup, id);
                MessageBox.Show(sqlite_cmd.CommandText);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void updateSubjectLecturer(int Lecturer, int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("UPDATE Subject SET Lecturer = '{0}' WHERE id='{1}'", Lecturer, id);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void updateStudentGroup(int Group, int id)
        {
            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("UPDATE User SET sGroup = '{0}' WHERE id='{1}'", Group, id);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public List<Student> readStudentByGroup(int group)
        {
            List<Student> result = new List<Student>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM User WHERE sGroup = {0}", group);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        if (sqlite_datareader.GetInt32(3) == 1)
                        {
                            Student S = new Student();

                            //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                            S.setId(sqlite_datareader.GetInt32(0));
                            S.setName(sqlite_datareader.GetString(1));
                            S.setSurname(sqlite_datareader.GetString(2));


                            result.Add(S);
                        }
                    }
                }
            }
            return result;
        }

        public List<Subject> readSubjectByGroupAndLecturer(int Group, int Lecturer)
        {
            List<Subject> result = new List<Subject>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Subject WHERE sGroup = '{0}' AND Lecturer = '{1}'", Group, Lecturer);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        Subject S = new Subject();

                        //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                        S.setId(sqlite_datareader.GetInt32(0));
                        S.setName(sqlite_datareader.GetString(1));
                        S.setLecturer(sqlite_datareader.GetInt32(2));
                        S.setGroup(sqlite_datareader.GetInt32(3));


                        result.Add(S);
                    }
                }
            }
            return result;
        }

        public List<Subject> readSubjectByGroup(int Group)
        {
            List<Subject> result = new List<Subject>();

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Subject WHERE sGroup = '{0}'", Group);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        Subject S = new Subject();

                        //MessageBox.Show(sqlite_datareader.GetInt32(0).ToString());

                        S.setId(sqlite_datareader.GetInt32(0));
                        S.setName(sqlite_datareader.GetString(1));
                        S.setLecturer(sqlite_datareader.GetInt32(2));
                        S.setGroup(sqlite_datareader.GetInt32(3));


                        result.Add(S);
                    }
                }
            }
            return result;
        }

        public int getUserIdByCredentials(string Username, string Password)
        {
            int result = 0;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM User WHERE Username = '{0}' AND Password = '{1}'", Username, Password);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.GetInt32(0);
                    }
                }
            }
            return result;
        }

        public int getMarkExists(int Subject, int Student)
        {
            int result = -1;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Mark WHERE Subject = '{0}' AND Student = '{1}'", Subject, Student);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.GetInt32(0);
                    }
                }
            }
            return result;
        }

        public void updateMark(int Subject, int Student, int Mark)
        {
            int rowid = getMarkExists(Subject, Student);

            if (rowid != -1)
            {
                using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
                {
                    sqlite_cmd.CommandText = String.Format("UPDATE Mark SET Subject = '{0}', Student = '{1}', Mark = '{2}' WHERE id='{3}'", 
                        Subject, Student, Mark, rowid);

                    //MessageBox.Show(sqlite_cmd.CommandText);

                    sqlite_cmd.ExecuteNonQuery();
                }
            }
            else
            {
                using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
                {
                    sqlite_cmd.CommandText = String.Format("INSERT INTO Mark (Subject, Student, Mark) VALUES ('{0}', '{1}', '{2}') ", Subject, Student, Mark);
                    sqlite_cmd.ExecuteNonQuery();
                }
            }
        }

        public int getGroupOfStudent(string Username, string Password)
        {
            int result = -1;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM User WHERE Username = '{0}' AND Password = '{1}'", Username, Password);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.GetInt32(6);
                    }
                }
            }
            return result;
        }

        public int getMark(int Student, int Subject)
        {
            int result = -1;

            using (SQLiteCommand sqlite_cmd = SQLITE_CONNECTION.CreateCommand())
            {
                sqlite_cmd.CommandText = String.Format("SELECT * FROM Mark WHERE Subject = '{0}' AND Student = '{1}'", Subject, Student);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                    {
                        result = sqlite_datareader.GetInt32(3);
                    }
                }
            }
            return result;
        }
    }
}
