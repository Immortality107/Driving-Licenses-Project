using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using DVLDProject;
using DVLDProject.DVLDBusiness;
using UserBusinessTier;
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;

public static class clsGlobal
    {
        public static clsUser CurrentUser = new clsUser();
         static string ValueName = "DVLDProject";
    public static bool RememberUsernameAndPassword(string Username, string Password)
    {

        try
        {
            //this will get the current project directory folder.
            //string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            ClsEventLog.HandleEventLog($"User {Username} Logged Successfully");

            // Define the path to the text file where you want to save the data
            string filePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLDProject";

            //incase the username is empty, delete the file
            if (Username == "" && File.Exists(filePath))
            {
                File.Delete(filePath);
                return true;

            }

            // concatonate username and passwrod withe seperator.
            string dataToSave = Username + "#//#" + ClsHashing.ComputeHash(Password);

            Registry.SetValue(filePath, ValueName, dataToSave, RegistryValueKind.String);
            ClsEventLog.HandleEventLog($"User {Username} Logged Successfully");
            return true;

        }    
            // Create a StreamWriter to write to the file
            //using (StreamWriter writer = new StreamWriter(filePath))
            //{
            //    // Write the data to the file
            //    writer.WriteLine(dataToSave);

        catch (Exception ex)
        {
            ClsEventLog.HandleEventLog($"User {Username} Failed To Login");
            return false;
        }

    }

    public static bool GetStoredCredential(ref string Username, ref string Password)
    {
        //this will get the stored username and password and will return true if found and false if not found.
        try
        {
            //gets the current project's directory
            //string currentDirectory = System.IO.Directory.GetCurrentDirectory();

            // Path for the file that contains the credential.
            string filePath = @"HKEY_LOCAL_MACHINE\SOFTWARE\DVLDProject" + "\\data.txt";

            // Check if the file exists before attempting to read it
            if (File.Exists(filePath))
            {
                // Create a StreamReader to read from the file
                //using (StreamReader reader = new StreamReader(filePath))
                //{
                    // Read data line by line until the end of the file
                    string line;
                    while ((line = Registry.GetValue( filePath,ValueName ,null ) as string) != null)
                    {
                        Console.WriteLine(line); // Output each line of data to the console
                        string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                         Username = result[0];
                         Password = ClsHashing.ComputeHash(result[1]);
                        //Password = result[1];
                    }
                ClsEventLog.HandleEventLog($"User {Username} Retrieved Data");
                return true;
                //}
            }
            else
            {
                ClsEventLog.HandleEventLog($"User {Username} Failed To Retrieve Data");
                return false;
            }
        }
        catch (Exception ex)
        {
            ClsEventLog.HandleEventLog($"User {Username} Failed To Retrieve Data");
            MessageBox.Show($"An error occurred: {ex.Message}");
            return false;
        }

    }

}
    



