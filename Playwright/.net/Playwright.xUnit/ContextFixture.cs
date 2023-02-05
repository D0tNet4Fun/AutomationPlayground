using Microsoft.Playwright;
using System.Threading.Tasks;

namespace Playwright.xUnit
{
    public class ContextFixture : BrowserFixture
    {
        private IBrowserContext _context;

        public override async Task InitializeAsync()
        {
            await base.InitializeAsync();
            _context = await Browser.NewContextAsync();
        }

        public override async Task DisposeAsync()
        {
            await _context.DisposeAsync();
            await base.DisposeAsync();
        }

        public Task<IPage> NewPageAsync() => _context.NewPageAsync();
    }
}
