using System;

namespace AnhShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatedDate { set; get; }
        public String CreatedBy { set; get; }
        public DateTime UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}