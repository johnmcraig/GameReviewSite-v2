using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviewSite.Models
{
    public class GameModel
    {
        public string Game_Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int Id { get; set; }
    }
}
