namespace DPM225455_HuynhNhutPhat_MyReal01_AbstractFactory
{
    class Lab
    {
        private Subject _subject;

        public Lab(SubjectFactory subjectFactory) 
        {
            _subject = subjectFactory.CreateSubject();
        }

        public void Introduction()
        {
            _subject.ShowInfo();
        }
    }
}
