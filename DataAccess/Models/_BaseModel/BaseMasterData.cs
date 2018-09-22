using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public enum elang { EN = 1, TH = 2 }
    public class BaseMasterData : BaseModel
    {
        public BaseMasterData()
        {
        }

        public int Seq { get; set; }
        [MaxLength(32)]
        public string Code { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public elang Langauge { get; set; }
    }
}
