using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubBrokerClassLib
{
    public class IssuesLabels : List<string>
    {
        private const string SeparatorLabels = ",";

        public string JoinToString()
        {
            return this.Aggregate((x, y) => x + SeparatorLabels + y);
        }
    }
}
