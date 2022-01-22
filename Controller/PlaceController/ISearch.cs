using System.Collections.Generic;

namespace TripAdvisor
{
    public interface ISearch<T, F>
    {
        public List<T> search(F Fields);
    }
}