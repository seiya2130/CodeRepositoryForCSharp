using CodeRepositoryForCSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NUnitTestProject
{
    public class CalcTest
    {
        [Test]
        public void AddTest()
        {
            var calcTest = new Calc();
            // CalCクラスの指定したメソッド情報の取得(インスタンスのメソッド且つパブリック以外のメソッド)
            var methodInfo = typeof(Calc).GetMethod("Add", BindingFlags.Instance | BindingFlags.NonPublic);

            var param = new object[] { 1, 2 };

            // Calcクラスに引数を指定して実行
            var result = methodInfo.Invoke(calcTest, param);
            Assert.AreEqual(3, result);
        }
    }
}
