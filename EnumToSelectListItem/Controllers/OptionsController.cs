using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using EnumToSelectListItem.Enumerations;
using EnumToSelectListItem.Extensions;

namespace EnumToSelectListItem.Controllers
{
    [Produces("application/json")]
    [Route("api/Options")]
    public class OptionsController : Controller
    {
        /// <summary>
        /// 取得一星期中的日期清單
        /// </summary>
        /// <returns></returns>
        [Route("Days")]
        [HttpGet]
        [ProducesResponseType(typeof(SelectListItem), 200)]
        public IActionResult GetDays()
        {
            var items = Enum.GetValues(typeof(Day))
                .Cast<Day>()
                .Select(x => new SelectListItem()
                {
                    Text = x.GetDescription(),
                    Value = Convert.ToInt32(x).ToString()
                });

            return Ok(items);
        }

        /// <summary>
        /// 取得一年中的月份清單
        /// </summary>
        /// <returns></returns>
        [Route("Months")]
        [HttpGet]
        [ProducesResponseType(typeof(SelectListItem), 200)]
        public IActionResult GetMonths()
        {
            var items = Enum.GetValues(typeof(Month))
                .Cast<Month>()
                .Select(x => new SelectListItem()
                {
                    Text = x.GetDescription(),
                    Value = Convert.ToInt32(x).ToString()
                });

            return Ok(items);
        }
    }
}