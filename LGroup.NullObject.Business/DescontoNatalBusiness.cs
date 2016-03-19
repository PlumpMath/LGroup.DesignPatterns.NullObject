using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.NullObject.Business
{
    public sealed class DescontoNatalBusiness : Base.IBaseBusiness
    {
        public decimal CalcularDesconto(decimal valorProduto_)
        {
            return valorProduto_ + 200;
        }
    }
}
