using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace System
{
    public class Configurator
    {
        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string ServiceHasKeyPrefix
        {
            get { return "MuYingZhiJia_Pqj_"; }
        }

        public static string DbConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString; }
        }

        public static string AutoAsyInvDifferencesFromNewErpToOldErp
        {
            get { return "AutoAsyInvDifferencesFromNewErpToOldErp"; }
        }

        public static string AutoUpdateOrdersProducingToOms
        {
            get { return "AutoUpdateOrdersProducingToOms"; }
        }

        public static string AutoGetCanceledOrdersFromOms
        {
            get { return "AutoGetCanceledOrdersFromOms"; }
        }

        public static string AutoUpdateOrdersPackedToOms
        {
            get { return "AutoUpdateOrdersPackedToOms"; }
        }

        public static string WmsSequences 
        {
            get
            {
                return "MYZJ_WMS_Sequences";
            }
        }

        public static string InventoryChangePlanSequences
        {
            get { return "InventoryChangePlanSequences"; }
        }

        public static int MaxWaveOrderQty
        {
            get
            {
                int _maxWaveOrderQty;
                if (int.TryParse(GetAppSetting("MaxWaveOrderQty"), out _maxWaveOrderQty))
                    return _maxWaveOrderQty;
                return 28;
            }
        }

        public static int MinWaveOrderQty
        {
            get
            {
                int _minWaveOrderQty;
                if (int.TryParse(GetAppSetting("MinWaveOrderQty"), out _minWaveOrderQty))
                    return _minWaveOrderQty;
                return 1;
            }
        }

        public static string BrandID
        {
            get { return GetAppSetting("BrandID"); }
        }
    }
}
