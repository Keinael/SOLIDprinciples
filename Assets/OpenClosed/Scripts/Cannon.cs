using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OpenClosed.Scripts
{
    public class Cannon : MonoBehaviour
    {
        public CannonballUsingAction CannonballUsingAction;
        public LaserUsingAction LaserUsingAction;

        private List<BulletsUsingActions> _bulletsUsingActions = new List<BulletsUsingActions>();

        private void Start()
        {
            Fire(CannonballUsingAction);
            Fire(LaserUsingAction);
        }

        private void Fire(BulletsUsingActions bulletsUsingActions)
        {
            bulletsUsingActions.StartFire();
        }
    }
}