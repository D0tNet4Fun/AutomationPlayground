using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Playwright.xUnit
{
    public class ContextFixture : IAsyncLifetime
    {
        private readonly IBrowser _browser;
        private IBrowserContext _context;

        public ContextFixture()
        {
            if (BrowserFixture.Current == null)
                throw new InvalidOperationException($"{nameof(BrowserFixture)} should be used as collection fixture inside a collection definition.");
            _browser = BrowserFixture.Current!.Browser;
        }

        public async Task InitializeAsync()
        {
            _context = await _browser.NewContextAsync();
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public Task<IPage> NewPageAsync() => _context.NewPageAsync();
    }
}
