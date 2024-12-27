using CleanCodeAssignments.Naming.src.Tesk4.ThirdParty;

namespace CleanCodeAssignments.Naming.src.Tesk4.Service.Impl
{
    public class CustomerContactServiceImpl : ICustomerContactService
    {
        private readonly ICustomerContactDAO customerContactDAO;

        public CustomerContactServiceImpl(ICustomerContactDAO customerContactDAO)
        {
            this.customerContactDAO = customerContactDAO;
        }

        public CustomerContact FindCustomerContactDetailsByCustomerId(long customerId)
        {
            return customerContactDAO.FindById(customerId);
        }

        public void UpdateCustomerContactDetails(CustomerContact customerContactDetails)
        {
            customerContactDAO.Update(customerContactDetails);
        }
    }
}
