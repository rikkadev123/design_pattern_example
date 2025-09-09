namespace DPM225455_HuynhNhutPhat_MyReal01_AbstractFactory
{
    class PhysicFactory : SubjectFactory
    {
        public override Subject CreateSubject()
        {
            return new Physic();
        }
    }
}
