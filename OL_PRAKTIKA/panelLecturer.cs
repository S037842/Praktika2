using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OL_PRAKTIKA
{
    public partial class panelLecturer : Form
    {
        SQL _SQL = new SQL();

        List<Group> groupList;
        List<Student> studentList;
        List<Subject> subjectList;

        int currentLecturerId = 0;

        public panelLecturer(int _currentLecturerId)
        {
            InitializeComponent();

            currentLecturerId = _currentLecturerId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _SQL.updateMark(subjectList[cSubject.SelectedIndex].getId(), studentList[cStudent.SelectedIndex].getId(), (int)numericUpDown1.Value);
        }

        private void panelLecturer_Load(object sender, EventArgs e)
        {
            cGroup.Items.Clear();

            groupList = _SQL.readStudentGroup();

            for (int i = 0; i < groupList.Count; i++)
                cGroup.Items.Add(groupList[i].getName());

            //subjectList = _SQL.readSubject();

            //for (int i = 0; i < subjectList.Count; i++)
            //    cSubject.Items.Add(subjectList[i].getName());
        }

        private void cGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            cStudent.Items.Clear();

            studentList = _SQL.readStudentByGroup(groupList[cGroup.SelectedIndex].getId());

            for (int i = 0; i < studentList.Count; i++)
                cStudent.Items.Add(studentList[i].getName() + " " + studentList[i].getSurname());


            cSubject.Items.Clear();

            subjectList = _SQL.readSubjectByGroupAndLecturer(groupList[cGroup.SelectedIndex].getId(), currentLecturerId);

            for (int i = 0; i < subjectList.Count; i++)
                cSubject.Items.Add(subjectList[i].getName());
        }

        private void cStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //studentList = _SQL.readStudentByGroup(studentList[cGroup.SelectedIndex].getId());

            //for (int i = 0; i < studentList.Count; i++)
            //    cStudent.Items.Add(studentList[i].getName() + " " + studentList[i].getSurname());
        }
    }
}
