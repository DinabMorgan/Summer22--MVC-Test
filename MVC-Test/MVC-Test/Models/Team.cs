namespace MVC_Test.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string City {get; set; }
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }
        public virtual List<Player> Player { get; set; }
        public int PlayerCount
        {
            get
            {
                return Player.Count;
            }
        }
        public string Mascot { get; set; }

        //public Team(int id, string name, string city, Coach coach, List<Player> players, string mascot)
        //{
        //    Id = id;
        //    Name = name;
        //    City = city;
        //    Coach = coach;
        //    Players = players;
        //    Mascot = mascot;
        //}
    }
    
}