using DataAccess.Data;

namespace Core.HistoryMethods
{
    public class RemoveHistory
    {
        public void HistoryRemoval()
        {
            using (var db = new MightyKnightsContext())
            {
                var history = (from h in db.Histories
                               select h).ToList();

                foreach (var historyItem in history)
                {
                    db.Histories.Remove(historyItem);
                }
                db.SaveChanges();
            }
        }
    }
}
