using System;
using System.Collections.Generic;
using System.Text;
using Tp4XamarinTest.Models;

namespace Tp4XamarinTest.Services
{
    public interface IService
    {
        bool Authentificate(string user, string password);

        List<Tweet> GetTweets();
    }
}
