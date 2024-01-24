using JetBrains.Annotations;
using Rewired;

namespace Radish.Rewired
{
    [PublicAPI]
    public static class RewiredPlayerExtensions
    {
        public static Player GetPlayer(this ReInput.PlayerHelper playerHelper, PlayerReference player)
        {
            return playerHelper.GetPlayer(player.id);
        }
    }
}