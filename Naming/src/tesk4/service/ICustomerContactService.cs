using CleanCodeAssignments.Naming.src.Tesk4.ThirdParty;

namespace CleanCodeAssignments.Naming.src.Tesk4.Service
{
    public interface ICustomerContactService
    {
        CustomerContact FindCustomerContactDetailsByCustomerId(long customerId);
        void UpdateCustomerContactDetails(CustomerContact customerContactDetails);
    }
}
