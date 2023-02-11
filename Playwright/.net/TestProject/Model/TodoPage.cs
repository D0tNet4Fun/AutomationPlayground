namespace TestProject.Model
{
    public class TodoPage : PageBase
    {
        public TodoPage(IPage page)
            : base(page, "https://example.cypress.io/todo")
        {
        }

        public ILocator List => Page.Locator("css=.todo-list li");
    }
}
