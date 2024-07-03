#define B9DEBUG
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

        string driveLetter = "C:",folderPath = "Data",fileName = "index.hem",fullName;
        fullName = Combine(driveLetter,folderPath,fileName);
        System.Console.WriteLine(fullName);



        string a = "a",b = "b";
    }

    static string Combine(string driveLetter,string folderPath,string fileName){
        string path;
        path = string.Format("{1}{0}{2}{0}{3}",
        System.IO.Path.DirectorySeparatorChar,
        driveLetter,folderPath,fileName);
        return path;
    }

    static void Swap(ref string a,ref string b){
        string temp = a;
        a = b;
        b = temp;
    }

}
