using System;
namespace _15marrt.Models
{
	public class Student : BaseModel.Base
	{
        static int _count = 0;

        public Student()
        {
            _count++;
            Id = _count;
        }


       
    }
}

