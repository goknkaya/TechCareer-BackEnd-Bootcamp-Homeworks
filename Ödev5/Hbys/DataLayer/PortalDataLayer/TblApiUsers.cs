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
    
    public partial class TblApiUsers
    {
        public int UserId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
