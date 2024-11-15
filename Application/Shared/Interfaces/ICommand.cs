using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.Interfaces
{
    public interface ICommand <Tinput, Toutput>
    {
        Task<Toutput> ExecuteAsync(Tinput input);
    }
    public interface ICommand <in Tinput>
    {
        Task ExecuteAsync(Tinput input);
    }
}
