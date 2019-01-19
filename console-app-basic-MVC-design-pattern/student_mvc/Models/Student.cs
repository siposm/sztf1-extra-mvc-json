using System;
namespace student_mvc
{

    class Student
    {
        private string rollNo;
        private string name;

        public string GetRollNo()
        {
            return rollNo;
        }

        public void SetRollNo(string rollNo)
        {
            this.rollNo = rollNo;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
