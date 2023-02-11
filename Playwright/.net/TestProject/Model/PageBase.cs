namespace TestProject.Model
{
    public class PageBase
    {
        protected PageBase(IPage page, string url)
        {
            Page = page;
            Url = url;
        }

        public IPage Page { get; }
        public string Url { get; }

        public Task GotoAsync() => Page.GotoAsync(Url);
    }
}
