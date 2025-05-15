using System;
using System.IO;
using System.Windows.Forms;

namespace DeviceInventoryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PrepareDataFiles();

            Application.Run(new MainForm());
        }

        private static void PrepareDataFiles()
        {
            string deviceTypesPath = @"C:\Users\evans\Downloads\Winforms\CRUDWinformsApp\EvansInterview-WinformsApp\data.txt";
            string panelsPath = @"C:\Users\evans\Downloads\Winforms\CRUDWinformsApp\EvansInterview-WinformsApp\panels.txt";

            try
            {
                // Ensure directories exist
                Directory.CreateDirectory(Path.GetDirectoryName(deviceTypesPath));

                // Create device types file if it doesn't exist
                if (!File.Exists(deviceTypesPath))
                {
                    string deviceTypesJson = @"{
  ""deviceTypes"": {
    ""totalCount"": 260,
    ""countByType"": {
      ""evertz_mv"": 1,
      ""evertz_multiviewercontrol"": 1,
      ""PackagerAuto"": 109,
      ""Automatic grd"": 4,
      ""Automatic info"": 24,
      ""Router"": 133,
      ""IPManager"": 3,
      ""IP_HARRIS_LRC"": 15,
      ""tx_supervisor"": 1,
      ""supervisor"": 1,
      ""workstation_tracker"": 1,
      ""Device_ID"": 2
      /* Many more device types omitted for brevity */
    }
  }
}";
                    File.WriteAllText(deviceTypesPath, deviceTypesJson);
                }

                // Create panels file if it doesn't exist
                if (!File.Exists(panelsPath))
                {
                    string panelsJson = @"{
  ""panelsInWorkstations"": {
    ""totalCount"": 954,
    ""workStationCountByPanel"": {
      ""ringmaster_packaging/package_router"": 198,
      ""ringmaster_packaging/arrivals_board"": 188,
      ""ringmaster_packaging/os_view"": 193,
      ""studio_common/router_sdi_salt_xy_list"": 59,
      ""studio_common/router_sdi_pepper_xy_list"": 59,
      ""studio_common/video_ter_salt_mon"": 1,
      ""studio_common/video_ter_pepper_mon"": 1,
      ""studio_racks/button_mapping_salt"": 1,
      ""studio_racks/button_mapping_pepper"": 1,
      ""studio_racks/salt_xy_mapped"": 2,
      ""studio_racks/pepper_xy_mapped"": 2,
      ""Imagine_SNP/SNP"": 0,
      ""MGN"": 31,
      """": 170
      /* Many more panel types omitted for brevity */
    }
  }
}";
                    File.WriteAllText(panelsPath, panelsJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error preparing data files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}