﻿using UnityEngine;

namespace SingleResponsibilityPrinciple.Scripts
{
    public class CannonballAction : MonoBehaviour, IProjectileType
    {
        public void Fire()
        {
            print("You shoot with cannonball");
        }
    }
}