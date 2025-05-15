using System.Text.Json;
using DeviceInventory;

namespace DeviceInventoryApp
{
    public partial class MainForm : Form
    {
        private DeviceTypeData deviceData;

        public MainForm()
        {
            InitializeComponent();
            LoadDataFromPath();
        }

        private void LoadDataFromPath()
        {
            var path = @"C:\Users\evans\Downloads\Winforms\CRUDWinformsApp\EvansInterview-WinformsApp\data.txt";

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string jsonContent = reader.ReadToEnd();

                    var deserializedData = JsonSerializer.Deserialize<DeviceTypeData>(jsonContent);

                    if (deserializedData != null)
                    {
                        deviceData = deserializedData;

                        lblDeviceTypesCount.Text = $"Total Device Count: {deviceData.deviceTypes.totalCount}";
                        lblPanelsCount.Text = $"Total Panel Count: {deviceData.panelsInWorkstations.totalCount}";

                        DisplayDeviceTypes();
                        DisplayPanelInStations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to load device data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayDeviceTypes()
        {
            listViewDevice.Items.Clear();

            if (listViewDevice.Columns.Count == 0)
            {
                listViewDevice.Columns.Add("Device Type", 200);
                listViewDevice.Columns.Add("Count", 100);
                listViewDevice.View = View.Details;
            }

            foreach (var device in deviceData.deviceTypes.countByType)
            {
                ListViewItem item = new ListViewItem(device.Key);
                item.SubItems.Add(device.Value.ToString());
                listViewDevice.Items.Add(item);
            }
        }

        private void DisplayPanelInStations()
        {
            listViewPanels.Items.Clear();

            if (listViewPanels.Columns.Count == 0)
            {
                listViewPanels.Columns.Add("Panel Type", 200);
                listViewPanels.Columns.Add("Count", 100);
                listViewPanels.View = View.Details;
            }

            foreach (var panel in deviceData.panelsInWorkstations.workStationCountByPanel)
            {
                ListViewItem item = new ListViewItem(panel.Key);
                item.SubItems.Add(panel.Value.ToString());
                listViewPanels.Items.Add(item);
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}