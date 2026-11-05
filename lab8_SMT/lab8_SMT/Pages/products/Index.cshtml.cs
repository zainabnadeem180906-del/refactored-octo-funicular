using lab8_SMT.Data;
using lab8_SMT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab8_SMT.Pages.products
{
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _repository;

        public IndexModel(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Products { get; set; } = new();

        public async Task OnGetAsync()
        {
            Products = await _repository.GetAllAsync();
        }
    }
}
