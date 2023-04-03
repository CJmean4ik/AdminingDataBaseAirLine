using AdminingDataBaseAirLine.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Forms.CashierFormSetting.CRUD
{
    public abstract class TicketOperation
    {
        public CashierForm cashierForm { get; set; }
        public AirlineContext db { get; set; }
        public bool ErorIsActive { get; set; }

        protected TicketOperation(CashierForm cashierForm, AirlineContext db)
        {
            this.cashierForm = cashierForm;
            this.db = db;
        }
    }
}
