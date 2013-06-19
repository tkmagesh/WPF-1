using System.ComponentModel.Composition;
using MEFDemoApp.Contracts;

namespace MEFDemoApp
{
    [Export(typeof(IEmployeeSource))]
    public class InMemoryEmployeeSource : IEmployeeSource
    {
        public Employee[] GetAllEmployees()
        {
            return new Employee[]
                {
                    new Employee() {Id = 101, FirstName = "Magesh", LastName = "Kuppan", Salary = 100000},
                    new Employee() {Id = 102, FirstName = "Rajesh", LastName = "Pandit", Salary = 200000},
                    new Employee() {Id = 103, FirstName = "Suresh", LastName = "Kannan", Salary = 200000},
                    new Employee() {Id = 104, FirstName = "Ganesh", LastName = "Easwaran", Salary = 400000},
                    new Employee() {Id = 105, FirstName = "Ramesh", LastName = "Jayaraman", Salary = 500000},
                };
        }
    }
}