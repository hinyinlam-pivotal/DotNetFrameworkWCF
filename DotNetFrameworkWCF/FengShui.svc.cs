using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DotNetFrameworkWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FengShuiService : IFengShui
    {

        FengShuiDataType IFengShui.GetFengShuiByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        PalmistryDataType ReadPalm(Image palmImage)
        {
            return null;
        }

        PalmistryDataType IFengShui.ReadPalm(Image palmImage)
        {
            throw new NotImplementedException();
        }
    }
}
