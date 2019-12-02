using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Net;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using System.Security.Claims;

//namespace HVITCore.Controllers
//{
//    public class BaseApiController : ApiController
//    {
//        protected async Task<PaginatedResponse<T>> GetPaginatedResponse<T>(IQueryable<T> query, Pagination pagination)
//        {
//            if (pagination == null) pagination = new Pagination();

//            var totalRecords = query.Count();
//            var totalPages = (int)Math.Ceiling((double)totalRecords / pagination.rowsPerPage);

//            pagination.page = pagination.page < 1 ? 0 : pagination.page - 1;

//            var results = await (pagination.rowsPerPage <= 0
//                ? query.ToListAsync()
//                : query.Skip(pagination.rowsPerPage * pagination.page)
//                    .Take(pagination.rowsPerPage)
//                    .ToListAsync());

//            var paginationHeader = new Pagination ()
//            {
//                page = pagination.page,
//                rowsPerPage = pagination.rowsPerPage,
//                records = results.Count,
//                totalItems = totalRecords,
//                totalPages = totalPages
//            };

//            HttpContext.Current.Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

//            return new PaginatedResponse<T>() {
//                Pagination = paginationHeader,
//                Data = results
//            };
//        }

//        protected Nhansu GetNhanSu()
//        {
//            Nhansu nhansu = null;
//            using (ApplicationDbContext db = new ApplicationDbContext())
//            {
//                if (this.User != null)
//                {
//                    nhansu = db.Nhansu
//                        .Include(x => x.Users)
//                        .Include(x => x.PhongBan)
//                        .Include(x => x.PhongBan.DonVi)
//                        .FirstOrDefault(x => x.Users.UserName.Equals(this.User.Identity.Name));
//                    if (nhansu.Users.DonViDangGiaLapID!=null)
//                    {
//                        DonVi donVi = db.DonVi.FirstOrDefault(x => x.DonViID == nhansu.Users.DonViDangGiaLapID);
//                        nhansu.PhongBan.DonVi = donVi;
//                        nhansu.PhongBan.DonViID = (int)nhansu.Users.DonViDangGiaLapID;
//                    }
//                }
//            }
//            return nhansu;
//        }
//    }
//    public class Pagination
//    {
//        public Pagination()
//        {
//            page = 1;
//            rowsPerPage = 10;
//            sortBy = null;
//            descending = true;
//            includeEntities = false;
//        }
//        public int page { get; set; }
//        public int rowsPerPage { get; set; }
//        public int records { get; set; }
//        public int totalItems { get; set; }
//        public int totalPages { get; set; }
//        public string sortBy { get; set; }
//        public bool descending { get; set; }
//        public bool includeEntities { get; set; }
//    }
//    public class PaginatedResponse<T>
//    {
//        public Pagination Pagination { get; set; }
//        public List<T> Data { get; set; }
//    }

//    public class BadRequestErrors : IHttpActionResult
//    {
//        private List<string> messages;
//        private HttpRequestMessage request;

//        public BadRequestErrors(List<string> messages, HttpRequestMessage request)
//        {
//            this.messages = messages;
//            this.request = request;
//        }

//        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
//        {
//            var response = request.CreateResponse(HttpStatusCode.BadRequest, messages);
//            return Task.FromResult(response);
//        }
//    }

//    public class OverrideRolesAttribute : AuthorizationFilterAttribute
//    {
//        public override Task OnAuthorizationAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
//        {
//            var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;

//            if (principal.Identity.IsAuthenticated)
//            {
//                return Task.FromResult<object>(null);
//            }

//            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Access Denied");
//            return Task.FromResult<object>(null);
//        }
//    }
//}