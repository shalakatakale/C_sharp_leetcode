using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Leetcode
{
    public class IsomorphicStrings205
    {
        public bool IsIsomorphic(string s, string t)
        {

            // Hashtable s_t = new Hashtable(); 
            // not using these because you have to make lots explicit data type conversions
            // Hashtable s_hash = new Hashtable();
            // Hashtable t_hash = new Hashtable();
            Dictionary<char, int> s_hash = new Dictionary<char, int>();
            Dictionary<char, int> t_hash = new Dictionary<char, int>();
            Dictionary<char, char> s_t = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                // make s_t dictionary
                // duplicate key will not be overwritten... you have to remove it and then add new
                if (s_t.ContainsKey(s[i]))
                {
                    s_t.Remove(s[i]);
                    s_t.Add(s[i], t[i]);
                }
                else
                    s_t.Add(s[i], t[i]);

                // make s_hash dictionary
                if (s_hash.ContainsKey(s[i]))
                    s_hash[s[i]] += 1;
                else
                    s_hash[s[i]] = 1;

                // make t_hash dictionary
                if (t_hash.ContainsKey(t[i]))
                    t_hash[t[i]] += 1;
                else
                    t_hash[t[i]] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                //if ( ( s_hash[s[i]] == t_hash[t[i]] ) && ( s_t[s[i]].Equals(t[i]) ) ) 
                if ((s_hash[s[i]] == t_hash[t[i]]) && (s_t[s[i]] == t[i]))
                    continue;
                else
                    return false;
            }
            return true;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
        }
    }

}

/*
public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> dict = new Dictionary<char, char>();
        
        if(s.Length != t.Length)
            return false;
          
        for(int i = 0; i < s.Length; i++){
		// characters of string s are keys 
            if(dict.ContainsKey(s[i])){
                if(dict[s[i]] != t[i])
                    return false;                   
            }
			// if value was mapped to some other key previously 
            else if(dict.ContainsValue(t[i])){
                return false;   
            }
            else {              
                dict.Add(s[i], t[i]);
            }            
        }
        
        return true;
    }
    */