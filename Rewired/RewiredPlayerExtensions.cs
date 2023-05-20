using JetBrains.Annotations;
using OrbHall.Rewired;
using Rewired;

[PublicAPI]
// ReSharper disable once CheckNamespace
public static class RewiredPlayerExtensions
{
    public static Player GetPlayer(this ReInput.PlayerHelper playerHelper, PlayerReference player)
    {
        return playerHelper.GetPlayer(player.id);
    }
}