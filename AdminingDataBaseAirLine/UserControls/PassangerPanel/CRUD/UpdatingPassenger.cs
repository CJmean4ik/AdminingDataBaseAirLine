using AdminingDataBaseAirLine.Properties;
using AirlineDataBase.DataBaseContext;
using AirlineDataBase.Entityes.Accounts;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD
{
    internal class UpdatingPassenger : PassengerOperation
    {
        private Dictionary<Func<Passenger, Passenger, bool>, TrackingModifierArguments<Passenger,AirCompanyContext, PassangerPanelControl>> modifiedProperty;
        public bool IsNowUpdate { get; internal set; }

        public UpdatingPassenger(PassangerPanelControl ticketPanel) : base(ticketPanel)
        {
            modifiedProperty = SourseBinder.InitializeDictionary();
        }   
        public void PreparingUpdateTicket()
        {

            ticketPanel.UpdateButton.Image = Resources.done;
            ticketPanel.AddButton.Enabled = false;
            ticketPanel.RemoveButton.Enabled = false;
        }
        public void SearchModifiePassengerProperty(Passenger comparablePassenger, Passenger oldPassenger, AirCompanyContext context)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Key.Invoke(comparablePassenger, oldPassenger))
                {
                    attachment.Value.ValueModifier.Invoke(comparablePassenger, oldPassenger);
                    attachment.Value.IsModified = true;
                }
            }

            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.Attacher.Invoke(oldPassenger,context);
                }
            }
        }

        public void UpdateDataInDataGridview(PassangerPanelControl panelControl, Passenger oldPassenger,int index)
        {
            foreach (var attachment in modifiedProperty)
            {
                if (attachment.Value.IsModified)
                {
                    attachment.Value.ChangerCells.Invoke(oldPassenger, panelControl,index);
                }
            }
        }
    }

    
    public class TrackingModifierArguments<T,V,P>
    {
        public bool IsModified { get; set; }
        public Action<T, T> ValueModifier { get; set; }
        public Action<T, V> Attacher { get; set; }
        public Action<T, P, int> ChangerCells { get; set; }
    }
}
