using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Sadeaner
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string[] unnecessaryFolders = {
                "%temp%",
                "%systemroot%\\Prefetch",
                "%systemroot%\\SoftwareDistribution",
                "%userprofile%\\AppData\\Local\\Temp",
                "%systemroot%\\Temp",
                "%localappdata%\\Microsoft\\Windows\\INetCache",
                "%systemdrive%\\Windows.old",
                "%systemroot%\\Logs\\CBS",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\WER\\ReportQueue",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\WER\\Temp",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp",
                "%systemdrive%\\$Recycle.bin",
                "%systemdrive%\\System Volume Information",
                "%userprofile%\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\Caches",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\AppRepository",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\StartUp",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\WebCache",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\Windows Error Reporting",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\DeviceMetadataStore",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\Registration",
                "%systemdrive%\\ProgramData\\Microsoft\\Windows\\SystemData",
                "%programfiles%\\Common Files\\Adobe\\OOBE\\PDApp",
                "%programfiles(x86)%\\Common Files\\Adobe\\OOBE\\PDApp",
                "%programfiles%\\Common Files\\Apple\\Apple Application Support",
                "%programfiles(x86)%\\Common Files\\Apple\\Apple Application Support",
                "%programfiles%\\Common Files\\Java\\Java Update",
                "%programfiles(x86)%\\Common Files\\Java\\Java Update",
                "%programfiles%\\Common Files\\Adobe\\ARM",
                "%programfiles(x86)%\\Common Files\\Adobe\\ARM",
                "%programfiles%\\Common Files\\Adobe\\Acrobat\\DC\\Acrobat\\PDFMaker\\Office",
                "%programfiles(x86)%\\Common Files\\Adobe\\Acrobat\\DC\\Acrobat\\PDFMaker\\Office",
                "%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Temporary Internet Files",
                "%userprofile%\\AppData\\Local\\Microsoft\\Windows\\History",
                "%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Cookies",
                "%userprofile%\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\*.default\\cache2",
                "%userprofile%\\AppData\\Roaming\\Mozilla\\Firefox\\Profiles\\*.default\\minidumps",
                "%userprofile%\\.nuget\\packages",
                "%userprofile%\\.npm-cache",
                "%userprofile%\\.bower-cache",
                "%userprofile%\\.cache",
                "%userprofile%\\.ccache",
                "%userprofile%\\.gradle",
                "%userprofile%\\.ivy2",
                "%userprofile%\\.sbt",
                "%userprofile%\\.m2",
                "%userprofile%\\.composer",
                "%userprofile%\\.pip",
                "%userprofile%\\.gem",
                "%userprofile%\\.rvm",
                "%userprofile%\\.nvm",
                "%userprofile%\\.local\\share\\Trash",
                "%userprofile%\\.local\\share\\Trash",
                "%userprofile%\\.local\\share\\Trash",
                "%userprofile%\.cache\pip",
                "%userprofile%\.cache\yarn",
                "%userprofile%\.npm-cache\_cacache",
                "%userprofile%\.vscode\extensions",
                "%systemdrive%\Windows\servicing",
                "%systemdrive%\Windows\System32\Spool\Printers",
                "%userprofile%\AppData\Local\Microsoft\Windows\Explorer",
                "%userprofile%\AppData\Roaming\npm-cache",
                "%systemdrive%\Program Files\Common Files\Microsoft Shared\Windows Live",
                "%userprofile%\Downloads\*.tmp",
                "%systemdrive%\Windows\Installer"
            };

            foreach (string folder in unnecessaryFolders)
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C rd /s /q " + folder;
                    process.Start();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete folder " + folder + ". Error: " + ex.Message);
                }
            }
            MessageBox.Show("The deletion of unnecessary files was carried out successfully.");
        }

        private void textBlock_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/Jisll");
        }

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("https://github.com/Jisll");
        }
    }
}
