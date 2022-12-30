using Contact.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContController : ControllerBase
{
    private readonly IContactService contactService;

    public ContController(IContactService contactService)
    {
        this.contactService = contactService;
    }

    [HttpGet("{id}")]
    public ContactDTO Get(int id)
    {
        return contactService.GetContId(id);
    }
}