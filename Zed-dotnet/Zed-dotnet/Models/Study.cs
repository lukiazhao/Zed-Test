using System;
namespace Zeddotnet.Models
{
    public class Study
    {
        public string GUID { get; set; }
        public string SpecificCharacterSet { get; set; }
        public string StudyInstanceUid { get; set; }
        public string PatientsName { get; set; }
        public string PatientId { get; set; }
        public string IssuerOfPatientId { get; set; }
        public string GlobalPatientId { get; set; }
        public string PatientsBirthDate { get; set; }
        public string PatientsAge { get; set; }
        public string PatientSex { get; set; }
        public string StudyDate { get; set; }
        public string StudyTime { get; set; }
        public string AccessionNumber { get; set; }
        public string StudyId { get; set; }
        public string StudyDescription { get; set; }
        public string ReferringPhysiciansName { get; set; }
        public string ReferringPhysiciansId { get; set; }
        public string NumberOfStudyRelatedSeries { get; set; }
        public string NumberOfStudyRelatedInstances { get; set; }
        public string UserRequested { get; set; }
        public string FilmBagGuid { get; set; }
        public string IsRemote { get; set; }
        public string StudyQueueStatusEnum { get; set; }
        public string Modality { get; set; }
        public string StudyStatusEnum { get; set; }
        public string NumberOfRelatedStudies { get; set; }
        public string LastImageReceived { get; set; }
        public string StudySize { get; set; }
        public string NoImage { get; set; }
        public string Locked { get; set; }
        public string LockedAt { get; set; }
        public string LockedUntil { get; set; }
        public string StudyImportTypeEnum { get; set; }
        public string Hidden { get; set; }
        public string HiddenAt { get; set; }
        public string HiddenUntil { get; set; }
        public string HasAttachments { get; set; }
        public string OrganisationSiteId { get; set; }
        public string OrganisationSite { get; set; }
        public string NumberOfAttachments { get; set; }
        public string FusionEventId { get; set; }
        public string InsertDateTime { get; set; }
    }
}
