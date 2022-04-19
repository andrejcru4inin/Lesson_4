using System;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace
lesson4ex1
{
    class
    Program
    {
        static void Main
        (
        string
        [
]
        args
        )
        {
            GetFullName
            (
            "Иванович"
            ,
            "Иван"
            ,
            "Иванов"
            )
            ;
            GetFullName
            (
            "Смирнов"
            ,
            "Владимир"
            ,
            "Владимирович"
            )
            ;
            GetFullName
            (
            "Петров"
            ,
            "Андрей"
            ,
            "Алексеевич"
            )
            ;
        }

        static void
        GetFullName(string lastName, string firstName, string patronymic)
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");




        }
    }
}
               