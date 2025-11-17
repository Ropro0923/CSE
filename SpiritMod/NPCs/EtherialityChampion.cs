using System.IO;
using ResonantSouls.SpiritMod.Core;
using Terraria.DataStructures;

namespace ResonantSouls.SpiritMod.NPCs
{
    [ExtendsFromMod(ModCompatibility.SpiritMod.Name)]
    [JITWhenModsEnabled(ModCompatibility.SpiritMod.Name)]
    public class EtherialityChampion : ModNPC
    {
        public override bool IsLoadingEnabled(Mod mod) => ResonantSoulsSpiritConfig.Instance.Enchantments;
        public override string Texture => Debug.Placeholder;
        public override string HeadTexture => Debug.Placeholder;
        public Player Target => Main.player[NPC.target];
        public Queue<int> AttackQueue = new(2);
        public enum Attacks
        {
            P1Attack1 = 1,
            P1Attack2,
            P1Attack3,
            P1Attack4,
            P1Attack5,
            P1Attack6,
            P1Attack7,
            P2Attack1,
            P2Attack2,
            P2Attack3,
            P2Attack4,
            P2Attack5,
            P3Attack1,
            P3Attack2,
            P3Attack3,
            P3Attack4,
            P3Attack5,
        }
        public override void OnSpawn(IEntitySource source)
        {
            AttackQueue.Enqueue(0);
        }
        public override void AI()
        {
            Main.NewText("[ Phase= " + NPC.ai[0] + ", Attack= " + NPC.ai[1] + ", Timer= " + NPC.ai[2] + " ]");

            switch ((Attacks)(int)NPC.ai[1])
            {
                case Attacks.P1Attack1:
                    P1Attack1();
                    break;
                case Attacks.P1Attack2:
                    P1Attack2();
                    break;
                case Attacks.P1Attack3:
                    P1Attack3();
                    break;
                case Attacks.P1Attack4:
                    P1Attack4();
                    break;
                case Attacks.P1Attack5:
                    P1Attack5();
                    break;
                case Attacks.P1Attack6:
                    P1Attack6();
                    break;
                case Attacks.P1Attack7:
                    P1Attack7();
                    break;
                case Attacks.P2Attack1:
                    P2Attack1();
                    break;
                case Attacks.P2Attack2:
                    P2Attack2();
                    break;
                case Attacks.P2Attack3:
                    P2Attack3();
                    break;
                case Attacks.P2Attack4:
                    P2Attack4();
                    break;
                case Attacks.P2Attack5:
                    P2Attack5();
                    break;
                case Attacks.P3Attack1:
                    P3Attack1();
                    break;
                case Attacks.P3Attack2:
                    P3Attack2();
                    break;
                case Attacks.P3Attack3:
                    P3Attack3();
                    break;
                case Attacks.P3Attack4:
                    P3Attack4();
                    break;
                case Attacks.P3Attack5:
                    P3Attack5();
                    break;
                default: NPC.ai[1] = (float)Attacks.P1Attack1; break;
            }
        }
        #region Phase 1 Attacks
        void P1Attack1()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack2()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack3()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack4()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack5()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack6()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P1Attack7()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        #endregion
        #region Phase 2 Attacks
        void P2Attack1()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P2Attack2()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P2Attack3()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P2Attack4()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P2Attack5()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        #endregion
        #region Phase 3 Attacks
        void P3Attack1()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P3Attack2()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P3Attack3()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P3Attack4()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        void P3Attack5()
        {
            ChooseNextAttack((int)NPC.ai[1]);
        }
        #endregion
        #region Helper Methods
        void ChooseNextAttack(int PreviousAttack)
        {
            AttackQueue.Enqueue(PreviousAttack);
            int PreviousAttack1 = AttackQueue.Dequeue();
            int PreviousAttack2 = AttackQueue.Peek();
            if (NPC.ai[0] == 1)
            {
                do NPC.ai[1] = Main.rand.Next((int)Attacks.P1Attack1, (int)Attacks.P2Attack1);
                while (NPC.ai[1] == PreviousAttack1 || NPC.ai[1] == PreviousAttack2);
            }
            else if (NPC.ai[0] == 2)
            {
                do NPC.ai[1] = Main.rand.Next((int)Attacks.P2Attack1, (int)Attacks.P3Attack1);
                while (NPC.ai[1] == PreviousAttack1 || NPC.ai[1] == PreviousAttack2);
            }
            else if (NPC.ai[0] == 3)
            {
                do NPC.ai[1] = Main.rand.Next((int)Attacks.P3Attack1, (int)(Attacks.P3Attack5 + 1));
                while (NPC.ai[1] == PreviousAttack1 || NPC.ai[1] == PreviousAttack2);
            }
            NPC.netUpdate = true;
        }
        public override void SendExtraAI(BinaryWriter BinaryWriter)
        {
            foreach (int attack in AttackQueue)
            {
                BinaryWriter.Write(attack);
            }
        }
        public override void ReceiveExtraAI(BinaryReader BinaryReader)
        {
            AttackQueue.Clear();
            for (int i = 0; i < 2; i++)
            {
                AttackQueue.Enqueue(BinaryReader.ReadInt32());
            }
        }
        #endregion
    }
}