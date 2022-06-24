namespace MVC_Test.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<PlayerPosition> Players { get; set; }

        //public Position(int id, string name, List<Player> player)
        //{
        //    Id = id;
        //    Name = name;
        //    Player = player;

        //}

    }
}
