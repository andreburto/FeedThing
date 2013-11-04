using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace FeedThing
{
    class RSS
    {
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }



        public RSS(string url)
        {
        }
    }
}
