﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace Fiap.Web.AspNet4.Controllers.Filters
{
    public class FiapLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("FiapLogFilter - OnActionExecuted");
            base.OnActionExecuted(context);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("FiapLogFilter - OnActionExecuting");
            base.OnActionExecuting(context);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine("FiapLogFilter - OnResultExecuted");
            base.OnResultExecuted(context);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine("FiapLogFilter - OnResultExecuting");
            base.OnResultExecuting(context);
        }
    }
}
