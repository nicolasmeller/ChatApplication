using Infrastrucutre.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucutre.Context
{
    public class ChatDatabase : DbContext
    {

        public DbSet<Message> Messages { get; set; }

        public ChatDatabase(DbContextOptions<ChatDatabase> options) : base(options) { }


    }
}
