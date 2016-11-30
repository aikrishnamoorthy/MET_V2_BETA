using MET.BUSINESS.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MET.BUSINESS.WEBAPI.Models
{
    [DataContract]
    public class ReleaseModel
    {
        private const int StatusCodeAssigned = 40;

        [DataMember]
        public long RELEASE_SEQ { get; set; }
        [DataMember]
        public string RELEASE_NBR { get; set; }
        [DataMember]
        public Nullable<long> SYSTEM_SEQ { get; set; }
        [DataMember]
        public Nullable<int> UAT_KICK_OFF { get; set; }
        [DataMember]
        public Nullable<int> NBR_PLAYBOOK { get; set; }
        [DataMember]
        public Nullable<int> NBR_ENVIRONMENT { get; set; }
        [DataMember]
        public Nullable<int> NBR_BUILDS { get; set; }
        [DataMember]
        public Nullable<int> NBR_DEPLOYMENTS { get; set; }
        [DataMember]
        public Nullable<int> NBR_PLAYBOOK_MEETING { get; set; }
        [DataMember]
        public Nullable<int> NBR_DB_REFRESH { get; set; }
        [DataMember]
        public Nullable<int> NBR_SECURITY_SUPPORT_HOUR { get; set; }
        [DataMember]
        public Nullable<int> NBR_LOAD_TEST { get; set; }
        [DataMember]
        public Nullable<int> NBR_BATCH_VOLUME_TEST { get; set; }
        [DataMember]
        public Nullable<int> NBR_SECURITY_TEST { get; set; }
        [DataMember]
        public Nullable<int> NBR_DESIGN_SESSION { get; set; }
        [DataMember]
        public Nullable<int> NBR_ARCHITECTURE_REVIEW { get; set; }
        [DataMember]
        public Nullable<int> TFS_RELEASE_ID { get; set; }
        [DataMember]
        public string UPDTD_BY { get; set; }
        [DataMember]
        public Nullable<System.DateTime> UPDTD_DTE { get; set; }

        [DataMember]
        public T_SYSTEM T_SYSTEM { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<T_RELEASE_USER_ACCESS> T_RELEASE_USER_ACCESS { get; set; }

        [DataMember]
        public int NoOfWorkItems { get; set; }

        [DataMember]
        public List<WorkItemModel> WorkItems { get; set; }

        [DataMember]
        public double? TotalEffortHours { get; set; }

        [DataMember]
        public int NoOfPendingWokrItems { get; set; }

        [DataMember]
        public int NoOfSprints { get;  set; }

        [DataMember]
        public List<SprintModel> Sprints { get; private set; }

        public  List<ReleaseModel> GetReleaseUserAccessListByUserSeq(long seq)
        {
            var context = new METEntities();

            var list = new List<ReleaseModel>();

            var workitemModel = new WorkItemModel();

            var myReleases = context.T_RELEASE_USER_ACCESS.Where(x => x.USER_SEQ == seq);

            foreach (var item in myReleases)
            {
                var newModel = new ReleaseModel();

                newModel.NoOfWorkItems = workitemModel.WorkItemListByReleaseSeq(item.RELEASE_SEQ).Count;
                newModel.RELEASE_NBR = item.T_RELEASE.RELEASE_NBR;
                newModel.RELEASE_SEQ = item.T_RELEASE.RELEASE_SEQ;

                list.Add(newModel);
            }

            return list;
        }

        public ReleaseModel GetReleaseDetailsBySeq(long seq)
        {
            var context = new METEntities();
            
            var workitemModel = new WorkItemModel();

            var sprintModel = new SprintModel();

            var myRelease = context.T_RELEASE.Where(x => x.RELEASE_SEQ == seq).FirstOrDefault();

            var newModel = new ReleaseModel();

            if (myRelease != null)
            {
                newModel.WorkItems = workitemModel.WorkItemListByReleaseSeq(seq);
                newModel.RELEASE_NBR = myRelease.RELEASE_NBR;
                newModel.RELEASE_SEQ = myRelease.RELEASE_SEQ;
                newModel.NBR_PLAYBOOK = myRelease.NBR_PLAYBOOK;
                newModel.NBR_ENVIRONMENT = myRelease.NBR_ENVIRONMENT;
                newModel.NBR_BUILDS = myRelease.NBR_BUILDS;
                newModel.NBR_DEPLOYMENTS = myRelease.NBR_DEPLOYMENTS;
                newModel.NBR_PLAYBOOK_MEETING = myRelease.NBR_PLAYBOOK_MEETING;
                newModel.NBR_DB_REFRESH = myRelease.NBR_DB_REFRESH;
                newModel.NBR_SECURITY_SUPPORT_HOUR = myRelease.NBR_SECURITY_SUPPORT_HOUR;
                newModel.NBR_LOAD_TEST = myRelease.NBR_LOAD_TEST;
                newModel.NBR_BATCH_VOLUME_TEST = myRelease.NBR_BATCH_VOLUME_TEST;
                newModel.NBR_SECURITY_TEST = myRelease.NBR_SECURITY_TEST;
                newModel.NBR_DESIGN_SESSION = myRelease.NBR_DESIGN_SESSION;
                newModel.NBR_ARCHITECTURE_REVIEW = myRelease.NBR_ARCHITECTURE_REVIEW;

                newModel.NoOfWorkItems = newModel.WorkItems.ToList().Count;
                newModel.TotalEffortHours = newModel.WorkItems.Sum(x => x.TOTAL_HOURS);
                newModel.NoOfPendingWokrItems = myRelease.T_WORK_ITEM.Select(x=>x.T_ASSIGNMENTS.Where(y=>y.STATUS_CDE != StatusCodeAssigned)).Count();
                newModel.NoOfSprints = myRelease.T_SPRINT.Count;
                newModel.Sprints = sprintModel.GetSprintsByRelSeq(seq);
            }
            

            return newModel;
        }
    }
}