using HPCL.DataModel.Card;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace HPCL.DataRepository.Card
{
    public interface ICardRepository
    {
        public Task<IEnumerable<ManageSearchCardsModelOutput>> SearchManageCard([FromBody] ManageSearchCardsModelInput ObjClass);
        public Task<GetCardLimtModelOutput> GetCardLimitFeatures([FromBody] GetCardLimtModelInput ObjClass);
        public Task<IEnumerable<UpdateMobileInCardModelOutput>> UpdateMobileInCard([FromBody] UpdateMobileInCardModelInput ObjClass);
        public Task<IEnumerable<UpdateServiveOnCardModelOutput>> UpdateServiveOnCard([FromBody] UpdateServiveOnCardModelInput ObjClass);
        public Task<IEnumerable<UpdateCardLimitsModelOutput>> UpdateCardLimits([FromBody] UpdateCardLimitsModelInput ObjClass);
        public Task<IEnumerable<UpdateCCMSLimitsModelOutput>> UpdateCCMSLimits([FromBody] UpdateCCMSLimitsModelInput ObjClass);
        public Task<IEnumerable<GetCCMSLimitsModelOutput>> GetCCMSLimits([FromBody] GetCCMSLimitsModelInput ObjClass);
        public Task<IEnumerable<GetCardLimitsModelOutput>> GetCardLimits([FromBody] GetCardLimitsModelInput ObjClass);
        public Task<IEnumerable<UpdateCCMSLimitForAllCardsModelOutput>> UpdateCCMSLimitForAllCards([FromBody] UpdateCCMSLimitForAllCardsModelInput ObjClass);
        public Task<IEnumerable<UpdateCardLimitForAllCardsModelOutput>> UpdateCardLimitForAllCards([FromBody] UpdateCardLimitForAllCardsModelInput ObjClass);
        public Task<IEnumerable<GetLimitMasterModelOutput>> GetCCMSLimitMaster([FromBody] GetLimitMasterModelInput ObjClass);
        public Task<IEnumerable<GetAllCardWithStatusModelOutput>> GetAllCardWithStatus([FromBody] GetAllCardWithStatusModelInput ObjClass);
        public Task<IEnumerable<UpdateCardStatusModelOutput>> UpdateCardStatus([FromBody] UpdateCardStatusModelInput ObjClass);
    }
}
