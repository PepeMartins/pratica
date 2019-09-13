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
        private bool IsPlaying = false;

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
            Volume = 50;
            Source = @"C:\Pp\Internet Money\nick mira\Nick Mira Bodega Drum Kit\Snares & Claps\NM - Blocc (Clap).wav";
            Sound = new SoundPlayer(Source);

            PlayCommand = new DelegateCommand(
                () =>
                {
                    IsPlaying = IsPlaying ? false : true;
                    if (IsPlaying)
                    {
                        var th = new Thread(new ThreadStart(Loop));
                        th.Start();
                    }
                });
        }

        private void Loop()
        {
            while (IsPlaying)
            {
                Sound.Play();
                Console.WriteLine("Play 1");
                Thread.Sleep(500);
            }
            Sound.Stop();
        }

    }
}
