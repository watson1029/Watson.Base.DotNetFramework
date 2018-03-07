using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watson.Base.DotNetFramework
{
    public class ConfigurationHelper
    {
        #region 读取配置文件
        /// <summary>
        /// 获取配置文件中的节点
        /// </summary>
        /// <param name="key">节点名</param>
        /// <returns></returns>
        public static string GetSettingByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        #endregion
    }
}
