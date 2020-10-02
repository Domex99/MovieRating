using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class JSONReader
    {
        public List<Rating> LoadData()
        {
            using (StreamReader r = new StreamReader("../../../../MovieRating.Infrastructure.Data/ratings.json"))
            {
                string json = r.ReadToEnd();
                List<Rating> items = JsonConvert.DeserializeObject<List<Rating>>(json);
                return items;
            }
        }
    }
}
