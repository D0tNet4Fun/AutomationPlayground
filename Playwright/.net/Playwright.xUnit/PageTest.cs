using Microsoft.Playwright;
using System.Threading.Tasks;
using Xunit;

namespace Playwright.xUnit
{
    [Collection("pageTests")]
    public class PageTest : IClassFixture<ContextFixture>, IAsyncLifetime
    {
        private ContextFixture _context;

        public PageTest(ContextFixture context)
        {
            _context = context;
        }

        public IPage Page { get; private set; }

        public Task DisposeAsync() => Task.CompletedTask;

        public async Task InitializeAsync()
        {
            Page = await _context.NewPageAsync().ConfigureAwait(false);
        }
    }
}
