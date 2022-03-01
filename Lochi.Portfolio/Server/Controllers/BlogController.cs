using Lochi.Portfolio.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Text;

namespace Lochi.Portfolio.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        public BlogController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        [Route("getFeed")]
        public Task<HashSet<BlogSummary>> GetFeed()
        {
            HashSet<BlogSummary> result = _cache.Get<HashSet<BlogSummary>>("currentFeed");
            if (result is null)
            {
                string? feedPath = Path.Combine("Blogs", "Feed");
                string[]? files = Directory.GetFiles(feedPath);
                result = new HashSet<BlogSummary>();
                foreach (string? file in files)
                {
                    FileInfo? fileInfo = new FileInfo(file);
                    StringBuilder summary = new();
                    using (StreamReader sr = fileInfo.OpenText())
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            string? s = sr.ReadLine();
                            if (s is not null)
                            {
                                if (i != 0)
                                {
                                    s = " " + s;
                                }
                                summary.Append(s);
                            }
                        }
                    }
                    result.Add(new BlogSummary(fileInfo.Name.Remove(fileInfo.Name.Length - 3), summary.ToString(), fileInfo.LastWriteTimeUtc));
                }
                if (result.Count > 0)
                {
                    _cache.Set("currentFeed", result);
                }

            }
            return Task.FromResult(result);
        }
        [HttpGet]
        [Route("getBlog/{blogName}")]
        public IActionResult GetBlogAsync(string blogName)
        {
            Blog blog = _cache.Get<Blog>(blogName);
            if (blog is null)
            {
                string[]? files = Directory.GetFiles("Blogs", blogName + ".md", SearchOption.AllDirectories);
                if (files.Length == 0)
                {
                    return NotFound();
                }

                string? file = files[0];
                FileInfo? fileInfo = new FileInfo(file);
                blog = new Blog(blogName, string.Empty, fileInfo.LastWriteTimeUtc, System.IO.File.ReadAllText(file));
                _cache.Set(blogName, blog, TimeSpan.FromHours(1));
            }
            return Ok(blog);
        }
        [HttpGet]
        [Route("VideoPlayback")]
        public IActionResult VideoPlayback([FromQuery] string fileName)
        {
            string? filePath = Path.Combine(Directory.GetCurrentDirectory(), "Blogs", "Videos", fileName);
            if (System.IO.File.Exists(filePath))
            {
                return PhysicalFile(filePath, "application/octet-stream", enableRangeProcessing: true);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
