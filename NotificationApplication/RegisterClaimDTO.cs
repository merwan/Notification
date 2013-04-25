using System;

namespace NotificationApplication
{
    public class RegisterClaimDTO : DataTransferObject
    {
        public static readonly Notification.Error MISSING_POLICY_NUMBER =
            new Notification.Error("Policy number is missing");

        public static readonly Notification.Error MISSING_INCIDENT_TYPE =
            new Notification.Error("Incident type is missing");

        public static readonly Notification.Error MISSING_INCIDENT_DATE =
            new Notification.Error("Incident date is missing");

        public string PolicyId { get; set; }
        public DateTime IncidentDate { get; set; }
        public string Type { get; set; }
    }
}