using System;
using UnityEngine;

namespace ScriptPlayer
{

    public class MouseLook : MonoBehaviour
    {
        
        private float _rotationX;
        private float _rotationY;

        [SerializeField]
        private float sensitivity = 5f;
        void Update()
        {
            _rotationX = _rotationX - Input.GetAxis("Mouse Y") * sensitivity;
            _rotationY = _rotationY + Input.GetAxis("Mouse X") * sensitivity;
            
            transform.rotation = Quaternion.Euler(_rotationX, _rotationY, 0);

        }

        private void Start()
        {
            // bloque et cache la souris
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

}