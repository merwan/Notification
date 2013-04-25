using System;
using System.Windows.Forms;

namespace NotificationApplication
{
    public partial class RegisterClaimForm : Form
    {
        private readonly ClaimService _claimService;
        private RegisterClaimDTO _claim;

        public RegisterClaimForm(ClaimService claimService)
        {
            InitializeComponent();
            _claimService = claimService;
            claimTypeControl.DataSource = new[] { "Policy 1", "Policy 2" };
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _claimService.RegisterClaim(_claim);
            SaveToClaim();

            registerClaimErrorProvider.Clear();

            if (_claim.Notification.HasErrors)
            {
                responseControl.Text = "Not registered, see errors";
                IndicateErrors();
            }
            else
            {
                responseControl.Text = "Succesfully registered.";
            }
        }

        private void IndicateErrors()
        {
            CheckError(RegisterClaimDTO.MISSING_POLICY_NUMBER, policyNumberControl);
            CheckError(RegisterClaimDTO.MISSING_INCIDENT_TYPE, claimTypeControl);
        }

        private void CheckError(Notification.Error error, Control control)
        {
            if (_claim.Notification.IncludesError(error))
            {
                ShowError(control, error.Message);
            }
        }

        private void ShowError(Control control, string message)
        {
            registerClaimErrorProvider.SetError(control, message);
        }

        private void SaveToClaim()
        {
            _claim = new RegisterClaimDTO
            {
                PolicyId = policyNumberControl.Text,
                IncidentDate = incidentDateControl.Value,
                Type = (string)claimTypeControl.SelectedItem
            };
        }
    }
}
