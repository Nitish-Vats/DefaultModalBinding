using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DefaultModalBinding.Models;
using System.Net.Http;



namespace DefaultModalBinding.Components
{
    public class CommentViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            HttpClient client = new HttpClient();
            ICollection<CommentViewComponent> comments = client.GetFromJsonAsync<ICollection<CommentViewComponent>>
                ("https://jsonplaceholder.typicode.com/comments?postId="+id).Result;
            return View("~/views/Components/comment.cshtml", comments);

        }
    }
}
