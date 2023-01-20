using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;
using FighteR_PG.ViewModels;
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

        public IActionResult List(string arquetipo)
        {
            IEnumerable<Character> characters;
            string Arquetipo = string.Empty;

            if (string.IsNullOrEmpty(arquetipo))
            {
                characters = _characterRepository.Characters.OrderBy(l => l.CharacterId);
                Arquetipo = "Todos personagens";
            }
            else
            {
                characters = _characterRepository.Characters
                    .Where(c => c.Archetype.Name == arquetipo)
                    .OrderBy(c => c.Name);

                if (characters.Any())
                {
                    Arquetipo = arquetipo;
                }
                else
                {
                    Arquetipo = "URL inválida cabaço";
                }

            }

            var characterViewModel = new CharactersViewModel
            {
                Characters = characters,
                Arquetipo = Arquetipo,
            };

            return View(characterViewModel);
        }
    }
}