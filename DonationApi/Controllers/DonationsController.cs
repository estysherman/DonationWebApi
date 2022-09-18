using DonationApi.Models;
using DonationApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DonationApi.Controllers
{
    [Route("api/donations")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private readonly ITrumaRepository _trumaRepository;
        
        public DonationsController(ITrumaRepository trumaRepository)
        {
            _trumaRepository = trumaRepository;

        }


        [HttpPost("UpsertTruma")]
        public ActionResult<Truma> UpsertTruma(Truma truma)
        {
            if (truma != null && truma.Id > -1) //UPDATE
            {
                var trumaToUpdate = _trumaRepository.UpdateTruma(truma);

                if (trumaToUpdate != null)
                {
                    return Ok(trumaToUpdate);
                } 
                else
                {
                    return BadRequest();
                }
            } 
            else //INSERT
            {
                var newTruma = _trumaRepository.InsertTruma(truma);

                return Ok(newTruma);
            }            
        }

        [HttpGet("trumot")]
        public ActionResult<List<Truma>> GetTrumot()
        {
            var trumot = _trumaRepository.GetTrumot();
            return Ok(trumot);
        }
    }
}
