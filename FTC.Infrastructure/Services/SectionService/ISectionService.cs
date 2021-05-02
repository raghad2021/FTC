using FTC.Core.Dto.CreateDto;
using FTC.Core.Dto.UpdateDto;
using FTC.Core.ViewModel;
using FTC.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FTC.Service.Service.SectionService
{
   public interface ISectionService
    {
        List<SectionViewModel> GetAll(int Page);
        void Create(CreateSectionDto dto);
        void Update(UpdateSectionDto dto);
        public void Delete(int id);

    }
}
