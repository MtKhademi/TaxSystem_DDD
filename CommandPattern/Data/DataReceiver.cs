using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Data
{
    public class DataReceiver
    {
        private readonly Dictionary<string, string> _data = new Dictionary<string, string>();

        public int GetCount() => _data.Count;

        public void Upsert(string key, string value)
        {
            _data[key] = value;
            Console.WriteLine($"Upserted: {key} - {value}");
        }

        public void Delete(string key)
        {
            if (_data.ContainsKey(key))
            {
                _data.Remove(key);
                Console.WriteLine($"Remove Data : {key}");
            }
        }
    }
}
