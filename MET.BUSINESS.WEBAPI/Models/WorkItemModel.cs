using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MET.BUSINESS.DAL.Repository;
using System.Data.Entity;
using System.Runtime.Serialization;

namespace MET.BUSINESS.WEBAPI.Models
{
    [DataContract]
    public class WorkItemModel
    {
        //DbContext dbContext;
        //public WorkItemModel()
        //{
        //     dbContext = new METEntities();
        //}

        [DataMember]
        public long WORK_ITEM_SEQ { get; set; }

        [DataMember]
        public Nullable<long> RELEASE_SEQ { get; set; }

        [DataMember]
        public string TYPE { get; set; }

        [DataMember]
        public string TITLE { get; set; }

        [DataMember]
        public Nullable<double> TOTAL_HOURS { get; set; }

        [DataMember]
        public Nullable<double> TOTAL_DEV_HOURS { get; set; }

        [DataMember]
        public Nullable<double> TOTAL_DES_HOURS { get; set; }

        [DataMember]
        public Nullable<int> TFS_WI_ID { get; set; }

        [DataMember]
        public string TFS_WI_SEVERITY { get; set; }

        [DataMember]
        public Nullable<long> SYSTEM_SEQ { get; set; }

        [DataMember]
        public Nullable<long> SPRINT_SEQ { get; set; }

        [DataMember]
        public Nullable<System.DateTime> UPDTD_DTE { get; set; }

        [DataMember]
        public string UPDTD_BY { get; set; }

        [DataMember]
        public long STATUS_CDE { get; set; }

        [DataMember]
        public List<T_ASSIGNMENTS> Assignments { get; set; }

        public List<WorkItemModel> MyWorkItems()
        {
            var locallist = new List<WorkItemModel>();

            var localcontext = new METEntities();

            var items = localcontext.T_WORK_ITEM.Take(50);

            foreach (var item in items)
            {
                var newModel = new WorkItemModel();
                newModel.RELEASE_SEQ = item.RELEASE_SEQ;
                newModel.SPRINT_SEQ = item.SPRINT_SEQ;
                newModel.SYSTEM_SEQ = item.SYSTEM_SEQ;
                newModel.TFS_WI_ID = item.TFS_WI_ID;
                newModel.TFS_WI_SEVERITY = item.TFS_WI_SEVERITY;
                newModel.TITLE = item.TITLE;
                newModel.TOTAL_DES_HOURS = item.TOTAL_DES_HOURS;
                newModel.TOTAL_DEV_HOURS = item.TOTAL_DEV_HOURS;
                newModel.TOTAL_HOURS = item.TOTAL_HOURS;
                newModel.TYPE = item.TYPE;
                newModel.UPDTD_BY = item.UPDTD_BY;
                newModel.UPDTD_DTE = item.UPDTD_DTE;
                newModel.WORK_ITEM_SEQ = item.WORK_ITEM_SEQ;
                newModel.STATUS_CDE = item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault() != null ? item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault().STATUS_CDE : 0;

                locallist.Add(newModel);
            }

            return locallist;
        }


        public List<WorkItemModel> WorkItemListByReleaseSeq(long relSeq)
        {
            var locallist = new List<WorkItemModel>();

            var localcontext = new METEntities();

            var items = localcontext.T_WORK_ITEM.Where(y => y.RELEASE_SEQ == relSeq);

            foreach (var item in items)
            {
                var newModel = new WorkItemModel();
                newModel.RELEASE_SEQ = item.RELEASE_SEQ;
                newModel.SPRINT_SEQ = item.SPRINT_SEQ;
                newModel.SYSTEM_SEQ = item.SYSTEM_SEQ;
                newModel.TFS_WI_ID = item.TFS_WI_ID;
                newModel.TFS_WI_SEVERITY = item.TFS_WI_SEVERITY;
                newModel.TITLE = item.TITLE;
                newModel.TOTAL_DES_HOURS = item.TOTAL_DES_HOURS;
                newModel.TOTAL_DEV_HOURS = item.TOTAL_DEV_HOURS;
                newModel.TOTAL_HOURS = item.TOTAL_HOURS;
                newModel.TYPE = item.TYPE;
                newModel.UPDTD_BY = item.UPDTD_BY;
                newModel.UPDTD_DTE = item.UPDTD_DTE;
                newModel.WORK_ITEM_SEQ = item.WORK_ITEM_SEQ;
                newModel.STATUS_CDE = item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault() != null ? item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault().STATUS_CDE : 0;
                //newModel.Assignments = item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).ToList(); :TODO create assignmentmodel else serialization error will occur

                locallist.Add(newModel);
            }

            return locallist;
        }



        public List<WorkItemModel> WorkItemListBySprintSeq(long sprintSeq)
        {
            var locallist = new List<WorkItemModel>();

            var localcontext = new METEntities();

            var items = localcontext.T_WORK_ITEM.Where(y => y.SPRINT_SEQ == sprintSeq);

            foreach (var item in items)
            {
                var newModel = new WorkItemModel();
                newModel.RELEASE_SEQ = item.RELEASE_SEQ;
                newModel.SPRINT_SEQ = item.SPRINT_SEQ;
                //newModel.SYSTEM_SEQ = item.SYSTEM_SEQ;
                newModel.TFS_WI_ID = item.TFS_WI_ID;
                newModel.TFS_WI_SEVERITY = item.TFS_WI_SEVERITY;
                //newModel.TITLE = item.TITLE;
                //newModel.TOTAL_DES_HOURS = item.TOTAL_DES_HOURS;
                //newModel.TOTAL_DEV_HOURS = item.TOTAL_DEV_HOURS;
                //newModel.TOTAL_HOURS = item.TOTAL_HOURS;
                newModel.TYPE = item.TYPE;
                //newModel.UPDTD_BY = item.UPDTD_BY;
                //newModel.UPDTD_DTE = item.UPDTD_DTE;
                newModel.WORK_ITEM_SEQ = item.WORK_ITEM_SEQ;
                //newModel.STATUS_CDE = item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault() != null ? item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).FirstOrDefault().STATUS_CDE : 0;
                //newModel.Assignments = item.T_ASSIGNMENTS.OrderByDescending(x => x.UPDTD_DTE).ToList();

                locallist.Add(newModel);
            }

            return locallist;
        }
    }
}