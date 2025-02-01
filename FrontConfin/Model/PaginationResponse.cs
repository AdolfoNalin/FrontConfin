using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontConfin.Model
{
    public class PaginationResponse<T> where T : class
    {
        public IEnumerable<T> Data { get; set; }
        public long AllLine { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public PaginationResponse(IEnumerable<T> data, long allLine, int skip, int take)
        {
            Data = data;
            AllLine = allLine;
            Skip = skip;
            Take = take;
        }
    }
}
