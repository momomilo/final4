using final;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            #region q1

            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            #endregion

            #region q2 
            //string land = "ione";
            //int con = Convert.ToInt32(land);
            //Console.WriteLine(con); // It will not be possible to convert to numbers.
            #endregion

            #region q3 
            float opretion = 1.03f + 64.9f;
            Console.WriteLine(opretion);  // 1.03f + 64.9f = 65.93 
            #endregion

            #region q4 
            string sub = "I play football with my friends";
            sub = sub.Substring(0, 15);
            Console.WriteLine(sub);
            #endregion

            #region q5
            int u = 14;
            int age = u;
            int id = age;
            age = 18;
            Console.WriteLine(id); // id = 14 and not change to 18 
            Console.WriteLine(age);
            #endregion

            #region q6
            akkk pl1 = new akkk();
            akkk pl2 = pl1;
            pl1.x = 11;
            Console.WriteLine(pl2.x); // x = 11
            Console.WriteLine(pl2.y); // 20 
            #endregion

            #region q7 
            Console.WriteLine("Type first string variable");
            string? var1 = Console.ReadLine();
            Console.WriteLine("Type secound string variable");
            string? var2 = Console.ReadLine();
            Console.WriteLine($"{var1}" + $" {var2}");
            #endregion

            #region q8
            Console.WriteLine("Type principal ");
            int principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type rate ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type time by years ");
            int time = Convert.ToInt32(Console.ReadLine());
            int Interest = (principal * rate * time) / 100;
            Console.WriteLine(Interest);
            #endregion

            #region q9 
            // BMI = (Weight)/(Height*Height)
            int Weight = 70;
            int Height = 170;
            int Bmi = (Weight) / (Height * Height);
            Console.WriteLine(Bmi);
            #endregion

            #region q10 - Ternary operator for temperature
            Console.WriteLine("Enter the temperature:");
            int temp = Convert.ToInt32(Console.ReadLine());
            string result = temp < 10 ? "Just Cold" :
                            temp > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(result);
            #endregion

            #region q11 - Date formatting
            Console.WriteLine("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Today's date: {day} , {month} , {year}");
            Console.WriteLine($"Today's date: {day} / {month} / {year}");
            Console.WriteLine($"Today's date: {day} – {month} – {year}");
            #endregion

            #region q12 
            Console.WriteLine("Enter a number:");
            int numk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((numk % 3 == 0 && numk % 4 == 0) ? "Yes" : "No");
            #endregion

            #region q13
            Console.WriteLine("Enter an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number < 0 ? "Negative" : "Positive");
            #endregion

            #region q14 
            Console.WriteLine("Enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(n1, Math.Max(n2, n3));
            int min = Math.Min(n1, Math.Min(n2, n3));

            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");
            #endregion

        }
    }
}
