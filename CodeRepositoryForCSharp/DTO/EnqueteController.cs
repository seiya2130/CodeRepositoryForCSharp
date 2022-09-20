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
        public ActionResult UpdateEnqueteSetting(int enqueteId, string name, int authorUserId, DateTime startDate, DateTime endDate, List<int> targetUserIdList, bool isSendMail, bool isRemaindMail, EnqueteLable enqueteLable)
        {
            enqueteRepository.UpdateEnqueteSetting(enqueteId, name, authorUserId, startDate, endDate, targetUserIdList, isSendMail, isRemaindMail, enqueteLable);
            return View();
        }
    }
    class EnqueteRepository
    {
        public void UpdateEnqueteSetting(int id, string name, int authorUserId, DateTime startDate, DateTime endDate, List<int> targetUserIdList, bool isSendMail, bool isRemaindMail, EnqueteLable enqueteLable)
        {

        }
    }

    enum EnqueteLable
    {
        Normal,
        Important,

    }
}
