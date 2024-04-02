using System;
using Entities.Model.Categories;

namespace Entities.Model.News
{
    public class New
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset UpdatedTime { get;set; }
        public DateTimeOffset PublishedTime { get; set; }
        public bool IsActive { get; set; }
    }
}
