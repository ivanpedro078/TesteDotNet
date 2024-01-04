using TesteDotNet.Repository.Entities;

namespace TesteDotNet.Business.DTOs
{
    public class UsuarioDTO
    {
        public string usuario { get; set; }
        public string dataNascimento { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public long? telefone { get; set; }
        public long celular { get; set; }
        public bool isWhatsApp { get; set; }


        public UsuarioDTO(Usuarios usuarios)
        {
            usuario = usuarios.usuario;
            dataNascimento = usuarios.dataNascimento.ToString("dd/mm/yyyy");
            cpf = usuarios.cpf;
            email = usuarios.email;
            telefone = usuarios.telefone;
            celular = usuarios.celular;
            isWhatsApp = usuarios.isWhatsApp;
        }

      



        //internal void Add(UsuarioDTO usuarioDTO)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
