using JetBrains.Annotations;
using Rewired;
using UnityEngine;

namespace Radish.Rewired
{
    [PublicAPI]
    public static class RewiredPlayerExtensions
    {
        public static Player GetPlayer(this ReInput.PlayerHelper playerHelper, PlayerReference player)
        {
            return playerHelper.GetPlayer(player.id);
        }

        public static Vector2 GetAxis2D(this Player player, ActionReference xAxis, ActionReference yAxis)
        {
            return player.GetAxis2D(xAxis.id, yAxis.id);
        }
    }
}