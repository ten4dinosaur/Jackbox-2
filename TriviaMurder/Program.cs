using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TriviaMurder
{
    internal static class Program
    {
        public partial class Questions
        {
            [JsonProperty("content")]
            public Content[] Content { get; set; }
        }

        public partial class Content
        {
            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("choices")]
            public Choice[] Choices { get; set; }
        }

        public partial class Choice
        {
            [JsonProperty("correct", NullValueHandling = NullValueHandling.Ignore)]
            public bool? Correct { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
