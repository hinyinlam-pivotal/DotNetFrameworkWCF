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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFengShui
    //What is Feng Shui? 
    // https://en.wikipedia.org/wiki/Feng_shui
    //https://ko.wikipedia.org/wiki/풍수
    {
        [OperationContract]
        FengShuiDataType GetFengShuiByDate(DateTime dateTime);

        [OperationContract]
        PalmistryDataType ReadPalm(Image palmImage);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class FengShuiDataType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class PalmistryDataType
    {
        [DataMember]
        public String palmSummary;

        [DataMember]
        public Image palmImage
        {
            get { return palmImage; }
            set { palmImage = value; }
        }
    }
}
