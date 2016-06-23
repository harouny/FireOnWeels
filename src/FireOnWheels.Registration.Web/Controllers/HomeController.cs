using System;
using System.Threading.Tasks;
using FireOnWheels.Messaging;
using FireOnWheels.Registration.Web.Messages;
using FireOnWheels.Registration.Web.ViewModels;
using Microsoft.AspNet.Mvc;

namespace FireOnWheels.Registration.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterOrder() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterOrder(OrderViewModel model) {
            var registerOrderCommand = new RegisterOrderCommand(model);
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMqConstants.RabbitMqUri}{RabbitMqConstants.RegisterOrderServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);

            await endPoint.Send<FireOnWheels.Messaging.Commands.IRegisterOrderCommand>(
                registerOrderCommand);
            return View("Thanks");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
