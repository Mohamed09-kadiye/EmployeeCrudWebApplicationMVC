using WebApplication1.Models.ViewModels;

namespace WebApplication1.Models.Interfaces
{
    public interface ICustomer
    {
        List<VmCustomer> AllCustomers();
    }
}
