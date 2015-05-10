using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Infrastructure
{
    public class PageData<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _currentItems; 
        public int TotalCount { get; private set; }
        public int Page { get; private set; }
        public int PerPage { get; private set; }
        public int TotalPages { get; private set; }

        public bool HasNextPage { get; private set; }
        public bool HasPreviousPage { get; private set; }

        public int NextPage
        {
            get
            {
                if (!HasNextPage)
                {
                    throw new InvalidOperationException();

                    return Page + 1;
                }
            }
        }

        public int PreviousPage
        {
            get
            {
                if (!HasPreviousPage)
                {
                    throw new InvalidOperationException();

                    return Page - 1;
                }
            }
        }

        public PageData(IEnumerable<T> currentItems, int totalCount, int page, int perPage)
        {
            _currentItems = currentItems;

            TotalCount = totalCount;
            Page = page;
            PerPage = perPage;

            TotalCount = (int) Math.Ceiling((float) TotalCount/PerPage);
            HasNextPage = Page < TotalPages;
            HasPreviousPage = Page > TotalPages;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _currentItems.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}