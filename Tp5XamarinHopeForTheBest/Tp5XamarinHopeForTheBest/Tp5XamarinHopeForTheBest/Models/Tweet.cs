using System;
using System.Collections.Generic;
using System.Text;

namespace Tp5XamarinHopeForTheBest.Models
{
    public class Tweet
    {
        public string Id { get; set; }
        public string DateCreation { get; set; }
        public string Texte { get; set; }
        public string NomUser { get; set; }
        public string IdUser { get; set; }
        public string PseudoUser { get; set; }
    }
}
