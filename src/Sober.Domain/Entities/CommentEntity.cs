using Sober.Domain.Entities.Base;

namespace Sober.Domain.Entities
{
    public class CommentEntity : BaseEntity<Guid>
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public DateTime CommentDate { get; set; }
        public string UserComment { get; set; }
        public string UserPicture { get; set; }

    }
}
