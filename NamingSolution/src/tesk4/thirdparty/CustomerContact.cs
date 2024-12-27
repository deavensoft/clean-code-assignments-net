namespace CleanCodeAssignments.NamingSolution.src.Tesk4.ThirdParty
{
    public class CustomerContact
    {
        private long customerId;
        private string emailId;
        private long contactNumber;
        private long alternateContactNumber;

        public long CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        public long ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public long AlternateContactNumber
        {
            get { return alternateContactNumber; }
            set { alternateContactNumber = value; }
        }
    }
}
