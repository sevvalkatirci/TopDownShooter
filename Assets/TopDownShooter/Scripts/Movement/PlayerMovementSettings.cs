using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Player/MovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float HorizontalSpeed = 5f;
        public float VerticalSpeed = 5f;
    }
}

