namespace Domashka
{
    class Dz_File
    {
        static void Main()
        {
            /**/
            //Директор Тимур
            Timur timur = new Timur("Тимур");

            //подчиненные тимура
            Other rashid = new Other("Рашид");
            rashid.nachalniks = new Employee[] { timur };
            Other ilham = new Other("О ильхам");
            ilham.nachalniks = new Employee[] { timur };

            //Подчиненные Рашида
            Other lukas = new Other("Лукас");
            lukas.nachalniks = new Employee[] { rashid };

            //Подчиненные О Ильхама
            Other orkadiy = new Other("Оркадий");
            orkadiy.nachalniks = new Employee[] { ilham };
            Other volodya = new Other("Володя");
            volodya.nachalniks = new Employee[] { ilham , orkadiy };

            //Подчиненные Оркадия и Володи
            Other ilshat = new Other("Ильшат");
            ilshat.nachalniks = new Employee[] {orkadiy, volodya };
            Other sergey = new Other("Сергей");
            sergey.nachalniks = new Employee[] { orkadiy, volodya };

            //Подчиненные Ильшата
            Other ivanich = new Other("Иваныч");
            ivanich.nachalniks = new Employee[] { ilshat };

            //Подчиненные Иваныча
            Other ilya = new Other("Илья");
            ilya.nachalniks = new Employee[] { ilshat, ivanich };
            Other vitya = new Other("Витя");
            vitya.nachalniks = new Employee[] { ilshat, ivanich };
            Other zhenya = new Other("Женя");
            zhenya.nachalniks = new Employee[] { ilshat, ivanich };
            
            //Подчиненные Сергея
            Other leysyan = new Other("Лейсян");
            leysyan.nachalniks = new Employee[] { sergey };

            //Подчиненные Лейсян
            Other marat = new Other("Марат");
            marat.nachalniks = new Employee[] { sergey, leysyan };
            Other dina = new Other("Дина");
            dina.nachalniks = new Employee[] { sergey, leysyan };
            Other ildar = new Other("Ильдар");
            ildar.nachalniks = new Employee[] { sergey, leysyan };
            Other anton = new Other("Антон");
            anton.nachalniks = new Employee[] { sergey, leysyan };

            Task task0 = new Task("Что-то вот тут");
            Task task1 = new Task("Что-то там", timur);
            Task task2 = new Task("Что-то тут", ilham);
            Task task3 = new Task("Что-то здесь", orkadiy);
            Task task4 = new Task("Что-то напоследок", leysyan);

            timur.CanAcceptTaskFrom(task0);

            rashid.CanAcceptTaskFrom(task1);
            rashid.CanAcceptTaskFrom(task2);
            volodya.CanAcceptTaskFrom(task3);
            anton.CanAcceptTaskFrom(task4);
            

        }
    }
}