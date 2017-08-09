using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Int64 topNumber = 0;

        public Int64 bottomNumber = 0;

        public bool resetNumber = false;

        public DispatcherTimer dispatcherTimer;

        public enum Command
        {
            kCommand_Non,
            kCommand_Add,
            kCommand_Sub,
            kCommand_Mul,
            kCommand_Div
        }

        public Command command = Command.kCommand_Non;

        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            errorContent.Content = "";
            dispatcherTimer.Stop();
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 1;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 2;
            string hexOutput = String.Format("{0:X}", bottomNumber);
           // Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 3;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 4;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 5;
            string hexOutput = String.Format("{0:X}", bottomNumber);
           // Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 6;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 7;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 8;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 9;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonA_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xA;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonB_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xB;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xC;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonD_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xD;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonE_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xE;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonF_Click(object sender, RoutedEventArgs e)
        {
            if (resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0xF;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            if(resetNumber)
            {
                resetNumber = false;
                bottomNumber = 0;
            }
            bottomNumber <<= 4;
            bottomNumber |= 0;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            resetNumber = false;
            switch (command)
            {
                case Command.kCommand_Add:
                    topNumber += bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Add;
                    commandContent.Content = "+";
                    break;
                case Command.kCommand_Sub:
                    topNumber -= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Add;
                    commandContent.Content = "+";
                    break;
                case Command.kCommand_Non:
                    topNumber = bottomNumber;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomNumber = 0;
                    bottomContent.Content = "0";
                    command = Command.kCommand_Add;
                    commandContent.Content = "+";
                    break;
                case Command.kCommand_Mul:
                    topNumber *= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Add;
                    commandContent.Content = "+";
                    break;
                case Command.kCommand_Div:
                    if (bottomNumber != 0)
                    {
                        float fResult = (float)topNumber / (float)bottomNumber;
                        Log.WriteLogFile(fResult.ToString("f5"));
                        if (fResult != (Int64)fResult)
                        {
                            //ERROR
                            errorContent.Content = "ERROR";
                            dispatcherTimer.Start();

                            Log.WriteLogFile(fResult.ToString("f5"));
                            topNumber = bottomNumber = 0;
                            bottomContent.Content = fResult.ToString("f5");
                            topContent.Content = "";
                            resetNumber = false;
                            commandContent.Content = "";
                            command = Command.kCommand_Non;
                        }
                        else
                        {
                            topNumber = (Int64)fResult;
                            bottomNumber = 0;
                            topContent.Content = String.Format("{0:X}", topNumber);
                            bottomContent.Content = "0";
                            command = Command.kCommand_Add;
                            commandContent.Content = "+";
                        }
                    }
                    else
                    {
                        //ERROR
                        errorContent.Content = "ERROR";
                        dispatcherTimer.Start();
                        topNumber = bottomNumber = 0;
                        bottomContent.Content = "0";
                        topContent.Content = "";
                        resetNumber = false;
                        commandContent.Content = "";
                        command = Command.kCommand_Non;
                    }
                    break;
            }
        }

        private void buttonSub_Click(object sender, RoutedEventArgs e)
        {
            resetNumber = false;
            switch (command)
            {
                case Command.kCommand_Add:
                    topNumber += bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Sub;
                    commandContent.Content = "-";
                    break;
                case Command.kCommand_Sub:
                    topNumber -= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Sub;
                    commandContent.Content = "-";
                    break;
                case Command.kCommand_Mul:
                    topNumber *= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Sub;
                    commandContent.Content = "-";
                    break;
                case Command.kCommand_Div:
                    if(bottomNumber != 0)
                    {
                        float fResult = (float)topNumber / (float)bottomNumber;
                        if (fResult != (Int64)fResult)
                        {
                            //ERROR
                            errorContent.Content = "ERROR";
                            dispatcherTimer.Start();
                            topNumber = bottomNumber = 0;
                            bottomContent.Content = fResult.ToString("f5");
                            topContent.Content = "";
                            resetNumber = false;
                            commandContent.Content = "";
                            command = Command.kCommand_Non;
                        }
                        else
                        {
                            topNumber = (Int64)fResult;
                            bottomNumber = 0;
                            topContent.Content = String.Format("{0:X}", topNumber);
                            bottomContent.Content = "0";
                            command = Command.kCommand_Sub;
                            commandContent.Content = "-";
                        }
                    }
                    else
                    {
                        //ERROR
                        errorContent.Content = "ERROR";
                        dispatcherTimer.Start();
                        topNumber = bottomNumber = 0;
                        bottomContent.Content = "0";
                        topContent.Content = "";
                        resetNumber = false;
                        commandContent.Content = "";
                        command = Command.kCommand_Non;
                    }
                    break;
                case Command.kCommand_Non:
                    topNumber = bottomNumber;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomNumber = 0;
                    bottomContent.Content = "0";
                    command = Command.kCommand_Sub;
                    commandContent.Content = "-";
                    break;
            }
        }

        private void buttonReverse_Click(object sender, RoutedEventArgs e)
        {
            bottomNumber = -bottomNumber;
            string hexOutput = String.Format("{0:X}", bottomNumber);
            //Log.WriteLogFile(hexOutput);
            bottomContent.Content = hexOutput;
            resetNumber = true;
            //bottomNumber = 0;
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            resetNumber = false;
            bottomNumber = 0;
            topNumber = 0;
            topContent.Content = "";
            bottomContent.Content = "0";
            command = Command.kCommand_Non;
            commandContent.Content = "";
        }

        private void buttonEqual_Click(object sender, RoutedEventArgs e)
        {
            switch(command)
            {
                case Command.kCommand_Add:
                    bottomNumber = topNumber + bottomNumber;
                    topNumber = 0;
                    topContent.Content = "";
                    bottomContent.Content = String.Format("{0:X}", bottomNumber);
                    //bottomNumber = 0;
                    command = Command.kCommand_Non;
                    commandContent.Content = "";
                    resetNumber = true;
                    break;
                case Command.kCommand_Sub:
                    bottomNumber = topNumber - bottomNumber;
                    topNumber = 0;
                    topContent.Content = "";
                    bottomContent.Content = String.Format("{0:X}", bottomNumber);
                    //bottomNumber = 0;
                    command = Command.kCommand_Non;
                    commandContent.Content = "";
                    resetNumber = true;
                    break;
                case Command.kCommand_Mul:
                    bottomNumber *= topNumber;
                    topNumber = 0;
                    topContent.Content = "";
                    bottomContent.Content = String.Format("{0:X}", bottomNumber);
                    command = Command.kCommand_Non;
                    commandContent.Content = "";
                    resetNumber = true;
                    break;
                case Command.kCommand_Div:
                    if (bottomNumber != 0)
                    {
                        float fResult = (float)topNumber / (float)bottomNumber;
                        if (fResult != (Int64)fResult)
                        {
                            //ERROR
                            errorContent.Content = "ERROR";
                            dispatcherTimer.Start();
                            topNumber = bottomNumber = 0;
                            bottomContent.Content = fResult.ToString("f5");
                            topContent.Content = "";
                            resetNumber = false;
                            commandContent.Content = "";
                            command = Command.kCommand_Non;
                        }
                        else
                        {
                            bottomNumber = (Int64)fResult;
                            topNumber = 0;
                            topContent.Content = "";
                            bottomContent.Content = String.Format("{0:X}", bottomNumber);
                            command = Command.kCommand_Non;
                            commandContent.Content = "";
                            resetNumber = true;
                        }
                    }
                    else
                    {
                        //ERROR
                        dispatcherTimer.Start(); errorContent.Content = "ERROR";
                        dispatcherTimer.Start();
                        topNumber = bottomNumber = 0;
                        bottomContent.Content = "0";
                        topContent.Content = "";
                        resetNumber = false;
                        commandContent.Content = "";
                        command = Command.kCommand_Non;
                    }
                    break;
            }
        }

        private void buttonMul_Click(object sender, RoutedEventArgs e)
        {
            resetNumber = false;
            switch (command)
            {
                case Command.kCommand_Add:
                    topNumber += bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Mul;
                    commandContent.Content = "*";
                    break;
                case Command.kCommand_Sub:
                    topNumber -= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Mul;
                    commandContent.Content = "*";
                    break;
                case Command.kCommand_Mul:
                    topNumber *= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Mul;
                    commandContent.Content = "*";
                    break;
                case Command.kCommand_Div:
                    if (bottomNumber != 0)
                    {
                        float fResult = (float)topNumber / (float)bottomNumber;
                        if (fResult != (Int64)fResult)
                        {
                            //ERROR
                            errorContent.Content = "ERROR";
                            dispatcherTimer.Start();
                            topNumber = bottomNumber = 0;
                            bottomContent.Content = fResult.ToString("f5");
                            topContent.Content = "";
                            resetNumber = false;
                            commandContent.Content = "";
                            command = Command.kCommand_Non;
                        }
                        else
                        {
                            topNumber = (Int64)fResult;
                            bottomNumber = 0;
                            topContent.Content = String.Format("{0:X}", topNumber);
                            bottomContent.Content = "0";
                            command = Command.kCommand_Mul;
                            commandContent.Content = "*";
                        }
                    }
                    else
                    {
                        //ERROR
                        errorContent.Content = "ERROR";
                        dispatcherTimer.Start();
                        topNumber = bottomNumber = 0;
                        bottomContent.Content = "0";
                        topContent.Content = "";
                        resetNumber = false;
                        commandContent.Content = "";
                        command = Command.kCommand_Non;
                    }
                    break;
                case Command.kCommand_Non:
                    topNumber = bottomNumber;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomNumber = 0;
                    bottomContent.Content = "0";
                    command = Command.kCommand_Mul;
                    commandContent.Content = "*";
                    break;
            }
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            resetNumber = false;
            switch (command)
            {
                case Command.kCommand_Add:
                    topNumber += bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Div;
                    commandContent.Content = "/";
                    break;
                case Command.kCommand_Sub:
                    topNumber -= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Div;
                    commandContent.Content = "/";
                    break;
                case Command.kCommand_Mul:
                    topNumber *= bottomNumber;
                    bottomNumber = 0;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomContent.Content = "0";
                    command = Command.kCommand_Div;
                    commandContent.Content = "/";
                    break;
                case Command.kCommand_Div:
                    if (bottomNumber != 0)
                    {
                        float fResult = (float)topNumber / (float)bottomNumber;
                        if (fResult != (Int64)fResult)
                        {
                            //ERROR
                            errorContent.Content = "ERROR";
                            dispatcherTimer.Start();
                            topNumber = bottomNumber = 0;
                            bottomContent.Content = fResult.ToString("f5");
                            topContent.Content = "";
                            resetNumber = false;
                            commandContent.Content = "";
                            command = Command.kCommand_Non;
                        }
                        else
                        {
                            topNumber = (Int64)fResult;
                            bottomNumber = 0;
                            topContent.Content = String.Format("{0:X}", topNumber);
                            bottomContent.Content = "0";
                            command = Command.kCommand_Div;
                            commandContent.Content = "/";
                        }
                    }
                    else
                    {
                        //ERROR
                        errorContent.Content = "ERROR";
                        dispatcherTimer.Start();
                        topNumber = bottomNumber = 0;
                        bottomContent.Content = "0";
                        topContent.Content = "";
                        resetNumber = false;
                        commandContent.Content = "";
                        command = Command.kCommand_Non;
                    }
                    break;
                case Command.kCommand_Non:
                    topNumber = bottomNumber;
                    topContent.Content = String.Format("{0:X}", topNumber);
                    bottomNumber = 0;
                    bottomContent.Content = "0";
                    command = Command.kCommand_Div;
                    commandContent.Content = "/";
                    break;
            }
        }
    }
}
