
namespace Domain.Entities
{
    public class Like
    {
        public required int UserId { get; set; }
        public required int PostId { get; set; }
        public virtual User? User{ get; set; }
        public virtual Post? Post{ get; set; }
    }
}
