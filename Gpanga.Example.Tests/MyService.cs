using Gpanga.Example.SDK;
using NUnit.Framework;

namespace Gpanga.Example.Tests
{
    public class Tests
    {

        [Test]
        public void MyService_SumTwoNumbers()
        {
            Assert.AreEqual(MyService.Sum(2, 4), 6);
        }
    }
}
