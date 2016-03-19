using NUnit.Framework;

using LGroup.NullObject.DataTransferObject;
using LGroup.NullObject.Business;
using LGroup.NullObject.Business.Base;
using System;

namespace LGroup.NullObject.Test
{
    [TestFixture]
    public sealed class DescontoTest
    {
        [Test]
        public void Testar_Produto()
        {
            var novoPRoduto = new ProdutoDTO();
            novoPRoduto.Codigo = 1;
            novoPRoduto.Nome = "Rexona ROllon";
            novoPRoduto.Valor = 99.20M;

            var dataAtual = new DateTime(2016, 03, 12);
            IBaseBusiness negocioProduto = null;
            if (dataAtual.ToString("ddMM") == "1206")
                negocioProduto = new DescontoNamoradoBusiness();
            else if (dataAtual.ToString("ddMM") == "2512")
                negocioProduto = new DescontoNatalBusiness();
            else
                negocioProduto = new DescontoNullObjectBusiness();
            //Temos um padrao do Martin Fowler (2009)
            //Padrao Null REference
            //A proposta do padrao 'e evitar tomar erros de NULL REFERENCE
            //Erros de NAO inicializacao de OBJETOS (Faltou dar new)
            //Erros sao pesados para a maquina CLR
            //Para nao dar erro de null, criamos um objeto default
            //com valores default
            //Uma classe qualquer, fazia so para dar erro de  null reference
            //Aonte tiver IF variavel == null ou TRY CATCH de NULL REFERENCE
            var novoValor = negocioProduto.CalcularDesconto(novoPRoduto.Valor);

            //Quando criamos uma variavel PAI (Super Tipo)
            //IBaseBUsiness, podemos dar NEW em qualquer classe filha 
            //Nas 3 classes de negocio, as 3 classes que herdam dela
            //Principio de Substituicao de Liskov (soLid)
            //Podemos inicializar qualquer filho dentro de um pai
            //BEM Flexivel, ABSTRAIDO
            //Um pai pode ser trocado por um filho

        }
    }
}
