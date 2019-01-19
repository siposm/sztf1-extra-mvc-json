using System;

namespace student_mvc
{
    class MVCPattern
    {
        public static void Main(string[] args)
        {
            Student model = RetriveStudentFromDatabase();

            StudentView view = new StudentView();

            StudentController controller = new StudentController(model, view);

            controller.UpdateView();

            controller.SetStudentName("Vikram Sharma");

            controller.UpdateView();
        }

        private static Student RetriveStudentFromDatabase()
        {
            Student student = new Student();
            student.SetName("Yolo Yozsef");
            student.SetRollNo("15UCS157");
            return student;
        }

    }
}
