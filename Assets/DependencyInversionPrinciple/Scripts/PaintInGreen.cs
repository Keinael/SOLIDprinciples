using UnityEngine;

namespace DependencyInversionPrinciple.Scripts
{
    public class PaintInGreen : MonoBehaviour, IPaint
    {
        public void PaintAnObject()
        {
            print("Object was painted in greed");
        }
    }
}