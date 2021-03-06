using System.Collections.Generic;
using System.Web.Mvc;
using MrCMS.Web.Areas.Admin.Models;

namespace MrCMS.Web.Areas.Admin.Services
{
    public interface IAdminPageStatsService
    {
        IList<WebpageStats> GetSummary();
    }
}