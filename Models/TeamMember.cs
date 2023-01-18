namespace FighteR_PG.Models
{
    public class TeamMember
    {
       public int TeamMemberId {get;set;}
       public int TeamId {get;set;}
       public int CharacterId {get;set;}

       public virtual Team Team {get;set;}
       public virtual Character Character { get;set;}
    }
}
