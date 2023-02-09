using FighteR_PG.Models;
using FighteR_PG.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Components
{
    public class SelectionIcon : ViewComponent
    {
        private readonly Selection _selection;

        public SelectionIcon(Selection selection)
        {
            _selection = selection;
        }

        public IViewComponentResult Invoke()
        {
            var selectedMembers = _selection.GetSelectedMembers();
            return View(selectedMembers);
        }
    }
}
