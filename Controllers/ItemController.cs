using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RicherBE.Models;

namespace RicherBE.Controllers
  {
  [Route("api/[controller]")]
  [ApiController]
  public class ItemController : ControllerBase
    {
    [HttpGet]
    [Route("item") ]
    public async Task<ActionResult> GetAllItems ()
      {
      return await _itemService.GetAllItems();
      }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetSingleItem (int id)
      {
      var result = await _itemService.GetSingleItem(id);
      if(result is null)
        return NotFound("Item Not Found")
      return Ok(result);
      }

    [HttpPost]
    public async Task<ActionResult> AddItem ()
      {
      var result = await _itemService.AddItem();
      return Ok(result);
      }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteItem(int id)
      {
      var result = await _itemService.DeleteItem(id);
      if ( result is null )
        return NotFound("Item not found");
      return Ok(result);
      }


    }
  }
