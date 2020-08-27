using System;
namespace Interfaces
{
    public interface IEmployee
    {
        void Add();
        void ShowSalary();
        void ShowTitle();
    }

    class Worker: IEmployee
    {
        void IEmployee.Add()
        {
            Console.WriteLine("Workers Added !");
        }
        void IEmployee.ShowSalary()
        {
            Console.WriteLine("Workers Salary 1300$");
        }
        void IEmployee.ShowTitle()
        {
            Console.WriteLine("Title : Worker");
        }
    }

    class Manager: IEmployee
    {
        void IEmployee.Add()
        {
            Console.WriteLine("Manager Added !");
        }
        void IEmployee.ShowSalary()
        {
            Console.WriteLine("Managers Salary 4300$");
        }
        void IEmployee.ShowTitle()
        {
            Console.WriteLine("Title : Manager");
        }
    }

    class ManageEmployee
    {
        public void Add(IEmployee employee)
        {
            employee.Add();
        }
        public void ShowSalary(IEmployee employee)
        {
            employee.ShowSalary();
        }
        public void ShowTitle(IEmployee employee)
        {
            employee.ShowTitle();
        }

    }
}
