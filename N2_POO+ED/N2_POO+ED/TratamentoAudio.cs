using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_ED
{
    class TratamentoAudio
    {
         public static void playQuemEsse()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Atomic\Desktop\N2\Pokemons\quemeesse.wav");
            simpleSound.Play();
        }
    }
}
