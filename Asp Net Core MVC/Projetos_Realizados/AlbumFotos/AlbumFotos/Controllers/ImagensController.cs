using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlbumFotos.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AlbumFotos.Controllers
{
    public class ImagensController : Controller
    {
        private readonly Contexto _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImagensController(Contexto context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

       
        // GET: Imagens/Create
        public IActionResult Create(int id)
        {
            ViewBag.Destinos = _context.Albuns.FirstOrDefault(x => x.AlbumId == id);
            return View();
        }

        // POST: Imagens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ImagemId,Link,AlbumId")] Imagem imagem, IFormFile arquivo)
        {
            if (ModelState.IsValid)
            {
                var linkUpload = Path.Combine(_hostingEnvironment.WebRootPath, "Imagens");
                if(linkUpload != null)
                {
                    using (var fileStream = new FileStream(Path.Combine(linkUpload, arquivo.FileName), FileMode.Create))
                    {
                        await arquivo.CopyToAsync(fileStream);
                        imagem.Link = "~/Imagens/" + arquivo.FileName;
                    }
                }

                _context.Add(imagem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details/", "Albuns", new { id = imagem.AlbumId });
            }
            ViewData["AlbumId"] = new SelectList(_context.Albuns, "AlbumId", "Destino", imagem.AlbumId);
            return View(imagem);
        }

       
    }
}
