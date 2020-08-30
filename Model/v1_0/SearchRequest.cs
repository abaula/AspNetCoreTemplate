namespace AspNetCoreTemplate.Model.v1_0
{
    public class SearchRequest
    {
        public string Query { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}