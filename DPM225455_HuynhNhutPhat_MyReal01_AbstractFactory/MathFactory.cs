namespace DPM225455_HuynhNhutPhat_MyReal01_AbstractFactory
{
    class MathFactory : SubjectFactory
    {
        public override Subject CreateSubject()
        {
            return new Math();
        }
    }
}
