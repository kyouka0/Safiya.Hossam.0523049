namespace Safiya.Hossam._0523049.DTOs.PlayerDTO
{
    public class ReadTeamforplayer
    {
        public string Name { get; set; }
    = string.Empty;
        public string Ciy { get; set; } = string.Empty;
        public int Younggest {  get; set; }
        public Playersforteamm Youngistplayers { get; set; }

    }
    public class Playersforteamm
    {
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
