using System;
using Microsoft.Extensions.DependencyInjection;

namespace CodeRepositoryForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            //事前に依存関係を登録
            services.AddSingleton<IEmployee>(new Employee());
            var provider = services.BuildServiceProvider();

            //サービスの型を取得(ここではEmployeeクラスを取得)
            var employee = provider.GetRequiredService<IEmployee>();
            var manager = new Manager(employee);

            foreach (var staff in manager.GetStaff())
            {
                Console.Write(staff.No);
                //結果 12345
            }

        }
    }
}

