using System.Threading.Tasks;
using Gpanga.Example.SDK;
using NUnit.Framework;

namespace Gpanga.Example.Tests
{
    public class Tests
    {

        [Test]
        public async Task MyService_SendsCorrectly_Request()
        {
            var service = new MyService();
            Assert.IsNotNull(await service.SendRequest("https://mock.codes/200"));
        }
    }
}
