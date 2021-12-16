﻿using Api.Data;
using Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
   [Route("api/[controller]")] // api/Users
   [ApiController]
   public class UsersController : ControllerBase
   {
      private readonly DataContext _context;

      public UsersController(DataContext context)
      {
         _context = context;
      }

      [HttpGet] // api/Users
      public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
      {
         return await _context.Users.ToListAsync();
      }

      [HttpGet("{id}")] // api/Users/1
      public async Task<ActionResult<AppUser>> GetUser(int id)
      {
         return await _context.Users.FindAsync(id);
      }

      
   }
}
