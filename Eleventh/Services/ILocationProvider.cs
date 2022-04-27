using Eleventh.Models;

namespace Eleventh.Services
{
    public interface ILocationProvider
    {
        bool ExistLocation(Room id);
        Location GetLocation(Room id);
        bool IsNavigationLegitimate(Room from, Room to, GameState state);
        List<Connection> GetConnectionsFrom(Room id);
        List<Connection> GetConnectionsTo(Room id);
    }
}
