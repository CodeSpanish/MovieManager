using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.BusinessLogic
{
    public interface IMovieListController
    {
        void UpadteList();
        void ListMovies(int? pageSize, int? page);
    }

}
