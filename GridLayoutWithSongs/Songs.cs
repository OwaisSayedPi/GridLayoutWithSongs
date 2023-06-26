using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridLayoutWithSongs
{
    public class Songs
    {
        public int SongID { get; set; }
        public string SongName { get; set; }
        public int SongRating { get; set; }
        public int MaxRatingLimit { get; set; }
        private string displayHearts;

        public string DisplayHearts
        {
            get {
                displayHearts = "♥".Repeat(SongRating, MaxRatingLimit);
                return displayHearts; }
        }        
    }
    static class ExtensionClass
    {
        public static string Repeat(this string toRepeat, int SongRating, int Limit)
        {
            string temp = "";
            for (int x = 1; x <= SongRating; x++)
            {
                temp += toRepeat;
            }
            for (int i = 0; i < Limit-SongRating; i++)
            {
                temp += "-";
            }
            return temp;
        }
    }
}
