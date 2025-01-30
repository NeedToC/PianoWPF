using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YoctoWPF.Mvvm.Input;

namespace PianoWPF
{
    public class MainViewViewModel
    {
        private const ushort KeyC4 = 262;
        public ICommand CmdKeyC4 { get; private set; }
        private const ushort KeyC4_Sharp = 277;
        public ICommand CmdKeyC4Sharp { get; private set; }
        private const ushort KeyD4 = 294;
        public ICommand CmdKeyD4 { get; private set; }
        private const ushort KeyD4_Sharp = 311;
        public ICommand CmdKeyD4Sharp { get; private set; }
        private const ushort KeyE4 = 330;
        public ICommand CmdKeyE4 { get; private set; }
        private const ushort KeyF4 = 349;
        public ICommand CmdKeyF4 { get; private set; }
        private const ushort KeyF4_Sharp = 370;
        public ICommand CmdKeyF4Sharp { get; private set; }
        private const ushort KeyG4 = 392;
        public ICommand CmdKeyG4 { get; private set; }
        private const ushort KeyG4_Sharp = 415;
        public ICommand CmdKeyG4Sharp { get; private set; }
        private const ushort KeyA4 = 440;
        public ICommand CmdKeyA4 { get; private set; }
        private const ushort KeyA4_Sharp = 466;
        public ICommand CmdKeyA4Sharp { get; private set; }
        private const ushort KeyB4 = 494;
        public ICommand CmdKeyB4 { get; private set; }
        private const ushort KeyC5 = 523;
        public ICommand CmdKeyC5 { get; private set; }
        private const ushort KeyC5_Sharp = 554;
        public ICommand CmdKeyC5Sharp { get; private set; }
        private const ushort KeyD5 = 587;
        public ICommand CmdKeyD5 { get; private set; }
        private const ushort KeyD5_Sharp = 622;
        public ICommand CmdKeyD5Sharp { get; private set; }
        private const ushort KeyE5 = 659;
        public ICommand CmdKeyE5 { get; private set; }
        private const ushort KeyF5 = 698;
        public ICommand CmdKeyF5 { get; private set; }
        private const ushort KeyF5_Sharp = 740;
        public ICommand CmdKeyF5Sharp { get; private set; }
        private const ushort KeyG5 = 784;
        public ICommand CmdKeyG5 { get; private set; }
        private const ushort KeyG5_Sharp = 831;
        public ICommand CmdKeyG5Sharp { get; private set; }
        private const ushort KeyA5 = 880;
        public ICommand CmdKeyA5 { get; private set; }
        private const ushort KeyA5_Sharp = 932;
        public ICommand CmdKeyA5Sharp { get; private set; }
        private const ushort KeyB5 = 988;
        public ICommand CmdKeyB5 { get; private set; }
        private const ushort KeyC6 = 1046;
        public ICommand CmdKeyC6 { get; private set; }
        private const ushort KeyC6_Sharp = 1109;
        public ICommand CmdKeyC6Sharp { get; private set; }
        private const ushort KeyD6 = 1175;
        public ICommand CmdKeyD6 { get; private set; }


        private const int DefaultDuration = 300;
        public int Duration { get; set; } = DefaultDuration;


