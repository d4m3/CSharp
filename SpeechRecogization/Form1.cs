using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace SpeechRecogization
{
    public partial class Form : System.Windows.Forms.Form
    {
        // Form Declarations
        SpeechSynthesizer speech = new SpeechSynthesizer();
        PromptBuilder prompt = new PromptBuilder();
        SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine();
        Choices choicesList = new Choices();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            choicesList.Add(new string[] {"hello", "how are you", "what is the current time", "open chrome", "thank you", "close" });
            Grammar grammer = new Grammar(new GrammarBuilder(choicesList));

            try
            {
                speechEngine.RequestRecognizerUpdate();
                speechEngine.LoadGrammar(grammer);
                speechEngine.SpeechRecognized += speechEngine_SpeechRecognized;
                speechEngine.SetInputToDefaultAudioDevice();
                speechEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void speechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "close")
            {
                Application.Exit();
            }
            if (e.Result.Text == "hello")
            {
                speech.SpeakAsync("hello to you too");
            }
            if (e.Result.Text == "how are you")
            {
                speech.SpeakAsync("I'm doing great");
            }
            if (e.Result.Text == "open chrome")
            {
                Process.Start("chrome", "https://cnn.com");
            }
            if (e.Result.Text == "thank you")
            {
                speech.SpeakAsync("Its my pleaseure!");
            }
                        
            txtContents.Text += e.Result.Text.ToString() + Environment.NewLine;
            
            /*
            switch (e.Result.Text.ToString())
            {
                case "hello":
                    speech.SpeakAsync("hello to you too");
                    break;
                case "how are you":
                    speech.SpeakAsync("I'm doing great");
                    break;
                case "what is the current time":
                    speech.SpeakAsync("the time is"+DateTime.Now.ToLongTimeString());
                    break;
                case "open chrome":
                    Process.Start("chrome","https://cnn.com");
                    break;
                case "thank you":
                    speech.SpeakAsync("Its my pleaseure!");
                    break;
                case "close":
                    Application.Exit();
                    break;
            }            
            txtContents.Text += e.Result.Text.ToString() + Environment.NewLine;
            */
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            speechEngine.RecognizeAsyncStop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
