using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonExamples;

namespace Tests
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void SingletonFirst_Test()
        {
            var singleton1 = SingletonFirst.Instance;
            var singleton2 = SingletonFirst.Instance;

            Assert.AreEqual(singleton1, singleton2);
        }

        [TestMethod]
        public void SingletonThreadSafe_Test()
        {
            var singleton1 = SingletonThreadSafe.Instance;
            var singleton2 = SingletonThreadSafe.Instance;

            Assert.AreEqual(singleton1, singleton2);
        }

        [TestMethod]
        public void SingletonStatic_Test()
        {
            var singleton1 = SingletonStatic.Instance;
            var singleton2 = SingletonStatic.Instance;

            Assert.AreEqual(singleton1, singleton2);
        }

        [TestMethod]
        public void SingletonLazy_Test()
        {
            var singleton1 = SingletonLazy.Instance;
            var singleton2 = SingletonLazy.Instance;

            Assert.AreEqual(singleton1, singleton2);
        }
    }
    
}
