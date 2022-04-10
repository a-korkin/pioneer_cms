using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Attributes
{
    public class DescriptionAttribute : TableAttribute 
    {
        public DescriptionAttribute(
            string schema, 
            string name, 
            string title) : base(name)
        {
            Schema = schema;
            Title = title;
        } 

        public string Title { get; set; }
    }
}