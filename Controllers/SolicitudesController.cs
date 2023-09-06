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
    public class SolicitudesController : SurfaceController
    {
        private ILogger<SolicitudesController> _log;
        public SolicitudesController(
            IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ILogger<SolicitudesController> log
        ) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _log = log;
        }

        [HttpGet]
        public IActionResult Crear()
        {
            SolicitudModel model = new SolicitudModel();

            return PartialView("_Contacto", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear([Bind("nombre","apellido", "empresa", "cargo", "correo", "telefono", "mensaje")]SolicitudModel model)
        {
            var cs = Services.ContentService;
            var pId = new Guid("7e25a96e-7f10-4804-b451-214a9263a673"); //7e25a96e-7f10-4804-b451-214a9263a673 56873b49-b358-420f-88fc-377efe1f7f1e
            var solicitud = cs.Create(model.Correo, pId, "solicitud");
            solicitud.SetValue("nombre", model.Nombre);
            solicitud.SetValue("apellido", model.Apellido);
            solicitud.SetValue("empresa", model.Empresa);
            solicitud.SetValue("cargo", model.Cargo);
            solicitud.SetValue("correo", model.Correo);
            solicitud.SetValue("telefono", model.Telefono);
            solicitud.SetValue("mensaje", model.Mensaje);
            solicitud.SetValue("origen", "General");
            cs.SaveAndPublish(solicitud);
            return PartialView("_Gracias");
        }
    }
}