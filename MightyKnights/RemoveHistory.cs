using DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class RemoveHistory
    {
        public void HistoryRemoval()
        {
            using (var db = new MightyKnightsContext())
            {
                var history = (from h in db.Histories
                               select h).ToList();

                foreach(var historyItem in history)
                {
                    db.Histories.Remove(historyItem);
                }
                db.SaveChanges();
            }
        }
    }
}
