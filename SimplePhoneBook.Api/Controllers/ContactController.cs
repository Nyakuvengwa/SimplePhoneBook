﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimplePhoneBook.Api.Models;
using SimplePhoneBook.Common.API;
using SimplePhoneBook.Data.Entites;
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
            var contacts = await _contactService.GetAllContactsAsync();
            return contacts.Select(contact => _mapper.Map<ContactModel>(contact)).ToList();
        }

        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ContactModel>> SaveContact(ContactModel contactModel)
        {
            try
            {
                var contact = _mapper.Map<Contact>(contactModel);
                var savedContact = await _contactService.AddContactAsync(contact);
                return _mapper.Map<ContactModel>(savedContact);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ContactModel>> UpdateContact(ContactModel contactModel)
        {
            try
            {
                var contact = _mapper.Map<Contact>(contactModel);
                var savedContact = await _contactService.UpdateContactAsync(contact);
                return _mapper.Map<ContactModel>(savedContact);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
    }
}
