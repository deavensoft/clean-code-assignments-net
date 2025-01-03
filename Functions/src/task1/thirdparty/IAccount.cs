namespace CleanCodeAssignments.Functions.Src.Task1.ThirdParty
{
    public interface IAccount
    {
        string GetName();
        string GetPassword();
        void SetCreatedDate(DateTime date);
        IAddress GetAdditionalAddress();
        IAddress GetWorkAddress();
        IAddress GetHomeAddress();
        void SetAddresses(List<IAddress> addresses);
    }
}
