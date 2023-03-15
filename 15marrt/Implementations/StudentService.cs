using System;
using _15marrt.Models;

namespace _15marrt.Implementations
{
    public class StudentService : Interfaces.IService,Interfaces.IStudentService
    {
        private Student[] Students = new Student[0];
        public void Create()
        {
            Student student = new Student();
            Console.WriteLine("Name");

            string name = Console.ReadLine();

            while (!CheckLength())
            {
                Console.WriteLine("Name is not valid");
                name = Console.ReadLine();

            }
            student.Name = name;

            Console.WriteLine("Surname");

            string surname = Console.ReadLine();

            while (!CheckLength())
            {
                Console.WriteLine("Name is not valid");
                surname = Console.ReadLine();

            }


            student.SurName = surname;
            Console.WriteLine("GroupNo");
            student.GroupNo = Console.ReadLine();
            while (!CheckLength())
            {
                Console.WriteLine("GroupNo is not valid");
                student.GroupNo = Console.ReadLine();

            }
            student.GroupNo = student.GroupNo;

            Array.Resize(ref Students, Students.Length + 1);

                Students[Students.Length - 1] = student;
        }

        private bool CheckLength()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            Console.WriteLine("Please add id");
            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Student student = Students[Students.Length - 1];

                    Students[Students.Length - 1] = Students[i];

                    Students[i] = student;

                    Array.Resize(ref Students, Students.Length - 1);
                }

            }
        }

        public void GetAll()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);

            }
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private bool CheckLength(string data)
        {
            return data.Length > 2 && data.Length < 30;
    }
}

