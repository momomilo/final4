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

        }
    }
}
