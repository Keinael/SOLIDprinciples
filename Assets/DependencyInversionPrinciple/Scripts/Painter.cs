using UnityEngine;

namespace DependencyInversionPrinciple.Scripts
{
    public class Painter : MonoBehaviour
    {
        public PaintInRed PaintInRed;
        public PaintInGreen PaintInGreen;
        public PaintInBlue PaintInBlue;

        private void Start()
        {
            Paint(PaintInRed);
            Paint(PaintInBlue);
        }

        private void Paint(IPaint paint)
        {
            paint.PaintAnObject();
        }
    }
}