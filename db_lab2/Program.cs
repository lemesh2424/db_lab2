using System;
using System.IO;
using db_lab2.Controllers;
using db_lab2.Database;
using db_lab2.Database.DAO;
using db_lab2.Models;

namespace db_lab2
{
    internal class Program
    {
        static void Main()
        {
            using var sr = new StreamReader("../../../DataBaseSettings.txt");
            var line = sr.ReadToEnd();
            var connection = new DbConnection(line);
            var controller = new Controller(connection);
            controller.Begin();
        }
    }
}
