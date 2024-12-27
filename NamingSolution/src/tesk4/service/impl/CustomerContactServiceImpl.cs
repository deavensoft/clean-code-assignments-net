using CleanCodeAssignments.NamingSolution.src.Tesk4.ThirdParty;

namespace CleanCodeAssignments.NamingSolution.src.Tesk4.Service.Impl
{
    public class CustomerContactServiceImpl : ICustomerContactService
    {
        private readonly ICustomerContactDAO customerContactDAO;

        public CustomerContactServiceImpl(ICustomerContactDAO customerContactDAO)
        {
            this.customerContactDAO = customerContactDAO;
        }

        public CustomerContact Find(long customerId)
        {
            return customerContactDAO.FindById(customerId);
        }

        public void update(CustomerContact customerContactDetails)
        {
            customerContactDAO.Update(customerContactDetails);
        }
    }
}
