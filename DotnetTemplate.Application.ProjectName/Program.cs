using DotnetTemplate.Domain.ProjectName.Entities;
using DotnetTemplate.Infrastructure.ProjectName.Services;
using System;

namespace DotnetTemplate.Application.ProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New project generated for Department department!");
            var customer = new Customer("Arthur");
            var service = new CustomerService();

            service.Integrate(customer);
        }
    }
}
