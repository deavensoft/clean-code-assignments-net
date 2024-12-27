
namespace CleanCodeAssignments.NamingSolution.src.task2
{
    public class User(string name)
    {
        private DateTime Birthday { get; set; }
        private readonly string Name = name;
        private bool Admin { get; set; }
        private User[] Subordinates { get; set; }
        private int Rating { get; set; }

        public override string ToString()
        {
            return $"User [dBirth={Birthday}, sName={Name}, bAdmin={Admin}, subordinateArray={string.Join(", ", Subordinates.Select(u => u.ToString()))}, iRating={Rating}]";
        }
    }
}
