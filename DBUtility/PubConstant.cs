using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString2
        {           
            get 
            {
                
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];       
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString; 
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString2(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }
        /// <summary>
        /// 得到appsettings.json里配置项的数据库连接字符串。
        /// </summary>
        public class AppSettings
        {
            /// <summary>
            /// 连接字符串是否加密
            /// </summary>
            public static string ConStringEncrypt { get; set; }
            /// <summary>
            /// 数据库连接字符串
            /// </summary>
            public static string ConnectionString { get; set; }
        }

        /// <summary>
        /// 得到appsettings.json里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = configName;
            string ConStringEncrypt = AppSettings.ConStringEncrypt;
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }

        public static string ConnectionString
        {
            get
            {

                string _connectionString = AppSettings.ConnectionString;
                bool StrEncryptB = false;
                bool ConStringEncrypt = String.IsNullOrEmpty(AppSettings.ConStringEncrypt)?false:bool.TryParse(AppSettings.ConStringEncrypt,out StrEncryptB);
                if (ConStringEncrypt&& ConStringEncrypt)
                {
                    _connectionString = DESEncrypt.Decrypt(_connectionString);
                }
                return _connectionString;
            }
        }



    }
}
