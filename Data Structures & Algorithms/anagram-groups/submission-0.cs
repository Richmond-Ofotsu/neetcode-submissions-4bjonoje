    public class Solution {
        public List<List<string>> GroupAnagrams(string[] strs) {
            var group = new Dictionary<string, List<string>>();

            foreach (var word in strs)
                {
                    char[] chars = word.ToCharArray();
                    Array.Sort(chars);
                    string key = new string(chars);

                    if(!group.ContainsKey(key))
                    {
                        group[key] = new List<string>();
                    }

                    group[key].Add(word);
                }
            return group.Values.ToList();
        }
    }
