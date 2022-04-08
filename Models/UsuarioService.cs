using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Biblioteca.Models
{

    public class UsuarioService
    {
        public void Inserir(Usuario user)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Add(user);
                bc.SaveChanges();
            }
        }

        public void Atualizar(Usuario userEditado)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(userEditado.Id);
                usuario.nome = userEditado.nome;
                usuario.login = userEditado.login;
                usuario.senha = userEditado.senha;
                usuario.Tipo = userEditado.Tipo;

                bc.SaveChanges();
            }
        }


        public List<Usuario> Listar()
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList();
            }

        }

        public Usuario Listar(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }

        }

        internal void Editar(Usuario u)
        {
            throw new NotImplementedException();
        }

       // public Usuario ObterPorId(int id)
        //{
          //  using (BibliotecaContext bc = new BibliotecaContext())
            //{
              //  return bc.Usuarios.Find(id);
            //}
        //}

        public void Excluir(int id)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }
        }

        internal void ExcluirUsuario(int id)
        {
            throw new NotImplementedException();
        }

        internal void excluirUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
