﻿using SistemaVenta.DTO;

namespace SistemaVenta.BLL.Servicios.Contrato
{
    public interface IUsuarioService
    {
            Task<List<UsuarioDTO>> ListaUsuarios();
            Task<SesionDTO> ValidarCredenciales(string correo , string clave);
            Task<UsuarioDTO> Crear(UsuarioDTO modelo);
            Task<bool>Editar(UsuarioDTO modelo);
            Task<bool> Eliminar(int id);

        

    }
}
