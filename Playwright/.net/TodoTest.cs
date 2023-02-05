namespace TestProject;

public class TodoTest
{
    [Fact]
    public async Task Todo()
    {
        // infrastructure
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new() { Headless = false });
        await using var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();
        // test
        await page.GotoAsync("https://example.cypress.io/todo");
        var list = page.Locator("css=.todo-list li");
        await Expect(list).ToHaveCountAsync(2);
        var items = await list.AllAsync();
        await Expect(items[0]).ToContainTextAsync("Pay electric bill");
        await Expect(items[1]).ToContainTextAsync("Walk the dog");
    }
}