//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblChatMessages
    {
        public int Id { get; set; }
        public int ChatroomId { get; set; }
        public int SenderId { get; set; }
        public string SenderMessage { get; set; }
        public string SendTimeStamp { get; set; }
    }
}