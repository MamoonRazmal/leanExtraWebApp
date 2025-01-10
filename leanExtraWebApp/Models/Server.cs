using System.ComponentModel.DataAnnotations;

namespace leanExtraWebApp.Models
{
    public class Server
    {
        public Server() 
        {
        Random random = new Random();
            int  randomnumber =random.Next(0,2);
            IsOnline = randomnumber ==0?false : true;
        }
        public int ServerId {  get; set; }
        public bool IsOnline { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? City {  get; set; }
        
        public string? CityPicture {  get; set; }
    }
}
