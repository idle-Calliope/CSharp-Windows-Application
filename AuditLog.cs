using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *      1923636 --- ELLAINE FONTAMILLAS 
 */

namespace AfroMed
{
    class AuditLog
    {
        private int ID;
        private string TimeChanged;
        private string ReasonChanged;
        private string TableName;

        public AuditLog()
        {
            this.ID = 2301;
            this.TimeChanged = "2021-11-01 21:17:57";
            this.ReasonChanged = "UPDATIONG";
            this.TableName = "Bookings";
        }

        public AuditLog(int id,string timeChanged,string reason,string table)
        {
            this.ID = id;
            this.TimeChanged = timeChanged;
            this.ReasonChanged = reason;
            this.TableName = table;
        }

        public int ID_
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public string Timechanged
        {
            get { return this.TimeChanged; }
            set { this.TimeChanged = value; }
        }

        public string Reasons_
        {
            get { return this.ReasonChanged; }
            set { this.ReasonChanged = value; }
        }

        public string Tablename
        {
            get { return this.TableName; }
            set { this.TableName = value; }
        }

        public string print()
        {
            int id = this.ID;
            string time = this.TimeChanged,
                   reason = this.ReasonChanged,
                   table = this.TableName;
            
            string message = "\n" + id + "\n" + time + "\n"+ reason + "\n" + table;
            
            return message;
        }

    }
}
