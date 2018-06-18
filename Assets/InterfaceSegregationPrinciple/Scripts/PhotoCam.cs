using InterfaceSegregationPrinciple.Scripts.Interfaces;
using UnityEngine;

namespace InterfaceSegregationPrinciple.Scripts
{
    public class PhotoCam : MonoBehaviour, ITakePhoto
    {
        public void TakePhoto()
        {
            print("Cam taking photo");
        }
    }
}