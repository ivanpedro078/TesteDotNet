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
            List<UsuarioDTO>? usuariosDTO = new();

            foreach (var usuario in usuarios)
            {
                UsuarioDTO usuarioDTO = new(usuario);
                usuariosDTO.Add(usuarioDTO);
            }
            return usuariosDTO;
        }
       
    }

}
