using Microsoft.AspNetCore.Mvc;
using UmbracoProject1.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Filters;
using Umbraco.Cms.Web.Website.Controllers;
using System.Net;
using Newtonsoft.Json.Linq;



namespace UmbracoProject1.Controllers
{
    public class SolicitudeschController : SurfaceController
    {
        private ILogger<SolicitudeschController> _log;
        public SolicitudeschController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ILogger<SolicitudeschController> log
        ) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            SolicitudeschModel model = new SolicitudeschModel();

            return PartialView("_Contactoch", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(SolicitudeschModel model)
        {
            string recaptchaResponse = Request.Form["g-recaptcha-response"];
            bool isValid = ValidateRecaptcha(recaptchaResponse);

            if (isValid)
            {
                var cs = Services.ContentService;
                var pId = new Guid("28e9e5d5-a3c4-4f2e-a283-32644c087505"); //28e9e5d5-a3c4-4f2e-a283-32644c087505
                var solicitud = cs.Create(model.Correoch, pId, "solicitudch");
                solicitud.SetValue("nombrech", model.Nombrech);
                solicitud.SetValue("apellidoch", model.Apellidoch);
                solicitud.SetValue("empresach", model.Empresach);
                solicitud.SetValue("cargoch", model.Cargoch);
                solicitud.SetValue("correoch", model.Correoch);
                solicitud.SetValue("telefonoch", model.Telefonoch);
                solicitud.SetValue("mensajech", model.Mensajech);
                cs.SaveAndPublish(solicitud);
                return PartialView("_GraciasCH");
            }

            else
            {
                ModelState.AddModelError("ReCaptcha", "Por favor verificar que no sea un robot");
                return PartialView("_FContactoch");
            }

        }

        private bool ValidateRecaptcha(string recaptchaResponse)
        {
            string secretKey = "6Lca7jkoAAAAALz6_q7gmgQZzYedy_vLhcSawN7U ";   //6Lca7jkoAAAAALz6_q7gmgQZzYedy_vLhcSawN7U   / 6Lca7jkoAAAAAMFVoTT4MvO6qAhW2JUWRcbql4Mw
            string apiUrl = "https://www.google.com/recaptcha/api/siteverify";
            var client = new WebClient();
            var response = client.DownloadString($"{apiUrl}?secret={secretKey}&response={recaptchaResponse}");
            var json = JObject.Parse(response);
            bool success = (bool)json["success"];
            return success;
        }


    }
}
