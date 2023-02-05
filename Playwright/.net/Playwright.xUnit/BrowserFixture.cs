using Microsoft.Playwright;
using System.Threading.Tasks;
using Xunit;

namespace Playwright.xUnit
{
    public class BrowserFixture : IAsyncLifetime
    {
        private static readonly Task<IPlaywright> _launchPlaywright = Microsoft.Playwright.Playwright.CreateAsync();
        private IPlaywright _playwright;

        public IBrowser Browser { get; private set; }

        public virtual async Task InitializeAsync()
        {
            _playwright = await _launchPlaywright.ConfigureAwait(false);
            Browser = await _playwright.Chromium.LaunchAsync(new() { Headless = false });
        }

        public virtual async Task DisposeAsync()
        {
            await Browser.DisposeAsync();
            _playwright.Dispose();
        }
    }
}
