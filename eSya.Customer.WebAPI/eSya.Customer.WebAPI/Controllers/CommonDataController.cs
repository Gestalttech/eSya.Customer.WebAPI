using eSya.Customer.IF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSya.Customer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommonDataController : ControllerBase
    {
        private readonly ICommonDataRepository _CommonDataRepository;
        public CommonDataController(ICommonDataRepository CommonDataRepository)
        {
            _CommonDataRepository = CommonDataRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetApplicationCodesByCodeType(int codeType)
        {
            var pa_rm = await _CommonDataRepository.GetApplicationCodesByCodeType(codeType);
            return Ok(pa_rm);
        }
        [HttpGet]
        public async Task<IActionResult> GetBusinessKey()
        {
            var pa_rm = await _CommonDataRepository.GetBusinessKey();
            return Ok(pa_rm);
        }
        [HttpPost]
        public async Task<IActionResult> GetApplicationCodesByCodeTypeList(List<int> l_codeType)
        {
            var pa_rm = await _CommonDataRepository.GetApplicationCodesByCodeTypeList(l_codeType);
            return Ok(pa_rm);
        }
    }
}
