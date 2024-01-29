using Rewired;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Radish.Rewired
{
    [CustomPropertyDrawer(typeof(PlayerReference))]
    internal sealed class PlayerReferencePropertyDrawer : RewiredReferencePropertyDrawerBase
    {
        protected override void GetItems(InputManager_Base inputManager, AdvancedDropdownItem parent)
        {
            foreach (var player in inputManager.userData.GetPlayerIds())
            {
                parent.AddChild(new RewiredEntryDropdownItem(inputManager.userData.GetPlayerNameById(player), 
                    player - 1, inputManager.userData.GetPlayerNameById(player)));
            }
        }
    }
}