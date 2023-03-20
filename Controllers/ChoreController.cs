using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chore.Controllers
{
    [ApiController]
    [Route("api/chore")]
    public class ChoreController : ControllerBase
    {
        
        private readonly ChorseService _choreService;

    public ChoreController(ChorseService choreService)
    {
      _choreService = choreService;
    }

    [HttpGet]
    public ActionResult<List<Chore>> getAllChores() {
        try 
        {
            List<Chore> Chores = _choreService.getAllChores();
            return Chores;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet ("{choreName}")]
    public ActionResult<Chore> getChoreByName(string choreName){
        try 
        {
            Chore chore = _choreService.getChoreByName(choreName);
            return chore;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut ("{choreName}")]
    public ActionResult<String> completeChore(string choreName){
        try 
        {
            _choreService.completeChore(choreName);
            string result = $"{choreName} is complete";
            return result;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete ("{choreName}")]
    public ActionResult<String> deletedChore(string choreName){
        try 
        {
            _choreService.deleteChore(choreName);
            string result = $"{choreName} has been deleted";
            return result;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chore> createChore([FromBody] Chore choreData ){
        try 
        {
            Chore chore = _choreService.createChore(choreData);
            return chore;
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    }
}