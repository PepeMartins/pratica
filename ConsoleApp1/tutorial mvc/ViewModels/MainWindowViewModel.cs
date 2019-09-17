using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using DevExpress.Mvvm;
using System.Threading;

namespace tutorial_mvc.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public bool IsPlaying
        {
            get { return GetValue<bool>(nameof(IsPlaying)); }
            set { SetValue(value, nameof(IsPlaying)); }
        }

        public SoundPlayer Sound
        {
            get { return GetValue<SoundPlayer>(nameof(Sound)); }
            set { SetValue(value, nameof(Sound)); }
        }
        public int Volume
        {
            get { return GetValue<int>(nameof(Volume)); }
            set { SetValue(value, nameof(Volume)); }
        }

        public float LineX
        {
            get { return GetValue<float>(nameof(LineX)); }
            set { SetValue(value, nameof(LineX)); }
        }

        public string BtPlayText
        {
            get { return GetValue<string>(nameof(BtPlayText)); }
            set { SetValue(value, nameof(BtPlayText)); }
        }


        public string Source
        {
            get { return GetValue<string>(nameof(Source)); }
            set { SetValue(value, nameof(Source)); }
        }

        public DelegateCommand PlayCommand
        {
            get; private set;
        }

        public MainWindowViewModel()
        {
            BtPlayText = "Play";
            Volume = 50;
            Source = @"C:\Pp\Internet Money\nick mira\Nick Mira Bodega Drum Kit\Snares & Claps\NM - Blocc (Clap).wav";
            Sound = new SoundPlayer(Source);

            PlayCommand = new DelegateCommand(
                () =>
                {
                    IsPlaying = IsPlaying ? false : true;
                });
            Loop().GetAwaiter();
        }

        private Task Loop()
        {
            return Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (IsPlaying)
                    {
                        LineX += 0.5f;
                        //Sound.Play();
                        Console.WriteLine("Play 1");
                        Thread.Sleep(60);
                    }
                    BtPlayText = IsPlaying ? "Stop" : "Play";
                }

            });
        }

    }
}
