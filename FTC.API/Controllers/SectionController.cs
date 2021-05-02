using FTC.API.ViewModel;
using FTC.Core.Dto;
using FTC.Core.Dto.CreateDto;
using FTC.Core.Dto.UpdateDto;
using FTC.Core.ViewModel;
using FTC.Service.Service.SectionService;
using Microsoft.AspNetCore.Mvc;


namespace FTC.API.Controllers
{
    public class SectionController : BaseControler
    {
        private ISectionService _SectionService;

        public SectionController(ISectionService SectionService)
        {
            _SectionService = SectionService;
        }
        [HttpGet]
        public APIResponseViewModel GetAllSections(int Page)
        {
            var Sections = _SectionService.GetAll(Page);
            return GetRespons (Sections, "Data Retrive Sucess");
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreateSectionDto dto)
        {
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "Data Retrive Sucess";
            return Ok(response);
        }


        [HttpPut]
        public IActionResult Update([FromBody] UpdateSectionDto dto)
        {
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "Data Updated Sucess";
            return Ok(response);
        }


        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _SectionService.Delete(id);
            var response = new APIResponseViewModel();
            response.Status = true;
            response.Message = "ISection Deleted Sucess";
            return Ok(response);
        }
    }
}

