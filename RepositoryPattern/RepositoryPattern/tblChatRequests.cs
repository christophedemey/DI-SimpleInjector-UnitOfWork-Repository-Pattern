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
    
    public partial class tblChatRequests
    {
        public int Id { get; set; }
        public int ChatRoomId { get; set; }
        public int InviterId { get; set; }
        public string InviterUsername { get; set; }
        public int InvitedId { get; set; }
        public string RequestedTimeStamp { get; set; }
        public int Accepted { get; set; }
    }
}