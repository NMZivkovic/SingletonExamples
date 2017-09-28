namespace SingletonExamples
{
    /// <summary>
    /// Broken, non thread-save solution.
    /// Don't use this code.
    /// </summary>
    public class SingletonFirst
    {
        private static SingletonFirst _instance;

        private SingletonFirst() { }

        public static SingletonFirst Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonFirst();
                }

                return _instance;
            }
        }
    }
}
