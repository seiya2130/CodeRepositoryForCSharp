using System;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IEmployee>(new Employee());
            var provider = services.BuildServiceProvider();

            var employee = provider.GetRequiredService<IEmployee>();
            var manager = new Manager(employee);

            foreach (var staff in manager.GetStaff())
            {
                Console.WriteLine(staff.No);
            }

        }
    }
}

