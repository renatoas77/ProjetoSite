using FighteR_PG.Models;
using Microsoft.AspNetCore.Mvc;

namespace FighteR_PG.Components
{
    public class SelectionList : ViewComponent
    {
        private readonly Selection _selection;

        public SelectionList(Selection selection)
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