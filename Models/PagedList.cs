using System.Collections.Generic;

namespace Infrastructure.Service.Model
{
    public class PagedList<TModel>
    {
        public Page Paged { get; set; }
        public IEnumerable<TModel> Data { get; private set; }

        public PagedList(Page paged, IEnumerable<TModel> data)
        {
            Paged = paged;
            Data = data;
        }
    }

    public class Page
    {
        public int TotalCount { get; set; }
        public int Count { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public double Duration { get; set; }
        public double QueryDuration { get; set; }
        public double TotalTime { get; set; }

        public static Page Create(int pageIndex, int pageSize, int totalItemCount, int itemCount, double queryDuration)
        {
            return new Page
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalCount = totalItemCount,
                Count = itemCount,
                QueryDuration = queryDuration
            };
        }
    }
}