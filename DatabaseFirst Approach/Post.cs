//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst_Approach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int Post_Id { get; set; }
        public string Post_Description { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public Nullable<int> Blog_Id { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}
