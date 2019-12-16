using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Criistal.Data;
using Criistal.Models;

namespace Criistal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPermissionsController : ControllerBase
    {
        private readonly CriistalContext _context;

        public UserPermissionsController(CriistalContext context)
        {
            _context = context;
        }

        // GET: api/UserPermissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPermission>>> GetUserPermission()
        {
            return await _context.UserPermission.ToListAsync();
        }

        // GET: api/UserPermissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserPermission>> GetUserPermission(int id)
        {
            var userPermission = await _context.UserPermission.FindAsync(id);

            if (userPermission == null)
            {
                return NotFound();
            }

            return userPermission;
        }

        // PUT: api/UserPermissions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPermission(int id, UserPermission userPermission)
        {
            if (id != userPermission.ID)
            {
                return BadRequest();
            }

            _context.Entry(userPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserPermissionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserPermissions
        [HttpPost]
        public async Task<ActionResult<UserPermission>> PostUserPermission(UserPermission userPermission)
        {
            _context.UserPermission.Add(userPermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserPermission", new { id = userPermission.ID }, userPermission);
        }

        // DELETE: api/UserPermissions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<UserPermission>> DeleteUserPermission(int id)
        {
            var userPermission = await _context.UserPermission.FindAsync(id);
            if (userPermission == null)
            {
                return NotFound();
            }

            _context.UserPermission.Remove(userPermission);
            await _context.SaveChangesAsync();

            return userPermission;
        }

        private bool UserPermissionExists(int id)
        {
            return _context.UserPermission.Any(e => e.ID == id);
        }
    }
}
