using FighteR_PG.Context;
using Microsoft.EntityFrameworkCore;

namespace FighteR_PG.Models
{
    public class Selection
    {
        private readonly AppDbContext _context;

        public Selection(AppDbContext context)
        {
            _context = context;
        }

        public string SelectionId { get; set; }
        public List<SelectedMembers> TeamMembers { get; set; }

        public static Selection GetSelection(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string selectionId = session.GetString("SelectionId") ?? Guid.NewGuid().ToString();

            session.SetString("SelectionId", selectionId);

            return new Selection(context)
            {
                SelectionId = selectionId,
            };
        }

        public void AddToSelection(Character character)
        {
            var SelectedMember = _context.SelectedMembers.FirstOrDefault(c => c.Character.CharacterId == character.CharacterId && c.SelectionId == SelectionId);

            if (SelectedMember == null)
            {
                var TeamMembers = _context.SelectedMembers.Where(c => c.SelectionId == SelectionId).Include(c => c.Character).ToList();

                if (TeamMembers.Count < 3)
                {
                    SelectedMember = new SelectedMembers
                    {
                        Character = character,

                        SelectionId = SelectionId,
                    };

                    _context.SelectedMembers.Add(SelectedMember);
                    _context.SaveChanges();
                }
            }
        }

        public void RemoveFromSelection(Character character)
        {
            var SelectedMember = _context.SelectedMembers.FirstOrDefault(c => c.Character.CharacterId == character.CharacterId && c.SelectionId == SelectionId);

            if (SelectedMember != null)
            {
                _context.SelectedMembers.Remove(SelectedMember);
                _context.SaveChanges();
            }
        }

        public List<SelectedMembers> GetSelectedMembers()
        {
            return TeamMembers ?? (TeamMembers = _context.SelectedMembers
                                                .Where(c => c.SelectionId == SelectionId)
                                                .Include(c => c.Character)
                                                .ToList());
        }

        public void ClearSelection()
        {
            var selectedMembers = _context.SelectedMembers.Where(S => S.SelectionId == SelectionId);

            _context.SelectedMembers.RemoveRange(selectedMembers);

            _context.SaveChanges();
        }
    }
}
