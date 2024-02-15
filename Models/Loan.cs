namespace Moment_3.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public DateOnly LoanDate { get; set; }

        public int BookId { get; set; }

        public Book? Book { get; set; }

        public int UserId { get; set; }

        public User? User { get; set; }

    }
}
