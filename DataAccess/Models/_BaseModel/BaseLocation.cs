using System;
namespace DataAccess.Models
{
    public class BaseLocation : BaseMasterData
    {
        public BaseLocation()
        {
        }

        public string LocationName { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }

    }
}
