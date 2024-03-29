﻿using AdminingDataBaseAirLine.Authentication;
using AdminingDataBaseAirLine.Properties;
using AdminingDataBaseAirLine.UserControls;
using AirlineDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.UserControls.TicketPanel.CRUD
{
    public abstract class TicketOperation
    {
        public TicketPanelControl TicketPanel { get; set; }
        public AirCompanyContext db { get; set; }
        public bool ErorIsActive { get; set; }

        protected TicketOperation(TicketPanelControl ticketPanel, AirCompanyContext db)
        {
            TicketPanel = ticketPanel;
            this.db = db;
        }
        public void ChangeStateButton()
        {
            TicketPanel.NumberTicketBox.Enabled = false;
            TicketPanel.FromWhereTicketBox.Enabled = false;
            TicketPanel.WhereTicketBox.Enabled = false;
            TicketPanel.AirplaneTicketBox.Enabled = false;
            TicketPanel.SenderTicketBox.Enabled = false;
        }
        public void ReturnState()
        {
            TicketPanel.NumberTicketBox.Enabled = true;
            TicketPanel.FromWhereTicketBox.Enabled = true;
            TicketPanel.WhereTicketBox.Enabled = true;
            TicketPanel.AirplaneTicketBox.Enabled = true;
            TicketPanel.SenderTicketBox.Enabled = true;
        }
    }
}
