global using BlazorWalkingSkeleton.Shared;

namespace BlazorWalkingSkeleton.Client.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> SuperHeroes { get; set; }
        Task GetSuperHeroes();
    }
}
