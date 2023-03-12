using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    public class UserStorage
    {
        private static string pathFile = "usersResults.json";

        public static void Append(User newUser)
        {
            var users = GetAll();
            users.Add(newUser);
            Save(users);
        }

        public static List<User> GetAll()
        {
            if (!FileProvider.Exists(pathFile))
            {
                return new List<User>();
            }

            var jsonData = FileProvider.GetValue(pathFile);
            return JsonConvert.DeserializeObject<List<User>>(jsonData);
        }

        public static void Save(List<User> users)
        {
            var jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
            FileProvider.Replace(pathFile, jsonData);
        }
    }
}