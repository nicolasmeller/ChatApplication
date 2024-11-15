using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ModelsDTO
{
    public class MessageDTO
    {
        public int Id { get; set; }
        public string User { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime Timestampe { get; set; }
    }
}
