using System;
namespace _15marrt.Models
{
	public class Teacher : BaseModel.Base
	{
		static int _count = 0;

			public Teacher()
		{
			_count++;
			Id = _count;
		}
		
	}
}

