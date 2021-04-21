using Microsoft.Win32;
using System;
using System.IO;

namespace OS_Laba1_Reest //С тектового файла, путь к кторому указан в ручную, создать дирректорию. Строка в файле имеет вит Путь_Имя:Тип:Значение
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расопложение txt файла");
            string path = Console.ReadLine();
            using (StreamReader readFile = new StreamReader(path))
            {
                path = readFile.ReadToEnd();

                var numbers = path.Split(':', '_',' ');

                var Key = numbers[0]; //Верхний ключ (User, CourrentUser, ClassesRoot и т.п.)
                var way = numbers[1]; // Путь Software\Google\bin
                var Objectt = numbers[2]; // Название обьекта
                var TipeValue = numbers[3]; // тип обьекта (String, DWord, Qword)
                var Valuee = numbers[4]; // Значение обьекта (123, HelloWorld, 0x00000150)

                switch (Key)
                {
                    case "ClassesRoot":
                        {
                            try //будет производиться вывод ошибки в случае ее возникновения
                            {

                                switch (TipeValue)
                                {
                                    case "DWord" or "DWORD" or "Dword":
                                        {
                                            var ResValuee = Convert.ToInt32(Valuee, 16);
                                            if (Registry.ClassesRoot.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;
                                    case "QWord" or "QWORD" or "Qword":
                                        {
                                            var ResValuee = Convert.ToInt64(Valuee, 16);
                                            if (Registry.ClassesRoot.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;

                                    default:
                                        {

                                            if (Registry.ClassesRoot.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}", RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.ClassesRoot.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}", RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.ClassesRoot.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        return;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }

                    case "CurrentUser":
                        {
                            try //будет производиться вывод ошибки в случае ее возникновения
                            {
                                switch (TipeValue)
                                {
                                    case "DWord":
                                        {
                                            var ResValuee = Convert.ToInt32(Valuee, 16);
                                            if (Registry.CurrentUser.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;
                                    case "QWord":
                                        {
                                            var ResValuee = Convert.ToInt64(Valuee, 16);
                                            if (Registry.CurrentUser.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;

                                    default:
                                        {

                                            if (Registry.CurrentUser.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", Valuee);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentUser.CreateSubKey($@"{way}").SetValue($"{Objectt}", Valuee); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentUser.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        return;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }

                    case "LocalMachine":
                        {
                            try //будет производиться вывод ошибки в случае ее возникновения
                            {

                                switch (TipeValue)
                                {
                                    case "DWord":
                                        {
                                            var ResValuee = Convert.ToInt32(Valuee, 16);
                                            if (Registry.LocalMachine.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;
                                    case "QWord":
                                        {
                                            var ResValuee = Convert.ToInt64(Valuee, 16);
                                            if (Registry.LocalMachine.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;

                                    default:
                                        {

                                            if (Registry.LocalMachine.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.LocalMachine.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}"); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.LocalMachine.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        return;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }

                    case "Users":
                        {
                            try //будет производиться вывод ошибки в случае ее возникновения
                            {

                                switch (TipeValue)
                                {
                                    case "DWord":
                                        {
                                            var ResValuee = Convert.ToInt32(Valuee, 16);
                                            if (Registry.Users.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;
                                    case "QWord":
                                        {
                                            var ResValuee = Convert.ToInt64(Valuee, 16);
                                            if (Registry.Users.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;

                                    default:
                                        {

                                            if (Registry.Users.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.Users.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}"); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.Users.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        return;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }

                    case "CurrentConfig":
                        {
                            try //будет производиться вывод ошибки в случае ее возникновения
                            {

                                switch (TipeValue)
                                {
                                    case "DWord":
                                        {
                                            var ResValuee = Convert.ToInt32(Valuee, 16);
                                            if (Registry.CurrentConfig.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.DWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;
                                    case "QWord":
                                        {
                                            var ResValuee = Convert.ToInt64(Valuee, 16);
                                            if (Registry.CurrentConfig.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord);
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", ResValuee, RegistryValueKind.QWord); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        break;

                                    default:
                                        {

                                            if (Registry.CurrentConfig.OpenSubKey($@"{way}") != null) // проверка на существоаваине дирректории
                                            {
                                                Console.WriteLine("Директория уже существует"); // вывод ошибки
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");
                                            }
                                            else
                                            {
                                                Registry.CurrentConfig.CreateSubKey($@"{way}").SetValue($"{Objectt}", $"{Valuee}"); // Создание дирректории
                                                Console.WriteLine("Создано");
                                                Console.WriteLine("Хотите удалить? нажмите дял подтверждения");
                                                Console.ReadKey();
                                                Registry.CurrentConfig.DeleteSubKeyTree($@"{way}");

                                            }
                                        }
                                        return;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            break;
                        }

                    default:
                        Console.WriteLine("Верхний ключ не существует");
                        break;
                }
                Console.WriteLine("----------------------------Программа завершена----------------------------");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
        }
    }
}
