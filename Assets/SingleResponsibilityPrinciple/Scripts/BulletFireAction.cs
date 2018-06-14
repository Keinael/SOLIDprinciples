using UnityEngine;

public class BulletFireAction : MonoBehaviour, IProjectileType
{
    public void Fire()
    {
        print("You shoot with bullet");
    }
}