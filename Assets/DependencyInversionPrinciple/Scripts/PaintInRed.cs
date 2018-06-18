using UnityEngine;

namespace DependencyInversionPrinciple.Scripts
{
    public class PaintInRed : MonoBehaviour, IPaint
    {
        public void PaintAnObject()
        {
            print("Object was painted in red");
        }
    }
}