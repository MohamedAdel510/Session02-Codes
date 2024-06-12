namespace Demo
{
    //Class
    //Struct
    //Interface
    //Enum
    internal class Program
    {
        //Functions
        void test01()
        {

        }
        void test03()
        {

        }

        static void Main(string[] args)
        {
            #region first prgram
            // Console.WriteLine("Hello, World!");  single line comment 
            /*           
            Console.ReadLine();                     multi line  comment      

            */
            #endregion

            #region Namming Convention
            // camel case ===> nourhanTariq
            // pascal Case ===> NourhanTariq
            // Kebab case ===> Nourhan_Tariq
            #endregion

            #region value type
            //int x; // Allocate unintialized 4 byte in stack
            //x = 4;

            //Int32 y = 5;

            //y = x;
            //x++;
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #region Reference type
            //Point p1; // Allocate 4 byte in stack
            //          // Zero byte in heap
            //p1 = new Point(); // Allocate required byte for object of point at heap
            //                  // intialized allocated bytes of object
            //                  // call user defind constructor if exist
            //                  // Assigned reference (p1) to the allocated opject
            //Point p2 = new Point();

            //p2 = p1;
            //p1.x = 9;

            //Console.WriteLine(p2.x);
            #endregion

            #region object
            //Point p1 = new Point();
            //Point p2 = new Point();

            //Console.WriteLine(p1.ToString());

            //Console.WriteLine(p1.GetHashCode());

            //Console.WriteLine(p2.Equals(p1));

            //Console.WriteLine(p1.GetType());

            //p1 = p2;

            //Console.WriteLine(p2.Equals(p1));

            //object x;
            //x = new string("Ahmed");
            //x = "Ahmed";             // syntax sugar
            //x = 'A';
            //x = 3;
            //x = 3.7;
            //x = new DateTime();
            //x = new DateOnly();
            //x = new TimeOnly();

            //object x1 = new Object();
            //object x2 = new Object();

            //Console.WriteLine(x1.GetHashCode());
            //Console.WriteLine(x2.GetHashCode());

            //x1 = x2;
            //Console.WriteLine("\nAfter Equal\n");

            //Console.WriteLine(x1.GetHashCode());
            //Console.WriteLine(x2.GetHashCode());
            #endregion

            #region casting
            // Parse Method
            //Console.WriteLine("Enter your name\n");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}!\n");
            //Console.WriteLine("Enter your age\n");
            //int age = int.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Your name: " + name +"\n");
            //Console.WriteLine("Your age: " + age + "\n");

            // Convert class

            //Console.WriteLine("Enter your name\n");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}!\n");
            //Console.WriteLine("Enter your age\n");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Your name: " + name + "\n");
            //Console.WriteLine("Your age: " + age + "\n");

            // Convert disadvatdes

            //string x = "Nourhan";
            //bool flag = Convert.ToBoolean(x);
            //Console.WriteLine(flag);        // Exception

            #endregion

        }
    }
}
