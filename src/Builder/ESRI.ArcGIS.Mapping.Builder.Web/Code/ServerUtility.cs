/*
(c) Copyright ESRI.
This source is subject to the Microsoft Public License (Ms-PL).
Please see https://opensource.org/licenses/ms-pl for details.
All other rights reserved.
*/

using System;
using System.Web;

namespace ESRI.ArcGIS.Mapping.Builder.Web
{
    public static class ServerUtility
    {
        public static string MapPath(string virtualPath)
        {
            if (HttpContext.Current != null && HttpContext.Current.Server != null
                && virtualPath.StartsWith("~", StringComparison.Ordinal))
            {
                return HttpContext.Current.Server.MapPath(virtualPath);
            }
            else
            {
                return virtualPath;
            }
        }
    }
}
