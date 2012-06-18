using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubBrokerClassLib
{
    public struct IssuesSince
    {
        public DateTime TimeStamp;

        //http://msdn.microsoft.com/en-us/library/az4se3k1.aspx
        //http://msdn.microsoft.com/en-us/library/az4se3k1.aspx#UniversalSortable
        //YYYY-MM-DDTHH:MM:SSZ
        public string ConvertToIso8601()
        {
            return this.TimeStamp.ToUniversalTime().ToString("u").Replace(" ", "T"); //ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
        }
    }
}
