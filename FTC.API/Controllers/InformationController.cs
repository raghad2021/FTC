using FTC.API.ViewModel;
using FTC.Core.Dto;
using FTC.Core.Dto.CreateDto;
using FTC.Core.Dto.UpdateDto;
using FTC.Core.ViewModel;
using FTC.Service.Service.InformationService;
using Microsoft.AspNetCore.Mvc;

namespace FTC.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class InformationController : BaseControler
    {
        private IInformationService _InformationService;

        public InformationController(IInformationService InformationService)
        {
            _InformationService = InformationService;
        }
        [HttpGet]
        public APIResponseViewModel GetAllInformations(int page)
        {
            var Informations = _InformationService.GetAll(page);
            return GetRespons(Informations, "Data Retrive Sucess");
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreateInformationDto dto)
        {
            
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "Data Retrive Sucess";
            
            return Ok(response);
        }


        [HttpPut]
        public IActionResult Update([FromBody] UpdateInformationDto dto)
        {
            
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "Data Updated Sucess";
            return Ok(response);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _InformationService.Delete(id);
           
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "IInformation Deleted Sucess";
            return Ok(response);
        }
    }
}
