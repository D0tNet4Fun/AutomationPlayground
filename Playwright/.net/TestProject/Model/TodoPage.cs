namespace TestProject.Model
{
    public class TodoPage : PageBase
    {
        public TodoPage(IPage page): base(page)
        {
        }

        public Task Open() => Page.GotoAsync("https://example.cypress.io/todo");

        public ILocator List => Page.Locator("css=.todo-list li");
    }
}
