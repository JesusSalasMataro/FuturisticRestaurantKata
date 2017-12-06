using FuturisticRestaurantKataTDD;
using FuturisticRestaurantKataTDD.Contracts;
using FuturisticRestaurantKataTDD.Implementations;
using System;
using System.Collections.Generic;

namespace FuturisticRestaurantKataConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables = InitializeTables();
            OccupyTables(tables);
            Console.ReadKey();
        }

        private static List<Table> InitializeTables()
        {
            List<Table> tables = new List<Table>();
            Observer waiter = new WaiterService();
            Observer menu = new ElectronicMenuService();
            Observer metre = new MetreService();

            for (int i = 0; i < 5; i++)
            {
                bool oddIndex = (i + 1) % 2 != 0;
                Table table = new Table(tableNumber: i + 1, isVip: oddIndex);
                table.Attach(waiter);
                table.Attach(menu);
                table.Attach(metre);
                tables.Add(table);
            }

            return tables;
        }

        private static void OccupyTables(List<Table> tables)
        {
            foreach (Table table in tables)
            {
                table.Status = TableStatusEnum.Occupied;
            }
        }
    }
}
