using System;
namespace GameOverrideDemo
{
    public class PhysicalSkill : Skill
    {
        private float critRate;

        public PhysicalSkill()
        {
            critRate = 0.1f;
            Console.WriteLine("----> Konstruktor default PhysicalSkill <----");
        }

        public PhysicalSkill(float critRate, string name, float power, float cost)
              : base(name, power, cost)
        {
            Console.WriteLine("----> Konstruktor berparameter PhysicalSkill <----");
            this.critRate = critRate;
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[PhysicalSkill.CalculateDamage] Menghitung damage fisik dengan critical hit...");
            return basePower * (1 + critRate);
        }

        public float CalculateDamage(bool isBackstab)
        {
            Console.WriteLine($"[PhysicalSkill.CalculateDamage] Megnhitung damage fisik dengan backstab: {isBackstab}");
            float damage = basePower * (1 + critRate);
            if (isBackstab)
                damage *=1.5f;
            return damage;
        }
        
    }
}