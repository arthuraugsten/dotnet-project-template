using System;

namespace DotnetTemplate.Domain.ProjectName.Entities
{
    public sealed class Customer
    {
        public Customer(string name)
            => Name = name;

        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
    }
}
