namespace StructExample
{
    struct FootballTeam
    {
        public int TeamId {get;set;}
        public string Name {get;set;}
        public int Win {get;set;}
        public int Draw {get;set;}
        public int Lose {get;set;}
        public Colors TeamColor {get;set;}

        public int Play()
        {
            return Win + Draw + Lose;
        }
        public int TeamPoints()
        {
            return 3*Win + 1*Draw + 0*Lose;
        }
        public int HirePlayer()
        {
            return 0;
        }
        public void Print()
        {
            Console.WriteLine($"TeamId: {TeamId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Win: {Win}");
            Console.WriteLine($"Draw: {Draw}");
            Console.WriteLine($"Lose: {Lose}");
            Console.WriteLine($"Play: {Play()}");
            Console.WriteLine($"HirePlayer: {HirePlayer()}");
            Console.WriteLine($"TeamPoints: {TeamPoints()}");
            Console.WriteLine($"TeamColor: {TeamColor}");
        }
    }
}