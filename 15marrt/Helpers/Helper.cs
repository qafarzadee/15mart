using System;
namespace _15marrt.Helpers
{
	public class Helper
	{
        private static bool CheckLength(string data)
        {
            return data.Length > 2 && data.Length < 30&&!
            string.IsNullOrWhiteSpace(data);
        }
    }
}

