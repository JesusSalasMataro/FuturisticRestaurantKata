using FuturisticRestaurantKata.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FuturisticRestaurantKata.Implementations
{
    public class DinningRoom
    {
        private int _nextTableNumber = 1;
        private readonly int NumNormalTables = 10;
        private readonly int NumVipTables = 7;
        private readonly int NumQueues = 4;

        private List<Table> Tables { get; set; }
        private List<Queue<Table>> queues;

        public DinningRoom()
        {
            WaiterService waiter = new WaiterService();
            ElectronicMenuService menu = new ElectronicMenuService();
            MetreService metre = new MetreService();
            Tables = new List<Table>();
            Tables.AddRange(NormalTables(waiter, menu, metre));
            Tables.AddRange(VipTables(waiter, menu, metre));
            queues = new List<Queue<Table>>();
            queues = DistributeTablesInQueues(Tables, NumQueues);
        }

        #region Public methods        

        public void Start()
        {
            List<Task> tasks = new List<Task>();

            for (int i = 0; i < queues.Count; i++)
            {
                Queue<Table> queue = queues[i];
                Task task = Task.Run(() => ProcessQueue(queue));
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray());
            Console.ReadKey();
        }

        #endregion

        #region Private methods        

        private IEnumerable<Table> NormalTables(WaiterService waiter, ElectronicMenuService menu, MetreService metre)
        {
            List<Table> NormalTables = new List<Table>();

            for (; _nextTableNumber <= NumNormalTables; _nextTableNumber++)
            {
                Table table = new Table(number: _nextTableNumber, vip: false);
                table.Attach(waiter);
                table.Attach(menu);
                NormalTables.Add(table);
            }

            return NormalTables;
        }

        private IEnumerable<Table> VipTables(WaiterService waiter, ElectronicMenuService menu, MetreService metre)
        {
            List<Table> VipTables = new List<Table>();

            for (; _nextTableNumber <= NumTotalTables(); _nextTableNumber++)
            {
                Table table = new Table(number: _nextTableNumber, vip: true);
                table.Attach(waiter);
                table.Attach(menu);
                table.Attach(metre);
                VipTables.Add(table);
            }

            return VipTables;
        }

        private void OcuppyTable(Table table)
        {
            table.Status = Status.Busy;
        }

        private void ProcessQueue(Queue<Table> queue)
        {
            while (queue.Count > 0)
            {
                Table table = queue.Dequeue();
                OcuppyTable(table);
            }
        }

        private int NumTotalTables()
        {
            return NumNormalTables + NumVipTables;
        }

        private List<Queue<Table>> DistributeTablesInQueues(List<Table> Tables, int queuesCount)
        {
            List<Queue<Table>> queues = new List<Queue<Table>>();
            Queue<Table> queue = new Queue<Table>();
            int elementsByQueue = NumTotalTables() / queuesCount;
            int index = 0;

            while (index < NumTotalTables())
            {
                if (index % elementsByQueue == 0)
                {
                    queue = new Queue<Table>();
                    queues.Add(queue);
                }

                queue.Enqueue(Tables[index]);
                index++;
            }

            return queues;
        }

        #endregion
    }
}
