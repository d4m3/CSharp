using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// TODO - disable buttons to be grayed when clicked
namespace WPFUserInterface
{
    public partial class Form1 : Form
    {
        // Cancelation Token Src for termnation process
        CancellationTokenSource cts = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void executeSync_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var results = DemoMethods.RunDownloadSync(); //RunDownloadParallelSync
            PrintResults(results);

            watch.Stop();
            var elapedMs = watch.ElapsedMilliseconds;
            resultsWindow.Text += $"Total execution time: { elapedMs }";
        }

        // Async
        private async void executeAsync_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                var results = await DemoMethods.RunDownloadAsync(progress, cts.Token);
                PrintResults(results);
            }
            catch (OperationCanceledException)
            {
                resultsWindow.Text += $"The Async download was cancelled. { Environment.NewLine }";                
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultsWindow.Text += $"Total Async execution time: {elapsedMs}";
        }

        private void ReportProgress(object sender, ProgressReportModel e)
        {
            dashboardProgress.Value = e.PercentageComplete;
            PrintResults(e.SitesDownloaded); // Prints what has been download thus far

        }

        // Parallel
        private async void executeParallelAsync_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            var results = await DemoMethods.RunDownloadParallelAsyncV2(progress);//RunDownloadParallelAsync();
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultsWindow.Text += $"Total Parallel execution time: {elapsedMs} ";

        }

        // Cancel
        private void cancelOperation_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void PrintResults(List<WebsiteDataModel> results)
        {
            resultsWindow.Text="";
            foreach (var item in results)
            {
                resultsWindow.Text += $"{item.WebsiteUrl} downloaded: {item.WebsiteData.Length} characters long.{ Environment.NewLine }";
            }
        }
    }
}
