using GuptaKirana.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace GuptaKirana.API.Controllers
{
    [ApiController]
    public class GuptaKiranaController : ControllerBase
    {
        protected ResponseDTO _response;
        public GuptaKiranaController()
        {
            this._response = new ResponseDTO();
        }
        protected ResponseDTO GenerateSuccessResponse(Object result)
        {
            _response.IsSuccess = true;
            _response.Result = new ResultDTO
            {
                Data = result,
                StatusCode = HttpStatusCode.OK
            };
            return _response;
        }

        protected ResponseDTO GenerateErrorResponse(Exception ex)
        {
            _response.IsSuccess = false;
            _response.Error = new ErrorDTO
            {
                StatusCode = HttpStatusCode.InternalServerError,
                Error = ex.Message
            };
                
            return _response;
        }
    }
}
