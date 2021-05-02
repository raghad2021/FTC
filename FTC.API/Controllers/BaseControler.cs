using FTC.API.ViewModel;
using FTC.Core.ViewModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FTC.API.Controllers
{ 
    [ApiController]
        [Route("api/[controller]/[action]")]
        [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
    public class BaseControler:Controller
    {
        protected string UserId;
        protected string Language;

        protected APIResponseViewModel GetRespons (object data=null,string message = "Done")
        {
            var result = new APIResponseViewModel();
            result.Status = true;
            result.Message = message;
            result.Data = data;
            return result;
        }
      
    }
}
