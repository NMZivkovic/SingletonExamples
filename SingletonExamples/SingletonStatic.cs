namespace SingletonExamples
{
    /// <summary>
    /// Using static constructor.
    /// </summary>
    public class SingletonStatic
    {
        private static SingletonStatic instance;

        private SingletonStatic() { }

        static SingletonStatic()
        {
            instance = new SingletonStatic();
        }

        public static SingletonStatic Instance
        {
            get { return instance; }
        }
    }
}
