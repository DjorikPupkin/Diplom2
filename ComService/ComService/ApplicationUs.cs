//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComService
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationUs
    {
        public int id { get; set; }
        public System.DateTime ApplicationDateTime { get; set; }
        public int StatusID { get; set; }
        public string Description { get; set; }
        public int Comid { get; set; }
        public Nullable<System.DateTime> DoneAplDateTime { get; set; }
        public Nullable<int> Detailid { get; set; }
        public Nullable<int> Worid { get; set; }
        public Nullable<System.DateTime> DateTimeWorker { get; set; }
    
        public virtual Detail Detail { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}