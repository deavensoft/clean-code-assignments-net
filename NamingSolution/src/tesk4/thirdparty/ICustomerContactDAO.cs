namespace CleanCodeAssignments.NamingSolution.src.Tesk4.ThirdParty
{
    public interface ICustomerContactDAO
    {
        CustomerContact FindById(long customerId);
        void Update(CustomerContact contact);
    }
}
