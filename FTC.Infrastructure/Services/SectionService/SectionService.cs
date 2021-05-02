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
using System.Threading.Tasks;

namespace FTC.Service.Service.SectionService
{
   public class SectionService:ISectionService
    {
        private IFileService _fileService;
        private FtcDbContext _DB;


        public SectionService(FtcDbContext DB, IFileService fileService)
        {
            _DB = DB;
            _fileService = fileService;
        }
        public List<SectionViewModel> GetAll(int Page)
        {
            var sectionViewModel = _DB.sections.Include(y => y.Information).Select(y => new SectionViewModel()
            {
                Id = y.Id,
                Titel = y.Titel,
                Discerption = y.Discerption,
                Image = y.Image,
                Information = new InformationViewModel()

                {
                    Id = y.Information.Id,
                    Titel = y.Information.Titel,
                    Logo = y.Information.Logo,
                    WhataApp = y.Information.WhataApp,
                    linkedIn = y.Information.linkedIn,
                    Twitter = y.Information.Twitter,
                    Facebook = y.Information.Facebook,
                    Instagram = y.Information.Instagram,
                    phone = y.Information.phone,
                    ppolicyURL = y.Information.ppolicyURL,
                }
            }).ToList();
            return sectionViewModel;
        }

        public void Create(CreateSectionDto dto)
        {
            var section = new SectionDbEntity();

            section.Titel = dto.Titel;
            section.Discerption = dto.Discerption;
            section.Image = dto.Image;

            _DB.sections.Add(section);
            _DB.SaveChanges();

        }

        public void Update(UpdateSectionDto dto)
        {
            var section = _DB.sections.SingleOrDefault(x => x.Id == dto.Id && !x.IsDelete);

            section.Titel = dto.Titel;
            section.Discerption = dto.Discerption;
            section.Image = dto.Image;
            _DB.sections.Update(section);
            _DB.SaveChanges();
        }

        public void Delete(int id)
        {
            var Section = _DB.sections.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            Section.IsDelete = true;
            _DB.sections.Update(Section);
            _DB.SaveChanges();
        }
    }
}
