using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ChatDatabase : DbContext
    {

        public DbSet<Message> Messages { get; set; }

        public ChatDatabase(DbContextOptions<ChatDatabase> options) : base(options) { }


    }
}
