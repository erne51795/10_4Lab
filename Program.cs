using System;

namespace _10_4lab
{
    class Program
    {

        public static void Main()
        {

            Artist muse = new _10_4lab.Artist("Muse");
            muse.AddToPlaylist("Uprising");
            muse.AddToPlaylist("Knights of Cydonia");
            muse.AddToPlaylist("Madness");
            muse.AddToPlaylist("Thought Contagion");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(muse);

            AudioBook howto = new AudioBook("How to Win Friends & Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);

        }
    }
}