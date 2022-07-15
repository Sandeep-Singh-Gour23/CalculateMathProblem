using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;
using System.Web;
using System;
using CalculateMathProblem.Domain;

namespace CalculateMathProblem.Filters
{
    public class CalculateLogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var commandDto = context.ActionArguments["input"] as domain;
            Console.WriteLine(commandDto.number_1);
            string inputParameter = $"The first number is {commandDto.number_1} and second is {commandDto.number_2} ";

            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file named "WriteLines.txt".
            File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"),inputParameter);

            base.OnActionExecuting(context);

            
        }

       
    }
}
