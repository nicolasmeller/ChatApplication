
namespace Application.Shared.Interfaces
{
     public interface IQuery <Tinput, Toutput>
    {
        Task<Toutput> ExecuteAsync(Tinput input);

    }
    public interface IQuery<in Tinput>
    {
        Task ExecuteAsync( Tinput input);
    }
}
