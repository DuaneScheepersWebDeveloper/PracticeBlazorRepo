using Bogus;

namespace TestingDynamicEditableTable.Data
{
    public static class DummyData
    {
        private static readonly Faker<Customer> CustomerFaker = new Faker<Customer>()
            .RuleFor(c => c.CustomerID, f => f.Random.AlphaNumeric(5))
            .RuleFor(c => c.CompanyName, f => f.Company.CompanyName())
            .RuleFor(c => c.ContactName, f => f.Person.FullName);

        public static IEnumerable<Customer> GetCustomers(int count = 50)
        {
            return CustomerFaker.Generate(count);
        }
    }


}
