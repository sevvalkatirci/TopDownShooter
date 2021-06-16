using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "TopDown Shooter/Camera/CameraSettings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed {get { return _rotationLerpSpeed; } }

        [Header("Position")] 
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset
        {
            get { return _positionOffset; }
        }

        [SerializeField] private float _positionLerp = 1f;
        public float PositionLerp
        {
            get { return _positionLerp; }
        }

    }
    
}

