using TesteDotNet.Repository.Entities;

namespace TesteDotNet.Business.DTOs
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public long? telefone { get; set; }
        public long celular { get; set; }
        public bool isWhatsApp { get; set; }
        public DateTime dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public DateTime? dataExclusao { get; set; }
        public bool isExcluido { get; set; }

        public UsuarioDTO(Usuarios usuarios)
        {
            id = usuarios.id;
            usuario = usuarios.usuario;
            dataNascimento = usuarios.dataNascimento;
            cpf = usuarios.cpf;
            email = usuarios.email;
            telefone = usuarios.telefone;
            celular = usuarios.celular;
            isWhatsApp = usuarios.isWhatsApp;
            dataInclusao = usuarios.dataInclusao;
            dataAlteracao = usuarios.dataAlteracao;
            dataExclusao = usuarios.dataExclusao;
            isExcluido = usuarios.isExcluido;
        }
    }
}
