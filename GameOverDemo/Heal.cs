using System;
namespace GameOverrideDemo
{
    public class HealSkill : Skill
    {
        private float bonusHeal;

        public HealSkill()
        {
            bonusHeal = 20f;
            Console.WriteLine("---> Konstruktor Default HealSkill <----");
        }

        public HealSkill(float bonusHeal, string name, float power, float cost) : base(name, power, cost)
        {
            Console.WriteLine("---> Konstruktor Berparameter HealSkill <----");
            this.bonusHeal = bonusHeal;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[HealSkill.CalculateDamage] Menghitung nilai healing...");
            float healAmount = basePower + bonusHeal;
            return healAmount;
        }

        public new void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("BONUS HEAL     : " + bonusHeal);
            Console.WriteLine("===============================");
        }
    }
}