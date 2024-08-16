using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESkryptering
{
    public class EncryptedMessage
    {
        public int ID { get; set; }
        public string Message { get; set; }
    }

}
