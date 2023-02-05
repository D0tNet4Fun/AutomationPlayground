using Playwright.xUnit;

namespace TestProject;

public class TodoTest : PageTest
{
    public TodoTest(ContextFixture context) : base(context)
    {
    }

    [Fact]
    public async Task Todo()
    {
        await Page.GotoAsync("https://example.cypress.io/todo");
        var list = Page.Locator("css=.todo-list li");
        await Expect(list).ToHaveCountAsync(2);
        var items = await list.AllAsync();
        await Expect(items[0]).ToContainTextAsync("Pay electric bill");
        await Expect(items[1]).ToContainTextAsync("Walk the dog");
    }
}