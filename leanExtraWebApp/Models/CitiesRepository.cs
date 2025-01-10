namespace leanExtraWebApp.Models
{
    public class CitiesRepository
    {
        private static List<string> Cities = new List<string>()
        {
            "Toronto","Montreal","Ottawa","Calgary","Halifax"
        };
        private static List<string> citiesPic = new List<string>()
        {
            "\\images\\toronto.png","\\images\\montreal.png","\\images\\montreal.png","\\images\\Calgary.png","\\images\\Halifax.png"
        };
        public static List<string> GetCities() => Cities;
        public static List<string> GetCitesiPic() => citiesPic;
    }
}
