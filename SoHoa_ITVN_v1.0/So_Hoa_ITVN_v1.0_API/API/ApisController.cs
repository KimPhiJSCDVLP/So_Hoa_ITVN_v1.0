//using System;
//using System.Data.Entity;
//using System.Linq;
//using System.Web.Http;
//using System.Threading.Tasks;
//using HVITCore.Controllers;
//using System.Data.Entity.Infrastructure;
//using CMS.Models;

//namespace VKS.Controllers
//{
//    [RoutePrefix("api/apis")]
//    public class ApisController : BaseApiController
//    {
//        [HttpGet, Route("")]
//        public async Task<IHttpActionResult> Search([FromUri]Pagination pagination, [FromUri]int? serviceId = null, [FromUri]int? httpMethod = null)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                IQueryable<Apis> results = db.Apis;
//                if (pagination == null)
//                    pagination = new Pagination();
//                if (pagination.includeEntities)
//                {
//                    results = results.Include(o => o.HttpMethods);
//                    results = results.Include(o => o.Services);
//                }

//                if (serviceId.HasValue) results = results.Where(o => o.ServiceId == serviceId);
//                if (httpMethod.HasValue) results = results.Where(o => o.HttpMethod == httpMethod);

//                results = results.OrderBy(o => o.ApiId);

//                return Ok((await GetPaginatedResponse(results, pagination)));
//            }
//        }

//        [HttpGet, Route("{apiId:int}")]
//        public async Task<IHttpActionResult> Get(int apiId)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                var apis = await db.Apis
//                    .Include(o => o.Services)
//                    .Include(o => o.HttpMethods)
//                    .SingleOrDefaultAsync(o => o.ApiId == apiId);

//                if (apis == null)
//                    return NotFound();

//                return Ok(apis);
//            }
//        }

//        [HttpPost, Route("")]
//        public async Task<IHttpActionResult> Insert([FromBody]Apis apis)
//        {
//            if (apis.ApiId != 0) return BadRequest("Invalid ApiId");

//            using (var db = new ApplicationDbContext())
//            {
//                db.Apis.Add(apis);
//                await db.SaveChangesAsync();
//            }

//            return Ok(apis);
//        }

//        [HttpPut, Route("{apiId:int}")]
//        public async Task<IHttpActionResult> Update(int apiId, [FromBody]Apis apis)
//        {
//            if (apis.ApiId != apiId) return BadRequest("Id mismatch");

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            using (var db = new ApplicationDbContext())
//            {
//                db.Entry(apis).State = EntityState.Modified;

//                try
//                {
//                    await db.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException ducEx)
//                {
//                    bool exists = db.Apis.Count(o => o.ApiId == apiId) > 0;
//                    if (!exists)
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw ducEx;
//                    }
//                }

//                return Ok(apis);
//            }
//        }

//        [HttpDelete, Route("{apiId:int}")]
//        public async Task<IHttpActionResult> Delete(int apiId)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                var apis = await db.Apis.SingleOrDefaultAsync(o => o.ApiId == apiId);

//                if (apis == null)
//                    return NotFound();

//                if (await db.GroupApi.AnyAsync(o => o.ApiId == apis.ApiId))
//                    return BadRequest("Unable to delete the apis as it has related groupapi");

//                if (await db.UserApi.AnyAsync(o => o.ApiId == apis.ApiId))
//                    return BadRequest("Unable to delete the apis as it has related userapi");

//                db.Entry(apis).State = EntityState.Deleted;

//                await db.SaveChangesAsync();

//                return Ok();
//            }
//        }

//    }
//}
