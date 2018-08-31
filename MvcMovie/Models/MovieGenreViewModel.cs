using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> movies;  // 영화목록
        public SelectList genres;    // 장르 목록을 포함한 SelectList - 이를 통해 사용자는 목록에서 장르선택
        public string movieGenre { get; set; }  //선택한 장르가 포함된 movieGenre
    }
}
