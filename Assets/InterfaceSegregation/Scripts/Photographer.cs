using InterfaceSegregation.Scripts.Interfaces;
using UnityEngine;

namespace InterfaceSegregation.Scripts
{
    /// <summary>
    /// Adding single functional interfaces to void forced dependency in functionality implementation 
    /// </summary>
    public class Photographer : MonoBehaviour
    {
        public Camera Cam;
        public Smartphone Phone;

        private void Start()
        {
            TakingPhoto(Cam);
            TakingPhoto(Phone);
        }

        private void TakingPhoto(ITakePhoto takePhoto)
        {
            takePhoto.TakePhoto();
        }
    }
}