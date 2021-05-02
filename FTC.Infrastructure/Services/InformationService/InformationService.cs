using FTC.Data;
using FTC.Data.Models;
using FTC.Core.Dto.CreateDto;
using FTC.Core.Dto.UpdateDto;
using FTC.Core.ViewModel;
using FTC.Service.Files;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTC.Service.Service.InformationService
{
  public  class InformationService:IInformationService 
    {
        private IFileService _fileService;
        private FtcDbContext _DB;


        public InformationService(FtcDbContext DB, IFileService fileService)
        {
            _DB = DB;
            _fileService = fileService;
        }
        public List<InformationViewModel> GetAll(int Page)
        {
            var informationViewModel = _DB.Information.Include(y => y.Section).Select(y => new InformationViewModel()
            {
                Id = y.Id,
                Titel = y.Titel,
                Logo = y.Logo,
                WhataApp = y.WhataApp,
                linkedIn = y.linkedIn,
                Twitter = y.Twitter,
                Facebook = y.Facebook,
                Instagram = y.Instagram,
                phone = y.phone,
                ppolicyURL = y.ppolicyURL,
                Section = y.Section.Select(v => new SectionViewModel()

                {
                    Id = v.Id,
                    Titel = v.Titel,
                    Discerption = v.Discerption,
                    Image = v.Image,

                }).ToList()


            }).ToList();
            return informationViewModel;
        }

        public void Create(CreateInformationDto dto)
        {
            var information = new InformationDbEntity();

            information.Titel = dto.Titel;
            information.Logo = dto.Logo;
            information.WhataApp = dto.WhataApp;
            information.linkedIn = dto.linkedIn;
            information.Twitter = dto.Twitter;
            information.Facebook = dto.Facebook;
            information.Instagram = dto.Instagram;
            information.phone = dto.phone;
            information.ppolicyURL = dto.ppolicyURL;

            _DB.Information.Add(information);
            _DB.SaveChanges();

        }

        public void Update(UpdateInformationDto dto)
        {
            var information = _DB.Information.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);

            information.Titel = dto.Titel;
            information.Logo = dto.Logo;
            information.WhataApp = dto.WhataApp;
            information.linkedIn = dto.linkedIn;
            information.Twitter = dto.Twitter;
            information.Facebook = dto.Facebook;
            information.Instagram = dto.Instagram;
            information.phone = dto.phone;
            information.ppolicyURL = dto.ppolicyURL;
            _DB.Information.Update(information);
            _DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var information = _DB.Information.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            information.IsDelete = true;
            _DB.Information.Update(information);
            _DB.SaveChanges();
        }
    }
}


