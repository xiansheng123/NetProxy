using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AspNetCore.Proxy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebProxy.Controllers
{
    public class ValuesController : ControllerBase
    {
        [Route("api/get/posts/{postId}")]
        public Task Get(string postId)
        {
//            var options = ProxyOptions.Instance
//                .WithShouldAddForwardedHeaders(false);
            return this.ProxyAsync($"https://jsonplaceholder.typicode.com/posts/{postId}");
        }
        
        [Route("api/post/posts")]
        [HttpPost]
        public Task Post(string str)
        {
//            var options = ProxyOptions.Instance
//                .WithShouldAddForwardedHeaders(false);
//            var aa = new StreamReader(this.Request.Body).ReadToEnd();
            return this.ProxyAsync($"https://jsonplaceholder.typicode.com/posts");
        }
    }
}