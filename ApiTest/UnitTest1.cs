using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lbc.WebApi;
using Lbc.WebApi.Methods;

namespace ApiTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {

            var a = ApiClient.Execute(new GetToken() {
                Password = "CSCL",
                UserName = "CSCL"
            });
        }
    }
}
