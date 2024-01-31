namespace KendoBarPocAPI.Models
{
    public class Root
    {
        public List<DataItemContainer>? Series { get; set; }
    }

    public class DataItemContainer
    {
        public List<DataItem>? Data { get; set; }
    }

    public class DataItem
    {
        public string? X { get; set; }
        public string? Value { get; set; }
    }

}
