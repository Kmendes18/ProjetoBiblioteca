using System.Linq;
using Biblioteca.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("Login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificarLoginSenha(string Login, string senha, Controller controller)
        {
          using (BibliotecaContext bc = new BibliotecaContext())     
            {
                verificaSeUsuarioAdminExiste(bc);
                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.login==Login && u.senha == senha);
                List<Usuario> ListaUsuarioEncontrado = UsuarioEncontrado.ToList();
                
                if (ListaUsuarioEncontrado.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("Login", ListaUsuarioEncontrado[0].login);
                    controller.HttpContext.Session.SetString("Nome", ListaUsuarioEncontrado[0].nome);
                    controller.HttpContext.Session.SetInt32("Tipo", ListaUsuarioEncontrado[0].Tipo);
                    return true;
                }
            }
        }

        internal static bool verificarLoginSenha(Func<IActionResult> login, string senha, HomeController homeController)
        {
            throw new NotImplementedException();
        }

        public static void verificaSeUsuarioAdminExiste (BibliotecaContext bc)
        {
           IQueryable<Usuario> UserEncontrado = bc.Usuarios.Where(u => u.login== "admin");

            if (UserEncontrado.ToList().Count == 0)
            {
                Usuario admin = new Usuario ();
                admin.login = "admin";
                admin.senha = Criptografo.TextoCriptografado("123");
                admin.Tipo = Usuario.Admin;
                admin.nome = "Administrador";

                bc.Usuarios.Add(admin);
                bc.SaveChanges();
            }
        }

        public static void verificaSeUsuarioAdmin (Controller controller)
        {
            if(!(controller.HttpContext.Session.GetInt32("Tipo") == Usuario.Admin))
            {
                controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");
            }
        }
    }
}