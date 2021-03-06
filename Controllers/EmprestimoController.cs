using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace Biblioteca.Controllers
{

    public class EmprestimoController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            LivroService livroService = new LivroService();
            EmprestimoService emprestimoService = new EmprestimoService();

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarDisponiveis();
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadEmprestimoViewModel viewModel)
        {
            Autenticacao.CheckLogin(this);
            EmprestimoService emprestimoService = new EmprestimoService();

            if (viewModel.Emprestimo.Id == 0)
            {
                emprestimoService.Inserir(viewModel.Emprestimo);
            }

            else
            {
                emprestimoService.Atualizar(viewModel.Emprestimo);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro, string itensPorPagina, int numDaPagina, int paginaAtual)
        {
            Autenticacao.CheckLogin(this);
            FiltrosEmprestimos objFiltro = null;
            if (!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosEmprestimos();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            
            ViewData["emprestimosPorPagina"] = (string.IsNullOrEmpty(itensPorPagina) ? 10 : Int32.Parse(itensPorPagina));
            ViewData["paginaAtual"] = (paginaAtual != 0 ? paginaAtual : 1);
            EmprestimoService emprestimoService = new EmprestimoService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            LivroService livroService = new LivroService();
            EmprestimoService em = new EmprestimoService();
            Emprestimo e = em.ObterPorId(id);

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarDisponiveis();
            cadModel.Emprestimo = e;

            return View(cadModel);
        }

        // Criado uma exclus??o para casa haja alguma devolu????o dos livros 

        /*
               (Subsituir "Cadastro" por "edi????o" no form do arquivo /Views/Emprestimos/Edicao.cshtml)
                (Retirar condi????o if/eslse do m??todo httpPost de "Cadastro" e deixar apneas a fun????o de inserir )
                [HttpPost]
                public IActionResult Edicao(CadEmprestimoViewModel viewModel)
                {
                    //DONE
                  Autenticacao.CheckLogin(this);
                    EmprestimoService emprestimoService = new EmprestimoService();

                    if (viewModel.Emprestimo.Devolvido == true)
                    {
                        emprestimoService.excluirEmprestimo(viewModel.Emprestimo.Id);
                    }
                    else
                    {
                        emprestimoService.Inserir(viewModel.Emprestimo);
                    }
                    return RedirectToAction("Listagem");

                }
        */
    }
}