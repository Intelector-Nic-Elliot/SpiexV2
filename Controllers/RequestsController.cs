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

namespace UmbracoProject1.Controllers
{
    public class requestsController : SurfaceController
    {
        private ILogger<requestsController> _log;
        public requestsController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ILogger<requestsController> log
        ) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            RequestModel model = new RequestModel();

            CookieOptions cookieOptions = new CookieOptions
            {
                Secure = true,

            };

            return PartialView("_Contact", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear([Bind("name1", "lastname", "company", "job", "email", "phone", "message")]RequestModel model)
        {
            var cs = Services.ContentService;
            var pId = new Guid("5933c3e3-ad04-40cc-b1ef-6540c0a61df4"); //5933c3e3-ad04-40cc-b1ef-6540c0a61df4
            var solicitud = cs.Create(model.Email, pId, "Request");
            solicitud.SetValue("name1", model.Names);
            solicitud.SetValue("lastname", model.LastName);
            solicitud.SetValue("company", model.Company);
            solicitud.SetValue("job", model.Job);
            solicitud.SetValue("email", model.Email);
            solicitud.SetValue("phone", model.Phone);
            solicitud.SetValue("message", model.Message);
            cs.SaveAndPublish(solicitud);
            return PartialView("_Thanks");
        }
    }
}