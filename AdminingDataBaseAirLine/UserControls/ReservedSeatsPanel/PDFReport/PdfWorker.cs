using AdminingDataBaseAirLine.UserControls.ReservedSeatsPanel;
using AirlineDataBase.DataBaseContext;
using GroupDocs.Assembly;
using PDFGroupDocs.PDFReport.ReportEntity;


namespace PDFGroupDocs.PDFReport
{
    internal class PdfWorker
    {


        private DocumentAssembler documentAssembler;
        private Func<AirCompanyContext, ReservedSeatsPanelControl, PassengerOrder> binder;
        private ReservedSeatsPanelControl control;
        public string PathToDocumentTemplate { get; set; }
        public string PathToDocumentReport { get; set; }
        public bool IsMake { get; set; }
        public PdfWorker(DocumentAssembler documentAssembler, ReservedSeatsPanelControl control,
            Func<AirCompanyContext, ReservedSeatsPanelControl, PassengerOrder> func)
        {
            this.documentAssembler = documentAssembler;
            this.control = control;
            binder = func;
        }

        public void EnableControls(bool isEnable)
        {
            control.ShowPlace.Enabled = isEnable;
            control.AirplaneBox.Enabled = isEnable;
            control.UpdateButton.Enabled = isEnable;
            control.AddButton.Enabled = isEnable;
            control.IdpassBox.Enabled = isEnable;
            control.NameBox.Enabled = isEnable;
            control.SecondNameBox.Enabled = isEnable;
            control.SeatsNumberBox.Enabled = isEnable;
            control.FlightNamesBox.Enabled = isEnable;
            control.RemoveButton.Enabled = isEnable;
        }
       public bool CreateReport(AirCompanyContext context, ReservedSeatsPanelControl control)
       {
            try
            {
               var passengerOrder = binder.Invoke(context, control);

               string ownerFile = $"{passengerOrder.Name}_{passengerOrder.Surname}_{passengerOrder.Patronymic}_{passengerOrder.PassengerId}";
               bool exist = CreateFileIfNotExist(ownerFile);

                if (!exist) return false;

               documentAssembler.AssembleDocument(PathToDocumentTemplate,PathToDocumentReport, GetDataSourceInfo(passengerOrder));
               return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;              
            }       
       }
       private DataSourceInfo[] GetDataSourceInfo(PassengerOrder passengerOrder)
        {
            var properties = typeof(PassengerOrder).GetProperties();

            DataSourceInfo[] dataSourceInfos = new DataSourceInfo[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                var propertyValue = properties[i].GetValue(passengerOrder);
                dataSourceInfos[i] = new DataSourceInfo(propertyValue, properties[i].Name);
            }
            return dataSourceInfos;
        }
       
        public bool CreateFileIfNotExist(string ownerFile)
        {
            string strDocumentReport = $@"C:\Users\Стас\OneDrive\Документы\Отчёты (Тест)\{ownerFile}.pdf";
            if (File.Exists(strDocumentReport))
                return false;

            File.Create(strDocumentReport).Close();
            PathToDocumentReport = strDocumentReport;
            return true;
        }

    }
}
