//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace memoral.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int isOnline { get; set; }
        public int degree { get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
    }
}
