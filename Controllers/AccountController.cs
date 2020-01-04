using GCS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GCS.Controllers
{
    public class AccountController : Controller
    {
        private readonly GCSContext _context;

        public AccountController(GCSContext context)
        {
            _context = context;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Index");
        }

        [HttpPost]
        public async Task<ActionResult> Login([Bind("Id,Company_id,Fname,Lname,Address,Phone,Email,Password,Is_admin,Gender,Race,Role,Company_length,Role_length,Inserted_on,Inserted_by,Updated_on,Updated_by,Deleted_on,Deleted_by")] User credential)
        {
            bool isUservalid = false;
            User user = await _context.Users
                .FromSql(@"
                SELECT [id]
                  ,COALESCE([company_id], 0) company_id
                  ,[fname]
                  ,[lname]
                  ,[address1]
                  ,[address2]
                  ,[city]
                  ,[state]
                  ,[zip]
                  ,[country]
                  ,[phone]
                  ,[email]
                  ,[password]
                  ,COALESCE([is_admin], 'false') is_admin
                  ,[gender]
                  ,[race]
                  ,[role]
                  ,[company_length]
                  ,[role_length]
                FROM [user]
                where email=@email and password=@password",
                new SqlParameter("@email", (object)credential.Email),
                new SqlParameter("@password", (object)credential.Password)).FirstOrDefaultAsync();

            if (user != null)
            {
                isUservalid = true;
            }


            if (ModelState.IsValid && isUservalid)
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, user.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.Email, user.Email));
                claims.Add(new Claim(ClaimTypes.Role, user.Is_admin.ToString()));

                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();
                //props.IsPersistent = model.RememberMe;

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal, props);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["message"] = "Invalid Username or Password!";
                return View("Index");
            }
        }
    }
}