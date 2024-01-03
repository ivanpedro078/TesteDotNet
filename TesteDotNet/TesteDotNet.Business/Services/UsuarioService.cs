using TesteDotNet.Business.DTOs;
using TesteDotNet.Repository.Context;
using TesteDotNet.Repository.Entities;

namespace TesteDotNet.Business.Services
{
    public class UsuarioService
    {
        private readonly UsuarioContext _usuarioContext;

        public UsuarioService(UsuarioContext usuarioContext)
        {
            _usuarioContext = usuarioContext;
        }

        public List<UsuarioDTO>? BuscarUsuarios()
        {
            List<Usuarios>? usuarios = _usuarioContext.Usuarios.ToList();
            if (!usuarios.Any()) throw new Exception("Não foram encontrados usuários");
            List<UsuarioDTO>? usuariosDTO = new();

            foreach (var usuario in usuarios)
            {
                UsuarioDTO usuarioDTO = new(usuario);
                usuariosDTO.Add(usuarioDTO);
            }
            return usuariosDTO;
        }
       public UsuarioDTO? BuscarUsuarioPorCpf(string cpf)
        {
            Usuarios? usuario = _usuarioContext.Usuarios.Where(e => e.cpf == cpf).FirstOrDefault();
            if (usuario == null) throw new Exception("Usuário não encontrado.");
            UsuarioDTO? usuarioDTO = new(usuario);
            return usuarioDTO;
        }
    }

}
