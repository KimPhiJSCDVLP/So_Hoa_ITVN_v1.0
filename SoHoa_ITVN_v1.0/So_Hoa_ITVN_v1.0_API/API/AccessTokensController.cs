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
//    [RoutePrefix("api/accesstokens")]
//    public class AccessTokensController : BaseApiController
//    {
//        [HttpGet, Route("")]
//        public async Task<IHttpActionResult> Search([FromUri]Pagination pagination)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                IQueryable<AccessTokens> results = db.AccessTokens;

//                results = results.OrderBy(o => o.AccessTokenId);

//                return Ok((await GetPaginatedResponse(results, pagination)));
//            }
//        }

//        [HttpGet, Route("{accessTokenId:int}")]
//        public async Task<IHttpActionResult> Get(int accessTokenId)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                var accessTokens = await db.AccessTokens
//                    .SingleOrDefaultAsync(o => o.AccessTokenId == accessTokenId);

//                if (accessTokens == null)
//                    return NotFound();

//                return Ok(accessTokens);
//            }
//        }

//        [HttpPost, Route("")]
//        public async Task<IHttpActionResult> Insert([FromBody]AccessTokens accessTokens)
//        {
//            if (accessTokens.AccessTokenId != 0) return BadRequest("Invalid AccessTokenId");

//            using (var db = new ApplicationDbContext())
//            {
//                db.AccessTokens.Add(accessTokens);
//                await db.SaveChangesAsync();
//            }

//            return Ok(accessTokens);
//        }

//        [HttpPut, Route("{accessTokenId:int}")]
//        public async Task<IHttpActionResult> Update(int accessTokenId, [FromBody]AccessTokens accessTokens)
//        {
//            if (accessTokens.AccessTokenId != accessTokenId) return BadRequest("Id mismatch");

//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            using (var db = new ApplicationDbContext())
//            {
//                db.Entry(accessTokens).State = EntityState.Modified;

//                try
//                {
//                    await db.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException ducEx)
//                {
//                    bool exists = db.AccessTokens.Count(o => o.AccessTokenId == accessTokenId) > 0;
//                    if (!exists)
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw ducEx;
//                    }
//                }

//                return Ok(accessTokens);
//            }
//        }

//        [HttpDelete, Route("{accessTokenId:int}")]
//        public async Task<IHttpActionResult> Delete(int accessTokenId)
//        {
//            using (var db = new ApplicationDbContext())
//            {
//                var accessTokens = await db.AccessTokens.SingleOrDefaultAsync(o => o.AccessTokenId == accessTokenId);

//                if (accessTokens == null)
//                    return NotFound();

//                db.Entry(accessTokens).State = EntityState.Deleted;

//                await db.SaveChangesAsync();

//                return Ok();
//            }
//        }

//    }
//}
