using System.Linq;
using Rewired;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Radish.Rewired
{
    [CustomPropertyDrawer(typeof(ActionReference))]
    internal sealed class ActionReferencePropertyDrawer : RewiredReferencePropertyDrawerBase
    {
        protected override void GetItems(InputManager_Base inputManager, AdvancedDropdownItem parent)
        {
            foreach (var category in inputManager.userData.GetActionCategoryIds())
            {
                var categoryItem = new AdvancedDropdownItem(inputManager.userData.GetActionCategoryNameById(category));
                parent.AddChild(categoryItem);

                foreach (var action in inputManager.userData.GetActionIds()
                             .Select(x => inputManager.userData.GetAction(x)).Where(x => x.categoryId == category))
                {
                    categoryItem.AddChild(new RewiredEntryDropdownItem(action.descriptiveName, action.id, action.name));
                }
            }
        }
    }
}