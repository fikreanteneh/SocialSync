
using Domain.Common;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public required string Content { get; set; }
        public required int UserId { get; set; }
        public required int PostId { get; set; }
        public required DateTime UpdatedAt{ get; set; }
        public virtual User? User{ get; set; }
        public virtual Post? Post{ get; set; }
    }
}
