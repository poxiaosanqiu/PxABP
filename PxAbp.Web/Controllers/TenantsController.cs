﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using PxAbp.Authorization;
using PxAbp.MultiTenancy;

namespace PxAbp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : PxAbpControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}