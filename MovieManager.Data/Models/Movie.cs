using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.Data.Models
{
    public partial class Movie: IMovie
    {
        public int Duration { get; set; }
    }
}
