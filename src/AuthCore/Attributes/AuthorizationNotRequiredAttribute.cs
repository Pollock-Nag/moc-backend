﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace BaseCore.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizationNotRequiredAttribute : Attribute
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute           
        }
    }
}
