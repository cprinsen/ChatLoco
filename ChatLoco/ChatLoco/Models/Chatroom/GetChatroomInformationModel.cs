﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatLoco.Models.Chatroom
{
    public class GetChatroomInformationModel
    {
        public string Username { get; set; }
        public string ChatroomName { get; set; }
        public string ParentChatroomName { get; set; }
    }
}