using Microsoft.AspNetCore.Mvc;
using DevIO.App.ViewModels;
using DevIO.Business.Inferfaces;
using AutoMapper;
using AppMvcBasica.Models;

namespace DevIO.App.Controllers
{


    public class FornecedoresController : BaseController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

     

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            // Mapeando o FornecedorViewModel, para obter as informações da base de dados.
            return View(_mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos()));
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(Guid id)
        {

            // Obtendo as informações do Fornecedor, com base na ID e verificando se é nulo
            var fornecedorViewModel = await ObterFornecedorEndereco(id);
            if (fornecedorViewModel == null)
            {
                return NotFound();
            }

            // Se não for nulo, redirecionado para a View com as informações do Fornecedor
            return View(fornecedorViewModel);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FornecedorViewModel fornecedorViewModel)
        {
            // Verificando se o modelo é invalido, se for, redireciona uma View com os dados.
            if (!ModelState.IsValid) return View(fornecedorViewModel);

            // Mapeando o Fornecedor
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            
            // Persistindo os dados no banco de dados, com base no mapeamento feito
            await _fornecedorRepository.Adicionar(fornecedor);

            return RedirectToAction("Index");
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {
           
            // explicação no final do código
            var fornecedorViewModel = await ObterFornecedorProdutosEndereco(id);

            // Verificando se o modelo está nulo, se sim, retorar notfound (404)
            if (fornecedorViewModel == null)
            {
                return NotFound();
            }
            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, FornecedorViewModel fornecedorViewModel)
        {
            if (id != fornecedorViewModel.Id) return NotFound();

            // Se a Model for invalida, retorne uma View com os dados do fornecedor.
            if (!ModelState.IsValid) return View(fornecedorViewModel);

            // Foi mapeado o Fornecedor, com base na Model, e persistiu no banco com ela montada e redirecionou para a Index.
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorRepository.Atualizar(fornecedor);

            return RedirectToAction("Index");
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var fornecedorViewModel = await ObterFornecedorEndereco(id);

            if (fornecedorViewModel == null)
            {
                return NotFound();
            }


            return View(fornecedorViewModel);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            // Foi no banco de dados, verificou se o fornecedor, com base na ID, é nulo, se não for, pode deletar.
            
            var fornecedorViewModel = await ObterFornecedorEndereco(id);

            if (fornecedorViewModel == null) return NotFound();

            await _fornecedorRepository.Remover(id);


            return RedirectToAction("Index");
        }

        private async Task<FornecedorViewModel> ObterFornecedorEndereco(Guid id)
        {
            // Mapeou o FornecedorViewModel e pegou o fornecedor e endereco, com base na ID passada por parâmetro
            return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorEndereco(id));
        }

        private async Task<FornecedorViewModel> ObterFornecedorProdutosEndereco(Guid id)
        {
            // Mapeou o FornecedorViewModel e pegou o fornecedor / produtos / endereco, com base na ID passada por parâmetro
            return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorProdutosEndereco(id));
        }
    }
}
