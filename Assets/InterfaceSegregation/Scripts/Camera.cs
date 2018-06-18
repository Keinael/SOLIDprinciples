using InterfaceSegregation.Scripts.Interfaces;
using UnityEngine;

namespace InterfaceSegregation.Scripts
{
    public class Camera : MonoBehaviour, ITakePhoto
    {
        public void TakePhoto()
        {
            print("Cam taking photo");
        }
    }
}