using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OL_PRAKTIKA
{
    public partial class panelStudent : Form
    {
        SQL _SQL = new SQL();

        List<Subject> subjectList;

        int currentStudentGroup = -1;
        int currentStudentId = -1;

        public panelStudent(int _currentStudentGroup, int _currentStudentId)
        {
            InitializeComponent();

            currentStudentGroup = _currentStudentGroup;
            currentStudentId = _currentStudentId;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Pažymys: ";

            label2.Text += _SQL.getMark(currentStudentId, subjectList[cSubject.SelectedIndex].getId());
        }

        private void panelStudent_Load(object sender, EventArgs e)
        {
            cSubject.Items.Clear();

            subjectList = _SQL.readSubjectByGroup(currentStudentGroup);

            for (int i = 0; i < subjectList.Count; i++)
                cSubject.Items.Add(subjectList[i].getName());
        }
    }
}
