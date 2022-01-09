namespace BlazorWalkingSkeleton.Server.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly DataContext _context;

        public SuperHeroService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SuperHero>> GetAll()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return heroes;
        }
    }
}
