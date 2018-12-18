using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityTest.Models
{
    public class User : IdentityUser
    {
        public List<Message> Messages {get;set;}
        public User()
        {
            Messages = new List<Message>();
        }
    }
    public class Message
    {
        public int MessageId {get;set;}
        public string MessageText {get;set;}
        public string UserId {get;set;}
        public User User {get;set;}
    }
}