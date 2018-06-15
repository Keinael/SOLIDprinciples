namespace OpenClosed.Scripts
{
    public class CannonballUsingAction : BulletsUsingActions
    {
        protected override void StartShooting()
        {
            print("Big boom");
        }

        protected override void BulletMove()
        {
            print("Parabola trajectory");
        }

        protected override void BulletEndMoving()
        {
            print("Big damage");
        }
    }
}