using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Biblioteca.Controllers
{

    public class UsuarioController : Controller
    {
        public IActionResult Listagem()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            return View(new UsuarioService().Listar());
        }

        public IActionResult CadastroUsuario()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            return View();
        }


        [HttpPost]
        public IActionResult CadastroUsuario(Usuario u)
        {
            u.senha = Criptografo.TextoCriptografado(u.senha);
            new UsuarioService().Inserir(u);
            return RedirectToAction("CadastroSucesso");

        }

        public IActionResult EditarUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }


        [HttpPost]
        public IActionResult EditarUsuario(Usuario u)
        {
            u.senha = Criptografo.TextoCriptografado(u.senha);

            new UsuarioService().Atualizar(u);
            return RedirectToAction("Listagem");

        }

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult NeedAdmin()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
        public IActionResult CadastroSucesso()
        {
            return View();
        }

        public IActionResult ExcluirUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            return View(new UsuarioService().Listar(id));
        }
        [HttpPost]
        public IActionResult ExcluirUsuario(string decisao, int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);

            if (decisao == "EXCLUIR")
            {
                new UsuarioService().Excluir(id);
            }
            return View("ConfirmacaoExclusao");
            
        }

    }
}