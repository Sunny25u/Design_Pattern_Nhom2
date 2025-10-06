using System;
using System.Collections.Generic;

namespace Composite.CafeMenu
{
    /// <summary>
    /// Composite Pattern – Menu quán cafe
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // ===== Tạo menu chính =====
            MenuItem rootMenu = new CompositeMenu("Menu Cafe");

            // Menu Cà phê
            MenuItem coffeeMenu = new CompositeMenu("Ca phê");
            coffeeMenu.Add(new SimpleMenuItem("Ca phe đen", 20000));
            coffeeMenu.Add(new SimpleMenuItem("Ca phe sua", 25000));
            coffeeMenu.Add(new SimpleMenuItem("Bac xiu", 30000));

            // Menu Trà
            MenuItem teaMenu = new CompositeMenu("Tra");
            teaMenu.Add(new SimpleMenuItem("Tra đao", 35000));
            teaMenu.Add(new SimpleMenuItem("Tra chanh", 25000));

            // Menu Sinh tố
            MenuItem smoothieMenu = new CompositeMenu("Sinh to");
            smoothieMenu.Add(new SimpleMenuItem("Sinh to xoai", 40000));
            smoothieMenu.Add(new SimpleMenuItem("Sinh to bo", 45000));

            // Thêm các menu con vào menu chính
            rootMenu.Add(coffeeMenu);
            rootMenu.Add(teaMenu);
            rootMenu.Add(smoothieMenu);

            // ===== Hiển thị menu =====
            rootMenu.Display(1);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Thành phần chung (Component)
    /// </summary>
    public abstract class MenuItem
    {
        protected string name;
        protected int price;

        public MenuItem(string name, int price = 0)
        {
            this.name = name;
            this.price = price;
        }

        public abstract void Add(MenuItem item);
        public abstract void Remove(MenuItem item);
        public abstract void Display(int indent);
    }

    /// <summary>
    /// Món đơn (Leaf)
    /// </summary>
    public class SimpleMenuItem : MenuItem
    {
        public SimpleMenuItem(string name, int price)
            : base(name, price) { }

        public override void Add(MenuItem item)
        {
            Console.WriteLine("Khong the them mon vao mon đon!");
        }

        public override void Remove(MenuItem item)
        {
            Console.WriteLine("Khong the xoa trong mon đon!");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + $" {name} : {price} VND");
        }
    }

    /// <summary>
    /// Menu nhóm (Composite)
    /// </summary>
    public class CompositeMenu : MenuItem
    {
        private List<MenuItem> items = new List<MenuItem>();

        public CompositeMenu(string name) : base(name) { }

        public override void Add(MenuItem item)
        {
            items.Add(item);
        }

        public override void Remove(MenuItem item)
        {
            items.Remove(item);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + $"+ {name}");
            foreach (var item in items)
            {
                item.Display(indent + 2);
            }
        }
    }
}
