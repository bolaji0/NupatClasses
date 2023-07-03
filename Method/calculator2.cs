using System;
namespace Method
{
	public class calculator2
	{

		public int convertInt(string input)
		{
			int num;
			if (int.TryParse(input, out num))
			{
				return num;
			}
			else
			{
				Console.WriteLine("Format Incorrect");
				return num = 0;
			}
		}

		public float convertToFloat(string input)
		{
			float numFloat;
			if(float.TryParse(input, out numFloat))
			{
				return numFloat;
			}
			else
			{
				Console.WriteLine("Incorrect Format");
				return numFloat;
			}
		}

		public DateTime convertToDateTime(string input)
		{
			DateTime toFloat;
			if (DateTime.TryParse(input, out toFloat))
			{
				return toFloat;
			}
			else
			{
				Console.WriteLine("Wrong Format");
				return toFloat;
			}
		}
	}
}

