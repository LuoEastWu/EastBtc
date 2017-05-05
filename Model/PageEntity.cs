using System;

namespace JY.Model
{
    public partial class PageEntity
	{
        public PageEntity() 
        { }
        #region Model
        public string Groupby { get; set; }
        public string Orderby { get; set; }
        public int Page { get; set; }
        public int Pagesize { get; set; }
        public string Pkfield { get; set; }
        public string Refields { get; set; }
        public string Tablename { get; set; }
        public string Where { get; set; }
        #endregion Model
    }
}

