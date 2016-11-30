using MET.BUSINESS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MET.BUSINESS.WEBAPI.Models
{
    [DataContract]
    public class SprintModel
    {
        [DataMember]
        public long SPRINT_SEQ { get; set; }

        [DataMember]
        public short NBR_STORY_POINTS { get; set; }

        [DataMember]
        public string SPRINT_NAME { get; set; }

        [DataMember]
        public Nullable<long> RELEASE_SEQ { get; set; }

        [DataMember]
        public List<WorkItemModel> SprintWorkItems { get; set; }


        public List<SprintModel> GetSprintsByRelSeq(long seq)
        {
            var context = new METEntities();

            var sprintList = new List<SprintModel>();

            var dbSprints = context.T_SPRINT.Where(x => x.RELEASE_SEQ == seq).ToList();

            var workitemModel = new WorkItemModel();

            foreach (var item in dbSprints)
            {
                var localItem = new SprintModel();

                localItem.SPRINT_NAME =  item.SPRINT_NAME;
                localItem.SPRINT_SEQ = item.SPRINT_SEQ;
                localItem.NBR_STORY_POINTS = item.NBR_STORY_POINTS;
                localItem.SprintWorkItems = workitemModel.WorkItemListBySprintSeq(item.SPRINT_SEQ);
                
                sprintList.Add(localItem);
            }

            return sprintList;
        }
    }
}