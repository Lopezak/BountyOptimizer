using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieBounty
{
    public class ProfileCharacter
    {
        public string characterId { get; set; }
        public int light { get; set; }
        public int classType { get; set; }
        public string emblemPath { get; set; }
        public string emblemBackgroundPath { get; set; }
    }
    public class Data
    {
        public ProfileCharacter Character1 { get; set; }
        public ProfileCharacter Character2 { get; set; }
        public ProfileCharacter Character3 { get; set; }
    }

    public class ProfileCharacters
    {
        public Dictionary<string, ProfileCharacter> data { get; set; }
        public int privacy { get; set; }
    }

    public class ProfileResponse
    {
        public ProfileCharacters characters { get; set; }
    }

    public class ProfileMessageData { }

    public class ProfileModel
    {
        public ProfileResponse Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public ProfileMessageData MessageData { get; set; }
    }


}
