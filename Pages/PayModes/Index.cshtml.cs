using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Data.SqlClient;

namespace SupermarketWEB.Pages.PayModes
{
    public class IndexModel : PageModel
    {
		private readonly SupermarketContext _context;

		public IndexModel(SupermarketContext context)
		{
			_context = context;
		}

		public IList<PayMode> PayModes { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.PayModes != null)
			{
				PayModes = await _context.PayModes.ToListAsync();
			}
		}
	}
}
