namespace OL_PRAKTIKA
{
    public class Subject
    {
        private int id, Lecturer;
        private string Name;

        public int getId()
        {
            return id;
        }

        public int getLecturer()
        {
            return Lecturer;
        }

        public string getName()
        {
            return Name;
        }

        public void setId(int _id)
        {
            id = _id;
        }

        public void setLecturer(int _lecturer)
        {
            Lecturer = _lecturer;
        }

        public void setName(string _name)
        {
            Name = _name;
        }
    }
}
