namespace CQRS_Mediator.Models
{
    public class ObjectModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }
    }
}
