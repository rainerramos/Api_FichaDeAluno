using ARF.Domain;

namespace ARF.Service
{
    public class ClientService
    {
        public void AddClient(Client client)
        {
            int age = DateTime.Today.Year - client.Birthday.Year;

            if(age >= 14)
            {
                if(client.CPF.Length != 11)
                {
                    throw new Exception("Invalid CPF");

                }
            }
            else
            {
                throw new Exception("Client must be 14 or older");
            }

        }
    }
}
