using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proje Ana Dizini

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.ShowTitle(new Worker());
            Console.ReadLine();
        }
    }
}
