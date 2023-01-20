using FighteR_PG.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Components
{
    public class ArchetypeMenu : ViewComponent
    {
        private readonly IArchetypesRepository _archetypeRepository;

        public ArchetypeMenu(IArchetypesRepository archetypeRepository)
        {
            _archetypeRepository = archetypeRepository;
        }

        public IViewComponentResult Invoke()
        {
            var archetypes = _archetypeRepository.Archetypes.OrderBy(c => c.Name);
            return View(archetypes);
        }
    }
}
