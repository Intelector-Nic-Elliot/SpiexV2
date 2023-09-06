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
    public class ChatbotController : SurfaceController
    {
        private ILogger<ChatbotController> _log;
        public ChatbotController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ILogger<ChatbotController> log
        ) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult Chats()
        {
            long total = 0;
            var cs = Services.ContentService;
            var chats = cs.GetPagedChildren(1214, 0, 100, out total);

            ChatbotModel model = new ChatbotModel()
            {
                Chats = new List<PYRModel>()
            };

            foreach (var chat in chats)
            {
                model.Chats.Add(new PYRModel()
                {
                    Pregunta = chat.GetValue("pregunta").ToString(),
                    Respuesta = chat.GetValue("respuesta").ToString()
                });
            }

            return PartialView("_Chats", model);
        }

    }
}