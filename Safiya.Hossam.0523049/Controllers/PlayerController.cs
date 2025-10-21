using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safiya.Hossam._0523049.DTOs.PlayerDTO;
using Safiya.Hossam._0523049.Repository.PlayerRepository;

namespace Safiya.Hossam._0523049.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayer _player;

        public PlayerController(IPlayer player)
        {
            _player = player;
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, PlayerDo dto)
        {
            var player = await _player.GetBy(id);
            if (player == null) { return NotFound(); }

            player.Position = dto.Position;

            await _player.SaveChange();
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var t = await _player.GetPlayersAsync();
            var team = t.Select(x => new ReadTeamforplayer
            {
                Ciy = x.Ciy,
                Name = x.Name,
                 Youngistplayers = x.players.Min(a=> a.Age)

            }).ToList();
            return Ok(team);
        }
    }
}
