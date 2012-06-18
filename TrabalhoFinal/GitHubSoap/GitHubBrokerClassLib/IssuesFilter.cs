using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitHubBrokerClassLib
{
    public enum IssuesFilter
    {
        Assigned    = 0 , //default
        Created     = 1 ,
        Mentioned   = 2 ,
        Subscribed  = 3
    }
}