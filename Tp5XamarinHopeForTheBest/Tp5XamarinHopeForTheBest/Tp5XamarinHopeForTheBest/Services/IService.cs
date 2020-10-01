using System;
using System.Collections.Generic;
using System.Text;
using Tp5XamarinHopeForTheBest.Models;

namespace Tp5XamarinHopeForTheBest.Services
{
    public interface IService
    {
        bool Authentificate(string user, string password);

        List<Tweet> GetTweets();
    }
}
