//using CMS.Models;
//using HVIT.Security;
//using HVITCore.Controllers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Web.Http;
//using System.Web.Http.Controllers;
//using System.Web.Http.Filters;
//using System.Data.Entity;

//namespace CMS.Controllers
//{
//    [RoutePrefix("api/auth")]
//    public class AuthController : BaseApiController
//    {
//        public class LoginForm
//        {
//            public string Username { get; set; }
//            public string Password { get; set; }
//            public string RePassword { get; set; }
//            public string ChangePasswordKey { get; set; }
//            public string OldPassword { get; set; }
//        }

//        public class UserModel
//        {
//            public Users User { get; set; }
//            public List<int> Groups { get; set; }

//            public UserModel()
//            {
//                Groups = new List<int>();
//            }
//        }

//        [HttpPost]
//        [Route("login")]
//        public IHttpActionResult Login(LoginForm login)
//        {
//            using (ApplicationDbContext db = new ApplicationDbContext())
//            {
//                Users user = db.Users.SingleOrDefault(x => x.UserName == login.Username);
//                if (user != null)
//                {
//                    string passwordSalt = user.PasswordSalt;
//                    string passwordInput = AuthenticationHelper.GetMd5Hash(passwordSalt + login.Password);
//                    string passwordUser = user.Password;

//                    if (passwordInput.Equals(passwordUser))
//                    {
//                        TokenProvider tokenProvider = new TokenProvider();
//                        TokenIdentity token = tokenProvider.GenerateToken(user.UserId, login.Username,
//                            Request.Headers.UserAgent.ToString(),
//                            "", Guid.NewGuid().ToString(),
//                            DateTime.Now.Ticks);
//                        token.SetAuthenticationType("Custom");
//                        token.SetIsAuthenticated(true);
//                        db.AccessTokens.Add(new AccessTokens()
//                        {
//                            Token = token.Token,
//                            EffectiveTime = new DateTime(token.EffectiveTime),
//                            ExpiresIn = token.ExpiresTime,
//                            IP = token.IP,
//                            UserAgent = token.UserAgent,
//                            UserName = token.Name
//                        });
//                        db.SaveChanges();
//                        List<UserRole> dsUserRole = db.UserRole.Where(x => x.UserId == user.UserId).ToList();

//                        var nhansu = db.Nhansu
//                            .Include(x => x.PhongBan)
//                            .Include(x => x.PhongBan.DonVi)
//                            .Select(x=> new {
//                                x.NhansuID,
//                                x.TaiKhoan,
//                                x.PhongBanID,
//                                x.PhongBan.TenPhongBan,
//                                x.PhongBan.DonViID,
//                                x.PhongBan.DonVi.TenDonVi,
//                                x.PhongBan.DonVi.ThanhPhoID,
//                                x.PhongBan.DonVi.QuanHuyenID,
//                                x.PhongBan.DonVi.XaPhuongID,
//                                x.PhongBan.DonVi.DonViDieuTraCungCap,
//                                x.HoTen,
//                                x.ChucVuID,
//                                DonVi = new
//                                {
//                                    x.PhongBan.DonViID,
//                                    x.PhongBan.DonVi.TenDonVi,
//                                    x.PhongBan.DonVi.ThanhPhoID,
//                                    x.PhongBan.DonVi.QuanHuyenID,
//                                    x.PhongBan.DonVi.XaPhuongID,
//                                    x.PhongBan.DonVi.DonViPID,
//                                    x.PhongBan.DonVi.DuocXXST,
//                                    x.PhongBan.DonVi.DuocXXPT,
//                                    x.PhongBan.DonVi.DuocXXTT,
//                                    x.PhongBan.DonVi.DuocXXGDT,
//                                    x.PhongBan.DonVi.CapDonVi,
//                                }
//                            })
//                            .FirstOrDefault(x => x.TaiKhoan == user.UserId);
//                        return Ok(
//                            new
//                            {
//                                AccessToken = token,
//                                Profile = new
//                                {
//                                    UserId = user.UserId,
//                                    Username = user.UserName,
//                                    Email = user.Email,
//                                    UserRole = dsUserRole.Select(x => x.RoleId),
//                                    NhanSu = nhansu
//                                }
//                            });
//                    }
//                }
//                return Ok("Login failed!");
//            }
//        }

//        [AuthorizeUser]
//        [HttpGet]
//        [Route("validate-token")]
//        public IHttpActionResult ValidateToken()
//        {
//            TokenIdentity tokenIdentity = ClaimsPrincipal.Current.Identity as TokenIdentity;
//            return Ok();
//        }
//    }
//    public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
//    {
//        public override void OnActionExecuting(HttpActionContext filterContext)
//        {
//            filterContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
//            base.OnActionExecuting(filterContext);
//        }
//    }
//}
