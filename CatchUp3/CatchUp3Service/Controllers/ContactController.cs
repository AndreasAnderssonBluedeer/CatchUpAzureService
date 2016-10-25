using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using CatchUp3Service.DataObjects;
using CatchUp3Service.Models;
using Microsoft.Azure.Mobile.Server;

namespace CatchUp3Service.Controllers
{
	public class ContactController : TableController<Contact>
	{
		protected override void Initialize(HttpControllerContext controllerContext)
		{
			base.Initialize(controllerContext);
			CatchUp3Context context = new CatchUp3Context();
			DomainManager = new EntityDomainManager<Contact>(context, Request);
		}
		// GET tables/TodoItem
		public IQueryable<Contact> GetAllContacts()
		{
			return Query();
		}

		// GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public SingleResult<Contact> GetContact(string id)
		{
			return Lookup(id);
		}

		// PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task<Contact> PatchContact(string id, Delta<Contact> patch)
		{
			return UpdateAsync(id, patch);
		}

		// POST tables/TodoItem
		public async Task<IHttpActionResult> PostContact(Contact item)
		{
			Contact current = await InsertAsync(item);
			return CreatedAtRoute("Tables", new { id = current.Id }, current);
		}

		// DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
		public Task DeleteContact(string id)
		{
			return DeleteAsync(id);
		}
	}
}