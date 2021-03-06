﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class voatEntities : DbContext
    {
        public voatEntities()
            : base("name=voatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutoModComment> AutoModComments { get; set; }
        public virtual DbSet<AutoModSubmission> AutoModSubmissions { get; set; }
        public virtual DbSet<Badge> Badges { get; set; }
        public virtual DbSet<BannedDomain> BannedDomains { get; set; }
        public virtual DbSet<BannedUser> BannedUsers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentRemovalLog> CommentRemovalLogs { get; set; }
        public virtual DbSet<CommentReplyNotification> CommentReplyNotifications { get; set; }
        public virtual DbSet<CommentSaveTracker> CommentSaveTrackers { get; set; }
        public virtual DbSet<CommentVoteTracker> CommentVoteTrackers { get; set; }
        public virtual DbSet<DefaultSubverse> DefaultSubverses { get; set; }
        public virtual DbSet<FeaturedSubverse> FeaturedSubverses { get; set; }
        public virtual DbSet<ModeratorInvitation> ModeratorInvitations { get; set; }
        public virtual DbSet<PartnerInformation> PartnerInformations { get; set; }
        public virtual DbSet<PrivateMessage> PrivateMessages { get; set; }
        public virtual DbSet<PromotedSubmission> PromotedSubmissions { get; set; }
        public virtual DbSet<SessionTracker> SessionTrackers { get; set; }
        public virtual DbSet<StickiedSubmission> StickiedSubmissions { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<SubmissionRemovalLog> SubmissionRemovalLogs { get; set; }
        public virtual DbSet<SubmissionReplyNotification> SubmissionReplyNotifications { get; set; }
        public virtual DbSet<SubmissionSaveTracker> SubmissionSaveTrackers { get; set; }
        public virtual DbSet<SubmissionVoteTracker> SubmissionVoteTrackers { get; set; }
        public virtual DbSet<Subverse> Subverses { get; set; }
        public virtual DbSet<SubverseBan> SubverseBans { get; set; }
        public virtual DbSet<SubverseFlair> SubverseFlairs { get; set; }
        public virtual DbSet<SubverseModerator> SubverseModerators { get; set; }
        public virtual DbSet<SubverseSubscription> SubverseSubscriptions { get; set; }
        public virtual DbSet<UserBadge> UserBadges { get; set; }
        public virtual DbSet<UserBlockedSubverse> UserBlockedSubverses { get; set; }
        public virtual DbSet<UserPreference> UserPreferences { get; set; }
        public virtual DbSet<UserScore> UserScores { get; set; }
        public virtual DbSet<UserSet> UserSets { get; set; }
        public virtual DbSet<UserSetList> UserSetLists { get; set; }
        public virtual DbSet<UserSetSubscription> UserSetSubscriptions { get; set; }
        public virtual DbSet<ViewStatistic> ViewStatistics { get; set; }
    
        public virtual ObjectResult<usp_CommentTree_Result> usp_CommentTree(Nullable<int> submissionID, Nullable<int> depth, Nullable<int> parentID)
        {
            var submissionIDParameter = submissionID.HasValue ?
                new ObjectParameter("SubmissionID", submissionID) :
                new ObjectParameter("SubmissionID", typeof(int));
    
            var depthParameter = depth.HasValue ?
                new ObjectParameter("Depth", depth) :
                new ObjectParameter("Depth", typeof(int));
    
            var parentIDParameter = parentID.HasValue ?
                new ObjectParameter("ParentID", parentID) :
                new ObjectParameter("ParentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CommentTree_Result>("usp_CommentTree", submissionIDParameter, depthParameter, parentIDParameter);
        }
    }
}
