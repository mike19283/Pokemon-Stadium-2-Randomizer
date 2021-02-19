using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Stadium_2_Randomizer
{
    static class Version
    {
        private static string versionString = "Version 0.021";
        public static string downloadLink;
        public static bool difVersion;
        private static string pasteLink = "https://pastebin.com/ECHhEd2G";
        static List<string> changeLog;
        private static string programName = "Pokemon Stadium 2 Randomizer";
        private static string messageHeader;
        private static string message = "";

        private static void IsUpdateAvailable()
        {
            try
            {
                changeLog = new List<string>();
                    //throw new System.ArgumentException();

                // Get current version from my pastebin
                System.Net.WebClient wc = new System.Net.WebClient();
                byte[] raw = wc.DownloadData(pasteLink);

                // Parse the string
                String webData = System.Text.Encoding.UTF8.GetString(raw);
                    // Split data at my chosen point
                var websiteArr = Regex.Split(webData, "\\>__\\.\\.//\\r\\n");
                string websiteStr = websiteArr[1];
                websiteStr = Regex.Split(websiteStr, "\\<")[0];

                // Update log consists of version[0] and link[1]
                string[] log = Regex.Split(websiteStr, "\\r\\n");
                downloadLink = log[1];

                difVersion = !(versionString == log[0]);

                changeLog = new List<string>(log);
                changeLog.RemoveAt(0);
                changeLog.RemoveAt(0);

                messageHeader = changeLog[0];
                changeLog.RemoveAt(0);
                message = changeLog[0];
                changeLog.RemoveAt(0);

            }
                
            catch (Exception ex)
            {
                    MessageBox.Show("Trouble connecting to the internet. You may be running outdated software!", "Pokemon Name Bot");
                    difVersion = false;
            }

            
        }

        public static void ManualCheck()
        {
            IsUpdateAvailable();

            if (difVersion)
            {
                WillUserUpdate();
            }
            else
            {
                MessageBox.Show("You are running the current version!", programName);
            }


        }

        public static void OnLoad()
        {

            IsUpdateAvailable();
            if (message != "")
            {
                MessageBox.Show(message, messageHeader);
            }
            if (difVersion)
            {
                WillUserUpdate();
            }

        }

        public static void WillUserUpdate()
        {
            // Does the user want to update now?
            if (MessageBox.Show("Your version is outdated. Update now?", programName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Please go to the github for any updates", programName);
                System.Diagnostics.Process.Start("https://github.com/mike19283/Pokemon-Stadium-2-Randomizer");
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Change log";
                s.Filter = "Text (*.txt)|*.txt";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllLines(s.FileName, changeLog.ToArray());
                }
            }
            else
            {
                MessageBox.Show("Not recommended", programName);
            }
        }


        public static string GetVersion() => versionString;

    }
}
