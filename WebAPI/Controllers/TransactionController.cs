using Business.Dto;
using Business.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        [Route("AddTransaction")]
        public ActionResult AddTransaction(TransactionRequest request)
        {
            var result = _transactionService.AddTransaction(request);
            return Ok(result);
        }
    }
}
