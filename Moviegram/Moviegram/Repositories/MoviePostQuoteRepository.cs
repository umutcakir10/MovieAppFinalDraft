using Moviegram.Data;
using Moviegram.Models.Domain;

namespace Moviegram.Repositories
{
    public class MoviePostQuoteRepository : IMoviePostQuoteRepository
    {
        private readonly MoviegramDbContext moviegramDbContext;

        public MoviePostQuoteRepository(MoviegramDbContext moviegramDbContext)
        {
            this.moviegramDbContext = moviegramDbContext;
        }
        public async Task<MoviePostQuote> AddAsync(MoviePostQuote moviePostQuote)
        {
            await moviegramDbContext.MoviePostQuote.AddAsync(moviePostQuote);
            await moviegramDbContext.SaveChangesAsync();
            return moviePostQuote;
        }

       
    }
}
