using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimplePhoneBook.Api.Models;
using SimplePhoneBook.Common.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        private readonly ILogger<ContactController> _logger;

        public ContactController(IContactService contactService, IMapper mapper, ILogger<ContactController> logger)
        {
            _contactService = contactService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ContactModel>>> GetAllContacts()
        {
            var contacts = await _contactService.GetAllContacts();
            return contacts.Select(contact => _mapper.Map<ContactModel>(contact)).ToList();
        }
    }
}
