using InterfaceSegregationPrinciple.Scripts.Interfaces;
using UnityEngine;

namespace InterfaceSegregationPrinciple.Scripts
{
    public class Smartphone : MonoBehaviour, ITakePhoto, IWeb, IApps, ICall
    {
        public void TakePhoto()
        {
            print("Phone taking photo");
        }

        public void BrowseWeb()
        {
            print("Browsing web");
        }

        public void PlayApps()
        {
            print("Playing app");
        }

        public void Call()
        {
            print("Calling");
        }
    }
}