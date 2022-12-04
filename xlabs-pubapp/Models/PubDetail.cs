namespace xlabs_pubapp.Models
{
    public class PubDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string Url { get; set; }
        public DateTime Date { get; set; }
        public string Excerpt { get; set; }
        public string Thumbnail { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Twitter { get; set; }
        public double StarsBeer { get; set; }
        public double StarsAtmosphere { get; set; }
        public double StarsAmnities { get; set; }
        public double StarsValue { get; set; }
        public string Tags { get; set; }
    }
}
