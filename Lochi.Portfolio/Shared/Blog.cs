using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lochi.Portfolio.Shared
{
    public record Blog(string Title, string Summary, DateTime Date,string Content) 
        : BlogSummary(Title, Summary, Date);
}
