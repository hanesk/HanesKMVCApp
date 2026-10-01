
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HanesKMVCApp.Models;

public class MembersController : Controller
{
    private readonly MembersContext _context;

    public MembersController(MembersContext context)
    {
        _context = context;
    }

    // GET: MEMBERSS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Membership.ToListAsync());
    }

    // GET: MEMBERSS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var members = await _context.Membership
            .FirstOrDefaultAsync(m => m.ID == id);
        if (members == null)
        {
            return NotFound();
        }

        return View(members);
    }

    // GET: MEMBERSS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: MEMBERSS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,GenderIdentity,Address,City,State,Zip,Email,Cell")] Members members)
    {
        if (ModelState.IsValid)
        {
            _context.Add(members);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(members);
    }

    // GET: MEMBERSS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var members = await _context.Membership.FindAsync(id);
        if (members == null)
        {
            return NotFound();
        }
        return View(members);
    }

    // POST: MEMBERSS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("ID,FirstName,LastName,GenderIdentity,Address,City,State,Zip,Email,Cell")] Members members)
    {
        if (id != members.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(members);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembersExists(members.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(members);
    }

    // GET: MEMBERSS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var members = await _context.Membership
            .FirstOrDefaultAsync(m => m.ID == id);
        if (members == null)
        {
            return NotFound();
        }

        return View(members);
    }

    // POST: MEMBERSS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var members = await _context.Membership.FindAsync(id);
        if (members != null)
        {
            _context.Membership.Remove(members);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool MembersExists(int? id)
    {
        return _context.Membership.Any(e => e.ID == id);
    }
}
