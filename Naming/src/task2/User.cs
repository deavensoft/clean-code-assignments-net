
namespace CleanCodeAssignments.Naming.src.task2
{
    public class User(string sName)
    {
        private DateTime dBirth;
        private string sName = sName;
        private bool bAdmin;
        private User[] subordinateArray;
        private int iR;

        public override string ToString()
        {
            return $"User [dBirth={dBirth}, sName={sName}, bAdmin={bAdmin}, subordinateArray={string.Join(", ", subordinateArray.Select(u => u.ToString()))}, iRating={iR}]";
        }
    }
}
