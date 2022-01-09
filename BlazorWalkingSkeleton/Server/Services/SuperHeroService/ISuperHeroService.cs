namespace BlazorWalkingSkeleton.Server.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        Task<List<SuperHero>> GetAll();
    }
}
