namespace xlabs_pubapp.Models
{
    public class SeedData
    {
        public static PubDataContext Initialize(PubDataContext pubdataContext)
        {

            pubdataContext.Details.Add(new PubDetail
            {
                Id = 1,
                Name = "Golf Cafe Bar",
                Category = Category.BarReview,
                Url = "http://leedsbeer.info/?p=1382",
                Date = DateTime.Parse("2013-04-27T14:44:22+00:00"),
                Excerpt = "FORE! You can play \"golf\" here and enjoy a nice bottled ale.",
                Thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/04/20130422_204442.jpg",
                Lat = "53.7934952",
                Lng = "-1.5478653",
                Address = "1 Little Neville Street, Granary Wharf, Leeds LS1 4ED",
                Phone = "0113 244 4428",
                Twitter = "GolfCafeBar",
                StarsBeer = 2.5,
                StarsAtmosphere = 2.5,
                StarsAmnities = 3.5,
                StarsValue = 2.5,
                Tags = "beer garden,coffee,food,free wifi,sports"
            });
            pubdataContext.Details.Add(new PubDetail
            {
                Id = 2,
                Name = "115 The Headrow",
                Category = Category.PubReview,
                Url = "http://leedsbeer.info/?p=2753",
                Date = DateTime.Parse("2014-10-18T15:48:51+00:00"),
                Excerpt = "A bar that lives up to its name.",
                Thumbnail = "http://leedsbeer.info/wp-content/uploads/2014/10/115.jpg",
                Lat = "53.7994003",
                Lng = "-1.545981",
                Address = "115 The Headrow, Leeds, LS1 5JW",
                Phone = "0113 244 4428",
                Twitter = "BLoungeGrp",
                StarsBeer = 1.5,
                StarsAtmosphere = 3,
                StarsAmnities = 2.5,
                StarsValue = 2,
                Tags = "coffee,food"
            });

            pubdataContext.SaveChanges();

            return pubdataContext;
            
        }
    }
}
