using System;

namespace ArgsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg); 
            }
        }
    }
}
//It 's an array of the parameters/arguments (hence args) that you send to the program. For example ping 172.16.0.1 -t -4; These arguments are passed to the program as an array of strings.

//string[] args // Array of Strings containing arguments.
