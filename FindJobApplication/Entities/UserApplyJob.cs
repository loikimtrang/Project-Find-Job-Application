//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindJobApplication.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserApplyJob
    {
        public int UserId { get; set; }
        public int JobPostId { get; set; }
        public string Status { get; set; }
        public string CoverLetter { get; set; }
        public System.DateTime AppliedAt { get; set; }
        public string CvAttachment { get; set; }
    
        public virtual JobPost JobPost { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
