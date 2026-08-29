public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new StringBuilder();

                foreach (string str in strs)
                {
                    encoded.Append(str.Length);
                    encoded.Append('#');
                    encoded.Append(str);
                }

                return encoded.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
                int i = 0;

                while (i < s.Length)
                {
                    int j = i;

                    // '#' karakterine kadar ilerleyip kelimenin uzunluğunu buluyoruz.
                    while (s[j] != '#')
                    {
                        j++;
                    }

                    int length = int.Parse(s.Substring(i, j - i));

                    // Kelime, '#' karakterinden hemen sonra başlıyor.
                    int wordStart = j + 1;
                    string word = s.Substring(wordStart, length);

                    result.Add(word);

                    // Bir sonraki kelimenin uzunluğuna ilerliyoruz.
                    i = wordStart + length;
                }

                return result;
   }
}
