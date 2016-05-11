//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WIUTAttendance.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeminarReschedule
    {
        public int ID { get; set; }
        public int SeminarID { get; set; }
        public int TeachingWeek { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.TimeSpan> FromTime { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<System.TimeSpan> ToTime { get; set; }
        public string ToBuilding { get; set; }
        public string ToRoom { get; set; }
        public Nullable<System.DateTime> RescheduleDate { get; set; }
        public string RescheduleReason { get; set; }
    
        public virtual Seminar Seminar { get; set; }
    }
}