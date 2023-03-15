using System;
using _15marrt.Models;

namespace _15marrt.Implementations
{
    public class TeacherService : Interfaces.IService,Interfaces.ITeacherService
    {
        public void Create()
        {
            Teacher teacher = new Teacher();
            Console.WriteLine("Name");

            teacher.Name = Console.ReadLine();
            Console.WriteLine("Surname");
            teacher.SurName = Console.ReadLine();
            Console.WriteLine("GroupNo");
            teacher.GroupNo = Console.ReadLine();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        
    }
}

