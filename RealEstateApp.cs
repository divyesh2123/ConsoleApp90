using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    public class RealEstateApp
    {
        List<RealEstateListing> list = new List<RealEstateListing>();

        public void AddListing(RealEstateListing realEstateListing)
        {
            list.Add(realEstateListing);
        }

        public void RemoveListing(int listd)
        {

            list.RemoveAll(y => y.Id == listd);
        }

        public void UpdateListing(RealEstateListing realEstateListing)
        {
            var d = list.Find(y => y.Id == realEstateListing.Id);   

            d.Description = realEstateListing.Description;
            d.Price = realEstateListing.Price;  
            d.Title = realEstateListing.Title;
        }

        public List<RealEstateListing> GetListings()
        {
            return list;
        }

        public List<RealEstateListing> GetListingsByLocation(string location)
        {
           return list.FindAll(y=>y.Location == location);    
        }

        public List<RealEstateListing> GetListingsByPriceRange(int min,int max)
        {
            return list.FindAll(y => y.Price >= min && y.Price <= max);

        }

    }
}
