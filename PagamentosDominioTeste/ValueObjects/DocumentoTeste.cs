using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentosDominio.Entidades;
using PagamentosDominio.ValueObjects;

using PagamentosDominio.Enums;

namespace PagamentosDominioTeste
{
    [TestClass]
    public class DocumentoTeste
    {
        //Red, Green, Refactory
        [TestMethod]
        public void RetornaErroQuandoCNPJInvalido()
        {  
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
            
            
        }

        [TestMethod]
        public void RetornaSucessoQuandoCNPJValido()
        {  
            
           var doc = new Document("34110468000150", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
            
        }

         [TestMethod]
        public void RetornaErroQuandoCPFInvalido()
        {  
            
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
            
        }

        [TestMethod]
        public void RetornaSucessoQuandoCPFValido()
        {  
            
            var doc = new Document("02088866051", EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
            
        }
    }
}