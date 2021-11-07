using System.Threading.Tasks;
using Gpanga.Example.SDK;
using NUnit.Framework;

namespace Gpanga.Example.Tests
{
    public class Tests
    {

        [Test]
        public async Task MyService_SumTwoNumbers()
        {
            var service = new MyService();
            Assert.IsNotNull(await service.SendRequest());
        }
    }
}
