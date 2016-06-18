using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Serialization;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<wsAccount> GetAllAccounts()
        {
            BankDataContext dc = new BankDataContext();
            List<wsAccount> results = new List<wsAccount>();

            foreach (Account count in dc.Accounts)
            {
                results.Add(new wsAccount()
                {
                    AccountID = count.Acc_ID,
                    balance = count.balance,
                    runningTotals = count.running_totals,
                    firstName = count.first_name,
                    lastName = count.last_name,
                    Address = count.address,
                    postCode = count.postcode,
                    telePhone = count.telephone,
                    pin = count.pin

                });
            }

            return results;
        }

        public List<wsAccount> GetAccount(string accountId)
        {
            
            BankDataContext dc = new BankDataContext();
            int account_Id = int.Parse(accountId);
            List<wsAccount> results = new List<wsAccount>();
            foreach (Account count in dc.Accounts.Where(a => a.Acc_ID == account_Id))
            {
                results.Add(new wsAccount()
                {
                    AccountID = count.Acc_ID,
                    balance = count.balance,
                    runningTotals = count.running_totals,
                    firstName = count.first_name,
                    lastName = count.last_name,
                    Address = count.address,
                    postCode = count.postcode,
                    telePhone = count.telephone,
                    pin = count.pin

                });
            }
            return results;
        }

        public List<wsTransaction> GetAllTransactions()
        {
            BankDataContext dc = new BankDataContext();
            List<wsTransaction> results = new List<wsTransaction>();

            foreach (Transaction tran in dc.Transactions)
            {
                results.Add(new wsTransaction()
                {
                    Trans_ID = tran.Trans_ID,
                    amount = tran.amount,
                    dateTime = tran.datetime,
                    acc_id = tran.acc_id
                    
                });
            }

            return results;
        }

        public List<wsTransaction> GetTransaction(string transId)
        {

            BankDataContext dc = new BankDataContext();
            int trans_Id = int.Parse(transId);
            List<wsTransaction> results = new List<wsTransaction>();
            foreach (Transaction tran in dc.Transactions.Where(a => a.Trans_ID == trans_Id))
            {
                results.Add(new wsTransaction()
                {
                    Trans_ID = tran.Trans_ID,
                    amount = tran.amount,
                    dateTime = tran.datetime,
                    acc_id = tran.acc_id

                });
            }
            return results;
        }

        public wsSQLResult CreateAccount(Stream JSONdataStream)
        {
            wsSQLResult result = new wsSQLResult();
            try
            {
                StreamReader reader = new StreamReader(JSONdataStream);
                string JSONdata = reader.ReadToEnd();

                JavaScriptSerializer jss = new JavaScriptSerializer();
                
                wsAccount acc = jss.Deserialize<wsAccount>(JSONdata);
                if (acc == null)
                {
                    result.WasSuccessful = 0;
                    result.Exception = "Unable to deserialize the JSON data.";
                    return result;
                }

                BankDataContext dc = new BankDataContext();
                Account newAccount = new Account()
                {
                    balance = acc.balance,
                    running_totals = acc.runningTotals,
                    first_name = acc.firstName,
                    last_name = acc.lastName,
                    address = acc.Address,
                    postcode = acc.postCode,
                    telephone = acc.telePhone,
                    pin = acc.pin
                };

                dc.Accounts.InsertOnSubmit(newAccount);
                dc.SubmitChanges();

                result.WasSuccessful = 1;
                result.Exception = "";
                return result;
            }
            catch (Exception ex)
            {
                result.WasSuccessful = 0;
                result.Exception = ex.Message;
                return result;
            }
        }

        public wsSQLResult CreateTransaction(Stream JSONdataStream)
        {
            wsSQLResult result = new wsSQLResult();
            try
            {
                StreamReader reader = new StreamReader(JSONdataStream);
                string JSONdata = reader.ReadToEnd();
                
                JavaScriptSerializer jss = new JavaScriptSerializer();
                wsTransaction tran = jss.Deserialize<wsTransaction>(JSONdata);
                if (tran == null)
                {
                    // Error: Couldn't deserialize our JSON string into a "wsCustomer" object.
                    result.WasSuccessful = 0;
                    result.Exception = "Unable to deserialize the JSON data.";
                    return result;
                }

                BankDataContext dc = new BankDataContext();

                Transaction newTransaction = new Transaction()
                {
                    amount = tran.amount,
                    datetime = DateTime.Now,
                    acc_id = tran.acc_id
                };

                dc.Transactions.InsertOnSubmit(newTransaction);
                dc.SubmitChanges();

                result.WasSuccessful = 1;
                result.Exception = "";
                return result;
            }
            catch (Exception ex)
            {
                result.WasSuccessful = 0;
                result.Exception = ex.Message;
                return result;
            }
        }

        public int DeleteAccount(string accountId)
        {
            try
            {
                BankDataContext dc = new BankDataContext();
                int acc_id = int.Parse(accountId);
                Account acc = dc.Accounts.Where(s => s.Acc_ID == acc_id).FirstOrDefault();
                if (acc == null)
                {
                    // We couldn't find a [Customer] record with this ID.
                    return -3;
                }

                dc.Accounts.DeleteOnSubmit(acc);
                dc.SubmitChanges();

                return 0;    // Success !
            }
            catch (Exception ex)
            {
                return -1;    // Failed.
            }
        }

        public List<wsTransaction> GetTransactionsForAccount(string accId)
        {

            BankDataContext dc = new BankDataContext();
            int acc_id = int.Parse(accId);
            List<wsTransaction> results = new List<wsTransaction>();
            foreach (Transaction tran in dc.Transactions.Where(a => a.acc_id == acc_id))
            {
                results.Add(new wsTransaction()
                {
                    Trans_ID = tran.Trans_ID,
                    amount = tran.amount,
                    dateTime = tran.datetime,
                    acc_id = tran.acc_id

                });
            }
            return results;
        }

        public int UpdateAccount(Stream JSONdataStream)
        {
            try
            {
                // Read in our Stream into a string...
                StreamReader reader = new StreamReader(JSONdataStream);
                string JSONdata = reader.ReadToEnd();

                // ..then convert the string into a single "wsOrder" record.
                JavaScriptSerializer jss = new JavaScriptSerializer();
                wsAccount acc = jss.Deserialize<wsAccount>(JSONdata);
                if (acc == null)
                {
                    // Error: Couldn't deserialize our JSON string into a "wsOrder" object.
                    return -2;
                }

                BankDataContext dc = new BankDataContext();
                Account currentAccount = dc.Accounts.Where(o => o.Acc_ID == acc.AccountID).FirstOrDefault();
                if (currentAccount == null)
                {
                    // Couldn't find an [Order] record with this ID
                    return -3;
                }

                currentAccount.balance = acc.balance;
                currentAccount.running_totals = acc.runningTotals;
                currentAccount.first_name = acc.firstName;
                currentAccount.last_name = acc.lastName;
                currentAccount.address = acc.Address;
                currentAccount.postcode = acc.postCode;
                currentAccount.telephone = acc.telePhone;
                currentAccount.pin = acc.pin;

                dc.SubmitChanges();

                return 0;     // Success !
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
