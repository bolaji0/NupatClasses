using System;

namespace Method;
class Program
{
    static void Main(string[] args)
    {
        //Calculator calculator = new Calculator();

        ////int result = calculator.AddNum(20, 40);

        //int resultTwo = calculator.MinusNum(100, 90);

        //Console.WriteLine(result);
        //Console.WriteLine(resultTwo);



        //int num2 = calculator1.AddNum(100, 40);
        //Console.WriteLine(num2);

        //var news = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //var newss = news.Where(x => x % 2 == 0);



        //Calculator calculator = new Calculator();
        //calculator.Name = "Mustapha";
        //calculator.AddNum();

        //Calculator.MinusNum(20, 3);

        //Calculator calculator = new Calculator();
        //var name = calculator.MinusNum(20, 4);


        //Person person = new Person();
        //person.FirstName = "fathiu";
        //person.LastName = "Mustapha";
        //person.Introduce();

        //int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //var evenNumbers = from number in myNumbers
        //                  where number % 2 == 0
        //                  select number;

        //foreach (int number in evenNumbers)
        //{
        //    Console.WriteLine(number);
        //}


        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var number = from numb in numbers
        //             where numb <= 3
        //             select numb;




        //foreach (var numb in number)
        //{
        //    Console.WriteLine(numb);
        //}

        //int[] church = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var number = from net in church
        //             where net >= 5
        //             select net;

        //foreach (var red in number)
        //{
        //    Console.WriteLine(red);
        //}


        //int[] myNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //// Select the numbers greater than 5.
        //var greaterThan5 = from number in myNumbers
        //                   where number > 5
        //                   select number;

        //// Sort the results in descending order.
        //greaterThan5 = greaterThan5.OrderByDescending(number => number);

        //// Print the results to the console.
        //foreach (int number in greaterThan5)
        //{
        //    Console.WriteLine(number);
        //}

        //string intString = Console.ReadLine();
        //int parsedInt = ParseInteger(intString);
        //Console.WriteLine($"Parsed integer: {parsedInt}");

        //string floatString = Console.ReadLine();
        //float parsedFloat = ParseFloat(floatString);
        //Console.WriteLine($"Parsed float: {parsedFloat}");

        //string dateString = "2023-10-23";
        //DateTime parsedDate = ParseDate(dateString);
        //Console.WriteLine($"Parsed date: {parsedDate}");

        //Console.WriteLine(DateTime.Now);


        //static int ParseInteger(string input)
        //{
        //    int parsedInt;
        //    if (int.TryParse(input, out parsedInt))
        //    {
        //        return parsedInt;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid integer input");
        //        return 0;
        //    }
        //}

        //static float ParseFloat(string input)
        //{
        //    float parsedFloat;
        //    if (float.TryParse(input, out parsedFloat))
        //    {
        //        return parsedFloat;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid float input");
        //        return 0.0f;
        //    }
        //}

        //static DateTime ParseDate(string input)
        //{
        //    DateTime parsedDate;
        //    if (DateTime.TryParse(input, out parsedDate))
        //    {
        //        return parsedDate;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid date input");
        //        return DateTime.MinValue;
        //    }
        //}








        //int[] numOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var numTwo = from nam in numOne
        //             where nam > 5
        //             select nam;

        //// Sort the results in descending order.
        //numTwo = numTwo.OrderByDescending(nam => nam);

        //foreach (var item in numTwo)
        //{

        //    Console.WriteLine(item);

        //}

        // Create a list of employees.
        //List<Employee> employees = new List<Employee>
        //{
        //    new Employee { Id = 1, name = "Charlie", Salary = 2000000, Gender = 'M' },
        //    new Employee {Id = 2, name = "Ronke", Salary = 40000000, Gender = 'F'},
        //    new Employee {Id = 3, name = "Mustapha", Salary = 1000000000, Gender = 'M'},
        //    new Employee {Id = 4, name = "Mayowa", Salary = 20000, Gender = 'T'}
        //};

        //// Group the employees by gender.
        //var check = employees.OrderBy(x => x);
        ////var groupedEmployees = employees.GroupBy(e => e.Gender);

        //// Print the groups.
        //foreach (var group in check)
        //{
        //    Console.WriteLine(group);
        //}

        //var people = new[]
        //{
        //    new Person { Name = "Alice", Age = 15, salary = 10 },
        //    new Person { Name = "Bob", Age = 15 ,salary = 50},
        //    new Person { Name = "Charlie", Age = 25, salary = 40 },
        //    new Person { Name = "Dave", Age = 30, salary = 20 },
        //    new Person { Name = "Eve", Age = 25, salary = 155 }
        //};

        //var sortedPeople = people.OrderBy(p => p.Age).ThenBy(p => p.Name).ThenBy(p => p.salary);

        //foreach (var person in sortedPeople)
        //{
        //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, {person.salary}");
        //}



        // Print the groups.






        /*
         Where :
         select
         orderby
         .thenby
         */






        //int[] num = { 4, 5, 5, 53, 90, 24 };

        //var sort = num.OrderBy(x => x);

        //foreach (var item in sort)
        //{
        //    Console.WriteLine(item);
        //}




        //List<Person> people = new List<Person>
        //{
        //    new Person{Name = "Martin", Age = 20, salary = 4000  },
        //    new Person{Name = "Frank", Age = 30, salary = 500  },
        //    new Person{Name = "Grace", Age = 25, salary = 6000  },
        //    new Person{Name = "Mayowa", Age = 22, salary = 9000  },
        //    new Person{Name = "Pelumi", Age = 40, salary = 10000  },
        //    new Person{Name = "John", Age = 35, salary = 40000  },
        //    new Person{Name = "Bright", Age = 60, salary = 75000  },
        //    new Person{Name = "Comfort", Age = 33, salary = 5788  },
        //    new Person{Name = "Phillip", Age = 49, salary = 2000  },
        //    new Person{Name = "Bolaji", Age = 40, salary = 5000  },
        //};


        //var getA = people.Where(x => x.Name.ToLower().Contains('m'));

        //foreach (var item in getA)
        //{
        //    Console.WriteLine(item.Name);
        //}





        //List<Department> departments = new List<Department>
        //{
        //    new Department {departId = 1, departName = "Chemistry", },
        //    new Department {departId = 1, departName = "Bio-Chemistry"},
        //    new Department {departId = 4, departName = "Art"},
        //    new Department {departId = 3, departName = "Art"},
        //    new Department {departId = 5, departName = "pol-science"},
        //    new Department {departId = 6, departName = "Biology"},
        //};


        //var departOrder = departments.OrderBy(x => x.departName).ThenBy(x => x.departId);

        //foreach (var item in departOrder)
        //{
        //    Console.WriteLine("The departmentId {0}, departName {1}",item.departId, item.departName);
        //}

        //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //var red = from num in number
        //          orderby num descending
        //          where num % 2 == 0
        //          select num;

        ////var reds = number.OrderByDescending(x => x);

        //foreach (var item in red)
        //{
        //    Console.WriteLine(item);
        //}

        //int nums = 30;

        //string result = (nums >= 20) ? "nums win" : "nums is wrong";
        //Console.WriteLine(result);


        //DayOfWeek
        //DateTime dates = DateTime.Now;
        //string results;

        //switch (dates)
        //{

        //}
        //Console.WriteLine(results);

        Console.WriteLine("Pls input your digit for conversion to int");
        string inpuTwo = Console.ReadLine();
        convertInt(inpuTwo);
        Console.WriteLine(inpuTwo);

        int convertInt(string input)
        {
            int num;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("Format correct and code changed successfully");
                return num;
            }
            else
            {
                Console.WriteLine("Format Incorrect");
                return 0;
            }
        }

        float convertToFloat(string input)
        {
            float numFloat;
            if (float.TryParse(input, out numFloat))
            {
                return numFloat;
            }
            else
            {
                Console.WriteLine("Incorrect Format");
                return numFloat;
            }
        }

        DateTime convertToDateTime(string input)
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









        Console.ReadLine();
    }


    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int salary { get; set; }
    }

    public class Department
    {
       public int departId { get; set; }

       public string departName { get; set; }

    }
}
