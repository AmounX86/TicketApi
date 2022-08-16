using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketApi.DAL;
using TicketApi.Models;

namespace TicketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly TicketContext _context;
        public TicketController(TicketContext context)
        {
            _context = context;
        }

        [HttpGet("{page}")]   
        public  async Task<ActionResult<IEnumerable<Ticket>>> Index(int page) 
        {
            IQueryable<Ticket> tickets = _context.Tickets.AsQueryable();
            int totalNumber = tickets.Count();
            tickets = tickets.Skip(page * 5).Take(5);
            return await tickets.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Ticket>> CreateTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }
        //[HttpGet("GovernorateList")]
        //public async Task<ActionResult<>>

        
        [HttpGet("GovList")]
        public ActionResult<IEnumerable<string>> GetGovs()
        {
            return Governorates.ToList();
        }
        [HttpGet("CityList")]
        public ActionResult<IEnumerable<string>> GetCities()
        {
            return Cities.ToList();
        }
        [HttpGet("DistrictList")]
        public ActionResult<IEnumerable<string>> GetDistricts()
        {
            return Districts.ToList();
        }


        private static readonly string[] Governorates = new[]
        {
            "Cairo", "Alexandria", "Aswan", "Asiut", "Giza", "Sohag"
        };

        private static readonly string[] Cities = new[]
        {
            "Cairo", "Alexandria", "Aswan", "Asiut", "Giza", "Sohag"
        };

        private static readonly string[] Districts = new[]
        {
            "District_1", "District_2", "District_3", "District_4", "District_5", "District_6",
            "District_7", "District_8", "District_9", "District_10", "District_11", "District_12"
        };

    }
}
