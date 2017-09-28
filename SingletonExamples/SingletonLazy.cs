using System;

namespace SingletonExamples
{
    /// <summary>
    /// Solution using Lazy implementation.
    /// </summary>
    public class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> instance =
        new Lazy<SingletonLazy>(() => new SingletonLazy());

        public static SingletonLazy Instance { get { return instance.Value; } }

        private SingletonLazy()
        {
        }
    }
}
