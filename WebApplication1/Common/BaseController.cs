using System.Web.Mvc;
using GashPortal.Core;

namespace WebApplication1.Controllers
{
    public class BaseController : PortalCoreController
    {
        /// <summary> 範例 </summary>
        public override string Token => Session["GashPortalMember"]?.ToString();


        /// <summary> 複寫 PortalCore 使用者金鎖 (設定) </summary>
        /// <param name="Token"></param>
        /// <returns></returns>
        [AllowAnonymous]
        public override ActionResult TurnIn(string Token)
        {
            Session["GashPortalMember"] = Token;

            // 自動轉導
            return base.TurnIn(Token);
        }
    }
}
