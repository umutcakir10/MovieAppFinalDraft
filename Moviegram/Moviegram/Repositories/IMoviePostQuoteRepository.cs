using Moviegram.Models.Domain;

namespace Moviegram.Repositories
{
    public interface IMoviePostQuoteRepository
    {
        Task<MoviePostQuote> AddAsync(MoviePostQuote moviePostQuote);

    }
}
