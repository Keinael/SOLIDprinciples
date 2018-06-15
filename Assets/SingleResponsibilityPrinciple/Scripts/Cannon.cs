using UnityEngine;

namespace SingleResponsibilityPrinciple.Scripts
{
    public class Cannon : MonoBehaviour
    {
        public BulletFireAction BulletFireAction;
        public CannonballAction CannonballAction;

        private void Start()
        {
            Fire(BulletFireAction);
            Fire(CannonballAction);
        }

        private void Fire(IProjectileType bulletsType)
        {
            print("You shooting...");
            bulletsType.Fire();
        }
    }
}