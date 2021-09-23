using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace string2int.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class String2IntController : ControllerBase
    {
        [HttpGet]
        public int Get(string textInput)
        {
            var regex = new Regex(@"\d+");
            if (!regex.IsMatch(textInput)) {
                Console.WriteLine($"{textInput} test digit is not support.");
                return 0;
            }
            var matches = regex.Matches(textInput);
            var strNum = string.Join(string.Empty, matches);
            int num = 0;
            int n = strNum.Length;
            // Iterate till length of the string
            for (int i = 0; i < n; i++) {
                num = num * 10 + (strNum[i] - 48);
            }
            return num;
        }
    }
}
