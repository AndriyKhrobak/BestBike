using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TitleTurtle.Models
{
    public class SearchResultViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
    }
    public class SearchViewModel
    {
        public Article Article { get; set; }
        public IEnumerable<Article> Results { get; set; }
    }
}