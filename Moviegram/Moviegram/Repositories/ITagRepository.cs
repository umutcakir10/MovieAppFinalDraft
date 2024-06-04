﻿using Moviegram.Models.Domain;

namespace Moviegram.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>>GetAllAsync(
            string? searchQuery = null);

        Task<Tag?> GetAsync(Guid id);

        Task<Tag> AddAsync(Tag tag);

        Task<Tag?> UpdateAsync(Tag tag);

        Task<Tag?> DeleteAsync(Guid id);
    }
}
