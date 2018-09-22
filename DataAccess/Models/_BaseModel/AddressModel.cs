using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class AddressModel : BaseModel
    {
        public AddressModel()
        {
        }
        public string AddressName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }


    }
}
