namespace SingletonExamples
{
    /// <summary>
    /// Simple Thread safe solution.
    /// </summary>
    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance;
        private static readonly object _lock = new object();

        private SingletonThreadSafe() { }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                    }
                    return _instance;
                }
            }
        }
    }
}
