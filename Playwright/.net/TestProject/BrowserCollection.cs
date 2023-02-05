using Playwright.xUnit;

namespace TestProject;

[CollectionDefinition("pageTests")]
public class BrowserCollection : ICollectionFixture<BrowserFixture>
{

}