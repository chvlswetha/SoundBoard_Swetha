using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
      public enum SoundCategory
    {
            Animals,
           Cartoons,
           Taunts,
           Warnings
        }
    public class Sound
    {
        public String Name { get; set; }
        public SoundCategory Categroy { get; set; }

        public String AudioFile { get; set; }

        public String ImageFile { get; set; }

        public Sound(string name, SoundCategory category) 
        {
            Name = name;
            Categroy = category;
            AudioFile = $"Assets/Audio/{category}/{name}.wav";
            ImageFile = $"Assets/Images/{category}/{name}.png";
        }
    }
}
