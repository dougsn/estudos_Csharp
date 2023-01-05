using Microsoft.AspNetCore.Mvc;
using DevIO.App.ViewModels;
using DevIO.Business.Inferfaces;
using AutoMapper;
using AppMvcBasica.Models;

namespace DevIO.App.Controllers
{
    public class ProdutosController : BaseController
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutoRepository produtoRepository, IMapper mapper, IFornecedorRepository fornecedorRepository)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _fornecedorRepository = fornecedorRepository;
        }
        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            // Retornando uma lista de produto, com seu devido fornecedor (possivel por conta do mapeamento)
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(Guid id)
        {

            var produtoViewModel = await ObterProduto(id);

            if (produtoViewModel == null)
            {
                return NotFound();
            }

            return View(produtoViewModel);
        }

        // GET: Produtos/Create
        public async Task<IActionResult> Create()
        {            
            var produtoViewModel = await PopularFornecedores(new ProdutoViewModel());
            
            return View(produtoViewModel);
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProdutoViewModel produtoViewModel)
        {
            // Populando os Fornecedores com o que veio do objeto da VIEW
            produtoViewModel = await PopularFornecedores(produtoViewModel);
            
            // Verificando se o Objeto é nulo
            if (!ModelState.IsValid) return View(produtoViewModel);

            // Mapeando o Produto com o Modelo e persistindo na base de dados.
            await _produtoRepository.Adicionar(_mapper.Map<Produto>(produtoViewModel));

            return View(produtoViewModel);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(Guid id)
        {

            // Pegando o Objeto pelo ID e verificando se é nulo, se não for, entregue uma VIEW com os dados do Objeto
            var produtoViewModel = await ObterProduto(id);
            if (produtoViewModel == null)
            {
                return NotFound();
            }
            

            return View(produtoViewModel);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ProdutoViewModel produtoViewModel)
        {
            // Verificando se o ID do objeto é igual ao que foi passado por parâmetro
            if (id != produtoViewModel.Id) return NotFound();
          
             // Verificando se o objeto é valido ou não
            if (!ModelState.IsValid) return View(produtoViewModel);

            // Mapeando a model, para persistir na base de dados o objeto pego na VIEW
            await _produtoRepository.Atualizar(_mapper.Map<Produto>(produtoViewModel));
           
            return RedirectToAction("Index");
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            // Buscando o produto Pelo ID e redirecionando para a página de exclusão
            var produto = await ObterProduto(id);
            if (produto == null)
            {
                return NotFound();
            }


            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            // Obtendo o produto pelo ID, para verificar se é nulo
            var produto = await ObterProduto(id);
            if (produto == null)
            {
                return NotFound();
            }
            // Se não for nulo, remova da base de dados.
            await _produtoRepository.Remover(id);
            return RedirectToAction("Index");
        }

        private async Task<ProdutoViewModel> ObterProduto(Guid id)
        {
            // Mapeando um Produtoviewmodel, atraves do produtoFornecedor
            var produto = _mapper.Map<ProdutoViewModel>(await _produtoRepository.ObterProdutoFornecedor(id));

            // Mapeando uma lista de Fornecedores, busccando essas lista no repositório do Fornecedor.
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }

        private async Task<ProdutoViewModel> PopularFornecedores(ProdutoViewModel produto)
        {
            

            // A partir de qualquer view model que seja passada, é populado os fornecedores naquela viewmodel
            produto.Fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return produto;
        }
    }
}
