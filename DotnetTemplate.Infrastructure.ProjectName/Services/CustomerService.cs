using DotnetTemplate.Domain.ProjectName.Entities;
using DotnetTemplate.Domain.ProjectName.Services;
using System;

namespace DotnetTemplate.Infrastructure.ProjectName.Services
{
    public sealed class CustomerService : ICustomerService
    {
        public void Integrate(Customer customer)
            => Console.WriteLine($"Integrating customer {customer.Name} (ID: {customer.Id}) with XPTO System.");
    }
}
