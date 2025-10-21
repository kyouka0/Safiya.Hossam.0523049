namespace Safiya.Hossam._0523049.DTOs.Competetiondto
{
    public class ReadCompetetion
    {
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public int Totalteams { get; set; }
        public List<Teamsforcomp> Teamsdto { get; set; }
    }
    public class Teamsforcomp
    {
        public string Name { get; set; }
         = string.Empty;
        public  int Totalcount { get; set; }
        public string Ciy { get; set; } = string.Empty;
        public List <Playerforcompetetion> Playres { get; set; }
    }
    public class Playerforcompetetion
    {
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
