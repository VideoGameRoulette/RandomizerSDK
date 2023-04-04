using GameRandomizer;

namespace RandomizerSDK
{
    public partial class Map : Form
    {
        private int[,] map;
        private Dictionary<string, string> randomItems;
        private Dictionary<string, int> locationIDDict;

        public Map(Randomizer<Powers> randomizer)
        {
            InitializeComponent();
            randomItems = randomizer.GetRandomizedItems();
            locationIDDict = randomizer.GetLocationIDDictionary();

            // Read the CSV file
            // Get the path of the executable
            string exePath = Path.GetDirectoryName(Application.ExecutablePath);

            // Set the path to the CSV file relative to the executable path
            string filePath = Path.Combine(exePath, "maps/map1.csv");
            string[] lines = File.ReadAllLines(filePath);

            // Get the length of the first line and number of lines
            int x = lines[0].Split(',').Length;
            int y = lines.Length;

            // Create the map of squares
            this.map = new int[x, y];
            for (int i = 0; i < y; i++)
            {
                string[] data = lines[i].Split(',');
                for (int j = 0; j < x; j++)
                {
                    int value = int.Parse(data[j]);
                    this.map[j, i] = value;
                }
            }

            // Set the size of the form
            this.ClientSize = new Size(x * 20, y * 20);
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        public string FindRandomItemKey(string value)
        {
            foreach (var kvp in randomItems)
            {
                if (kvp.Value == value)
                {
                    return kvp.Key;
                }
            }

            // If no matching key was found, return null or throw an exception
            return null;
        }

        public string FindRandomItemValue(string key)
        {
            string value;
            if (randomItems.TryGetValue(key, out value))
            {
                return value;
            }

            // If no matching value was found, return a default value or throw an exception
            return default;
        }

        // Given a value, find the corresponding key (name)
        public string FindKey(int value)
        {
            foreach (var kvp in locationIDDict)
            {
                if (kvp.Value == value)
                {
                    return kvp.Key;
                }
            }

            // If no matching key was found, return null or throw an exception
            return null;
        }

        // Given a key (name), find the corresponding value
        public int FindValue(string key)
        {
            int value;
            if (locationIDDict.TryGetValue(key, out value))
            {
                return value;
            }

            // If no matching value was found, return a default value or throw an exception
            return default;
        }

        private Image? GetItemImage(string itemName)
        {
            switch (itemName)
            {
                case "DataDisruptor":
                    return Properties.Resources.DataDisruptor;
                case "AddressDisruptor1":
                    return Properties.Resources.AddressDisruptor1;
                case "Scythe":
                    return Properties.Resources.Scythe;
                case "Swim":
                    return Properties.Resources.Swim;
                case "TendrilsTop":
                    return Properties.Resources.TendrilsTop;
                case "TendrilsBottom":
                    return Properties.Resources.TendrilsBottom;
                case "AddressDisruptor2":
                    return Properties.Resources.AddressDisruptor2;
                case "FlameThrower":
                    return Properties.Resources.FlameThrower;
                case "WallTrace":
                    return Properties.Resources.WallTrace;
                case "Nova":
                    return Properties.Resources.Nova;
                case "Drill":
                    return Properties.Resources.Drill;
                case "MultiDisruptor":
                    return Properties.Resources.MultiDisruptor;
                case "Kilver":
                    return Properties.Resources.Kilver;
                case "HighJump":
                    return Properties.Resources.HighJump;
                case "FireWall":
                    return Properties.Resources.FireWall;
                case "GlitchTeleport":
                    return Properties.Resources.GlitchTeleport;
                case "DroneGun":
                    return Properties.Resources.DroneGun;
                case "PasswordTool":
                    return Properties.Resources.PasswordTool;
                case "Voranj":
                    return Properties.Resources.Voranj;
                case "VerticalSpread":
                    return Properties.Resources.VerticalSpread;
                case "InertialPulse":
                    return Properties.Resources.InertialPulse;
                case "Grapple":
                    return Properties.Resources.Grapple;
                case "TetheredCharge":
                    return Properties.Resources.TetheredCharge;
                case "Reflect":
                    return Properties.Resources.Reflect;
                case "EnhancedLaunch":
                    return Properties.Resources.EnhancedLaunch;
                case "BlackCoat":
                    return Properties.Resources.BlackCoat;
                case "GlitchBomb":
                    return Properties.Resources.GlitchBomb;
                case "LightningGun":
                    return Properties.Resources.LightningGun;
                case "Shards":
                    return Properties.Resources.Shards;
                case "DroneTeleport":
                    return Properties.Resources.DroneTeleport;
                case "DistortionField":
                    return Properties.Resources.DistortionField;
                case "DataGrenade":
                    return Properties.Resources.DataGrenade;
                case "TriCone":
                    return Properties.Resources.TriCone;
                case "BreachSuppressor":
                    return Properties.Resources.BreachSuppressor;
                case "RedCoat":
                    return Properties.Resources.RedCoat;
                case "IonBeam":
                    return Properties.Resources.IonBeam;
                case string s when s.StartsWith("HealthNode"):
                    if (s.EndsWith("Fragment")) return Properties.Resources.HealthNodeFragment;
                    else return Properties.Resources.HealthNode;
                case string s when s.StartsWith("PowerNode"):
                    if (s.EndsWith("Fragment")) return Properties.Resources.PowerNodeFragment;
                    else return Properties.Resources.PowerNode;
                case string s when s.StartsWith("SizeNode"):
                    return Properties.Resources.SizeNode;
                case string s when s.StartsWith("RangeNode"):
                    return Properties.Resources.RangeNode;
                case string s when s.StartsWith("Note"):
                    return Properties.Resources.Note;
                default:
                    return null;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int i = 0; i < this.map.GetLength(1); i++)
            {
                for (int j = 0; j < this.map.GetLength(0); j++)
                {
                    int value = this.map[j, i];
                    Rectangle rect = new Rectangle(j * 20, i * 20, 20, 20);

                    var k = "";
                    var k2 = "";
                    Image? img;

                    switch (value)
                    {
                        case 0:
                            g.FillRectangle(Brushes.DarkGray, rect); // Draw pink square
                            break;
                        case int n when n >= 1 && n <= 125:
                            k = FindKey(n);
                            k2 = FindRandomItemValue(k);
                            img = GetItemImage(k2);
                            g.FillRectangle(Brushes.Pink, rect); // Draw pink square
                            if (img != null) g.DrawImage(img, rect);
                            break;
                        case 126:
                            g.FillRectangle(Brushes.Pink, rect); // Draw pink square
                            break;
                        case 127:
                            g.FillEllipse(Brushes.Red, rect); // Draw red dot
                            g.FillRectangle(Brushes.Pink, rect); // Draw pink square
                            break;
                        case 128:
                            g.FillRectangle(Brushes.Blue, rect); // Draw blue square
                            break;
                        case 129:
                            g.FillRectangle(Brushes.Red, rect); // Draw red square
                            break;
                        case 130:
                            g.FillEllipse(Brushes.Yellow, rect); // Draw yellow circle
                            g.FillRectangle(Brushes.Blue, rect); // Draw blue square
                            break;
                    }
                }
            }
        }
    }
}
