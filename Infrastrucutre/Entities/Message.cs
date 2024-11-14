
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string User{ get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Timestampe {  get; set; }
    }
}
