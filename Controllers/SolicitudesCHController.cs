using UmbracoProject1.Models;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.Filters;
using Umbraco.Cms.Web.Website.Controllers;
using Newtonsoft.Json.Linq;
using System.Net;

namespace UmbracoProject1.Controllers
{
    public class SolicitudesCHController : SurfaceController
    {
        private ILogger<SolicitudesCHController> _log;
        public SolicitudesCHController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ILogger<SolicitudesCHController> log
        ) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            SolicitudCHModel model = new SolicitudCHModel();

            return PartialView("_ContactoCH", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(SolicitudCHModel model)
        {
            string recaptchaResponse = Request.Form["g-recaptcha-response"];
            bool isValid = ValidateRecaptcha(recaptchaResponse);

            if (isValid)
            {
                var cs = Services.ContentService;
                var pId = new Guid("87ed8bf2-ea6c-4cd3-9c3a-2442e3f57d74"); //87ed8bf2-ea6c-4cd3-9c3a-2442e3f57d74
                var solicitud = cs.Create(model.Correoch, pId, "Request");
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
                ModelState.AddModelError("ReCaptcha", "请确认我不是机器人");
                return PartialView("_FContactoCH");
            }


        }
        private bool ValidateRecaptcha(string recaptchaResponse)
        {
            string secretKey = "6Lca7jkoAAAAALz6_q7gmgQZzYedy_vLhcSawN7U";
            string apiUrl = "https://www.google.com/recaptcha/api/siteverify";
            var client = new WebClient();
            var response = client.DownloadString($"{apiUrl}?secret={secretKey}&response={recaptchaResponse}");
            var json = JObject.Parse(response);
            bool success = (bool)json["success"];
            return success;
        }
    }
}