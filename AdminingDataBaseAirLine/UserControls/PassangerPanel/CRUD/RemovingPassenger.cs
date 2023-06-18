using AdminingDataBaseAirLine.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD
{
    public class RemovingPassenger : PassengerOperation
    {
        public bool IsNowRemoving { get; set; }
        public RemovingPassenger(PassangerPanelControl passanger) : base(passanger)
        {
        }
        public void PreperingDeletePassenger()
        {
            ticketPanel.RemoveButton.Image = Resources.doneDelete;
            ticketPanel.AddButton.Enabled = false;
            ticketPanel.UpdateButton.Enabled = false;
        }
        public void ChangeStateBox(bool isEnable)
        {
            ticketPanel.NameBox.Enabled = isEnable;
            ticketPanel.SecondNameBox.Enabled = isEnable;
            ticketPanel.PatronicBox.Enabled = isEnable;
            ticketPanel.AgeBox.Enabled = isEnable;
            ticketPanel.GenderBox.Enabled = isEnable;
            ticketPanel.PhoneNumberBox.Enabled = isEnable;
            ticketPanel.EmailBox.Enabled = isEnable;
            ticketPanel.AddButton.Enabled = isEnable;
            ticketPanel.UpdateButton.Enabled = isEnable;

        }
    }
}
