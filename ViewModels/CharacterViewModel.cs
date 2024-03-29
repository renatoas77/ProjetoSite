﻿using FighteR_PG.Models;

namespace FighteR_PG.ViewModels
{
    public class CharacterViewModel
    {

        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Icon { get; set; }
        public string Specie { get; set; }
        public string Class { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        public string Hobbie { get; set; }
        public string Food { get; set; }
        public string Background { get; set; }
        public string Conclusao { get; set; }
        public string SkilName01 { get; set; }
        public string SkilName02 { get; set; }
        public string SkilName03 { get; set; }
        public string SkilName04 { get; set; }
        public string SkilName05 { get; set; }
        public string SkilName06 { get; set; }
        public string SkilName07 { get; set; }
        public string SkilName08 { get; set; }
        public string SkilName09 { get; set; }
        public string SkilName10 { get; set; }
        public string SkilName11 { get; set; }
        public string SkilName12 { get; set; }
        public string SkilDesc01 { get; set; }
        public string SkilDesc02 { get; set; }
        public string SkilDesc03 { get; set; }
        public string SkilDesc04 { get; set; }
        public string SkilDesc05 { get; set; }
        public string SkilDesc06 { get; set; }
        public string SkilDesc07 { get; set; }
        public string SkilDesc08 { get; set; }
        public string SkilDesc09 { get; set; }
        public string SkilDesc10 { get; set; }
        public string SkilDesc11 { get; set; }
        public string SkilDesc12 { get; set; }
        public string SkilImage01 { get; set; }
        public string SkilImage02 { get; set; }
        public string SkilImage03 { get; set; }
        public string SkilImage04 { get; set; }
        public string SkilImage05 { get; set; }
        public string SkilImage06 { get; set; }
        public string SkilImage07 { get; set; }
        public string SkilImage08 { get; set; }
        public string SkilImage09 { get; set; }
        public string SkilImage10 { get; set; }
        public string SkilImage11 { get; set; }
        public string SkilImage12 { get; set; }
        public string Special01 { get; set; }
        public string Special02 { get; set; }
        public string SpecialDesc01 { get; set; }
        public string SpecialDesc02 { get; set; }
        public string SpecialImage01 { get; set; }
        public string SpecialImage02 { get; set; }
        public string Fury { get; set; }
        public string Hit01 { get; set; }
        public string Hit02 { get; set; }
        public string StandComboImage01 { get; set; }
        public string StandComboImage02 { get; set; }
        public string WalkingComboImage01 { get; set; }
        public string WalkingComboImage02 { get; set; }
        public string RunningComboImage01 { get; set; }
        public string RunningComboImage02 { get; set; }
        public string JumpComboImage01 { get; set; }
        public string JumpComboImage02 { get; set; }
        public string RunningJumpComboImage01 { get; set; }
        public string RunningJumpComboImage02 { get; set; }
        public string StandCombo01 { get; set; }
        public string StandCombo02 { get; set; }
        public string WalkingCombo01 { get; set; }
        public string WalkingCombo02 { get; set; }
        public string RunningCombo01 { get; set; }
        public string RunningCombo02 { get; set; }
        public string JumpCombo01 { get; set; }
        public string JumpCombo02 { get; set; }
        public string RunningJumpCombo01 { get; set; }
        public string RunningJumpCombo02 { get; set; }
        public int ArchetypeId { get; set; }
        public virtual Archetype Archetype { get; set; }
        public int SexId { get; set; }
        public virtual Sex Sex { get; set; }
    }
}
