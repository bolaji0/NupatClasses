using System;
namespace Method
{
	public class Calculator
	{
        //public string Name;

        //public void AddNum()
        //{
        //	Console.WriteLine("Hello my name is " + Name);
        //}

        //public int MinusNum(int c, int d)
        //{
        //	return c - d;
        //}


        static int ParseInteger(string input)
        {
            int parsedInt;
            if (int.TryParse(input, out parsedInt))
            {
                return parsedInt;
            }
            else
            {
                Console.WriteLine("Invalid integer input");
                return 0;
            }
        }

        static float ParseFloat(string input)
        {
            float parsedFloat;
            if (float.TryParse(input, out parsedFloat))
            {
                return parsedFloat;
            }
            else
            {
                Console.WriteLine("Invalid float input");
                return 0.0f;
            }
        }


        static DateTime ParseDate(string input)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(input, out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                Console.WriteLine("Invalid date input");
                return DateTime.MinValue;
            }
        }



    }

    
}

