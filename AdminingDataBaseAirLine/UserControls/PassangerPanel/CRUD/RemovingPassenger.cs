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
        public void ChangeStateBox(bool isEnable = true)
        {
            ticketPanel.NameBox.Enabled = isEnable ? false : true;
            ticketPanel.SecondNameBox.Enabled = isEnable ? false : true;
            ticketPanel.PatronicBox.Enabled = isEnable ? false : true;
            ticketPanel.AgeBox.Enabled = isEnable ? false : true;
            ticketPanel.GenderBox.Enabled = isEnable ? false : true;
            ticketPanel.PhoneNumberBox.Enabled = isEnable ? false : true;
            ticketPanel.EmailBox.Enabled = isEnable ? false : true;


        }
    }
}
