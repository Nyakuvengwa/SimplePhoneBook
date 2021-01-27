using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimplePhoneBook.Api.Models;
using SimplePhoneBook.Common.API;
using SimplePhoneBook.Data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePhoneBook.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneNumberTypeController : ControllerBase
    {
        private readonly IPhoneNumberTypeService _phoneNumberTypeService;
        private readonly IMapper _mapper;

        public PhoneNumberTypeController(IPhoneNumberTypeService phoneNumberTypeService, IMapper mapper)
        {
            _phoneNumberTypeService = phoneNumberTypeService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async  Task<ActionResult<List<PhoneNumberTypeModel>>> GetPhoneNumberTypes()
        {
            var phoneNumberTypes = await _phoneNumberTypeService.GetAllPhoneNumberTypes();
            return phoneNumberTypes.Select(type => _mapper.Map<PhoneNumberTypeModel>(type)).ToList();
        }
    }
}