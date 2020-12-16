namespace OL_PRAKTIKA
{
    public class Student
    {
        private int id;
        private string Name, Surname;

        public int getId()
        {
            return id;
        }

        public void setId(int _id)
        {
            id = _id;
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
    }
}
