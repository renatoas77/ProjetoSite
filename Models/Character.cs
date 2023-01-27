using System.ComponentModel.DataAnnotations;

namespace FighteR_PG.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Nome")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Imagem do personagem")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Icone do personagem")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string Icon { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Espécie")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Specie { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Classe")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Arma")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Weapon { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Altura em cm")]
        [Range(1, 1000, ErrorMessage = "A altura deve estar entre 1cm e 1000cm")]
        public int Height { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Peso em Kg")]
        [Range(10, 10000, ErrorMessage = "A altura deve estar entre 10Kg e 10000Kg")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Idade")]
        [Range(0, 1000, ErrorMessage = "A idade deve estar entre 16 e 1000")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Gosta de")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Likes { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Não gosta de")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Dislikes { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Hobby")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Hobby { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Comida favorita")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Food { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Curiosidade")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string Curiosity { get; set; }

        [Display(Name = "Ideias em geral")]
        [MaxLength(400, ErrorMessage = "Maximo de {1} caracteres")]
        public string Ideias { get; set; }

       
        [Display(Name = "Plano de fundo")]
        public string Background { get; set; }

      
        [Display(Name = "Conclusão")]
        public string Conclusao { get; set; }

        
        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName01 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName02 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName03 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName04 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName05 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName06 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName07 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName08 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName09 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName10 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName11 { get; set; }

        [Display(Name = "Nome da Skill")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillName12 { get; set; }

      
        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc01 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc02 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc03 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc04 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc05 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc06 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc07 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc08 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc09 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc10 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc11 { get; set; }

        [Display(Name = "Descrição da skill")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillDesc12 { get; set; }

        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage01 { get; set; }

        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage02 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage03 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage04 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage05 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage06 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage07 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage08 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage09 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage10 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage11 { get; set; }


        [Display(Name = "Imagem da skill")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string SkillImage12 { get; set; }

       
        [Display(Name = "Nome do especial")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Special01 { get; set; }

        [Display(Name = "Nome do especial")]
        [MaxLength(20, ErrorMessage = "Maximo de {1} caracteres")]
        public string Special02 { get; set; }

       
        [Display(Name = "Descrição do especial")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SpecialDesc01 { get; set; }

        [Display(Name = "Descrição do especial")]
        [MaxLength(200, ErrorMessage = "Maximo de {1} caracteres")]
        public string SpecialDesc02 { get; set; }

      
        [Display(Name = "Imagem do especial")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string SpecialImage01 { get; set; }

        [Display(Name = "Imagem do especial")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string SpecialImage02 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Furia")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string Fury { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Golpe 01")]
        [MaxLength(60, ErrorMessage = "Maximo de {1} caracteres")]
        public string Hit01 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Golpe 02")]
        [MaxLength(60, ErrorMessage = "Maximo de {1} caracteres")]
        public string Hit02 { get; set; }

       
        [Display(Name = "Imagem do combo parado")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string StandComboImage01 { get; set; }

        [Display(Name = "Imagem do combo parado")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string StandComboImage02 { get; set; }

        [Display(Name = "Imagem do combo andando")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string WalkingComboImage01 { get; set; }

        [Display(Name = "Imagem do combo andando")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string WalkingComboImage02 { get; set; }

        [Display(Name = "Imagem do combo correndo")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningComboImage01 { get; set; }

        [Display(Name = "Imagem do combo correndo")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningComboImage02 { get; set; }

        [Display(Name = "Imagem do combo pulando")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string JumpComboImage01 { get; set; }

        [Display(Name = "Imagem do combo pulando")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string JumpComboImage02 { get; set; }

        [Display(Name = "Imagem do combo pulando enquanto corre")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningJumpComboImage01 { get; set; }

        [Display(Name = "Imagem do combo pulando enquanto corre")]
        [MaxLength(300, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningJumpComboImage02 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo parado")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string StandCombo01 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo parado")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string StandCombo02 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo andando")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string WalkingCombo01 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo andando")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string WalkingCombo02 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo correndo")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningCombo01 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo correndo")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningCombo02 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo pulando")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string JumpCombo01 { get; set; }


        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo pulando")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string JumpCombo02 { get; set; }


        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo pulando enquanto corre")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningJumpCombo01 { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco")]
        [Display(Name = "Combo pulando enquanto corre")]
        [MaxLength(100, ErrorMessage = "Maximo de {1} caracteres")]
        public string RunningJumpCombo02 { get; set; }

        [Display(Name = "Arquetipo")]
        public int ArchetypeId { get; set; }
        public virtual Archetype Archetype { get; set; }

        [Display(Name = "Sexo")]
        public int SexId { get; set; }
        [Display(Name = "Sexo")]
        public virtual Sex Sex { get; set; }

    }
}
