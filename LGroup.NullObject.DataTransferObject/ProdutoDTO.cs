using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.NullObject.DataTransferObject
{
   public sealed class ProdutoDTO
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}
