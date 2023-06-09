using AirlineDataBase.Entityes.TicketAndOrders;
using System;
using System.Linq;
using System.Xml.Linq;

namespace AdminingDataBaseAirLine.UserControls.OrdersPanel
{
    internal class OrderSorter
    {
        private OrderPanelControl _orderControl;

        public OrderSorter(OrderPanelControl orderPanelControl)
        {
            _orderControl = orderPanelControl;
        }
        public List<Orders> SortingData(List<Orders> orders)
        {
            bool firstPredicat = SortingByRoute(_orderControl.RouteFromBox.Text,
                _orderControl.WhereToBox.Text);

            bool secondPredicat = SortingByPassenger(_orderControl.PassNameBox.Text,
                _orderControl.PassSurnameBox.Text);

            bool thirdPredicat = SortingByNameFlight(_orderControl.FlightNameBox.Text);

            var sortedList = new List<Orders>();

            if (firstPredicat)           
                sortedList = orders.Where(s =>
                s.Ticket.Flight.Route.FromWhere == _orderControl.RouteFromBox.Text &&
                s.Ticket.Flight.Route.FromWhere == _orderControl.WhereToBox.Text
                ).ToList();


            if (secondPredicat)      
               sortedList = orders.Where(s => 
               s.Passenger.Name == _orderControl.PassNameBox.Text &&
               s.Passenger.Surname == _orderControl.PassSurnameBox.Text)
                    .ToList();
            
            

            if (thirdPredicat)
                sortedList = orders.Where(s => s.Ticket.Flight.NameRoute == _orderControl.FlightNameBox.Text)
                     .ToList();

            if (secondPredicat && thirdPredicat)

                sortedList = orders.Where(s =>
               s.Passenger.Name == _orderControl.PassNameBox.Text &&
               s.Passenger.Surname == _orderControl.PassSurnameBox.Text
               ).Where(s => s.Ticket.Flight.NameRoute == _orderControl.FlightNameBox.Text)
                        .ToList();

            return sortedList;
        }
        
        private bool SortingByRoute(string fromWhere, string where)
        {
            if (fromWhere != "" && where != "")         
                return true;
            

            return false;
        }
        private bool SortingByPassenger(string name,string surname)
        {

            if (name != "" || surname != "")
                return true;

            return false;
        }
        private bool SortingByNameFlight(string flightName)
        {
            if (flightName != "")
                return true;
           
            return false;
        }

    }
}
