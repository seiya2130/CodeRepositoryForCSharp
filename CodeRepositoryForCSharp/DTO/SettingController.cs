using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace CodeRepositoryForCSharp.DTO
{
    class SettingController : Controller
    {

        private SettingRepository settingRepository;

        [HttpPost]
        public ActionResult UpdateSetting(UpdateSettingRequest updateSettingRequest)
        {
            settingRepository.UpdateSetting(updateSettingRequest);
            return View();
        }
    }

    class SettingRepository
    {
        public void UpdateSetting(UpdateSettingRequest updateEnqueteSettingRequest)
        {

        }
    }

    class UpdateSettingRequest
    {
        int settingId { get; set; }
        string settingName { get; set; }
        int authorUserId { get; set; }
        Boolean isEnable { get; set; }
        List<int> targetUserIdList { get; set; }
    }

}