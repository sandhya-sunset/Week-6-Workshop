using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Music(string title, int durationInSeconds)
    {
        public string Title { get; set; } = title;
        public int Duration { get; set; } = durationInSeconds;
    }
}