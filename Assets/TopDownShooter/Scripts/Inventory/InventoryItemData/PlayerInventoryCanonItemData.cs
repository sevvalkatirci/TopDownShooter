using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/PlayerInventoryCanonItemData")]
    public class PlayerInventoryCanonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCanonItemMono>
    {
        [SerializeField] private float _damage;
        public float Damage
        {
            get { return _damage; }
        }
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateandInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("THIS CLASS IS PLAYER INVENTORY ITEM DATA");
        }
    }
}