        public MainViewViewModel()
        {
            CmdKeyC4 = new RelayCommand(OnCmdKeyC4);
            CmdKeyC4Sharp = new RelayCommand(OnCmdKeyC4Sharp);
            CmdKeyD4 = new RelayCommand(OnCmdKeyD4);
            CmdKeyD4Sharp = new RelayCommand(OnCmdKeyD4Sharp);
            CmdKeyE4 = new RelayCommand(OnCmdKeyE4);
            CmdKeyF4 = new RelayCommand(OnCmdKeyF4);
            CmdKeyF4Sharp = new RelayCommand(OnCmdKeyF4Sharp);
            CmdKeyG4 = new RelayCommand(OnCmdKeyG4);
            CmdKeyG4Sharp = new RelayCommand(OnCmdKeyG4Sharp);
            CmdKeyA4 = new RelayCommand(OnCmdKeyA4);
            CmdKeyA4Sharp = new RelayCommand(OnCmdKeyA4Sharp);
            CmdKeyB4 = new RelayCommand(OnCmdKeyB4);

            CmdKeyC5 = new RelayCommand(OnCmdKeyC5);
            CmdKeyC5Sharp = new RelayCommand(OnCmdKeyC5Sharp);
            CmdKeyD5 = new RelayCommand(OnCmdKeyD5);
            CmdKeyD5Sharp = new RelayCommand(OnCmdKeyD5Sharp);
            CmdKeyE5 = new RelayCommand(OnCmdKeyE5);
            CmdKeyF5 = new RelayCommand(OnCmdKeyF5);
            CmdKeyF5Sharp = new RelayCommand(OnCmdKeyF5Sharp);
            CmdKeyG5 = new RelayCommand(OnCmdKeyG5);
            CmdKeyG5Sharp = new RelayCommand(OnCmdKeyG5Sharp);
            CmdKeyA5 = new RelayCommand(OnCmdKeyA5);
            CmdKeyA5Sharp = new RelayCommand(OnCmdKeyA5Sharp);
            CmdKeyB5 = new RelayCommand(OnCmdKeyB5);

            CmdKeyC6 = new RelayCommand(OnCmdKeyC6);
            CmdKeyC6Sharp = new RelayCommand(OnCmdKeyC6Sharp);
            CmdKeyD6 = new RelayCommand(OnCmdKeyD6);
        }

        private void OnCmdKeyC4()
        {
            Console.Beep(KeyC4, Duration);
        }

        private void OnCmdKeyC4Sharp()
        {
            Console.Beep(KeyC4_Sharp, Duration);
        }

        private void OnCmdKeyD4()
        {
            Console.Beep(KeyD4, Duration);
        }

        private void OnCmdKeyD4Sharp()
        {
            Console.Beep(KeyD4_Sharp, Duration);
        }

        private void OnCmdKeyE4()
        {
            Console.Beep(KeyE4, Duration);
        }

        private void OnCmdKeyF4()
        {
            Console.Beep(KeyF4, Duration);
        }

        private void OnCmdKeyF4Sharp()
        {
            Console.Beep(KeyF4_Sharp, Duration);
        }

        private void OnCmdKeyG4()
        {
            Console.Beep(KeyG4, Duration);
        }

        private void OnCmdKeyG4Sharp()
        {
            Console.Beep(KeyG4_Sharp, Duration);
        }

        private void OnCmdKeyA4()
        {
            Console.Beep(KeyA4, Duration);
        }

        private void OnCmdKeyA4Sharp()
        {
            Console.Beep(KeyA4_Sharp, Duration);
        }

        private void OnCmdKeyB4()
        {
            Console.Beep(KeyB4, Duration);
        }



        private void OnCmdKeyC5()
        {
            Console.Beep(KeyC5, Duration);
        }

        private void OnCmdKeyC5Sharp()
        {
            Console.Beep(KeyC5_Sharp, Duration);
        }

        private void OnCmdKeyD5()
        {
            Console.Beep(KeyD5, Duration);
        }

        private void OnCmdKeyD5Sharp()
        {
            Console.Beep(KeyD5_Sharp, Duration);
        }

        private void OnCmdKeyE5()
        {
            Console.Beep(KeyE5, Duration);
        }

        private void OnCmdKeyF5()
        {
            Console.Beep(KeyF5, Duration);
        }

        private void OnCmdKeyF5Sharp()
        {
            Console.Beep(KeyF5_Sharp, Duration);
        }

        private void OnCmdKeyG5()
        {
            Console.Beep(KeyG5, Duration);
        }

        private void OnCmdKeyG5Sharp()
        {
            Console.Beep(KeyG5_Sharp, Duration);
        }

        private void OnCmdKeyA5()
        {
            Console.Beep(KeyA5, Duration);
        }

        private void OnCmdKeyA5Sharp()
        {
            Console.Beep(KeyA5_Sharp, Duration);
        }

        private void OnCmdKeyB5()
        {
            Console.Beep(KeyB5, Duration);
        }



        private void OnCmdKeyC6()
        {
            Console.Beep(KeyC6, Duration);
        }

        private void OnCmdKeyC6Sharp()
        {
            Console.Beep(KeyC6_Sharp, Duration);
        }

        private void OnCmdKeyD6()
        {
            Console.Beep(KeyD6, Duration);
        }
    }
}
