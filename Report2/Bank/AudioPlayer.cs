using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace Bank
{
    class AudioPlayer
    {
        public void PlaySound()
        {
            SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "D:\\report\\Bank\\Bank\\sfx\\button.wav";
            soundPlayer.Load();
            soundPlayer.Play();
        }
    }
}
