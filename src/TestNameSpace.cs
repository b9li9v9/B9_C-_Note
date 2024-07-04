namespace MyNameSpace
{
    class MyClass
    {
        public static void SayHi()
        // static void sayhi()  <- error  (private func)
        {
            System.Console.WriteLine("hi!");
        }

        // static void Main(string[] args){} <- error  (main * 2)

        public static int addOne(int x) => x + 1;

        public int i = 10086;
    }
}

namespace MyReNameSpace
{
    class MyClass
    {
        public static void ReNameSayHI() => System.Console.WriteLine("hi, this is rename");
    }
}
