using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domashka
{
    internal abstract class Employee
    {
        public string name { get; }
        public Employee[] nachalniks;
        public Employee(string nameEmp)
        {
            name = nameEmp;
        }

        public abstract void CanAcceptTaskFrom( Task task);

    }
    internal class Timur:Employee
    {
        public Timur(string name) : base(name) { }
        public override void CanAcceptTaskFrom( Task task)
        {
            Console.WriteLine("Директор не возьмет задачу {0} ни от кого",task.name);
        }
    }
    internal class Other : Employee
    {
        public Other(string name) : base(name) { }
        public override void CanAcceptTaskFrom( Task task)
        {
            Console.WriteLine($"Задача {task.name} от {task.fromWho.name} Для {this.name}");
            if (nachalniks.Contains(task.fromWho))
            {
                Console.WriteLine("Сотрудник {0} берет задачу от {1}",this.name, task.fromWho.name);
            }
            else
            {
                Console.WriteLine("Сотрудник {0} не берет задачу от {1}", this.name, task.fromWho.name);
            }
            
        }

    }
    internal class Task
    {
        
        public string name;
        public Employee toWho;
        public Employee fromWho;
        public Task(string Name)
        {
            name = Name;
        }
        public Task(string Name,Employee fromW)
        {
            name = Name;
            fromWho = fromW;
        }
    }
}
