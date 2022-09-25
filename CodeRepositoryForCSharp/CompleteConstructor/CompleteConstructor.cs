using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace CodeRepositoryForCSharp.CompleteConstructor
{
    class CompleteConstructor : Controller
    {

        [HttpPost]
        public ActionResult RegisterSkill(RegisterSkillRequest registerSkillRequest)
        {
            ValidateSkill(registerSkillRequest.Skill);

            // 問題なければ登録処理

            return View();
        }

        private void ValidateSkill(Skill skill)
        {
            if (skill.Score < 0)
            {
                throw new ValidationException("スコアが不正です");
            }
        }
    }

    class RegisterSkillRequest
    {
        public Skill Skill { get; set; }


    }

    class Skill
    {
        public int Score { get; set; }

        public Skill(int score)
        {
            if (score < 0)
            {
                throw new ValidationException("スコアが不正です");
            }

            Score = score;
        }
    }

    class ValidationException : Exception
    {
        public ValidationException(string message)
        {

        }
    }
}
