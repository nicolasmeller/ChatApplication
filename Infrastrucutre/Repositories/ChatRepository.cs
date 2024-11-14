
using Infrastructure.Context;
using Infrastructure.Entities;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Repositories
{
    internal class MessageRepository : GenericRepository<Message>, IMessageRespository
    {
        private ChatDatabase database;

        public MessageRepository(ChatDatabase chatDatabase) : base(chatDatabase)
        {
            this.database = chatDatabase;
        }

        public async Task<Message?> GetMessage(int id)
        {
            return await database.Messages.FirstOrDefaultAsync(m => m.Id == id);
        }

    }
}
