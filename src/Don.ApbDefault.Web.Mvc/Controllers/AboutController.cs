﻿using Abp.AspNetCore.Mvc.Authorization;
using Don.ApbDefault.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Don.ApbDefault.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ApbDefaultControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}