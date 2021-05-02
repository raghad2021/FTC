using FTC.Data.Models;
using FTC.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FTC.Core.Dto.CreateDto;
using FTC.Core.Dto.UpdateDto;

namespace FTC.Service.Service.InformationService
{
   public interface IInformationService
    {
        List<InformationViewModel> GetAll(int Page);
        void Create(CreateInformationDto dto);
        void Update(UpdateInformationDto dto);
        void Delete(int id);
    }
}
