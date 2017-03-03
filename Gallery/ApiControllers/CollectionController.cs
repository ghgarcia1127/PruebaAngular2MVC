

namespace Gallery.ApiControllers
{
    using Core;
    using Core.IServices;
    using Dtos;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;

    [RoutePrefix("api/collection")]
    public class CollectionController : ApiController
    {
        #region Private members
        private ICollectionService service;
        #endregion

        #region Construction
        public CollectionController()
        {
            this.service = ContainerBootstrapper.GetType<ICollectionService>();
        }
        public CollectionController(ICollectionService service)
        {
            this.service = service;
        }
        #endregion

        #region Public members
        // GET: api/Collection
        [Route("")]
        public async Task<IHttpActionResult> GetAllAsync()
        {
            try
            {
                return Ok(await service.GetAllAsync());
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET: api/Collection/5
        [Route("{id}")]
        public IHttpActionResult FindbyId(Guid id)
        {
            try
            {
                return Ok(service.FindById(id));
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        //POST: api/Collection/
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(Collection entity)
        {
            try
            {
                service.Add(entity);
                return Ok();
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        #endregion
    }
}
