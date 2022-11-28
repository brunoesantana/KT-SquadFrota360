namespace _1.SRP
{
    public class Cpf
    {
        public string CpfCliente { get; set; }

        public bool Validar()
        {
            return CpfCliente.Trim().Length == 11;
        }
    }
}