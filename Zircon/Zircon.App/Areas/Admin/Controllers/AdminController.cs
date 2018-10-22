namespace Zircon.App.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Zircon.Common;

    [Area(Constants.AttributeConstraint.AdminArea)]
    [Authorize(Roles = Constants.AttributeConstraint.AdminRole)]
    public abstract class AdminController : Controller
    {
    }
}