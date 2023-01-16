using FighteR_PG.Context;
using FighteR_PG.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepository _characterRepository;

        public CharacterController(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public IActionResult Details(int? id)
        {
            if (id == null || _characterRepository.Characters == null)
            {
                return NotFound();
            }

            var character = _characterRepository.Characters.FirstOrDefault(m => m.CharacterId == id);

            if (character == null)
            {
                return NotFound();
            }

            return View(character);
        }
    }
}
