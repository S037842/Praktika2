namespace OL_PRAKTIKA
{
    public class Subject
    {
        private int id, Lecturer, Group;
        private string Name;

        public int getId()
        {
            return id;
        }

        public int getLecturer()
        {
            return Lecturer;
        }

        public int getGroup()
        {
            return Group;
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

        public void setGroup(int _group)
        {
            Group = _group;
        }

        public void setName(string _name)
        {
            Name = _name;
        }
    }
}
