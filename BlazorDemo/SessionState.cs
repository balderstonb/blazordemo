using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo
{
    public class SessionState
    {
        private Dictionary<string, List<string>> dirtyWords = new Dictionary<string, List<string>>();

        public List<string> GetDirtyWords(string key)
        {
            return dirtyWords[key];
        }

        public void SetDirtyWords(string key, List<string> words)
        {
            if (!dirtyWords.ContainsKey(key))
            {
                dirtyWords.Add(key, words);
            }
            else
            {
                dirtyWords[key] = words;
            }
        }
    }
}
