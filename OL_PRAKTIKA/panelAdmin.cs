using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OL_PRAKTIKA
{
    public partial class panelAdmin : Form
    {
        SQL _SQL = new SQL();

        List<Group> groupList;
        List<Student> studentList;
        List<Subject> subjectList;
        List<Lecturer> lecturerList;

        public panelAdmin()
        {
            InitializeComponent();
        }

        private void panelAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                updateGroupList();
                updateStudentList();
                updateLecturerList();
                updateSubjectList();
            }
            catch
            {

            }
        }

        #region Student Group

        private void bCreateGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SQL.bStudentGroupExists(tNewGroup.Text))
                {
                    MessageBox.Show("Tokia grupė jau egzistuoja!");
                    return;
                }
                else
                {
                    lGroup.Items.Clear();
                    _SQL.insertStudentGroup(tNewGroup.Text);
                    updateGroupList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepavyko įterpti grupės: " + ex.ToString());
            }
        }

        private void bDeleteGroup_Click(object sender, EventArgs e)
        {
            _SQL.deleteStudentGroup(groupList[lGroup.SelectedIndex].getId());

            updateGroupList();
        }

        private void updateGroupList()
        {
            lGroup.Items.Clear();
            cGroup.Items.Clear();
            cStudentGroup.Items.Clear();

            groupList = _SQL.readStudentGroup();

            for (int i = 0; i < groupList.Count; i++)
                lGroup.Items.Add(groupList[i].getName());

            for (int i = 0; i < groupList.Count; i++)
                cGroup.Items.Add(groupList[i].getName());

            for (int i = 0; i < groupList.Count; i++)
                cStudentGroup.Items.Add(groupList[i].getName());
        }

        #endregion

        #region Student

        private void bCreateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tNewStudent.Text.Contains(" "))
                {
                    MessageBox.Show("Neteisingas vardo pavardės formatas. Formatas: Vardas Pavardė");
                }
                else
                {
                    string Name = tNewStudent.Text.Split(' ')[0];
                    string Surname = tNewStudent.Text.Split(' ')[1];

                    if (_SQL.bStudentExists(Name, Surname))
                    {
                        MessageBox.Show("Toks studentas jau egzistuoja!");
                        return;
                    }
                    else
                    {
                        lStudent.Items.Clear();
                        _SQL.insertUser(Name, Surname, 1, Name, Surname, 0);
                        updateStudentList();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepavyko įterpti studento: " + ex.ToString());
            }
        }

        private void bDeleteStudent_Click(object sender, EventArgs e)
        {
            _SQL.deleteUser(studentList[lStudent.SelectedIndex].getId());

            updateStudentList();
        }

        private void updateStudentList()
        {
            lStudent.Items.Clear();
            cStudent.Items.Clear();

            studentList = _SQL.readStudent();

            for (int i = 0; i < studentList.Count; i++)
                lStudent.Items.Add(studentList[i].getName() + " " + studentList[i].getSurname());

            for (int i = 0; i < studentList.Count; i++)
                cStudent.Items.Add(studentList[i].getName() + " " + studentList[i].getSurname());
        }

        #endregion

        #region Lecturer

        private void bCreateLecturer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!tNewLecturer.Text.Contains(" "))
                {
                    MessageBox.Show("Neteisingas vardo pavardės formatas. Formatas: Vardas Pavardė");
                }
                else
                {
                    string Name = tNewLecturer.Text.Split(' ')[0];
                    string Surname = tNewLecturer.Text.Split(' ')[1];

                    if (_SQL.bLecturerExists(Name, Surname))
                    {
                        MessageBox.Show("Toks dėstytojas jau egzistuoja!");
                        return;
                    }
                    else
                    {
                        lLecturer.Items.Clear();
                        _SQL.insertUser(Name, Surname, 2, Name, Surname, 0);
                        updateLecturerList();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepavyko įterpti dėstytojo: " + ex.ToString());
            }
        }

        private void bDeleteLecturer_Click(object sender, EventArgs e)
        {
            _SQL.deleteUser(lecturerList[lLecturer.SelectedIndex].getId());

            updateLecturerList();
        }

        private void updateLecturerList()
        {
            lLecturer.Items.Clear();
            cLecturer.Items.Clear();
            cLecturer1.Items.Clear();

            lecturerList = _SQL.readLecturer();

            for (int i = 0; i < lecturerList.Count; i++)
                lLecturer.Items.Add(lecturerList[i].getName() + " " + lecturerList[i].getSurname());

            //Also updates combobox
            for (int i = 0; i < lecturerList.Count; i++)
                cLecturer.Items.Add(lecturerList[i].getName() + " " + lecturerList[i].getSurname());

            for (int i = 0; i < lecturerList.Count; i++)
                cLecturer1.Items.Add(lecturerList[i].getName() + " " + lecturerList[i].getSurname());
        }

        #endregion

        #region Subject

        private void bCreateSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (_SQL.bSubjectExists(tNewSubject.Text))
                {
                    MessageBox.Show("Toks dalykas jau egzistuoja!");
                    return;
                }
                else
                {
                    lSubject.Items.Clear();
                    _SQL.insertSubject(tNewSubject.Text, lecturerList[cLecturer.SelectedIndex].getId());
                    updateSubjectList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepavyko įterpti dalyko: " + ex.ToString());
            }
        }

        private void bDeleteSubject_Click(object sender, EventArgs e)
        {
            _SQL.deleteSubject(subjectList[lSubject.SelectedIndex].getId());

            updateSubjectList();
        }

        private void updateSubjectList()
        {
            lSubject.Items.Clear();
            cSubject.Items.Clear();
            cSubject1.Items.Clear();

            subjectList = _SQL.readSubject();

            for (int i = 0; i < subjectList.Count; i++)
                lSubject.Items.Add(subjectList[i].getName());

            for (int i = 0; i < subjectList.Count; i++)
                cSubject.Items.Add(subjectList[i].getName());

            for (int i = 0; i < subjectList.Count; i++)
                cSubject1.Items.Add(subjectList[i].getName());
        }


        #endregion

        private void bLecturerToGroup_Click(object sender, EventArgs e)
        {
            _SQL.updateSubjectGroup(groupList[cGroup.SelectedIndex].getId(), subjectList[cSubject.SelectedIndex].getId());

            updateSubjectList();
        }

        private void bSubjectToLecturer_Click(object sender, EventArgs e)
        {
            _SQL.updateSubjectLecturer(lecturerList[cLecturer1.SelectedIndex].getId(), subjectList[cSubject1.SelectedIndex].getId());

            updateSubjectList();
        }

        private void bStudentToGroup_Click(object sender, EventArgs e)
        {
            _SQL.updateStudentGroup(groupList[cStudentGroup.SelectedIndex].getId(), studentList[cStudent.SelectedIndex].getId());

            updateSubjectList();
        }
    }
}
