using System.Windows.Forms;

namespace NotificationApplication
{
    public class RegisterClaim : ServiceCommand<RegisterClaimDTO>
    {
        public RegisterClaim(RegisterClaimDTO claim) : base(claim) { }

        public void Run()
        {
            Validate();
            if (!Notification.HasErrors)
            {
                RegisterClaimInBackendSystems();
            }
        }

        private void RegisterClaimInBackendSystems()
        {
            MessageBox.Show("Registered!");
        }

        private void Validate()
        {
            FailIfNullOrBlank(Data.PolicyId, RegisterClaimDTO.MISSING_POLICY_NUMBER);
            FailIfNullOrBlank(Data.Type, RegisterClaimDTO.MISSING_INCIDENT_TYPE);
        }
    }
}