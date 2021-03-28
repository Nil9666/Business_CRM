using System.Threading.Tasks;
using WizeTech_Business_CRM.Models.TokenAuth;
using WizeTech_Business_CRM.Web.Controllers;
using Shouldly;
using Xunit;

namespace WizeTech_Business_CRM.Web.Tests.Controllers
{
    public class HomeController_Tests: WizeTech_Business_CRMWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}