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
            var skill = new Skill(registerSkillRequest.Skill.Score);

            // 登録処理

            return View();
        }
    }

    class RegisterSkillRequest
    {
        public Skill Skill { get; set; }
    }

    class Skill
    {
        public readonly int Score;

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
