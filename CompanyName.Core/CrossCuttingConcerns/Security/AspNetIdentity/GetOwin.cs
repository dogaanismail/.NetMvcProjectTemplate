﻿using Ninject.Activation;
using System.Web;
using Microsoft.AspNet.Identity.Owin;

namespace CompanyName.Core.CrossCuttingConcerns.Security.AspNetIdentity
{
    public class GetOwin
    {
        public static T GetOwinInjection<T>(IContext context) where T : class
        {
            var contextBase = new HttpContextWrapper(HttpContext.Current);
            return contextBase.GetOwinContext().Get<T>();
        }
    }
}
