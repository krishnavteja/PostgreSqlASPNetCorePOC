using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSqlASPNetCorePOC.Entities
{
    public interface IDataAccessProvider
    {
        void AddDataEventRecord(DataEventRecord dataEventRecord);

        void UpdateDataEventRecord(long dataEventRecordId, DataEventRecord dataEventRecord);

        void DeleteDataEventRecord(long dataEventRecordId);

        DataEventRecord GetDataEventRecord(long dataEventRecordId);

        List<DataEventRecord> GetDataEventRecords();

        List<SourceInfo> GetSourceInfos(bool withChildren);

    }
}
