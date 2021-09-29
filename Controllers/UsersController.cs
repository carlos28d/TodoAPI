using TodoApi.API.Entities;
using TodoApi.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
      public UsersController(DataContext context)
      {
            _context = context;
      }  

      [AllowAnonymous]
      [HttpGet]
      public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
      {
          return await _context.Users.ToListAsync();
      }

      [Authorize]
      [HttpGet("{id}")]
      [Route("{id}")]
      public async Task<ActionResult<AppUser>> GetUser(int id)
      {
          return await _context.Users.FindAsync(id);
      }
    }
}