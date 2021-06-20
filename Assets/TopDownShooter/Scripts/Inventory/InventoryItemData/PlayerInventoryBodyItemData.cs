using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/Player Inventory Body Item Data")]
    public class PlayerInventoryBodyItemData :AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateandInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("THIS CLASS IS PLAYER INVENTORY ITEM DATA");
        }
   
    }  
}

