using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _positionTarget;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            CameraMovementFollow();
           CameraRotationFollow();
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation=Quaternion.Lerp(_cameraTransform.rotation,
                Quaternion.LookRotation(_targetTransform.position-_cameraTransform.position),
                Time.deltaTime*_cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            _cameraTransform.localPosition = _cameraSettings.PositionOffset;
        }
    }

}
