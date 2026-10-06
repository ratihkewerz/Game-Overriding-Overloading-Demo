using System;
namespace GameOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDING & OVERLOADING (GAME SKILLS) ===\n");

            Console.WriteLine("1. Membuat PhysicalSkill");
            PhysicalSkill slash = new PhysicalSkill(0.3f, "slash", 50f, 15f);
            slash.DisplaySkillInfo();
            float slashDamage = slash.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan: " + slashDamage + "\n");

            Console.WriteLine("2. Membuat MagicSkill");
            MagicSkill fireball = new MagicSkill("Fire", "Fireball", 40f, 25f);
            fireball.DisplaySkillInfo();
            float fireDamage = fireball.CalculateDamage();
            Console.WriteLine("Damage yang dihasilkan: " + fireDamage + "\n");

            Console.WriteLine("3. Membuat HealSkill");
            HealSkill heal = new HealSkill(30f, "Heal", 50f, 20f);
            heal.DisplaySkillInfo();
            float healAmount = heal.CalculateDamage();
            Console.WriteLine("Healing yang dihasilkan: " + healAmount + "\n");
            
            Console.WriteLine("\n\n--- Menguji Overloading Method ---");

            float dmg1 = slash.CalculateDamage();
            Console.WriteLine("Damage (tanpa parameter): " + dmg1);

            float dmg2 = slash.CalculateDamage(2.0f);
            Console.WriteLine("Damage (multiplier 2.0): " + dmg2);

            float dmg3 = slash.CalculateDamage(1.5f, 20f);
            Console.WriteLine("Damage (multiplier 1.5, defense 20): " + dmg3);

            float dmg4 =  slash.CalculateDamage("Piercing");
            Console.WriteLine("Damage (tipe Piercing): " + dmg4);

            float dmg5 =  slash.CalculateDamage("True");
            Console.WriteLine("Damage (backstab true): " + dmg5);

            Console.ReadKey();
        }
    }
}