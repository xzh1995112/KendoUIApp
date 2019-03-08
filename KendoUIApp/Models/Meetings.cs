//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KendoUIApp1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meetings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meetings()
        {
            this.MeetingAttendees = new HashSet<MeetingAttendees>();
            this.Meetings1 = new HashSet<Meetings>();
        }
    
        public int MeetingID { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> RoomID { get; set; }
        public bool IsAllDay { get; set; }
        public string RecurrenceRule { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MeetingAttendees> MeetingAttendees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meetings> Meetings1 { get; set; }
        public virtual Meetings Meetings2 { get; set; }
    }
}
