//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendanceApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseRegistration
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int StartTimeID { get; set; }
        public int EndTimeID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Time Time { get; set; }
        public virtual Time Time1 { get; set; }
    }
}