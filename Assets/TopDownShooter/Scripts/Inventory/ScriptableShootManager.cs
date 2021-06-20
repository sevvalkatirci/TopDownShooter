using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Inventory/ScriptableShootManager")]
    public class ScriptableShootManager: AbstractScriptableManager<ScriptableShootManager>
    {
        public override void Initialize()
        {
            base.Initialize();
           Debug.Log("Scriptable Shoot Manager Activated");
        }

        public override void Destroy()
        {
            base.Destroy();
            Debug.Log("Scriptable shoot manager destroyed");
        }

        public void Shoot()
        {
          
            
        }
    }

}
