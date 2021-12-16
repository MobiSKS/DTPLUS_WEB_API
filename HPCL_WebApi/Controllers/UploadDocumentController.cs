using HPCL.DataModel.UploadDocument;
using HPCL.DataRepository.UploadDocument;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    
    [ApiController]
    [Route("api")]
    public class UploadDocumentController : ControllerBase
    {
        private readonly ILogger<UploadDocumentController> _logger;

        private readonly IUploadDocumentRepository _uploaddocRepo;

        public UploadDocumentController(ILogger<UploadDocumentController> logger, IUploadDocumentRepository uploaddocRepo)
        {
            _logger = logger;
            _uploaddocRepo = uploaddocRepo;
        }

        [HttpPost]
        [Route("upload_document_create_customer")]
        public async Task<IActionResult> uploadDocumentCreateCustomer()
        {
            try
            {
                return Ok("upload_document_create_customer");
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

    }

}
