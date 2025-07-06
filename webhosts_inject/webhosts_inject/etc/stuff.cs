using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webhosts_inject.etc
{
    public class stuff
    {

        private static List<string> loadingMessages = new List<string>
        {
            "Reticulating splines...",
            "Swapping time and space...",
            "Tokenizing real life...",
            "Bending the spoon...",
            "We need a new fuse...",
            "The bits are breeding",
            "Follow the white rabbit",
            "Are we there yet?",
            "It's not you. It's me.",
            "Counting backwards from Infinity",
            "Embiggening Prototypes",
            "Creating time-loop inversion field",
            "Spinning the wheel of fortune...",
            "I'm sorry Dave, I can't do that.",
            "Adjusting flux capacitor...",
            "Cleaning off the cobwebs...",
            "Spinning the hamster…",
            "Stay awhile and listen..",
            "Convincing AI not to turn evil..",
            "How did you get here?",
            "Constructing additional pylons...",
            "Roping some seaturtles...",
            "Dividing by zero...",
            "Proving P=NP...",
            "Entangling superstrings...",
            "Twiddling thumbs...",
            "Trying to sort in O(n)...",
            "Winter is coming...",
            "Aw, snap! Not..",
            "Ordering 1s and 0s...",
            "Updating dependencies...",
            "Please wait... Consulting the manual...",
            "Mining some bitcoins...",
            "Initializing the initializer...",
            "Optimizing the optimizer...",
            "Pushing pixels...",
            "Building a wall...",
            "Running with scissors...",
            "Definitely not a virus...",
            "You may call me Steve.",
            "Obfuscating quantum entanglement",
            "Making breakfast...",
            "Combing the desert...",
            "Yes, yes. Yes. Without the oops."
        };

        public static string get_data(string url) {
            var output = "";
            using (WebClient client = new WebClient())
            {
                string downloadString = client.DownloadString(url);
                output = downloadString;
            }
            return output;
        }
        public static void AppendLines(string filePath, params string[] lines)
        {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
        }
        private static Random random = new Random();

        public static string Shit_Post()
        {
            int index = random.Next(loadingMessages.Count);
            return loadingMessages[index];
        }


    }
}
