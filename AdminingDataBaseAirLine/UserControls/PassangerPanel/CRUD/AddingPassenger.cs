using AdminingDataBaseAirLine.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD
{
    internal class AddingPassenger : PassengerOperation
    {
        public AddingPassenger(PassangerPanelControl ticketPanel) : base(ticketPanel)
        {

        }



        public void PreperingForAddingPassanger()
        {
            ticketPanel.CleatTextBox();
            ticketPanel.IdpassBox.Enabled = false;
            ticketPanel.AddButton.Image = Resources.save;
            ticketPanel.UpdateButton.Enabled = false;
            ticketPanel.RemoveButton.Enabled = false;
        }
       
    }
}
