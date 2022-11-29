namespace FighteR_PG.Models
{
    public class Boss
    {
        public int BossId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Region { get; set; }
        public string RegionImage { get; set; }
        public string GerneralText { get; set; }
        public int SexId { get; set; }
        public Sex Sex { get; set; }
    }
}
