using PagamentosDominioComparti.ValueObjects;

namespace PagamentosDominio.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(Endereco endereco, string numero, string vizinhanca, string cidade, string uF, string pais, string codigoPostal)
        {
            this.endereco = endereco;
            Numero = numero;
            Vizinhanca = vizinhanca;
            Cidade = cidade;
            UF = uF;
            Pais = pais;
            CodigoPostal = codigoPostal;

            AddNotifications(new Contract()
                .Requires() //Add demais validações
                .HasMinLen(endereco,"Endereco.endereco", "A Rua deve conter pelo menos 3 caracteres")
            );
        }

        public Endereco endereco { get; private set; }
        public string Numero { get; private set; }
        public string Vizinhanca { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
        public string CodigoPostal { get; private set; }
    }
}