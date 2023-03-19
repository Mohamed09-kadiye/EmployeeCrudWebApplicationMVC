using WebApplication1.Models.Interfaces;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Models.Repository
{
    public class CustomerRepo :ICustomer
    {
        List<VmCustomer> customers = new List<VmCustomer>()
        {

            new VmCustomer() { Id = 1,Name="maymuun",Address = "dayniile",Phone="06177322"},
            new VmCustomer() { Id = 2,Name="Jama",Address = "Hargaysa",Phone="0617733"},
            new VmCustomer() {Id = 3, Name = "Foos", Address = "Gubta", Phone = "0617732"},
            new VmCustomer() {Id = 4, Name = "Halima", Address = "Yaqshid", Phone = "061774"},
            new VmCustomer() {Id = 5, Name = "Yusra", Address = "Odweyne", Phone = "061771"},
        };

        public List<VmCustomer> AllCustomers()
        {
            return customers.ToList();
        }

        public VmCustomer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        } 




    }
}
