using System;
namespace _15marrt.BaseModel
{
	public abstract class Base
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string GroupNo { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Surname : {SurName} GroupNO: {GroupNo}";     
        }
    }
}

