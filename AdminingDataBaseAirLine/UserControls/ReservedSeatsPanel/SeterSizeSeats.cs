namespace AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel
{
    internal class SeterSizeSeats
    {
        private List<FlowLayoutPanel> _layoutPanels;

        private int capasity;
        private int firstTake;
        private int secondTake;
        private int thirdTake;
        private int[] numbersReservedSeats;

        public ReservedSeatsControl seatsPanelControl { get; set; }


        public SeterSizeSeats(ReservedSeatsControl seatsPanelControl, int[] numbersReservedSeats)
        {
            this.seatsPanelControl = seatsPanelControl;
            this.numbersReservedSeats = numbersReservedSeats;
            _layoutPanels = new List<FlowLayoutPanel>();
            InitializeFlowPanel(seatsPanelControl);

        }
        public void SetCapasity(int capasity)
        {
            this.capasity = capasity;
        }
        private void InitializeFlowPanel(ReservedSeatsControl reservedSeats)
        {
            _layoutPanels.Add(reservedSeats.FlowLayoutPanel1);
            _layoutPanels.Add(reservedSeats.FlowLayoutPanel2);
            _layoutPanels.Add(reservedSeats.FlowLayoutPanel3);
            _layoutPanels.Add(reservedSeats.FlowLayoutPanel4);
        }
        public int CountPanelByNumberOfSeats() => capasity >= 400 ? 4 : 2;
        public void CalculateSizeFlowPanel()
        {
            int countPanel = CountPanelByNumberOfSeats();

            CalculateCountElementInFlowPanel(countPanel);
        }
        private void CalculateCountElementInFlowPanel(int countPanel)
        {

            int firstCount;
            int secondCount;
            if (countPanel == 2)
            {
                firstCount = capasity / 2;
                secondCount = firstCount + 1;

                firstTake = firstCount;
                secondTake = secondCount + firstCount;
                return;
            }
            int thirdCount;
            if (countPanel == 4)
            {
                firstCount = (capasity / 4) + 1;
                secondCount = firstCount * 2;
                thirdCount = secondCount + firstCount;

                firstTake = firstCount;
                secondTake = secondCount;
                thirdTake = thirdCount;
                return;
            }
        }
        public void AddingItemToFlowPanel()
        {
            int COUNT_FLOW_PANEL = CountPanelByNumberOfSeats();

            if (COUNT_FLOW_PANEL == 2) FillTwoFlowPanel();

            if (COUNT_FLOW_PANEL == 4) FillFourFlowPanel();

            EnableVisibleNonEmptyFlowPanel();
        }
        private void FillTwoFlowPanel()
        {
            for (int i = 1; i <= capasity; i++)
            {
                Button button = CreateButton();

                if (i <= firstTake)
                {
                    SecondPanelFill(i, button);
                    SetPropertyForButton(button);
                    ChangeButton(i, button);
                    continue;
                }
                if (i <= secondTake)
                {
                    ThirdPanelFill(i, button);
                    SetPropertyForButton(button);
                    ChangeButton(i, button);
                    continue;
                }
            }
        }
        private void FillFourFlowPanel()
        {
            for (int i = 1; i <= capasity; i++)
            {
                Button button = CreateButton();

                if (i <= firstTake)
                {
                    FirstPanelFill(i, button);
                    SetPropertyForButton(button);
                    ChangeButton(i, button);
                    continue;
                }
                if (i <= secondTake)
                {
                    SecondPanelFill(i, button);
                    SetPropertyForButton(button);
                    ChangeButton(i, button);
                    continue;
                }
                if (i <= thirdTake)
                {
                    ThirdPanelFill(i, button);
                    SetPropertyForButton(button);
                    ChangeButton(i, button);
                    continue;
                }
                FourthPanelFill(i, button);
                SetPropertyForButton(button);
                ChangeButton(i, button);
            }
        }
        private void FirstPanelFill(int index, Button button)
        {
            button.Text = index.ToString();
            seatsPanelControl.FlowLayoutPanel1.Controls.Add(button);
        }
        private void SecondPanelFill(int index, Button button)
        {
            button.Text = index.ToString();
            seatsPanelControl.FlowLayoutPanel2.Controls.Add(button);
        }
        private void ThirdPanelFill(int index, Button button)
        {
            button.Text = index.ToString();
            seatsPanelControl.FlowLayoutPanel3.Controls.Add(button);
        }
        private void FourthPanelFill(int index, Button button)
        {
            button.Text = index.ToString();
            seatsPanelControl.FlowLayoutPanel4.Controls.Add(button);
        }
        private void ChangeButton(int numberSeats, Button button)
        {
            if (!numbersReservedSeats.Contains(numberSeats)) return;

            SetReservedColor(button);
        }
        private void SetReservedColor(Button button)
        {
            Color reservedColor = Color.FromArgb(255, 100, 0);

            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = reservedColor;
            button.ForeColor = reservedColor;
        }
        private Button CreateButton()
        {
            var button = new Button();
            return button;
        }
        public void ClearFlowPanelControls()
        {
            foreach (var flowLayoutPanel in _layoutPanels)
            {
                flowLayoutPanel.Controls.Clear();
                flowLayoutPanel.Visible = false;
            }
        }
        public void SetDeffaultPropertyButton(int oldReservedSeats)
        {
            bool res;
            res = SetDeffaultSetting(oldReservedSeats, seatsPanelControl.FlowLayoutPanel1);
            if (res) return;

            res = SetDeffaultSetting(oldReservedSeats, seatsPanelControl.FlowLayoutPanel2);
            if (res) return;

            res = SetDeffaultSetting(oldReservedSeats, seatsPanelControl.FlowLayoutPanel3);
            if (res) return;

            res = SetDeffaultSetting(oldReservedSeats, seatsPanelControl.FlowLayoutPanel4);
            if (res) return;
        }
        private void EnableVisibleNonEmptyFlowPanel()
        {
            foreach (var flowLayoutPanel in _layoutPanels)
            {
                if (flowLayoutPanel.Controls.Count == 0)
                    continue;

                flowLayoutPanel.Visible = true;


            }
        }
        private void SetPropertyForButton(Button button)
        {
            button.Size = new Size(35, 35);
            button.Margin = new Padding(1, 1, 1, 1);
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(10, 126, 245);
            button.FlatStyle = FlatStyle.Flat;
            button.ForeColor = Color.FromArgb(10, 126, 245);
            button.Click += seatsPanelControl.Event;
        }
        public void MakeSeatReserved(int reservedSeats)
        {
            bool res;

            res = MakeSeatReservedPanel(reservedSeats, seatsPanelControl.FlowLayoutPanel1);
            if (res) return;

            res = MakeSeatReservedPanel(reservedSeats, seatsPanelControl.FlowLayoutPanel2);
            if (res) return;

            res = MakeSeatReservedPanel(reservedSeats, seatsPanelControl.FlowLayoutPanel3);
            if (res) return;

            res = MakeSeatReservedPanel(reservedSeats, seatsPanelControl.FlowLayoutPanel4);
            if (res) return;
        }
        private bool MakeSeatReservedPanel(int reservedSeats, FlowLayoutPanel flowLayoutPanel)
        {
            foreach (Button seatsButton in flowLayoutPanel.Controls)
            {
                if (seatsButton.Text == reservedSeats.ToString())
                {
                    SetReservedColor(seatsButton);
                    return true;
                }
            }
            return false;
        }
        private bool SetDeffaultSetting(int oldReservedSeats, FlowLayoutPanel flowLayoutPanel)
        {
            foreach (Button oldButton in flowLayoutPanel.Controls)
            {
                if (oldButton.Text == oldReservedSeats.ToString())
                {
                    SetPropertyForButton(oldButton);
                    return true;
                }
            }
            return false;
        }
    }
}
