namespace _1.SRP
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            AddCliente(cliente);

            SendEmail(cliente.Email.EmailCliente);

            return "Cliente cadastrado com sucesso";
        }

        public void AddCliente(Cliente cliente)
        {
            var repository = new ClienteRepository();
            repository.AdicionarCliente(cliente);
        }

        public void SendEmail(string emailCliente)
        {
            new EmailServices().Enviar(emailCliente);
        }
    }
}