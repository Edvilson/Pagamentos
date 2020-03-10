using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentosDominio.Entidades;

namespace PagamentosDominioTeste
{
    [TestClass]
    public class TesteEstudante
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {   
            var assinatura = new Assinatura(null);
            var estudante = new Estudante("Edvilson","Almeida","1245124511","edvilson.ads@gmail.com","Tes");
            
        }
    }
}