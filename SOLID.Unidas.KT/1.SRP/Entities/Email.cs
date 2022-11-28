namespace _1.SRP
{
    public class Email
    {
        public string EmailCliente { get; set; }

        public bool Validar()
        {
            return EmailCliente.Contains("@");
        }
    }
}