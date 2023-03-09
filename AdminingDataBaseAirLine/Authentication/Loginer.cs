using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AccountContext _db;

        public Loginer(AccountContext db) => _db = db;
    }
}
