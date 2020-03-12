using PagamentosDominioComparti.ValueObjects;

namespace PagamentosDominio.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco endereco { get; private set; }
        public string Numero { get; private set; }
        public string Vizinhanca { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
        public string CodigoPostal { get; private set; }
    }
}