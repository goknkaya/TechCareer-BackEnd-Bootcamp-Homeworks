//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOpeningHours
    {
        public int Id { get; set; }
        public Nullable<int> DayOfWeek { get; set; }
        public Nullable<System.TimeSpan> StartHour { get; set; }
        public Nullable<System.TimeSpan> EndHour { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
