using project_akhir_stock_gudang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public static class UserStore
{
    private static readonly string filePath =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");

    public static List<UserAccount> LoadUsers()
    {
        if (!File.Exists(filePath))
        {
            return new List<UserAccount>();
        }

        try
        {
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<UserAccount>();
            }

            return JsonSerializer.Deserialize<List<UserAccount>>(json)
                   ?? new List<UserAccount>();
        }
        catch
        {
            return new List<UserAccount>();
        }
    }

    public static void SaveUsers(List<UserAccount> users)
    {
        string json = JsonSerializer.Serialize(
            users,
            new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );

        File.WriteAllText(filePath, json);
    }

    public static bool Register(string username, string password)
    {
        List<UserAccount> users = LoadUsers();

        bool usernameSudahAda = users.Any(
            user => string.Equals(
                user.Username,
                username,
                StringComparison.OrdinalIgnoreCase
            )
        );

        if (usernameSudahAda)
        {
            return false;
        }

        UserAccount userBaru = new UserAccount
        {
            Username = username,
            Password = password
        };

        users.Add(userBaru);

        SaveUsers(users);

        return true;
    }

    public static bool ValidateLogin(string username, string password)
    {
        List<UserAccount> users = LoadUsers();

        return users.Any(
            user =>
                string.Equals(
                    user.Username,
                    username,
                    StringComparison.OrdinalIgnoreCase
                )
                && user.Password == password
        );
    }
}