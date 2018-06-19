using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortafolioNet.Data;

namespace PortafolioNet.Business
{
    public class SequencerController
    {
        public static int GetNextVal(string sequenceName)
        {
            using (LindaSonrisaEntities context = new LindaSonrisaEntities())
            {
                IList<int> sequence;
                sequence = context.Database.SqlQuery<int>("SELECT "+sequenceName+".nextval FROM DUAL").ToList();
                return sequence[0];
            }
        }
    }
}
