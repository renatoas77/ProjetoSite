using FighteR_PG.Repositories.IRepositories;
using FighteR_PG.Models;
using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Controllers
{
    public class SelectionController : Controller
    {
        private readonly ICharacterRepository _character;
        private readonly Selection _selection;

        public SelectionController(ICharacterRepository character, Selection selection)
        {
            _character = character;
            _selection = selection;
        }

        public IActionResult Index()
        {
               _selection.TeamMembers = _selection.GetSelectedMembers();

          return View(_selection.TeamMembers);
        }

        public IActionResult SelecionarMembro(int CharacterId)
        {
            var character = _character.Characters
                            .FirstOrDefault(c => c.CharacterId == CharacterId);

            if (character != null)
            {
                _selection.AddToSelection(character);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverMembro(int CharacterId)
        {
            var character = _character.Characters
                            .FirstOrDefault(c => c.CharacterId == CharacterId);

            if (character != null)
            {
                _selection.RemoveFromSelection(character);
            }
            return RedirectToAction("Index");
        }
    }
}
