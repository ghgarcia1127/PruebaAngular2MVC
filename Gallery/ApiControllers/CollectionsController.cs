namespace Gallery.ApiControllers
{
    using Core;
    using Core.IServices;
    using System.Threading.Tasks;
    using System.Web.Http;
    [RoutePrefix("services/collections")]
    public class CollectionsController : ApiController
    {
        private ICollectionService service;

        CollectionsController()
        {
            service = ContainerBootstrapper.GetType<ICollectionService>();
        }

        [Route("")]
        [HttpGet]
        public async  Task<IHttpActionResult> GetAll()
        {
            try
            {
                return Ok(await service.GetAllAsync());
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
