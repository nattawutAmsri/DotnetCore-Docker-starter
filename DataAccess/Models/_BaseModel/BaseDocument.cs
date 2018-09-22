using System;
namespace DataAccess.Models
{
    public abstract class BaseDocument : BaseModel
    {
        public BaseDocument()
        {
        }
        public string Path { get; set; }
        public string OriginPath { get; set; }
        public string ThumbPath { get; set; }
        public string Extension { get; set; }
        public string FileSize { get; set; }
        public string FileName { get; set; }
        public string URL { get; set; }
    }
}
