using EM_Projeto.Models;
using EM_Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EM_Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlunoController : Controller
    {
        public RepositorioAluno _repositorioAluno;

        [HttpGet("/todos")]
        public async Task<IEnumerable<Aluno>> GetAll()
        {
            _repositorioAluno = new RepositorioAluno();
            return await _repositorioAluno.GetAll();
        }

        //[HttpGet("/verificacao")]
        //public async Task<IEnumerable<Aluno>> Get(AlunoModel predicate)
        //{
        //    _repositorioAluno = new RepositorioAluno();
        //    return await _repositorioAluno.Get();
        //}

        [HttpGet("/matricula")]
        public async Task<Aluno> GetByMatricula(int matricula)
        {
            _repositorioAluno = new RepositorioAluno();
            Aluno aluno = new()
            {
                Matricula = matricula
            };

            return await _repositorioAluno.GetByMatricula(aluno.Matricula);
        }

        [HttpGet("/partedonome")]
        public async Task<IEnumerable<Aluno>> GetByContendoNoNome(string parteDoNome)
        {
            _repositorioAluno = new RepositorioAluno();
            Aluno aluno = new()
            {
                Nome = parteDoNome
            };
            return await _repositorioAluno.GetByContendoNoNome(aluno.Nome);
        }

        [HttpPost("/adicionar")]
        public async Task Add(AlunoModel alunoModel)
        {
            _repositorioAluno = new RepositorioAluno();
            var aluno = new Aluno
            {
                Matricula = alunoModel.Matricula,
                Nome = alunoModel.Nome,
                CPF = alunoModel.CPF,
                Nascimento = alunoModel.Nascimento,
                Sexo = alunoModel.Sexo
            };

            await _repositorioAluno.Add(aluno);
        }

        [HttpPut("/atualizar")]
        public async Task Update(AlunoModel alunoModel)
        {
            _repositorioAluno = new RepositorioAluno();
            var aluno = new Aluno
            {
                Matricula = alunoModel.Matricula,
                Nome = alunoModel.Nome,
                CPF = alunoModel.CPF,
                Nascimento = alunoModel.Nascimento,
                Sexo = alunoModel.Sexo
            };

            await _repositorioAluno.Update(aluno);
        }

        [HttpDelete("/excluir")]
        public async Task Remove(AlunoModel alunoModel)
        {
            _repositorioAluno = new RepositorioAluno();
            var aluno = new Aluno
            {
                Matricula = alunoModel.Matricula
            };

            await _repositorioAluno.Remove(aluno);
        }

    }
}
