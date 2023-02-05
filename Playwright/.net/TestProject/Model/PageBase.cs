namespace TestProject.Model
{
    public class PageBase
    {
        protected PageBase(IPage page)
        {
            Page = page;
        }

        public IPage Page { get; }
    }
}
