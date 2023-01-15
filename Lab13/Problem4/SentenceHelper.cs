namespace Lab13.Problem4 {
    internal static class SentenceHelper {
        public static List<string> GetSentenceByKey(List<string> sentences, string key) {
            var result = new List<string>();
            for (int i = 0; i < sentences.Count; i++) {
                if (IsKeyExist(sentences[i], key))
                    result.Add(sentences[i]);
            }

            return result;
        }

        private static bool IsKeyExist(string sentence, string key) {
            string[] words = sentence.Split(" ,\"\'\\/<>@#$%^&*()+=|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in words) {
                if (item.Equals(key))
                    return true;
            }

            return false;
        }
    }
}
