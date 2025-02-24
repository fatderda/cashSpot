﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cashSpot.Data;
using cashSpot.Data.Models;

namespace cashSpot.Web.Pages.BudgetItems
{
    public class IndexModel : PageModel
    {
        private readonly cashSpot.Data.CashSpotContext _context;

        public IndexModel(cashSpot.Data.CashSpotContext context)
        {
            _context = context;
        }

        public IList<BudgetItem> BudgetItem { get;set; }

        public async Task OnGetAsync()
        {
            BudgetItem = await _context.BudgetItem.ToListAsync();
        }
    }
}
