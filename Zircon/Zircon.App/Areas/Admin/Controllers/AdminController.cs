namespace Zircon.App.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Zircon.Common.Constrants;

    [Area(AttributeConstraintsConstants.AdminArea)]
    [Authorize(Roles = AttributeConstraintsConstants.AdminRole)]
    public abstract class AdminController : Controller
    {
    }
}