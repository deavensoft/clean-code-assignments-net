using CleanCodeAssignments.NamingSolution.src.Tesk4.ThirdParty;

namespace CleanCodeAssignments.NamingSolution.src.Tesk4.Service
{
    public interface ICustomerContactService
    {
        CustomerContact Find(long customerId);
        void update(CustomerContact customerContactDetails);
    }
}
