using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Threading;

namespace ManagementForm.Ui
{
    public partial class DatabaseUI: Form
    {
        const string databaseStatus = "数据库连接状态:";

        public DatabaseUI()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

            string dataSource = textBoxConnectionAdress.Text;
            string dataBaseKey = textBoxConnectionSecret.Text;
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = dataSource;
           
           
            builder["Initial Catalog"] = "management";
            builder["Connect Timeout"] = "5";
            builder["App"] = "EntityFramework";
            Console.WriteLine(builder.ConnectionString);

            if (checkBoxWindowsAuth.Checked == true)
            {
                builder["integrated Security"] = true; // windows auth
            }
            else
            {
                builder["User ID"] = dataBaseKey; // password login
                builder["Password"] = dataBaseKey;
            }
           testConnectionAsync(builder.ConnectionString);
        }

        public async Task testConnectionAsync (string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    labelConnectionState.Text = databaseStatus + "检测中...";
                    await connection.OpenAsync();
                    labelConnectionState.Text = databaseStatus + " 成功";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    labelConnectionState.Text = databaseStatus + " 失败";
                }
            }
        }
        private void checkBoxWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            textBoxConnectionSecret.Enabled = checkBoxWindowsAuth.Checked ? false : true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Get the application configuration file.
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Construct a sql connection string builder 
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            
            // Check if all the textbox is filled 
            if (textBoxConnectionAdress.Text != "" && textBoxConnectionName.Text != "")
            {
                builder["Data Source"] = textBoxConnectionAdress.Text;
                builder["Initial Catalog"] = "management";
                // check box
                if (checkBoxWindowsAuth.Checked)
                {
                    builder["integrated Security"] = true; // windows auth
                                                           // Create a connection string element.
                    ConnectionStringSettings csSettings = new ConnectionStringSettings("ManagementDbContext", builder.ConnectionString, "System.Data.SqlClient");
                    //// Get the connection strings section.
                    ConnectionStringsSection csSection = config.ConnectionStrings;
                    // Add the new element.
                    csSection.ConnectionStrings.Clear();
                    csSection.ConnectionStrings.Add(csSettings);
                    // Save the configuration file.
                    config.Save(ConfigurationSaveMode.Modified);
                    MessageBox.Show("保存成功");
                    AuthUI ower = (AuthUI)this.Owner;
                    ower.loadAsynAsync();
                }
                // sql connection mode 
                else
                {
                    if(textBoxConnectionSecret.Text !="")
                    {
                        builder["User ID"] = textBoxConnectionSecret.Text; // password login
                        builder["Password"] = textBoxConnectionSecret.Text;
                        // Create a connection string element.
                        ConnectionStringSettings csSettings = new ConnectionStringSettings("ManagementDbContext", builder.ConnectionString, "System.Data.SqlClient");
                        //// Get the connection strings section.
                        ConnectionStringsSection csSection = config.ConnectionStrings;
                        // Add the new element.
                        csSection.ConnectionStrings.Clear();
                        csSection.ConnectionStrings.Add(csSettings);
                        // Save the configuration file.
                        config.Save(ConfigurationSaveMode.Modified);
                        MessageBox.Show("保存成功");
                        AuthUI ower = (AuthUI)this.Owner;
                        ower.loadAsynAsync();
                    }
                    else
                    {
                        MessageBox.Show("请正确填写数据库资料");
                      
                    }
                }
            
            }
            else
            {
                MessageBox.Show("请正确填写数据库资料");
            }
        }

        private void DatabaseUI_Load(object sender, EventArgs e)
        {
            string connectionName = "";
            string connectionString = "";
            string connectionProvider = "System.Data.SqlClient";

            // Get the application configuration file.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.PerUserRoamingAndLocal);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;
            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                ConnectionStringSettings cs = csSection.ConnectionStrings[i];
                connectionName = cs.Name;
                if (connectionName == "ManagementDbContext" && cs.ProviderName == connectionProvider)
                {
                    connectionString = cs.ConnectionString;
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                    // check the windows login 
                    if (builder.IntegratedSecurity)
                    {
                        checkBoxWindowsAuth.Checked = true;
                        textBoxConnectionSecret.Enabled = false;
                    }
                    // Datasource 
                    textBoxConnectionAdress.Text = builder.DataSource;
                    // Check if the windows login is no true
                    textBoxConnectionSecret.Text = builder.UserID;
                    break;
                }
            }
            textBoxConnectionName.Text = connectionName;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
    }
}
