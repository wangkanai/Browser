// Copyright (c) 2014-2020 Sarin Na Wangkanai, All Rights Reserved.
// The Apache v2. See License.txt in the project root for license information.

using System.Linq;

namespace Wangkanai.Detection
{
    public class CrawlerResolver : BaseResolver, ICrawlerResolver
    {
        public ICrawler Crawler => _crawler;

        private readonly ICrawler _crawler;

        public CrawlerResolver(IUserAgentService service) : base(service)
        {
            _crawler = GetCrawler();
        }

        private Crawler GetCrawler()
        {
            if (!IsCrawler()) return null;

            var agent = UserAgent.ToString();
            if (agent.Contains("Yahoo"))
                agent = agent.Replace("Yahoo! Slurp", "Yahoo!Slurp");

            var split = agent.ToString().Split(' ');
            var bot = split.Where(x => CrawlerCollection.Keywords.Count(y => x.ToLower().Contains(y)) == 1)
                           .FirstOrDefault();

            string name, version;
            var index = bot.IndexOf('/');
            if (index < 0)
                index = bot.IndexOf(';');

            if (index < 0)
            {
                name = bot;
                version = string.Empty;
            }
            else
            {
                name = bot.Substring(0, index);
                version = bot.Substring(index + 1).TrimEnd(';');
            }

            if (version == string.Empty)
                return new Crawler(name);

            return new Crawler(name, version);
        }

        private bool IsCrawler()
        {
            var agent = GetUserAgent();
            if (agent == null) return false;
            if (CrawlerCollection.Keywords.Any(keyword => agent.Contains(keyword))) return true;
            return false;
        }
    }
}
