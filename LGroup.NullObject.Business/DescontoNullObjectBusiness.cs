using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.NullObject.Business
{
    //Classe padrao para quando nao tiver data festiva
    public sealed class DescontoNullObjectBusiness : Base.IBaseBusiness
    {
        public decimal CalcularDesconto(decimal valorProduto_)
        {
            return valorProduto_;
        }
    }
}
