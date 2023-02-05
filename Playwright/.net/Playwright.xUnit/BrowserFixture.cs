using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Playwright.xUnit
{
    public class BrowserFixture : IAsyncLifetime
    {
        private static readonly Task<IPlaywright> _launchPlaywright = Microsoft.Playwright.Playwright.CreateAsync();
        private IPlaywright _playwright;

        public IBrowser Browser { get; private set; }
        public static BrowserFixture? Current { get; private set; }

        public BrowserFixture()
        {
#pragma warning disable RCS1059 // Avoid locking on publicly accessible instance.
            lock (typeof(BrowserFixture))
            {
                if (Current != null) throw new InvalidOperationException("Only one instance is allowed.");
                Current = this;
            }
#pragma warning restore RCS1059 // Avoid locking on publicly accessible instance.
        }

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
