#define B9DEBUG
using MyNameSpace;
using MyRename = MyReNameSpace;
class Program
{

    static void Main(string[] args)
    {
        // 多维度可以轴长不同、但不允许有缺位
        int[,,] cells = {
            {{0,1,2,4,5,6},{0,2,3,4,5,6},{0,3,4,4,5,6}},
            {{0,1,2,4,5,6},{0,2,3,4,5,6},{0,3,4,4,5,6}},
            {{0,1,2,4,5,6},{0,2,3,4,5,6},{0,3,4,4,5,6}},
            {{0,1,2,4,5,6},{0,2,3,4,5,6},{0,3,4,4,5,6}}};

#if B9DEBUG
        System.Console.WriteLine($"{cells[0, 1, 2]}");
        MyNameSpace.MyClass.SayHi();
#endif

        System.Console.WriteLine(MyNameSpace.MyClass.addOne(1));


        // program beark
        Console.WriteLine("Enter a number:");
        int? number = int.Parse(System.Console.ReadLine());  // 
        System.Console.WriteLine(number);
        // program geart
        Console.WriteLine("Enter a number:");
        string? tempStr = System.Console.ReadLine();  // 
        if (int.TryParse(tempStr, out int number2))
        {
            Console.WriteLine(number2);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        MyRename.MyClass.ReNameSayHI();

        string driveLetter = "C:", folderPath = "Data", fileName = "index.hem", fullName;
        fullName = Combine(driveLetter, folderPath, fileName);
        System.Console.WriteLine(fullName);



        string a = "a", b = "b";
        System.Console.WriteLine($"{a} {b}");
        Swap(ref a, ref b);
        System.Console.WriteLine($"{a} {b}");
        NotRefSwap(a, b);
        System.Console.WriteLine($"{a} {b}");

        MyClass myclass = new MyNameSpace.MyClass();
        System.Console.WriteLine(myclass.i);
        MyClass othermyclass = myclass;
        othermyclass.i += 1;
        System.Console.WriteLine(myclass.i);

        // task -------
        const int repetitions = 100000;
        System.Threading.Tasks.Task task = Task.Run(
            () =>
            {
                for (int count = 0; count < repetitions; count++)
                {
                    System.Console.Write('-');
                };
            });

        for (int count = 0; count < repetitions; count++)
        {
            System.Console.Write('+');
        }

        task.Wait();

    }
    static string Combine(string driveLetter, string folderPath, string fileName)
    {
        string path;
        path = string.Format("{1}{0}{2}{0}{3}",
        System.IO.Path.DirectorySeparatorChar,
        driveLetter, folderPath, fileName);
        return path;
    }

    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    static void NotRefSwap(string a, string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

}
