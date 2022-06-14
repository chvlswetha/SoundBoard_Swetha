using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBoard.Model
{
   public static class SoundManager //static - No instantiation //utility class -only methods
    {
        private  static List<Sound> getsounds() 
        {
            var sounds = new List<Sound>();
            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }

        public static void GetAllSounds(ObservableCollection<Sound> sounds) //Datarefresh everytime with observablecollection
        {
            var allsounds = getsounds();
            sounds.Clear();
            /* foreach(var sound in allsounds)
                 sounds.Add(sound);*/
            allsounds.ForEach(sound => sounds.Add(sound));  //LAMBDA statement
        }

        public static void GetAllSoundsByCategory(ObservableCollection<Sound> sounds,SoundCategory category) //Datarefresh everytime with observablecollection
        {
            var allsounds = getsounds();
             //where (var sound in allsounds) filter by category
                
            var filteredsounds = allsounds.Where(
                sound => sound.Categroy  == category).ToList(); //LINQ statement

            sounds.Clear();
            /* foreach(var sound in filteredsounds)
                 sounds.Add(sound);*/
            filteredsounds.ForEach(sound => sounds.Add(sound));  //LAMBDA statement

        }
    }
}
