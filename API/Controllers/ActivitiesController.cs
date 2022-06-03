using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {g
        [HttpGet]
        public async Task<ActionResult<List<Activity>>>GetActivities()
        {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] 
        public async Task<ActionResult<Activity>>GetActivity(Guid id)
        {
            return await _context.FindAsync<Activity>(id);
        }
    }
}