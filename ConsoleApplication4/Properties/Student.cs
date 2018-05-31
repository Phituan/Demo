using System;

namespace ConsoleApplication4.Properties
{
    public class Student
    {
        private String rollNumber;
        private String name;
        private String email;
        private int phone;

        public Student(string rollNumber,string name, string email, int phone)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public Student()
        {
        }

        public string RollNumber
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public override string ToString()
        {
            return this.RollNumber + this.name + this.Email + this.Phone ;
        }
    }
}