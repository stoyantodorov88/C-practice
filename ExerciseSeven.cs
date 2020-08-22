using System;

namespace excersize
{
    class Program
    {
        static void Main()

        {
            string[] array = Console.ReadLine().Split('|');
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Done")
            {
                int index = int.Parse(command[2]);

                if (command[0] == "Move" && command[1] == "Left")
                {
                    if (index > 0 && index < array.Length)
                    {

                        string temp = array[index];
                        array[index] = array[index - 1];
                        array[index - 1] = temp;
                    }

                }
                else if (command[0] == "Move" && command[1] == "Right")
                {
                    if (index >= 0 && index < array.Length - 1)
                    {

                        string temp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = temp;
                    }
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"You crafted {String.Join("", array)}");
        }
    }
}
