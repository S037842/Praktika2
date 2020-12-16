namespace OL_PRAKTIKA
{
    public class Student
    {
        private int id, Group;
        private string Name, Surname;

        public int getId()
        {
            return id;
        }

        public void setId(int _id)
        {
            id = _id;
        }

        public int getGroup()
        {
            return Group;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(string _name)
        {
            Name = _name;
        }

        public string getSurname()
        {
            return Surname;
        }

        public void setSurname(string _surname)
        {
            Surname = _surname;
        }

        public void setGroup(int _group)
        {
            Group = _group;
        }
    }
}
