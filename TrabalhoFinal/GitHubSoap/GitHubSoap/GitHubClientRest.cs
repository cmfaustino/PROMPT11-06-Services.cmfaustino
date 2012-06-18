using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using GitHubBrokerClassLib;

namespace GitHubSoap
{
    [ServiceContract]
    class GitHubClientRest
    {
        [WebGet(UriTemplate = "issueslist")]
        protected HttpResponseMessage GetIssuesList(IssuesFilter issuesFilter, IssuesState issuesState, IssuesLabels issuesLabels,
                                                    IssuesSort issuesSort, IssuesDirection issuesDirection, IssuesSince issuesSince)
        {
            ;
        }
    }
}
