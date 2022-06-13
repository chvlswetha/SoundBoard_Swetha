using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
      public enum SoundCategroy
        {
            Animals,
           Cartoons,
           Taunts,
           Warnings
        }
    internal class Sound
    {
        public String Name { get; set; }
        public SoundCategroy Categroy { get; set; }

        public String AudioFile { get; set; }

        public String ImageFile { get; set; }
    }
}
