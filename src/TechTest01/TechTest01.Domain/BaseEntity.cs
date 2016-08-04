
using System.ComponentModel.DataAnnotations;

namespace TechTest01.Domain
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
