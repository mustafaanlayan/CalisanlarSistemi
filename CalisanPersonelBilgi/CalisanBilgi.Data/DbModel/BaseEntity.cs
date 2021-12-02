using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CalisanBilgi.Data.DbModel
{
  public  class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
