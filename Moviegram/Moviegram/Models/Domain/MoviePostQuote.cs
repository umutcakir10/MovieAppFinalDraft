namespace Moviegram.Models.Domain
{
    public class MoviePostQuote
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Guid MoviePostId { get; set; }

        public Guid UserId { get; set; }

        public DateTime DateAdded { get; set; }
    }
}
