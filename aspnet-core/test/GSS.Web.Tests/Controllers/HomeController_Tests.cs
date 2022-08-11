using System.Threading.Tasks;
using GSS.Models.TokenAuth;
using GSS.Web.Controllers;
using Shouldly;
using Xunit;

namespace GSS.Web.Tests.Controllers
{
    public class HomeController_Tests: GSSWebTestBase
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