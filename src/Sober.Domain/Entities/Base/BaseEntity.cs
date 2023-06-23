namespace Sober.Domain.Entities.Base
{
    public class BaseEntity <TKey> where TKey : struct
    {
        public TKey Id { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public string AuthorizeStatus { get; set; } = "U";
        public Guid? AuthorizedBy { get; set; }
        public DateTime? AuthorizedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
