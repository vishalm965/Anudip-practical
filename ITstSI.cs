using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITstSI" in both code and config file together.
    [ServiceContract]
    public interface ITstSI
    {
        [OperationContract]
        int CalculateSI(int p, int r, int t);
        [OperationContract]
        DataTable GetRecordList();
    }
}
