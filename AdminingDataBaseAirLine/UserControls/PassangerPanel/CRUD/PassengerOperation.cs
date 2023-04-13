using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD
{
    public class PassengerOperation
    {
        public PassangerPanelControl ticketPanel { get; set; }
        public bool ErorIsActive { get; set; }

        public PassengerOperation(PassangerPanelControl ticketPanel)
        {
            this.ticketPanel = ticketPanel;
        }
        public void ErorHandling()
        {
            if (ErorIsActive)
            {
                ErorIsActive = false;
                ticketPanel.ErorLabel.Visible = false;
                return;
            }
        }
    }
}
