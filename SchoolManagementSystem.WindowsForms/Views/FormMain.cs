using EFProject.Views;

namespace EFProject
{
    public partial class FormMain : Form
    {
        /*--------------------------------------------------------------------------*/
        public FormMain()
        {
            InitializeComponent();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddStudents_Click(object sender, EventArgs e)
        {
            FormStudent frmStudent = new FormStudent();
            frmStudent.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewStudents_Click(object sender, EventArgs e)
        {
            FormStudentsList frmStudentList = new FormStudentsList();
            frmStudentList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddDepartments_Click(object sender, EventArgs e)
        {
            FormDepartment frmDepartment = new FormDepartment();
            frmDepartment.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewDepartments_Click(object sender, EventArgs e)
        {
            FormDepartmentsList frmDepartmentsList = new FormDepartmentsList();
            frmDepartmentsList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddInstructors_Click(object sender, EventArgs e)
        {
            FormInstructor frmInstructor = new FormInstructor();
            frmInstructor.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewInstructors_Click(object sender, EventArgs e)
        {
            FormInstructorsList frmInstructorsList = new FormInstructorsList();
            frmInstructorsList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddCourses_Click(object sender, EventArgs e)
        {
            FormCourse frmCourse = new FormCourse();
            frmCourse.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewCourses_Click(object sender, EventArgs e)
        {
            FormCoursesList frmCoursesList = new FormCoursesList();
            frmCoursesList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddCoursesStudent_Click(object sender, EventArgs e)
        {
            FormCourseStudent frmCourseStudent = new FormCourseStudent();
            frmCourseStudent.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewCoursesStudent_Click(object sender, EventArgs e)
        {
            FormCoursesStudentsList frmCoursesStudentsList = new FormCoursesStudentsList();
            frmCoursesStudentsList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddCoursesSessions_Click(object sender, EventArgs e)
        {
            FormCourseSession frmCourseSession = new FormCourseSession();
            frmCourseSession.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewCoursesSessions_Click(object sender, EventArgs e)
        {
            FormCoursesSessionsList frmCoursesSessionsList = new FormCoursesSessionsList();
            frmCoursesSessionsList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuAddCoursesSessionsAttendance_Click(object sender, EventArgs e)
        {
            FormCourseSessionAttendance frmCourseSessionAttendance = new FormCourseSessionAttendance();
            frmCourseSessionAttendance.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
        private void stripMenuViewCoursesSessionsAttendance_Click(object sender, EventArgs e)
        {
            FormCoursesSessionsAttendanceList frmCoursesSessionsAttendanceList = new FormCoursesSessionsAttendanceList();
            frmCoursesSessionsAttendanceList.ShowDialog();
        }
        /*--------------------------------------------------------------------------*/
    }
}
