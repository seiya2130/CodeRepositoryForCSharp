using System;
//using Microsoft.Extensions.DependencyInjection;


namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee();

            var manager = new Manager(employee);

            foreach (var staff in manager.GetStaff())
            {
                Console.WriteLine(staff.No);
            }

            //var services = new ServiceCollection();
            //services.AddSingleton<IEmployee>(new Employee());
            //var provider = services.BuildServiceProvider();

            //var employee = provider.GetRequiredService<IEmployee>();
            //var manager = new Manager(employee);

            //foreach (var staff in manager.GetStaff())
            //{
            //    Console.WriteLine(staff.No);
            //}

        }
    }
}

