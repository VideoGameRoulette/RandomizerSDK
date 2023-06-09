﻿using System.IO;
using System.Diagnostics;
using GameRandomizer;

namespace RandomizerSDK
{
    public partial class ControllerForm : Form
    {
        public ControllerForm()
        {
            InitializeComponent();
            Difficulty.SelectedIndex = 0;
        }

        private async void Benchmark()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int count = 1;

            await Task.Run(() =>
            {

                Parallel.For(1, (int)IterationCount.Value + 1, i =>
                {
                    var path = $"logs/randomizer{i}.log";

                    if ((int)IterationCount.Value == 1 && File.Exists(path)) File.Delete(path);
                    Randomizer<Powers> randomizer = new Randomizer<Powers>(Path.GetDirectoryName(Application.ExecutablePath), Difficulty.SelectedIndex, path);
                    while (randomizer.GetRandomizedItems().Count < 125)
                    {
                        randomizer.GenerateItems(randomizer, (long)SeedValue.Value);
                    }
                    string logDirectory = "logs";
                    string logFilePath = $"logs/locations_{i}.log";
                    Utils.CheckOrCreateDirectory(logDirectory);
                    Utils.WriteDictionaryToLogFile(randomizer.GetRandomizedItems(), logFilePath);
                    Interlocked.Increment(ref count);
                });
            });

            sw.Stop();
            MessageBox.Show($"Finished Generating {count - 1} Times No Issues. Time elapsed: {sw.Elapsed}");
        }

        private async void StartForm()
        {
            var path = $"logs/randomizer.log";
            Map? m = null;
            if ((int)IterationCount.Value == 1 && File.Exists(path)) File.Delete(path);
            Randomizer<Powers> randomizer = new Randomizer<Powers>(Path.GetDirectoryName(Application.ExecutablePath), Difficulty.SelectedIndex, path);
            if (ShowMap.Checked) m = new Map(randomizer);
            while (randomizer.GetRandomizedItems().Count < 125)
            {
                randomizer.GenerateItems(randomizer, (long)SeedValue.Value);
            }
            string logDirectory = "logs";
            string logFilePath = $"logs/locations.log";
            Utils.CheckOrCreateDirectory(logDirectory);
            Utils.WriteDictionaryToLogFile(randomizer.GetRandomizedItems(), logFilePath);
            MessageBox.Show($"Finished Generating No Issues.");
            if (ShowMap.Checked && m != null) m.Show();
        }

        private async void GetItem_Click(object sender, EventArgs e)
        {
            if (IsDebug.Checked) Benchmark();
            else StartForm();
        }

        private void IsDebug_CheckedChanged(object sender, EventArgs e)
        {
            IterationCount.Enabled = IsDebug.Checked;
        }
    }
}
