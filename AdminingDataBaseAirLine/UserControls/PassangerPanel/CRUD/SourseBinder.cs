using AdminingDataBaseAirLine.UserControls.PassangerPanel;
using AirlineDataBase.DataBaseContext;
using AirlineDataBase.Entityes.Accounts;

namespace AdminingDataBaseAirLine.UserControls.PassangerPanel.CRUD
{
    public static class SourseBinder
    {
        public static Dictionary<Func<Passenger, Passenger, bool>, TrackingModifierArguments<Passenger, AirCompanyContext, PassangerPanelControl>> InitializeDictionary()
        {
            return new Dictionary<Func<Passenger, Passenger, bool>, TrackingModifierArguments<Passenger, AirCompanyContext, PassangerPanelControl>>()
            {
                [(newV, oldV) => newV.Name != oldV.Name] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Name = newV.Name,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Name)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[2].Value = oldV.Name
                },
                [(newV, oldV) => newV.Surname != oldV.Surname] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Surname = newV.Surname,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Surname)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[1].Value = oldV.Surname

                },
                [(newV, oldV) => newV.Patronymic != oldV.Patronymic] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Patronymic = newV.Patronymic,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Patronymic)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[3].Value = oldV.Patronymic

                },
                [(newV, oldV) => newV.Gender != oldV.Gender] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Gender = newV.Gender,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Gender)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[4].Value = oldV.Gender

                },
                [(newV, oldV) => newV.Age != oldV.Age] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Age = newV.Age,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Age)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[5].Value = oldV.Age

                },
                [(newV, oldV) => newV.PhoneNumber != oldV.PhoneNumber] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.PhoneNumber = newV.PhoneNumber,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.PhoneNumber)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                       .DataGridView1.Rows[rowIndex]
                                                                       .Cells[6].Value = oldV.PhoneNumber

                },
                [(newV, oldV) => newV.Email != oldV.Email] = new()
                {
                    IsModified = false,
                    ValueModifier = (newV, oldV) => oldV.Email = newV.Email,
                    Attacher = (oldVm, db) => db.Entry(oldVm)
                                                                         .Property(p => p.Email)
                                                                         .IsModified = true,
                    ChangerCells = (oldV, panel, rowIndex) => panel
                                                                         .DataGridView1.Rows[rowIndex]
                                                                         .Cells[7].Value = oldV.Email

                }
            };
        }


    }
}
