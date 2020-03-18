using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentosDominio.Entidades;
using PagamentosDominio.Enums;
using PagamentosDominio.ValueObjects;
using System;

namespace PagamentosDominioTeste
{
    [TestClass]
    public class TesteEstudante
    {
        private readonly Estudante _estudante;
        private readonly Assinatura _assinatura;
        private readonly Name _nome;
        private readonly Document _documento;
        private readonly Endereco _endereco;
        private readonly Email _email;


        public TesteEstudante()
        {          
          _nome = new Name("Edvilson", "Almeida");
          _documento = new Document("02088866051", EDocumentType.CPF);
          _email = new Email("edvilson.ads@gmail.com");
          _endereco = new Endereco("Av Prefeito Ary","145","142","Pelotas","RS","Brasil","1452");
          _estudante = new Estudante(_nome, _documento, _email);
          _assinatura = new Assinatura(null);

        }

        [TestMethod]
        public void RetornaErroSeAssinaturaAtiva()
        {  
          
          var pagamento = new PaypalPagamento("12345678", DateTime.Now, DateTime.Now.AddDays(5),10,10, _documento,"Edvilson Almeida", _endereco, _email);

          _assinatura.IncluirPagamento(pagamento);
          _estudante.IncluirAssinatura(_assinatura);
          _estudante.IncluirAssinatura(_assinatura);
          
          Assert.IsTrue(_estudante.Invalid);
            
        }

        [TestMethod]
        public void RetornarSuvessoSeAssinaturaInativa()
        {   
          
          var pagamento = new PaypalPagamento("12345678", DateTime.Now, DateTime.Now.AddDays(5),10,10, _documento,"Edvilson Almeida", _endereco, _email);

          _assinatura.IncluirPagamento(pagamento);
          _estudante.IncluirAssinatura(_assinatura);
          _estudante.IncluirAssinatura(_assinatura);
          
          Assert.IsTrue(_estudante.Valid);
            
        }

        [TestMethod]
        public void RetornaErroSeAssinaturaNaoTemPagamento()
        {  
                             
          _estudante.IncluirAssinatura(_assinatura);
          Assert.IsTrue(_estudante.Invalid);
            
        }
    }
}