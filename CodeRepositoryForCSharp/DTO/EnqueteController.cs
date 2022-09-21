using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace CodeRepositoryForCSharp.DTO
{
    class EnqueteController : Controller
    {
        private EnqueteRepository enqueteRepository;

        [HttpPost]
        public ActionResult UpdateEnqueteSetting(UpdateEnqueteSettingRequest updateEnqueteSettingRequest)
        {
            enqueteRepository.UpdateEnqueteSetting(updateEnqueteSettingRequest);
            return View();
        }
    }
    class EnqueteRepository
    {
        public void UpdateEnqueteSetting(UpdateEnqueteSettingRequest updateEnqueteSettingRequest)
        {

        }
    }

    enum EnqueteLable
    {
        Normal,
        Important,
    }

    class UpdateEnqueteSettingRequest { 
        int enqueteId { get; set; }
        string name { get; set; }
        int authorUserId { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        List<int> targetUserIdList { get; set; }
        bool isSendMail { get; set; }
        bool isRemaindMail { get; set; }
    }
}
