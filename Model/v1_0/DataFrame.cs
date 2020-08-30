namespace AspNetCoreTemplate.Model.v1_0
{
    public class DataFrame<TItem>
        where TItem : class
    {
        public TItem[] Items { get; set; }
        public bool HasNext { get; set; }
    }
}