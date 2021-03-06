﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Luv.Extensions;

namespace Luv.Controllers
{
    /*
    http://127.0.0.1:9000/api/upload
    content-type: application/x-www-form-urlencoded
    TODO 500 At no File Attached
    */

    [System.Web.Http.RoutePrefix("api")]
    public class FileUploadController : ApiController
    {

		[System.Web.Http.Route("upload")]
		[System.Web.Http.HttpPost]
		public async Task<HttpResponseMessage> UploadFile(HttpRequestMessage request)
		{
            var data = await Request.Content.ParseMultipartAsync();

			if (!request.Content.IsMimeMultipartContent())
			{
				throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
			}


			if (data.Files.ContainsKey("file"))
			{
				var file = data.Files["file"].File;
				var fileName = data.Files["file"].Filename;
			}

			if (data.Fields.ContainsKey("description"))
			{
				var description = data.Fields["description"].Value;
			}

			return new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StringContent("Thank you for uploading the file...")
			};
		}
    }
}
