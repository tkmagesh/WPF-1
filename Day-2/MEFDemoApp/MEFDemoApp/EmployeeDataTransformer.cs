using System.ComponentModel.Composition;
using MEFDemoApp.Contracts;

namespace MEFDemoApp
{
    [Export]
    public class EmployeeDataTransformer
    {
        [Import(typeof (IEmployeeSource))]
        public IEmployeeSource Source { get; set; }

        [ImportMany(typeof(IEmployeeDestionation))]
        public IEmployeeDestionation[] Destionations { get; set; }

        public EmployeeDataTransformer()
        {
        }

        public void Transform()
        {
            Destionations.ForEach(d => d.Persist(Source.GetAllEmployees()));
        }
    }
}