using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using ProjetSession.Controllers;
using ProjetSession.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace TestsUnitaires
{
    public class CommandesControllerTests
    {
        //TODO : 21. Compléter le test unitaire.
        [Fact]
        public void Panier_ShouldReturnViewWithPanier()
        {
            // Arrange
            var films = new List<Film>
            {
                new Film("Film1", "url1", 5.99m),
                new Film("Film2", "url2", 6.99m)
            };

            var httpContext = new DefaultHttpContext();
            var session = new Mock<ISession>();
            var sessionStorage = new Dictionary<string, byte[]>();

            // Mock du comportement de Get / Set pour ISession
            session.Setup(s => s.Set(It.IsAny<string>(), It.IsAny<byte[]>()))
                   .Callback<string, byte[]>((key, value) => sessionStorage[key] = value);

            session.Setup(s => s.TryGetValue(It.IsAny<string>(), out It.Ref<byte[]>.IsAny))
                   .Returns((string key, out byte[] value) =>
                   {
                       return sessionStorage.TryGetValue(key, out value);
                   });


            var controller = new CommandesController(null, null)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext { Session = session.Object }
                }
            };


            // Act
            var result = controller.Panier() as ViewResult;

            // Assert ...
            // Vous devez vérifier que la vue panier est bien retournée avec une liste de films vide.
          
        }
    }
}
