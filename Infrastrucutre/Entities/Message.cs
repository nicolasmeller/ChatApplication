

namespace Infrastrucutre.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string User{ get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Timestampe {  get; set; }
    }
}
