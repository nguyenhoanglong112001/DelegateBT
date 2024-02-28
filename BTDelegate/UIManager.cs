﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BTDelegate
{
    public class UIManager
    {

        public int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Create Item");
            Console.WriteLine("2. Show all ITem in inventory");
            Console.WriteLine("3. Create Hero");
            Console.WriteLine("4. Show hero infomation");
            int input = InputInt("Your choice: ");
            return input;
        }

        public void Gacha()
        {
            Console.Clear();
            Console.WriteLine("1. Roll x1");
            Console.WriteLine("2. Roll x10");
            int input = InputInt("Your choice: ");
            if (input == 1)
            {
                Program.Gacha(1);
            }
            else if (input == 2)
            {
                Program.Gacha(10);
            }
            Program.Start();
        }

        public void ShowAllItem(List<Item> items,Chracter hero)
        {
            Console.Clear();
            Console.WriteLine("---------Inventory-----------");
            for (int i =0;i< items.Count;i++)
            {
                if (items[i] != null) 
                {
                    Console.WriteLine($"{i + 1}. {items[i].type}");
                    ShowItem(items[i]);
                }
            }
            Console.WriteLine("Choose item to update or use");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("1. Update level item");
            Console.WriteLine("2. Merge Item");
            Console.WriteLine("3. Use Item");
            Console.WriteLine("4. Back to main menu");
            int input = InputInt("Your choice: ");
            if (input == 1)
            {
                string select = Updatelvitem(items, index-1);
                if (select.Equals("y") || select.Equals("Y"))
                {
                    Program.UpdateItemlv(index-1);
                    Console.WriteLine("Update succesfully");
                    ShowItem(items[index- 1]);
                    Console.ReadKey();
                    Program.Start();
                }
                else
                {
                    ShowItem(items[index - 1]);
                }
            }
            else if (input ==2)
            {
                showListsameItem(items, index-1);
                int index2 = InputInt("chon item de megre: ");
                string select = MergeItem(items,index - 1,index2-1);
                if (select.Equals("y") || select.Equals("Y"))
                {
                    Program.UpdateRarityItem(index - 1,index2-1);
                    ShowAllItem(items,hero);
                    Console.ReadKey();
                    Program.Start();
                }
            }
            else if (input == 3)
            {
                string select = EquiqItem(items,index-1);
                if (select.Equals("Y")||select.Equals("y"))
                {
                    Program.useitem(items[index - 1], hero);
                    ShowHero(hero);
                    Console.ReadKey();
                    MainMenu();
                }
            }
            else if (input == 4)
            {
                Program.Start();
            }
            Console.ReadKey();
        }
        public void ShowItem(Item item)
        {
            Console.WriteLine($"Type: {item.type} \t Rarity: {item.rarity} \t Level: {item.level}");
        }

        public string Updatelvitem(List<Item> items, int index)
        {
            Console.Clear();
            Console.WriteLine("Item update information");
            Console.WriteLine($"{items[index].type} \t {items[index].rarity} \t {items[index].level + 1}");
            string select = InputStr("Y/y: update item,N/n Back to inventory");
            return select;
        }
        public string MergeItem(List<Item> items, int index1,int index2)
        {
            Console.Clear();
            Console.WriteLine("Item update information");
            Console.WriteLine($"{items[index1].type} \t {items[index1].rarity+1} \t {items[index1].level }");
            string select = InputStr("Y/y: update item,N/n Back to inventory");
            return select;
        }

        public void showListsameItem(List<Item> items,int index)
        {
            for (int i=0;i<items.Count;i++)
            {
                if (i != index)
                {
                    if (items[index].rarity == items[i].rarity && items[index].type == items[i].type)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{i + 1}. {items[i].type}");
                        ShowItem(items[i]);
                    }
                }
            }
            Console.ReadKey();
        }

        public void ShowHero(Chracter hero)
        {
            Console.Clear();
            Console.WriteLine($"Hero Type: {hero.type}");
            Console.WriteLine($"Attack Dame: {hero.attack}");
            Console.WriteLine($"Power Dame: {hero.powerdame}");
            Console.WriteLine($"HP: {hero.HP}");
            Console.WriteLine($"Attack Speed: {hero.atkspeed}");
            if (hero.itemuse != null)
            {
                for (int i = 0; i < hero.itemuse.Count; i++)
                {
                    if (hero.itemuse[i] != null)
                    {
                        Console.WriteLine($"Item: {hero.itemuse[i].type}");
                    }
                }
            }
            else { Console.WriteLine($"Item: "); }
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Uneqip Item");
            Console.WriteLine("2. Back to main menu");
            int choice = InputInt("Your choice: ");
            if (choice == 1)
            {
                int index = InputInt("Choice item to unequip: ");
                string select = UnequipItem(hero.itemuse, index - 1);
                if (hero.itemuse == null)
                {
                    Console.WriteLine("slot empty!");
                    Program.Start();
                }
                else
                {
                    Program.unuseitem(hero.itemuse[index-1],hero);
                    Console.WriteLine("Unequip item succes");
                    Console.ReadKey();
                    Program.Start();
                }
            }
            else if (choice == 2) { Program.Start(); }
            Console.ReadKey();
            Program.Start();
        }

        public int InputInt(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public string InputStr(string message) 
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }

        public string EquiqItem(List<Item> items,int index)
        {
            Console.Clear();
            Console.WriteLine("Item used information");
            Console.WriteLine($"{items[index].type} \t {items[index].rarity } \t {items[index].level}");
            Console.WriteLine("Do You Want to use this item:");
            string select = InputStr("Y / y Yes, N / n No");
            return select;
        }

        public string UnequipItem(List<Item> items,int index)
        {
            Console.Clear();
            Console.WriteLine("Item unequip information: ");
            Console.WriteLine($"{items[index].type} \t {items[index].rarity} \t {items[index].level}");
            Console.WriteLine("Do you want to unequip this item");
            string select = InputStr("Y / y Yes, N / n No");
            return select;
        }
    }
}