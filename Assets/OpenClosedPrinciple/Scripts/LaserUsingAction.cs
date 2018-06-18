namespace OpenClosed.Scripts
{
    public class LaserUsingAction : BulletsUsingActions
    {
        protected override void StartShooting()
        {
            print("Laser noise");
        }

        protected override void BulletMove()
        {
            print("Linear trajectory");
        }

        protected override void BulletEndMoving()
        {
            print("Material melt");
        }
    }
}