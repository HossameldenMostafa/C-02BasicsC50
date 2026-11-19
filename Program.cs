namespace DemoC02C50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Object in C#

            //int x = 10;

            //object Y = 10;

            //Console.WriteLine(Y); // 10 'Boxing'

            //Y = "Hello";
            //Console.WriteLine(Y); // Hello 'Boxing'

            //Y = 10.20;
            //Y = 'A';
            //Y = true;

            #endregion

            #region Four Universal Methods

            //Student S1 = new Student() { Name = "Ahmed" , Age = 20};
            //Student S2 = new Student() { Name = "Mai" , Age = 22}; // 246
            //Student S3 = new Student() { Name = "Mai" , Age = 22}; // 135
            // Reference Automatic Call ToString()
            //Console.WriteLine(S1);
            //Console.WriteLine();
            //Console.WriteLine(S2);


            //// Is S2 Equal S3 ?
            //Console.WriteLine(S2.Equals(S3)); // False = Compare References

            //int X = 10;
            //int Y = 10;

            //Console.WriteLine(X.Equals(Y));

            // GetHashCode()
            //Console.WriteLine(S2.GetHashCode());
            //Console.WriteLine(S3.GetHashCode());

            //Console.WriteLine(S1.GetType());

            //int x = 20;
            //Console.WriteLine(x.GetType());

            //Int32 y = 20;

            //Console.WriteLine(x.GetHashCode());

            #endregion

            #region Error Types

            // Compile Time Error -> Syntax Error
            //int x = 10

            //int X = 10;
            //int Y = 0;

            //// RunTime Ex => Exception
            //Console.WriteLine(X / Y); // Exception


            #endregion

            #region Exception Handling

            //int TotalStudents = 10;
            //int TotalScore = 100;

            //try
            //{
            //    int Average = TotalScore / TotalStudents;
            //    Console.WriteLine(Average);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("You Cannot Divide By ZERO !");
            //    Console.WriteLine(ex.);
            //}
            //finally
            //{

            //}

            //Console.WriteLine("Hello");


            #endregion

            #region Implicit & Explicit Casting

            //// Implicit Casting
            //int X = 10; // 4 Byte
            //double Y = X; // 8 Byte 10.0
            //Console.WriteLine(Y);

            // Explicit Casting [Unsafe Casting]
            // Casting Large Datatype to Smaller Datatype
            // Data Loss
            // Invalid Data
            // Error May Happen

            //double Z = 20.20;

            //int G = (int) Z;
            //Console.WriteLine(G);


            #endregion

            #region Convert Class

            //string AgeText = "25";

            //int Age = Convert.ToInt32(AgeText);
            //double AgeDouble = Convert.ToDouble(AgeText);

            //Console.WriteLine(AgeDouble);

            #endregion

            #region Parse & TryParse

            //string AgeText = "25";
            ////int Age = Convert.ToInt32 (AgeText);
            //// == 
            //int Age = int.Parse(AgeText);

            //Console.WriteLine(Age);

            //string AgeText = "Twenty Five";

            //int.TryParse(AgeText, out int age);

            //Console.WriteLine(age);

            #endregion

            #region ToString()

            //int Age = 10;
            //double GPA = 3.5;
            //string AgeText = Age.ToString();
            //string GPAText = GPA.ToString();

            //int X = 10;
            //int Y = 20;

            //int Z = X + Y; // 30

            //string XT = X.ToString(); // "10"
            //string YT = Y.ToString(); // "20"
            //// "1020"



            //Console.WriteLine(AgeText);
            //Console.WriteLine(GPAText);


            DateTime Today = DateTime.Now;

            Console.WriteLine(Today.ToString("dddd/MM/yyyy"));

            #endregion
        }
    }
}
