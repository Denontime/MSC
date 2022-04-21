using System;
using System.Collections.Generic;
using System.Text;
using BottlePickModuleForWindows.Resources;
using WCS.Core.Net;

namespace BottlePickModuleForWindows.Service
{
    public static class HttpService
    {
        private readonly static string dataCenterService = "";
        public static ModuleModel RequestModuleInfo(string moduleID)
        {
            try
            {
                HttpResponse httpResonse = new HttpRequest(dataCenterService).WithQueryString("APICommand", "").WithQueryString("ModuleID", moduleID).Get();
                ModuleModel tmpModule = httpResonse.ResponseObject<ModuleModel>();
                return tmpModule;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
