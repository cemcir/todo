using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.CrossCuttingConcerns.Transaction
{
    public class TransactionHelper
    {
        public static bool ExecuteWithTransaction(Action action) // action geriye değer döndürmeyen methodlar için kullanılır
        {
            try
            {
                using (TransactionScope scope = new TransactionScope()) { // transaction başlat

                    action.Invoke();
                    scope.Complete(); // hata yoksa commit et
                }

                return true;
            }
            catch (Exception ex) {
                
                Console.WriteLine("Hata" +ex.Message);
               
                return false;
            }
        }
    }
}
