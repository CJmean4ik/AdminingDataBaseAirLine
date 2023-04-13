using AdminingDataBaseAirLine.UserControls.PassangerPanel;
using AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD;
using DataBaseModel.Entities.Accounts;


namespace AdminingDataBaseAirLine.UserControls.TicketPanel.CRUD
{
    public static class SourseBinder
    {
        public static Dictionary<Func<Passenger, Passenger, bool>, TrackingModifierArguments> InitializeDictionary()
        {
            return new Dictionary<Func<Passenger, Passenger, bool>, TrackingModifierArguments>()
            {
                [(Passenger newV, Passenger oldV) => newV.Name != oldV.Name] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Name = newV.Name,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Name)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[2].Value = oldV.Name
                },
                [(Passenger newV, Passenger oldV) => newV.Surname != oldV.Surname] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Surname = newV.Surname,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Surname)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[1].Value = oldV.Surname

                },
                [(Passenger newV, Passenger oldV) => newV.Patronymic != oldV.Patronymic] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Patronymic = newV.Patronymic,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Patronymic)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[3].Value = oldV.Patronymic

                },
                [(Passenger newV, Passenger oldV) => newV.Gender != oldV.Gender] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Gender = newV.Gender,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Gender)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[4].Value = oldV.Gender

                },
                [(Passenger newV, Passenger oldV) => newV.Age != oldV.Age] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Age = newV.Age,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Age)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[5].Value = oldV.Age

                },
                [(Passenger newV, Passenger oldV) => newV.PhoneNumber != oldV.PhoneNumber] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.PhoneNumber = newV.PhoneNumber,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.PhoneNumber)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV, PassangerPanelControl panel, int rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[6].Value = oldV.PhoneNumber

                },
                [(Passenger newV, Passenger oldV) => newV.Email != oldV.Email] = new TrackingModifierArguments
                {
                    IsModified = false,
                    ValueModifier = (Passenger newV, Passenger oldV) => oldV.Email = newV.Email,
                    Attacher = (Passenger oldVm, AirlineContext db) => db.Entry(oldVm)
                                                                         .Property(p => p.Email)
                                                                         .IsModified = true,
                    ChangerCells = (Passenger oldV,PassangerPanelControl panel,int rowIndex) => panel
                                                                         .DataGridView1.Rows[rowIndex]
                                                                         .Cells[7].Value = oldV.Email

                }
            };
        }


    }
}
