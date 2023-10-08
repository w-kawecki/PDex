namespace PDex.Domain.Interfaces
{
    public interface IPokemonRepository
    {
        Task<IEnumerable<Entities.Pokemon>> GetAll();
    }
}
