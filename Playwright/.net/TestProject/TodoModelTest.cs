using Playwright.xUnit;
using TestProject.Model;

namespace TestProject;

public class TodoModelTest : PageTest
{
    private TodoPage _todoPage;

    public TodoModelTest(ContextFixture context) : base(context)
    {
    }

    public override async Task InitializeAsync()
    {
        await base.InitializeAsync();
        _todoPage = new TodoPage(Page);
    }

    [Fact]
    public async Task TodoUsingModel()
    {
        await _todoPage.GotoAsync();
        await Expect(_todoPage.List).ToHaveCountAsync(2);
        var items = await _todoPage.List.AllAsync();
        await Expect(items[0]).ToContainTextAsync("Pay electric bill");
        await Expect(items[1]).ToContainTextAsync("Walk the dog");
    }
}
