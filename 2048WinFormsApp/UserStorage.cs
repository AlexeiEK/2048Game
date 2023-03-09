using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class UserStorage
    {
        private static string pathFile = "usersResults.json";

        public static void Append(User user)
        {
            var usersResults = GetUsersResults();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetUsersResults()
        {
            if (!FileProvider.Exists(pathFile))
            {
                return new List<User>();
            }

            var jsonData = FileProvider.GetValue(pathFile);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(jsonData);
            return usersResults;
        }

        public static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileProvider.Replace(pathFile, jsonData);
        }
    }
}