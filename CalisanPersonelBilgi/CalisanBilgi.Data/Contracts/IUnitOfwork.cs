using System;
using System.Collections.Generic;
using System.Text;

namespace CalisanBilgi.Data.Contracts
{
   public interface IUnitOfwork:IDisposable
   {
       void Save();
   }
}
