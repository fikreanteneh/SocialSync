
namespace Domain.Entities
{
    public class Follow
    {
        public required int FollowerId { get; set; }
        public required int FollowedId { get; set; }
        public virtual User? Follower{ get; set; }
        public virtual User? Followed{ get; set; }
    }
}