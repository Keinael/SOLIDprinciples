using UnityEngine;

namespace DependencyInversionPrinciple.Scripts
{
    public class PaintInBlue : MonoBehaviour, IPaint
    {
        public void PaintAnObject()
        {
            print("Object was painted in blue");
        }
    }
}