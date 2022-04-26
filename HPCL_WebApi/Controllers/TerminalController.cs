using HPCL.DataModel.Merchant;
using HPCL.DataRepository.Terminal;
using HPCL.DataRepository.ZonalOffice;
using HPCL_WebApi.ActionFilters;
using HPCL_WebApi.ExtensionMethod;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPCL_WebApi.Controllers
{
    [Route("api/dtplus/terminal")]
    [ApiController]
    public class TerminalController : ControllerBase
    {
        private readonly ILogger<TerminalController> _logger;

        private readonly ITerminalRepository _TrRepo;
        public TerminalController(ILogger<TerminalController> logger, ITerminalRepository TrRepo)
        {
            _logger = logger;
            _TrRepo = TrRepo;
        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_for_terminal_installation_request")]
        public async Task<IActionResult> SearchForTerminalInstallationRequest([FromBody] MerchantSearchForTerminalInstallationRequestModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.SearchForTerminalInstallationRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjMerchantDetail.Count > 0 || result.ObjTerminalDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }


        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_terminal_installation_request")]
        public async Task<IActionResult> InsertTerminalInstallationRequest([FromBody] MerchantInsertAddonTerminalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.InsertTerminalInstallationRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantInsertAddonTerminalModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantInsertAddonTerminalModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_for_terminal_installation_request_close")]
        public async Task<IActionResult> SearchForTerminalInstallationRequestClose([FromBody] MerchantSearchForTerminalInstallationRequestCloseModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.SearchForTerminalInstallationRequestClose(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantSearchForTerminalInstallationRequestCloseModelOutput> item = result.Cast<MerchantSearchForTerminalInstallationRequestCloseModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_reason_list")]
        public async Task<IActionResult> GetReasonList([FromBody] MerchantGetReasonListModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetReasonList(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetReasonListModelOutput> item = result.Cast<MerchantGetReasonListModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_terminal_installation_request_close")]
        public async Task<IActionResult> UpdateTerminalInstallationRequestClose([FromBody] MerchantUpdateTerminalInstallationRequestCloseModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.UpdateTerminalInstallationRequestClose(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantUpdateTerminalInstallationRequestCloseModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantUpdateTerminalInstallationRequestCloseModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_terminal_installation_request_status")]
        public async Task<IActionResult> ViewTerminalInstallationRequestStatus([FromBody] MerchantViewTerminalInstallationRequestStatusCloseInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.ViewTerminalInstallationRequestStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantViewTerminalInstallationRequestStatusCloseModelOutput> item = result.Cast<MerchantViewTerminalInstallationRequestStatusCloseModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_de_installation_request")]
        public async Task<IActionResult> GetTerminalDeinstallationRequest([FromBody] MerchantGetTerminalDeinstallationRequestModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalDeinstallationRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.ObjMerchantDeinstallationDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("update_terminal_de_instal_request")]
        public async Task<IActionResult> UpdateTerminalDeInstalRequest([FromBody] MerchantUpdateTerminalDeInstalRequestModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.UpdateTerminalDeInstalRequest(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantUpdateTerminalDeInstalRequestModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantUpdateTerminalDeInstalRequestModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_de_installation_request_close")]
        public async Task<IActionResult> GetTerminalDeInstallationRequestClose([FromBody] MerchantGetTerminalDeInstallationRequestCloseModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalDeInstallationRequestClose(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetTerminalDeInstallationRequestCloseModelOutput> item = result.Cast<MerchantGetTerminalDeInstallationRequestCloseModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);

                }
            }

        }



        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("terminal_de_instal_update_request_close")]
        public async Task<IActionResult> TerminalDeInstalUpdateRequestClose([FromBody] MerchantTerminalDeInstalUpdateRequestCloseModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.TerminalDeInstalUpdateRequestClose(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantTerminalDeInstalUpdateRequestCloseModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantTerminalDeInstalUpdateRequestCloseModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_installation_request_approval")]
        public async Task<IActionResult> GetTerminalInstallationRequestApproval([FromBody] MerchantGetTerminalInstallationRequestApprovalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalInstallationRequestApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetTerminalInstallationRequestApprovalModelOutput> item = result.Cast<MerchantGetTerminalInstallationRequestApprovalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_terminal_installation_request_approval")]

        public async Task<IActionResult> InsertTerminalInstallationRequestApproval([FromBody] MerchantUpdateTerminalInstallationRequestApprovalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.InsertTerminalInstallationRequestApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {

                    if (result.Cast<MerchantUpdateTerminalInstallationRequestApprovalModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantUpdateTerminalInstallationRequestApprovalModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }




        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_de_installation_request_approval")]
        public async Task<IActionResult> GetTerminalDeInstallationRequestApproval([FromBody] MerchantGetTerminalDeInstallationRequestApprovalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalDeInstallationRequestApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetTerminalDeInstallationRequestApprovalModelOutput> item = result.Cast<MerchantGetTerminalDeInstallationRequestApprovalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_terminal_de_installation_request_approval")]
        public async Task<IActionResult> InsertTerminalDeInstallationRequestApproval([FromBody] MerchantInsertTerminalDeInstallationRequestApprovalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.InsertTerminalDeInstallationRequestApproval(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>().ToList()[0].Status == 1)
                    {
                        List<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput> item = result.Cast<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>().ToList();
                        if (item.Count > 0)
                            return this.OkCustom(ObjClass, result, _logger);
                        else
                            return this.Fail(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantInsertTerminalDeInstallationRequestApprovalModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_de_installation_request_authorization")]
        public async Task<IActionResult> GetTerminalDeInstallationRequestAuthorization([FromBody] MerchantGetTerminalDeInstallationRequestAuthorizationModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalDeInstallationRequestAuthorization(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetTerminalDeInstallationRequestAuthorizationModelOutput> item = result.Cast<MerchantGetTerminalDeInstallationRequestAuthorizationModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_terminal_de_installation_request_authorization")]
        public async Task<IActionResult> InsertTerminalDeInstallationRequestAuthorization([FromBody] MerchantInsertTerminalDeInstallationRequestAuthorizationModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.InsertTerminalDeInstallationRequestAuthorization(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("view_terminal_de_installation_request_status")]
        public async Task<IActionResult> ViewTerminalDeInstallationRequestStatus([FromBody] MerchantViewTerminalDeInstallationRequestStatusModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.ViewTerminalDeInstallationRequestStatus(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantViewTerminalDeInstallationRequestStatusModelOutput> item = result.Cast<MerchantViewTerminalDeInstallationRequestStatusModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_problematic_de_installed_to_deinstalled")]
        public async Task<IActionResult> GetProblematicDeinstalledToDeinstalled([FromBody] MerchantGetProblematicDeinstalledToDeinstalledModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetProblematicDeinstalledToDeinstalled(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetProblematicDeinstalledToDeinstalledModelOutput> item = result.Cast<MerchantGetProblematicDeinstalledToDeinstalledModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("insert_problematic_de_installed_to_deinstalled")]
        public async Task<IActionResult> InsertProblematicDeinstalledToDeinstalled([FromBody] MerchantInsertProblematicDeinstalledToDeinstalledModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.InsertProblematicDeinstalledToDeinstalled(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    if (result.Cast<MerchantInsertProblematicDeinstalledToDeinstalledModelOutput>().ToList()[0].Status == 1)
                    {
                        return this.OkCustom(ObjClass, result, _logger);
                    }
                    else
                    {
                        return this.FailCustom(ObjClass, result, _logger,
                            result.Cast<MerchantInsertProblematicDeinstalledToDeinstalledModelOutput>().ToList()[0].Reason);
                    }


                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_manage_terminal_detail")]
        public async Task<IActionResult> GetManageTerminalDetails([FromBody] MerchantGetManageTerminalDetailsModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetManageTerminalDetails(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetManageTerminalDetailsModelOutput> item = result.Cast<MerchantGetManageTerminalDetailsModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("search_terminal")]
        public async Task<IActionResult> SearchTerminal([FromBody] MerchantSearchTerminalModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.SearchTerminal(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantSearchTerminalModelOutput> item = result.Cast<MerchantSearchTerminalModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }

        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("terminal_detail")]
        public async Task<IActionResult> TerminalDetail([FromBody] MerchantTerminalDetailModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.TerminalDetail(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {

                    if (result.ObjTerminalDetail.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


        [HttpPost]
        [ServiceFilter(typeof(CustomAuthenticationFilter))]
        [Route("get_terminal_type")]
        public async Task<IActionResult> GetTerminalType([FromBody] MerchantGetTerminalTypeModelInput ObjClass)
        {

            if (ObjClass == null)
            {
                return this.BadRequestCustom(ObjClass, null, _logger);
            }
            else
            {
                var result = await _TrRepo.GetTerminalType(ObjClass);
                if (result == null)
                {
                    return this.NotFoundCustom(ObjClass, null, _logger);
                }
                else
                {
                    List<MerchantGetTerminalTypeModelOutput> item = result.Cast<MerchantGetTerminalTypeModelOutput>().ToList();
                    if (item.Count > 0)
                        return this.OkCustom(ObjClass, result, _logger);
                    else
                        return this.Fail(ObjClass, result, _logger);
                }
            }

        }


    }

}
