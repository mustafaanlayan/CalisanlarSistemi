using System.ComponentModel.DataAnnotations;

namespace CalisanBilgi.Common.VModel
{
   public class BaseVM
    {
        [Key]
        public int Id { get; set; }
    }
}
