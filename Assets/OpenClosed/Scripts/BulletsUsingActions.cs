using UnityEngine;

namespace OpenClosed.Scripts
{
    public abstract class BulletsUsingActions : MonoBehaviour
    {
        public void StartFire()
        {
            StartShooting();
            BulletMove();
            BulletEndMoving();
        }

        protected abstract void StartShooting();
        protected abstract void BulletMove();
        protected abstract void BulletEndMoving();

    }
}