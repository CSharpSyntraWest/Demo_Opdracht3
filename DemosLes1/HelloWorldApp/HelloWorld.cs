using System;

namespace HelloWorldApp
{

    class HelloWorld
    {
        //VISUAL STUDIO IS EEN IDE (Integrated developer user interface)
        static void Main()
        {
            PrintHelloWorldStringBuilder();
            PrintHelloWorld();
        }

        private static void PrintHelloWorldStringBuilder()
        {
            System.Text.StringBuilder sb_tekst = new System.Text.StringBuilder();
            sb_tekst.Append("Hello\n");
            sb_tekst.Append("World");
            string tekst = sb_tekst.ToString();
            Console.WriteLine(tekst);
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
