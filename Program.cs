namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {//3адание 3
            Pc pc = new Pc("Lenovo IdeaCentre 3 07ADA05", "AMD Ryzen 3 3250U, 2600 МГц", "8 ГБ", "1 ТБ");
            pc.InfoPc();

            Laptop laptop = new Laptop("DESKTOP-OBCFRVU", "Intel(R) Core(TM) i5-7200U CPU @ 2.50GHz   2.71 GHz", "8,00 ГБ (доступно: 7,88 ГБ)", "476 Gb","2 kg");
            laptop.InfoLaptop();
        }
    }
}
