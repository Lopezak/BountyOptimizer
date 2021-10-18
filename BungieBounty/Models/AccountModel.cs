using System;
using System.Collections.Generic;

namespace BungieBounty
{
    public class AccountResponse
    {
        public string iconPath { get; set; }
        public int crossSaveOverride { get; set; }
        public List<int> applicableMembershipTypes { get; set; }
        public bool isPublic { get; set; }
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public string displayName { get; set; }
        public string bungieGlobalDisplayName { get; set; }
        public int bungieGlobalDisplayNameCode { get; set; }
    }

    public class AccountMessageData
    {
    }

    public class AccountModel
    {
        public List<AccountResponse> Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public AccountMessageData MessageData { get; set; }
    }


}
