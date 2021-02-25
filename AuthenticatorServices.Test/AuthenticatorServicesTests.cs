using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace AuthenticatorServices.Test
{
    public interface ITestClient
    {
        Task<HttpResponseMessage> GetAsync();
    }

    public class TestClient: ITestClient
    {
        private readonly HttpClient _client;
        public TestClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> GetAsync()
        {
            return await _client.GetAsync("http://google.com");
        }
    }

    public class AuthenticatorServicesTests
    {
        private readonly ITestClient _client;
        public AuthenticatorServicesTests(ITestClient client)
        {
            _client = client;
        }

        [Fact]
        public async Task Test1()
        {
            Assert.NotNull(await _client.GetAsync());
        }
    }
}
