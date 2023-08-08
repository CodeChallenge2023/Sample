using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sample.ViewModel;
using System.Security.Claims;

namespace Sample.web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            ViewData["returnUrl"]= returnUrl;
            return View();
        }

        
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                if (loginViewModel.UserName == "arun" && loginViewModel.Password == "12345")
                {
                    List<Claim> claims = new List<Claim>();
                    // type of doc to validate like as adhar card
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, loginViewModel.UserName));
                    // id doc details like as adahr card details, user roles
                    claims.Add(new Claim(ClaimTypes.Name, loginViewModel.UserName));
                    claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                    // how to validate like as cookie , jwt token
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    // declaring authetication type like as use adhar card to validate
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    HttpContext.SignInAsync(principal);

                    string returnUrl = HttpContext.Request.Query["returnUrl"];
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }                   
                }               
            }
            return BadRequest();
        }

        public IActionResult Success()
        {
            return Content("loggedin");
        }

        public IActionResult Fail()
        {
            return Content("failed");
        }
    }
}
